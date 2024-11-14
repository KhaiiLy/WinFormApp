namespace WinFormApp.Views
{
    partial class PersonViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            peopleBindingSource = new BindingSource(components);
            LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            BirthDateEdit = new DevExpress.XtraEditors.DateEdit();
            PhoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            sbtnAddPerson = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            BirthDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            ItemForFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForLastName = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForBirthDate = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            lctrlGroupInformation = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            Item1_FirstName = new DevExpress.XtraLayout.LayoutControlItem();
            Item2_LastName = new DevExpress.XtraLayout.LayoutControlItem();
            Item3_BirthDate = new DevExpress.XtraLayout.LayoutControlItem();
            Item4_PhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            Item5_Email = new DevExpress.XtraLayout.LayoutControlItem();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemAlignment1 = new DevExpress.XtraRichEdit.Design.RepositoryItemAlignment();
            repositoryItemAlignment2 = new DevExpress.XtraRichEdit.Design.RepositoryItemAlignment();
            dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(components);
            mvvmPersonContext = new DevExpress.Utils.MVVM.MVVMContext(components);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peopleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForBirthDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lctrlGroupInformation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item1_FirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item2_LastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item3_BirthDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item4_PhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item5_Email).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemAlignment1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemAlignment2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dxValidationProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mvvmPersonContext).BeginInit();
            SuspendLayout();
            // 
            // sbtnDelete
            // 
            sbtnDelete.Location = new Point(801, 463);
            sbtnDelete.Name = "sbtnDelete";
            sbtnDelete.Size = new Size(287, 57);
            sbtnDelete.TabIndex = 6;
            sbtnDelete.Text = "Delete Record(s)";
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(FirstNameTextEdit);
            dataLayoutControl1.Controls.Add(LastNameTextEdit);
            dataLayoutControl1.Controls.Add(BirthDateEdit);
            dataLayoutControl1.Controls.Add(PhoneNumberTextEdit);
            dataLayoutControl1.Controls.Add(EmailTextEdit);
            dataLayoutControl1.Controls.Add(sbtnAddPerson);
            dataLayoutControl1.Controls.Add(textEdit1);
            dataLayoutControl1.Controls.Add(textEdit2);
            dataLayoutControl1.Controls.Add(BirthDateDateEdit);
            dataLayoutControl1.Controls.Add(textEdit3);
            dataLayoutControl1.Controls.Add(textEdit4);
            dataLayoutControl1.DataSource = peopleBindingSource;
            dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForFirstName, ItemForLastName, ItemForBirthDate, ItemForPhoneNumber, ItemForEmail });
            dataLayoutControl1.Location = new Point(769, 3);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1580, 37, 812, 500);
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new Size(351, 454);
            dataLayoutControl1.TabIndex = 5;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // FirstNameTextEdit
            // 
            FirstNameTextEdit.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "FirstName", true));
            FirstNameTextEdit.EditValue = "";
            FirstNameTextEdit.Location = new Point(32, 77);
            FirstNameTextEdit.Name = "FirstNameTextEdit";
            FirstNameTextEdit.Size = new Size(287, 22);
            FirstNameTextEdit.StyleController = dataLayoutControl1;
            FirstNameTextEdit.TabIndex = 0;
            // 
            // peopleBindingSource
            // 
            peopleBindingSource.DataSource = typeof(Models.Person);
            // 
            // LastNameTextEdit
            // 
            LastNameTextEdit.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "LastName", true));
            LastNameTextEdit.Location = new Point(32, 138);
            LastNameTextEdit.Name = "LastNameTextEdit";
            LastNameTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            LastNameTextEdit.Properties.MaskSettings.Set("mask", "\\p{L}+");
            LastNameTextEdit.Properties.MaskSettings.Set("allowBlankInput", true);
            LastNameTextEdit.Properties.MaskSettings.Set("isAutoComplete", false);
            LastNameTextEdit.Properties.MaskSettings.Set("showPlaceholders", false);
            LastNameTextEdit.Size = new Size(287, 22);
            LastNameTextEdit.StyleController = dataLayoutControl1;
            LastNameTextEdit.TabIndex = 2;
            // 
            // BirthDateEdit
            // 
            BirthDateEdit.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "BirthDate", true));
            BirthDateEdit.EditValue = null;
            BirthDateEdit.Location = new Point(32, 199);
            BirthDateEdit.Name = "BirthDateEdit";
            BirthDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            BirthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthDateEdit.Size = new Size(287, 22);
            BirthDateEdit.StyleController = dataLayoutControl1;
            BirthDateEdit.TabIndex = 3;
            // 
            // PhoneNumberTextEdit
            // 
            PhoneNumberTextEdit.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "PhoneNumber", true));
            PhoneNumberTextEdit.EditValue = "";
            PhoneNumberTextEdit.Location = new Point(32, 260);
            PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            PhoneNumberTextEdit.Size = new Size(287, 22);
            PhoneNumberTextEdit.StyleController = dataLayoutControl1;
            PhoneNumberTextEdit.TabIndex = 4;
            PhoneNumberTextEdit.Tag = "";
            // 
            // EmailTextEdit
            // 
            EmailTextEdit.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "Email", true));
            EmailTextEdit.Location = new Point(32, 321);
            EmailTextEdit.Name = "EmailTextEdit";
            EmailTextEdit.Size = new Size(287, 22);
            EmailTextEdit.StyleController = dataLayoutControl1;
            EmailTextEdit.TabIndex = 5;
            EmailTextEdit.Tag = "";
            // 
            // sbtnAddPerson
            // 
            sbtnAddPerson.Location = new Point(32, 363);
            sbtnAddPerson.Name = "sbtnAddPerson";
            sbtnAddPerson.Size = new Size(285, 57);
            sbtnAddPerson.StyleController = dataLayoutControl1;
            sbtnAddPerson.TabIndex = 6;
            sbtnAddPerson.Text = "Add Person";
            // 
            // textEdit1
            // 
            textEdit1.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "FirstName", true));
            textEdit1.Location = new Point(108, 416);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            textEdit1.Size = new Size(210, 22);
            textEdit1.StyleController = dataLayoutControl1;
            textEdit1.TabIndex = 7;
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "LastName", true));
            textEdit2.Location = new Point(108, 442);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            textEdit2.Size = new Size(210, 22);
            textEdit2.StyleController = dataLayoutControl1;
            textEdit2.TabIndex = 8;
            // 
            // BirthDateDateEdit
            // 
            BirthDateDateEdit.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "BirthDate", true));
            BirthDateDateEdit.EditValue = null;
            BirthDateDateEdit.Location = new Point(108, 468);
            BirthDateDateEdit.Name = "BirthDateDateEdit";
            BirthDateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            BirthDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BirthDateDateEdit.Properties.DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            BirthDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            BirthDateDateEdit.Properties.EditFormat.FormatString = "{0:dd/MM/yyyy}";
            BirthDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            BirthDateDateEdit.Size = new Size(210, 22);
            BirthDateDateEdit.StyleController = dataLayoutControl1;
            BirthDateDateEdit.TabIndex = 9;
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "PhoneNumber", true));
            textEdit3.Location = new Point(108, 494);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            textEdit3.Size = new Size(210, 22);
            textEdit3.StyleController = dataLayoutControl1;
            textEdit3.TabIndex = 10;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("EditValue", peopleBindingSource, "Email", true));
            textEdit4.Location = new Point(108, 520);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(210, 22);
            textEdit4.StyleController = dataLayoutControl1;
            textEdit4.TabIndex = 11;
            // 
            // ItemForFirstName
            // 
            ItemForFirstName.Control = textEdit1;
            ItemForFirstName.Location = new Point(0, 404);
            ItemForFirstName.Name = "ItemForFirstName";
            ItemForFirstName.Size = new Size(310, 26);
            ItemForFirstName.Text = "First Name";
            ItemForFirstName.TextSize = new Size(50, 20);
            // 
            // ItemForLastName
            // 
            ItemForLastName.Control = textEdit2;
            ItemForLastName.Location = new Point(0, 404);
            ItemForLastName.Name = "ItemForLastName";
            ItemForLastName.Size = new Size(310, 52);
            ItemForLastName.Text = "Last Name";
            ItemForLastName.TextSize = new Size(50, 20);
            // 
            // ItemForBirthDate
            // 
            ItemForBirthDate.Control = BirthDateDateEdit;
            ItemForBirthDate.Location = new Point(0, 404);
            ItemForBirthDate.Name = "ItemForBirthDate";
            ItemForBirthDate.Size = new Size(310, 78);
            ItemForBirthDate.Text = "Birth Date";
            ItemForBirthDate.TextSize = new Size(50, 20);
            // 
            // ItemForPhoneNumber
            // 
            ItemForPhoneNumber.Control = textEdit3;
            ItemForPhoneNumber.Location = new Point(0, 404);
            ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            ItemForPhoneNumber.Size = new Size(310, 104);
            ItemForPhoneNumber.Text = "Phone Number";
            ItemForPhoneNumber.TextSize = new Size(50, 20);
            // 
            // ItemForEmail
            // 
            ItemForEmail.Control = textEdit4;
            ItemForEmail.Location = new Point(0, 404);
            ItemForEmail.Name = "ItemForEmail";
            ItemForEmail.Size = new Size(310, 130);
            ItemForEmail.Text = "Email";
            ItemForEmail.TextSize = new Size(50, 20);
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1 });
            Root.Name = "Root";
            Root.Size = new Size(351, 454);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.AllowDrawBackground = false;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lctrlGroupInformation });
            layoutControlGroup1.Location = new Point(0, 0);
            layoutControlGroup1.Name = "autoGeneratedGroup0";
            layoutControlGroup1.Size = new Size(331, 434);
            // 
            // lctrlGroupInformation
            // 
            lctrlGroupInformation.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, Item1_FirstName, Item2_LastName, Item3_BirthDate, Item4_PhoneNumber, Item5_Email });
            lctrlGroupInformation.Location = new Point(0, 0);
            lctrlGroupInformation.Name = "lctrlGroupInformation";
            lctrlGroupInformation.Size = new Size(331, 434);
            lctrlGroupInformation.Text = "Fill in the informations";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = sbtnAddPerson;
            layoutControlItem1.Location = new Point(0, 305);
            layoutControlItem1.MinSize = new Size(94, 49);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(307, 79);
            layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 10, 8, 10);
            layoutControlItem1.Tag = "6";
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // Item1_FirstName
            // 
            Item1_FirstName.Control = FirstNameTextEdit;
            Item1_FirstName.Location = new Point(0, 0);
            Item1_FirstName.Name = "Item1_FirstName";
            Item1_FirstName.Size = new Size(307, 61);
            Item1_FirstName.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            Item1_FirstName.Tag = "1";
            Item1_FirstName.Text = "First Name";
            Item1_FirstName.TextLocation = DevExpress.Utils.Locations.Top;
            Item1_FirstName.TextSize = new Size(84, 16);
            // 
            // Item2_LastName
            // 
            Item2_LastName.Control = LastNameTextEdit;
            Item2_LastName.Location = new Point(0, 61);
            Item2_LastName.Name = "Item2_LastName";
            Item2_LastName.Size = new Size(307, 61);
            Item2_LastName.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            Item2_LastName.Tag = "1";
            Item2_LastName.Text = "Last Name";
            Item2_LastName.TextLocation = DevExpress.Utils.Locations.Top;
            Item2_LastName.TextSize = new Size(84, 16);
            // 
            // Item3_BirthDate
            // 
            Item3_BirthDate.Control = BirthDateEdit;
            Item3_BirthDate.Location = new Point(0, 122);
            Item3_BirthDate.Name = "Item3_BirthDate";
            Item3_BirthDate.Size = new Size(307, 61);
            Item3_BirthDate.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            Item3_BirthDate.Tag = "3";
            Item3_BirthDate.Text = "Birth Date";
            Item3_BirthDate.TextLocation = DevExpress.Utils.Locations.Top;
            Item3_BirthDate.TextSize = new Size(84, 16);
            // 
            // Item4_PhoneNumber
            // 
            Item4_PhoneNumber.Control = PhoneNumberTextEdit;
            Item4_PhoneNumber.Location = new Point(0, 183);
            Item4_PhoneNumber.Name = "Item4_PhoneNumber";
            Item4_PhoneNumber.Size = new Size(307, 61);
            Item4_PhoneNumber.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            Item4_PhoneNumber.Tag = "4";
            Item4_PhoneNumber.Text = "Phone Number";
            Item4_PhoneNumber.TextLocation = DevExpress.Utils.Locations.Top;
            Item4_PhoneNumber.TextSize = new Size(84, 16);
            // 
            // Item5_Email
            // 
            Item5_Email.Control = EmailTextEdit;
            Item5_Email.Location = new Point(0, 244);
            Item5_Email.Name = "Item5_Email";
            Item5_Email.Size = new Size(307, 61);
            Item5_Email.Spacing = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            Item5_Email.Tag = "5";
            Item5_Email.Text = "Email";
            Item5_Email.TextLocation = DevExpress.Utils.Locations.Top;
            Item5_Email.TextSize = new Size(84, 16);
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemAlignment1, repositoryItemAlignment2 });
            gridControl1.Size = new Size(751, 508);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirstName, colLastName, colBirthDate, colPhoneNumber, colEmail });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.MinWidth = 25;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 25;
            // 
            // colFirstName
            // 
            colFirstName.FieldName = "FirstName";
            colFirstName.MinWidth = 25;
            colFirstName.Name = "colFirstName";
            colFirstName.Visible = true;
            colFirstName.VisibleIndex = 1;
            colFirstName.Width = 122;
            // 
            // colLastName
            // 
            colLastName.FieldName = "LastName";
            colLastName.MinWidth = 25;
            colLastName.Name = "colLastName";
            colLastName.Visible = true;
            colLastName.VisibleIndex = 2;
            colLastName.Width = 117;
            // 
            // colBirthDate
            // 
            colBirthDate.FieldName = "BirthDate";
            colBirthDate.MinWidth = 25;
            colBirthDate.Name = "colBirthDate";
            colBirthDate.Visible = true;
            colBirthDate.VisibleIndex = 3;
            colBirthDate.Width = 121;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.FieldName = "PhoneNumber";
            colPhoneNumber.MinWidth = 25;
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.Visible = true;
            colPhoneNumber.VisibleIndex = 5;
            colPhoneNumber.Width = 164;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 25;
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 4;
            colEmail.Width = 188;
            // 
            // repositoryItemAlignment1
            // 
            repositoryItemAlignment1.AutoHeight = false;
            repositoryItemAlignment1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemAlignment1.HasArabic = false;
            repositoryItemAlignment1.HasDistribute = false;
            repositoryItemAlignment1.HasThaiDistribute = false;
            repositoryItemAlignment1.Name = "repositoryItemAlignment1";
            // 
            // repositoryItemAlignment2
            // 
            repositoryItemAlignment2.AutoHeight = false;
            repositoryItemAlignment2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemAlignment2.HasArabic = false;
            repositoryItemAlignment2.HasDistribute = false;
            repositoryItemAlignment2.HasThaiDistribute = false;
            repositoryItemAlignment2.Name = "repositoryItemAlignment2";
            // 
            // mvvmPersonContext
            // 
            mvvmPersonContext.ContainerControl = this;
            mvvmPersonContext.ViewModelType = typeof(ViewModels.PersonViewModel);
            // 
            // PersonViewControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sbtnDelete);
            Controls.Add(dataLayoutControl1);
            Controls.Add(gridControl1);
            Name = "PersonViewControl";
            Size = new Size(1179, 649);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peopleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthDateDateEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForBirthDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemForEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lctrlGroupInformation).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item1_FirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item2_LastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item3_BirthDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item4_PhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item5_Email).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemAlignment1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemAlignment2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dxValidationProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mvvmPersonContext).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnDelete;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.DateEdit BirthDateEdit;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.SimpleButton sbtnAddPerson;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lctrlGroupInformation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem Item1_FirstName;
        private DevExpress.XtraLayout.LayoutControlItem Item2_LastName;
        private DevExpress.XtraLayout.LayoutControlItem Item3_BirthDate;
        private DevExpress.XtraLayout.LayoutControlItem Item4_PhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem Item5_Email;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraRichEdit.Design.RepositoryItemAlignment repositoryItemAlignment1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemAlignment repositoryItemAlignment2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;

        private DevExpress.Utils.MVVM.MVVMContext mvvmPersonContext;
        private BindingSource peopleBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.DateEdit BirthDateDateEdit;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFirstName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLastName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBirthDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
    }
}
