namespace WinFormApp
{
    partial class XtraForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            tabNavigationPeople = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            tabNavigationCompany = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)tabPane1).BeginInit();
            tabPane1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPane1
            // 
            tabPane1.Controls.Add(tabNavigationPeople);
            tabPane1.Controls.Add(tabNavigationCompany);
            tabPane1.Dock = DockStyle.Fill;
            tabPane1.Location = new Point(0, 0);
            tabPane1.Name = "tabPane1";
            tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { tabNavigationPeople, tabNavigationCompany });
            tabPane1.RegularSize = new Size(1124, 609);
            tabPane1.SelectedPage = tabNavigationPeople;
            tabPane1.Size = new Size(1124, 609);
            tabPane1.TabIndex = 2;
            tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPeople
            // 
            tabNavigationPeople.Caption = "People";
            tabNavigationPeople.Name = "tabNavigationPeople";
            tabNavigationPeople.Size = new Size(1124, 568);
            // 
            // tabNavigationCompany
            // 
            tabNavigationCompany.Caption = "Company";
            tabNavigationCompany.Name = "tabNavigationCompany";
            tabNavigationCompany.Size = new Size(1124, 568);
            // 
            // XtraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 609);
            Controls.Add(tabPane1);
            Name = "XtraForm";
            Text = "XtraForm";
            ((System.ComponentModel.ISupportInitialize)tabPane1).EndInit();
            tabPane1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPeople;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationCompany;
    }
}