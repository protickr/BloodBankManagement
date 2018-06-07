namespace BBM.Ui
{
    partial class RequestForm
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
            this.requestPanelRequestForm = new MetroFramework.Controls.MetroPanel();
            this.backButtonRequestForm = new MetroFramework.Controls.MetroButton();
            this.clearButtonRequestForm = new MetroFramework.Controls.MetroButton();
            this.sendButtonRequestForm = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.quantityComboBoxUserForm = new MetroFramework.Controls.MetroComboBox();
            this.requestTypeComboBoxUserForm = new MetroFramework.Controls.MetroComboBox();
            this.bloodGroupComboBoxUserForm = new MetroFramework.Controls.MetroComboBox();
            this.userNameLabelUserForm = new MetroFramework.Controls.MetroLabel();
            this.userIdLabelRequestForm = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.requestPanelRequestForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestPanelRequestForm
            // 
            this.requestPanelRequestForm.Controls.Add(this.backButtonRequestForm);
            this.requestPanelRequestForm.Controls.Add(this.clearButtonRequestForm);
            this.requestPanelRequestForm.Controls.Add(this.sendButtonRequestForm);
            this.requestPanelRequestForm.Controls.Add(this.metroLabel7);
            this.requestPanelRequestForm.Controls.Add(this.metroLabel6);
            this.requestPanelRequestForm.Controls.Add(this.metroLabel5);
            this.requestPanelRequestForm.Controls.Add(this.quantityComboBoxUserForm);
            this.requestPanelRequestForm.Controls.Add(this.requestTypeComboBoxUserForm);
            this.requestPanelRequestForm.Controls.Add(this.bloodGroupComboBoxUserForm);
            this.requestPanelRequestForm.Controls.Add(this.userNameLabelUserForm);
            this.requestPanelRequestForm.Controls.Add(this.userIdLabelRequestForm);
            this.requestPanelRequestForm.Controls.Add(this.metroLabel2);
            this.requestPanelRequestForm.Controls.Add(this.metroLabel1);
            this.requestPanelRequestForm.HorizontalScrollbarBarColor = true;
            this.requestPanelRequestForm.HorizontalScrollbarHighlightOnWheel = false;
            this.requestPanelRequestForm.HorizontalScrollbarSize = 10;
            this.requestPanelRequestForm.Location = new System.Drawing.Point(24, 78);
            this.requestPanelRequestForm.Name = "requestPanelRequestForm";
            this.requestPanelRequestForm.Size = new System.Drawing.Size(783, 466);
            this.requestPanelRequestForm.TabIndex = 0;
            this.requestPanelRequestForm.VerticalScrollbarBarColor = true;
            this.requestPanelRequestForm.VerticalScrollbarHighlightOnWheel = false;
            this.requestPanelRequestForm.VerticalScrollbarSize = 10;
            this.requestPanelRequestForm.Paint += new System.Windows.Forms.PaintEventHandler(this.requestPanelRequestForm_Paint);
            // 
            // backButtonRequestForm
            // 
            this.backButtonRequestForm.Location = new System.Drawing.Point(351, 355);
            this.backButtonRequestForm.Name = "backButtonRequestForm";
            this.backButtonRequestForm.Size = new System.Drawing.Size(195, 34);
            this.backButtonRequestForm.TabIndex = 14;
            this.backButtonRequestForm.Text = "Back To Homepage";
            this.backButtonRequestForm.UseSelectable = true;
            this.backButtonRequestForm.Click += new System.EventHandler(this.backButtonRequestForm_Click);
            // 
            // clearButtonRequestForm
            // 
            this.clearButtonRequestForm.Location = new System.Drawing.Point(455, 303);
            this.clearButtonRequestForm.Name = "clearButtonRequestForm";
            this.clearButtonRequestForm.Size = new System.Drawing.Size(91, 33);
            this.clearButtonRequestForm.TabIndex = 13;
            this.clearButtonRequestForm.Text = "Clear";
            this.clearButtonRequestForm.UseSelectable = true;
            this.clearButtonRequestForm.Click += new System.EventHandler(this.clearButtonRequestForm_Click);
            // 
            // sendButtonRequestForm
            // 
            this.sendButtonRequestForm.Location = new System.Drawing.Point(351, 303);
            this.sendButtonRequestForm.Name = "sendButtonRequestForm";
            this.sendButtonRequestForm.Size = new System.Drawing.Size(98, 33);
            this.sendButtonRequestForm.TabIndex = 12;
            this.sendButtonRequestForm.Text = "Send";
            this.sendButtonRequestForm.UseSelectable = true;
            this.sendButtonRequestForm.Click += new System.EventHandler(this.sendButtonRequestForm_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(227, 229);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Quantity (Bags)";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(239, 179);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Request Type";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(240, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Blood Group";
            // 
            // quantityComboBoxUserForm
            // 
            this.quantityComboBoxUserForm.FormattingEnabled = true;
            this.quantityComboBoxUserForm.ItemHeight = 23;
            this.quantityComboBoxUserForm.Items.AddRange(new object[] {
            "Select Quantity",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantityComboBoxUserForm.Location = new System.Drawing.Point(351, 229);
            this.quantityComboBoxUserForm.Name = "quantityComboBoxUserForm";
            this.quantityComboBoxUserForm.Size = new System.Drawing.Size(195, 29);
            this.quantityComboBoxUserForm.TabIndex = 8;
            this.quantityComboBoxUserForm.UseSelectable = true;
            // 
            // requestTypeComboBoxUserForm
            // 
            this.requestTypeComboBoxUserForm.FormattingEnabled = true;
            this.requestTypeComboBoxUserForm.ItemHeight = 23;
            this.requestTypeComboBoxUserForm.Items.AddRange(new object[] {
            "Select Request Type",
            "Donate",
            "Obtain"});
            this.requestTypeComboBoxUserForm.Location = new System.Drawing.Point(351, 179);
            this.requestTypeComboBoxUserForm.Name = "requestTypeComboBoxUserForm";
            this.requestTypeComboBoxUserForm.Size = new System.Drawing.Size(195, 29);
            this.requestTypeComboBoxUserForm.TabIndex = 7;
            this.requestTypeComboBoxUserForm.UseSelectable = true;
            // 
            // bloodGroupComboBoxUserForm
            // 
            this.bloodGroupComboBoxUserForm.FormattingEnabled = true;
            this.bloodGroupComboBoxUserForm.ItemHeight = 23;
            this.bloodGroupComboBoxUserForm.Items.AddRange(new object[] {
            "Select Blood Group",
            "O ( + ve )",
            "O ( - ve )",
            "A ( + ve )",
            "A ( - ve )",
            "B ( + ve )",
            "B ( - ve )",
            "AB ( + ve )",
            "AB ( - ve )"});
            this.bloodGroupComboBoxUserForm.Location = new System.Drawing.Point(351, 135);
            this.bloodGroupComboBoxUserForm.Name = "bloodGroupComboBoxUserForm";
            this.bloodGroupComboBoxUserForm.Size = new System.Drawing.Size(195, 29);
            this.bloodGroupComboBoxUserForm.TabIndex = 6;
            this.bloodGroupComboBoxUserForm.UseSelectable = true;
            this.bloodGroupComboBoxUserForm.SelectedIndexChanged += new System.EventHandler(this.bloodGroupComboBoxUserForm_SelectedIndexChanged);
            // 
            // userNameLabelUserForm
            // 
            this.userNameLabelUserForm.AutoSize = true;
            this.userNameLabelUserForm.Location = new System.Drawing.Point(351, 100);
            this.userNameLabelUserForm.Name = "userNameLabelUserForm";
            this.userNameLabelUserForm.Size = new System.Drawing.Size(0, 0);
            this.userNameLabelUserForm.TabIndex = 5;
            // 
            // userIdLabelRequestForm
            // 
            this.userIdLabelRequestForm.AutoSize = true;
            this.userIdLabelRequestForm.Location = new System.Drawing.Point(351, 61);
            this.userIdLabelRequestForm.Name = "userIdLabelRequestForm";
            this.userIdLabelRequestForm.Size = new System.Drawing.Size(0, 0);
            this.userIdLabelRequestForm.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(250, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "User Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(274, 61);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "User ID";
            //this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.requestPanelRequestForm);
            this.Name = "RequestForm";
            this.Text = "Request Form";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.requestPanelRequestForm.ResumeLayout(false);
            this.requestPanelRequestForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel requestPanelRequestForm;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox quantityComboBoxUserForm;
        private MetroFramework.Controls.MetroComboBox requestTypeComboBoxUserForm;
        private MetroFramework.Controls.MetroComboBox bloodGroupComboBoxUserForm;
        private MetroFramework.Controls.MetroLabel userNameLabelUserForm;
        private MetroFramework.Controls.MetroLabel userIdLabelRequestForm;
        private MetroFramework.Controls.MetroButton clearButtonRequestForm;
        private MetroFramework.Controls.MetroButton sendButtonRequestForm;
        private MetroFramework.Controls.MetroButton backButtonRequestForm;
    }
}