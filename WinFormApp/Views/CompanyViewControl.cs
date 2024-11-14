using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using WinFormApp.Services.GridService;
using WinFormApp.Services.MyValidationService;
using WinFormApp.ViewModels;
using WinFormApp.Views.MyValidationRules;

namespace WinFormApp.Views
{
    public partial class CompanyViewControl : UserControl
    {
        private MVVMContextFluentAPI<CompanyViewModel> fluentApi { get; set; }

        public CompanyViewControl()
        {
            InitializeComponent();

            // Inicializace mvvmContextu
            // Nastaveni ViewModelu pro typ (CompanyViewModel) v kontextu MVVM
            // Nastaveni Fluent API k ziskani kontextu ViewModelu
            var companyVM = CompanyViewModel.Create();
            mvvmCompanyContext.SetViewModel(typeof(CompanyViewModel), companyVM);
            fluentApi = mvvmCompanyContext.OfType<CompanyViewModel>();

            // Registrace sluzeb pro praci s gridem
            // Registrace sluzeb pro validaci vstupnich hodnot
            mvvmCompanyContext.RegisterService(new GridViewService(companyGridView));
            mvvmCompanyContext.RegisterService(new MyValidationService());

            InitBindings();         // Inicializace vazeb mezi View a View Modelem
            SetupLayoutControls();  // Nastaveni Layout Controlu - povolene formaty vstup. hodnot
            SetupGridControl();
            SetupValidationRules();         // Nastaveni Custom validacich pravidel => /Views/MyValidationRules
            UpdateDeleteBtnState(false);    // Uzamkne Delete Button - odemknuti po vyberu radku v gridu

            // Povoli opusteni editoru pri vlozeni nespravne hodnody
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void InitBindings()
        {
            // Propojeni LayoutControl (TextEdits) s Company objektem
            fluentApi.SetBinding(dataLayoutCompanyControl, layout => layout.DataSource, x => x.Company);
            // Propojeni GridControl s databazi = data z tabulky Companies
            fluentApi.SetBinding(companyGridControl, grid => grid.DataSource, x => x.CompanyBindingSource);
            // Event pro pridani nove Firmy do databaze
            // ViewModel metoda se zavola, pokud projde validace vstup. hodnot
            fluentApi.WithEvent(sbtnAddCompany, "Click")
                .EventToCommand(x => x.AddCompany, (args) =>
                {
                    if (!dxCompanyValidationProvider.Validate())
                    {
                        MessageBox.Show("Data might be in incorrect format or some fields are left emtpy.");
                        return false;
                    }
                    return true;
                });
            // Propojeni Buttonu pro mazani zaznamu z gridu
            fluentApi.BindCommand(sbtnDeleteRecord, x => x.DeleteSelectedCompanyRecords());
            // Event reaguje na zmenu dat v grid view
            fluentApi.EventToCommand<CellValueChangedEventArgs>(companyGridView, "CellValueChanged", e => e.OnCellValueChanged(null!), x => x);
            // Event pro validaci editovanych dat v grid view
            fluentApi.EventToCommand<BaseContainerValidateEditorEventArgs>(companyGridView, "ValidatingEditor",
                x => x.OnValidatingEditor(null!));
        }

        private void SetupLayoutControls()
        {
            CompanyIDTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = "[0-9]{8}";
                settings.ShowPlaceholders = false;
            });

            CompanyPhoneNumTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = @"\+\d{1,3} \d{3} \d{3} \d{3}";
                settings.ShowPlaceholders = true;
            });
            CompanyEmailTextEdit.Properties.MaskSettings.Configure<MaskSettings.RegExp>(settings =>
            {
                settings.MaskExpression = @"\w+([-._]\w*)*@\w+([-.]\w*)*\.\w*([-.]\w*)*";
                settings.ShowPlaceholders = false;
            });
        }

        public void SetupGridControl()
        {
            companyGridView.Columns[0].Visible = false;
            companyGridView.OptionsSelection.MultiSelect = true;
            companyGridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;

            RepositoryItemTextEdit companyIdEdit = new RepositoryItemTextEdit
            {
                Mask = {
                    EditMask = "[0-9]{8}",
                    MaskType = MaskType.RegEx,
                    ShowPlaceHolders = false,},
                UseMaskAsDisplayFormat = true,
            };

            RepositoryItemTextEdit companyNameEdit = new RepositoryItemTextEdit
            {
                Mask =
                {
                    EditMask = ".{1,40}",
                    MaskType = MaskType.RegEx,
                    ShowPlaceHolders = false,
                },
                UseMaskAsDisplayFormat = true,
            };

            RepositoryItemTextEdit phoneEdit = new RepositoryItemTextEdit
            {
                Mask = {
                    EditMask = @"\+\d{1,3} \d{3} \d{3} \d{3}",
                    MaskType = MaskType.RegEx,
                    ShowPlaceHolders = false,
                },
                UseMaskAsDisplayFormat = true,
            };

            RepositoryItemTextEdit emailEdit = new RepositoryItemTextEdit
            {
                Mask = {
                    EditMask = @"\w+([-._]\w*)*@\w+([-.]\w*)*\.\w*([-.]\w*)*",
                    MaskType = MaskType.RegEx,
                    ShowPlaceHolders = false,
                },
                UseMaskAsDisplayFormat = true,
            };

            // nastaveni povoleneho formatu pri editaci dat
            companyGridView.Columns["CompanyID"].ColumnEdit = companyIdEdit;
            companyGridView.Columns["CompanyName"].ColumnEdit = companyNameEdit;
            companyGridView.Columns["PhoneNumber"].ColumnEdit = phoneEdit;
            companyGridView.Columns["Email"].ColumnEdit = emailEdit;

            // reakce na event - vyber radku
            companyGridView.SelectionChanged += CompanyGridView_SelectionChanged;
        }

        private void SetupValidationRules()
        {
            dxCompanyValidationProvider.ValidationMode = ValidationMode.Auto;
                
            ConditionValidationRule companyNameRule = new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.IsNotBlank,
                ErrorText = "Company name is required.",
            };

            dxCompanyValidationProvider.SetValidationRule(CompanyIDTextEdit, new CompanyIDValidationRule());
            dxCompanyValidationProvider.SetValidationRule(CompanyNameTextEdit, companyNameRule);
            dxCompanyValidationProvider.SetValidationRule(CompanyPhoneNumTextEdit, new PhoneNumValidationRule());
            dxCompanyValidationProvider.SetValidationRule(CompanyEmailTextEdit, new EmailValidationRule());
        }

        // Detekce vybranych radku pomoci CheckBox prvku
        // neni-li vybran radek, Delete Button je uzamcen
        private void CompanyGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as GridView;
            if (view != null)
            {
                bool anyRowSelected = view.SelectedRowsCount > 0;
                UpdateDeleteBtnState(anyRowSelected);
            }
        }

        private void UpdateDeleteBtnState(bool anyRowSelected)
        {
            sbtnDeleteRecord.Enabled = anyRowSelected;
        }
    }
}
