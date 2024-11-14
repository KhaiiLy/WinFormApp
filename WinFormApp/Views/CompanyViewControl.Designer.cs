namespace WinFormApp.Views
{
    partial class CompanyViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sbtnDeleteRecord = new DevExpress.XtraEditors.SimpleButton();
            companyGridControl = new DevExpress.XtraGrid.GridControl();
            companyGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            companiesBindingSource = new BindingSource(components);
            dataLayoutCompanyControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            sbtnAddCompany = new DevExpress.XtraEditors.SimpleButton();
            CompanyNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            CompanyPhoneNumTextEdit = new DevExpress.XtraEditors.TextEdit();
            CompanyEmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            CompanyIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForCompanyName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            ItemToAddCompany = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForCompanyID = new DevExpress.XtraLayout.LayoutControlItem();
            mvvmCompanyContext = new DevExpress.Utils.MVVM.MVVMContext(components);
            dxCompanyValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(components);
            ((System.ComponentModel.ISupportInitialize)companyGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companyGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)companiesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataLayoutCompanyControl).BeginInit();
            dataLayoutCompanyControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CompanyNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyPhoneNumTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyEmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyIDTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCompanyName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemToAddCompany).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCompanyID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mvvmCompanyContext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxCompanyValidationProvider).BeginInit();
            SuspendLayout();
            // 
            // sbtnDeleteRecord
            // 
            sbtnDeleteRecord.Location = new Point(803, 412);
            sbtnDeleteRecord.Name = "sbtnDeleteRecord";
            sbtnDeleteRecord.Size = new Size(266, 57);
            sbtnDeleteRecord.TabIndex = 6;
            sbtnDeleteRecord.Text = "Delete Record(s)";
            // 
            // companyGridControl
            // 
            companyGridControl.Location = new Point(14, 24);
            companyGridControl.MainView = companyGridView;
            companyGridControl.Name = "companyGridControl";
            companyGridControl.Size = new Size(751, 446);
            companyGridControl.TabIndex = 5;
            companyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { companyGridView });
            // 
            // companyGridView
            // 
            companyGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colCompanyID, colCompanyName, colPhoneNumber, colEmail });
            companyGridView.GridControl = companyGridControl;
            companyGridView.Name = "companyGridView";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 54;
            // 
            // colCompanyID
            // 
            colCompanyID.FieldName = "CompanyID";
            colCompanyID.MinWidth = 25;
            colCompanyID.Name = "colCompanyID";
            colCompanyID.Visible = true;
            colCompanyID.VisibleIndex = 1;
            colCompanyID.Width = 90;
            // 
            // colCompanyName
            // 
            colCompanyName.FieldName = "CompanyName";
            colCompanyName.MinWidth = 25;
            colCompanyName.Name = "colCompanyName";
            colCompanyName.Visible = true;
            colCompanyName.VisibleIndex = 2;
            colCompanyName.Width = 186;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.FieldName = "PhoneNumber";
            colPhoneNumber.MinWidth = 25;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.Visible = true;
            colPhoneNumber.VisibleIndex = 4;
            colPhoneNumber.Width = 188;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 25;
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 3;
            colEmail.Width = 203;
            // 
            // companiesBindingSource
            // 
            companiesBindingSource.DataSource = typeof(Models.Company);
            // 
            // dataLayoutCompanyControl
            // 
            dataLayoutCompanyControl.Controls.Add(sbtnAddCompany);
            dataLayoutCompanyControl.Controls.Add(CompanyNameTextEdit);
            dataLayoutCompanyControl.Controls.Add(CompanyPhoneNumTextEdit);
            dataLayoutCompanyControl.Controls.Add(CompanyEmailTextEdit);
            dataLayoutCompanyControl.Controls.Add(CompanyIDTextEdit);
            dataLayoutCompanyControl.DataSource = companiesBindingSource;
            dataLayoutCompanyControl.Location = new Point(771, 15);
            dataLayoutCompanyControl.Name = "dataLayoutCompanyControl";
            dataLayoutCompanyControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(494, 384, 812, 500);
            dataLayoutCompanyControl.Root = layoutControlGroup2;
            dataLayoutCompanyControl.Size = new Size(330, 392);
            dataLayoutCompanyControl.TabIndex = 4;
            dataLayoutCompanyControl.Text = "dataLayoutControl2";
            // 
            // sbtnAddCompany
            // 
            sbtnAddCompany.Location = new Point(32, 302);
            sbtnAddCompany.Name = "sbtnAddCompany";
            sbtnAddCompany.Size = new Size(266, 58);
            sbtnAddCompany.StyleController = dataLayoutCompanyControl;
            sbtnAddCompany.TabIndex = 4;
            sbtnAddCompany.Text = "Add Company";
            // 
            // CompanyNameTextEdit
            // 
            CompanyNameTextEdit.DataBindings.Add(new Binding("EditValue", companiesBindingSource, "CompanyName", true));
            CompanyNameTextEdit.Location = new Point(32, 138);
            CompanyNameTextEdit.Name = "CompanyNameTextEdit";
            CompanyNameTextEdit.Size = new Size(266, 22);
            CompanyNameTextEdit.StyleController = dataLayoutCompanyControl;
            CompanyNameTextEdit.TabIndex = 0;
            // 
            // CompanyPhoneNumTextEdit
            // 
            CompanyPhoneNumTextEdit.DataBindings.Add(new Binding("EditValue", companiesBindingSource, "PhoneNumber", true));
            CompanyPhoneNumTextEdit.Location = new Point(32, 199);
            CompanyPhoneNumTextEdit.Name = "CompanyPhoneNumTextEdit";
            CompanyPhoneNumTextEdit.Size = new Size(266, 22);
            CompanyPhoneNumTextEdit.StyleController = dataLayoutCompanyControl;
            CompanyPhoneNumTextEdit.TabIndex = 2;
            // 
            // CompanyEmailTextEdit
            // 
            CompanyEmailTextEdit.DataBindings.Add(new Binding("EditValue", companiesBindingSource, "Email", true));
            CompanyEmailTextEdit.Location = new Point(32, 260);
            CompanyEmailTextEdit.Name = "CompanyEmailTextEdit";
            CompanyEmailTextEdit.Size = new Size(266, 22);
            CompanyEmailTextEdit.StyleController = dataLayoutCompanyControl;
            CompanyEmailTextEdit.TabIndex = 3;
            // 
            // CompanyIDTextEdit
            // 
            CompanyIDTextEdit.DataBindings.Add(new Binding("EditValue", companiesBindingSource, "CompanyID", true));
            CompanyIDTextEdit.Location = new Point(32, 77);
            CompanyIDTextEdit.Name = "CompanyIDTextEdit";
            CompanyIDTextEdit.Size = new Size(266, 22);
            CompanyIDTextEdit.StyleController = dataLayoutCompanyControl;
            CompanyIDTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup3 });
            layoutControlGroup2.Name = "Root";
            layoutControlGroup2.Size = new Size(330, 392);
            layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.AllowDrawBackground = false;
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup4 });
            layoutControlGroup3.Location = new Point(0, 0);
            layoutControlGroup3.Name = "autoGeneratedGroup0";
            layoutControlGroup3.Size = new Size(310, 372);
            // 
            // layoutControlGroup4
            // 
            layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForEmail, ItemForCompanyName, ItemForPhoneNumber, ItemToAddCompany, ItemForCompanyID });
            layoutControlGroup4.Location = new Point(0, 0);
            layoutControlGroup4.Name = "layoutControlGroup4";
            layoutControlGroup4.Size = new Size(310, 372);
            layoutControlGroup4.Text = "Fill in company informations";
            // 
            // ItemForEmail
            // 
            ItemForEmail.Control = CompanyEmailTextEdit;
            ItemForEmail.Location = new Point(0, 183);
            ItemForEmail.Name = "ItemForEmail";
            ItemForEmail.Size = new Size(286, 61);
            ItemForEmail.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            ItemForEmail.Text = "Email";
            ItemForEmail.TextLocation = DevExpress.Utils.Locations.Top;
            ItemForEmail.TextSize = new Size(90, 16);
            // 
            // ItemForCompanyName
            // 
            ItemForCompanyName.Control = CompanyNameTextEdit;
            ItemForCompanyName.Location = new Point(0, 61);
            ItemForCompanyName.Name = "ItemForCompanyName";
            ItemForCompanyName.Size = new Size(286, 61);
            ItemForCompanyName.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            ItemForCompanyName.Text = "Company Name";
            ItemForCompanyName.TextLocation = DevExpress.Utils.Locations.Top;
            ItemForCompanyName.TextSize = new Size(90, 16);
            // 
            // ItemForPhoneNumber
            // 
            ItemForPhoneNumber.Control = CompanyPhoneNumTextEdit;
            ItemForPhoneNumber.Location = new Point(0, 122);
            ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            ItemForPhoneNumber.Size = new Size(286, 61);
            ItemForPhoneNumber.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            ItemForPhoneNumber.Text = "Phone Number";
            ItemForPhoneNumber.TextLocation = DevExpress.Utils.Locations.Top;
            ItemForPhoneNumber.TextSize = new Size(90, 16);
            // 
            // ItemToAddCompany
            // 
            ItemToAddCompany.Control = sbtnAddCompany;
            ItemToAddCompany.Location = new Point(0, 244);
            ItemToAddCompany.MinSize = new Size(107, 71);
            ItemToAddCompany.Name = "ItemToAddCompany";
            ItemToAddCompany.Size = new Size(286, 78);
            ItemToAddCompany.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            ItemToAddCompany.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            ItemToAddCompany.TextSize = new Size(0, 0);
            ItemToAddCompany.TextVisible = false;
            // 
            // ItemForCompanyID
            // 
            ItemForCompanyID.Control = CompanyIDTextEdit;
            ItemForCompanyID.Location = new Point(0, 0);
            ItemForCompanyID.Name = "ItemForCompanyID";
            ItemForCompanyID.Size = new Size(286, 61);
            ItemForCompanyID.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            ItemForCompanyID.Text = "Company ID";
            ItemForCompanyID.TextLocation = DevExpress.Utils.Locations.Top;
            ItemForCompanyID.TextSize = new Size(90, 16);
            // 
            // mvvmCompanyContext
            // 
            mvvmCompanyContext.ContainerControl = this;
            mvvmCompanyContext.ViewModelType = typeof(ViewModels.CompanyViewModel);
            // 
            // CompanyViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sbtnDeleteRecord);
            Controls.Add(companyGridControl);
            Controls.Add(dataLayoutCompanyControl);
            Name = "CompanyViewControl";
            Size = new Size(1106, 497);
            ((System.ComponentModel.ISupportInitialize)companyGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)companyGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)companiesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataLayoutCompanyControl).EndInit();
            dataLayoutCompanyControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CompanyNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyPhoneNumTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyEmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyIDTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCompanyName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemToAddCompany).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForCompanyID).EndInit();
            ((System.ComponentModel.ISupportInitialize)mvvmCompanyContext).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxCompanyValidationProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnDeleteRecord;
        private DevExpress.XtraGrid.GridControl companyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView companyGridView;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutCompanyControl;
        private DevExpress.XtraEditors.SimpleButton sbtnAddCompany;
        private DevExpress.XtraEditors.TextEdit CompanyNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CompanyPhoneNumTextEdit;
        private DevExpress.XtraEditors.TextEdit CompanyEmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemToAddCompany;
        private DevExpress.Utils.MVVM.MVVMContext mvvmCompanyContext;
        private DevExpress.XtraEditors.TextEdit CompanyIDTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompanyID;
        private BindingSource companiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxCompanyValidationProvider;
    }
}
