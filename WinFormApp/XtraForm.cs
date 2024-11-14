using WinFormApp.Views;

namespace WinFormApp
{
    public partial class XtraForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly PersonViewControl _personView;
        private readonly CompanyViewControl _companyView;

        public XtraForm()
        {
            InitializeComponent();

            // Nastaveni navigace TabPanelu mezi PersonView a CompanyView
            _personView = new PersonViewControl();
            _companyView = new CompanyViewControl();
            tabNavigationPeople.Controls.Add(_personView);
            tabNavigationCompany.Controls.Add(_companyView);

            this.StartPosition = FormStartPosition.CenterScreen;    // Prikaz pro spusteni aplikace uprostred obrazovky
            this.FormClosing += XtraForm_FormClosing;   // Prikaz dovoli zavrit aplikaci v jakekoliv situaci (duvod: pri editaci je tato funkce nekdy zamezena)
        }

        private void XtraForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}