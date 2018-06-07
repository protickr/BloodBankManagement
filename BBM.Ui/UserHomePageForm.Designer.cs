namespace BBM.Ui
{
    partial class UserHomePageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanelUserHomePageForm = new MetroFramework.Controls.MetroPanel();
            this.logOutButtonUserHomePageForm = new MetroFramework.Controls.MetroButton();
            this.editDetailsHomepageForm = new MetroFramework.Controls.MetroButton();
            this.donateButtonUserHomePageForm = new MetroFramework.Controls.MetroButton();
            this.requestButtonUserHomePageForm = new MetroFramework.Controls.MetroButton();
            this.userNameUserHomePageForm = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.userIdLabelUserHomePageForm = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userHistoryGridUserHomePageForm = new MetroFramework.Controls.MetroGrid();
            this.mainPanelUserHomePageForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userHistoryGridUserHomePageForm)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelUserHomePageForm
            // 
            this.mainPanelUserHomePageForm.Controls.Add(this.logOutButtonUserHomePageForm);
            this.mainPanelUserHomePageForm.Controls.Add(this.editDetailsHomepageForm);
            this.mainPanelUserHomePageForm.Controls.Add(this.donateButtonUserHomePageForm);
            this.mainPanelUserHomePageForm.Controls.Add(this.requestButtonUserHomePageForm);
            this.mainPanelUserHomePageForm.Controls.Add(this.userNameUserHomePageForm);
            this.mainPanelUserHomePageForm.Controls.Add(this.metroLabel3);
            this.mainPanelUserHomePageForm.Controls.Add(this.userIdLabelUserHomePageForm);
            this.mainPanelUserHomePageForm.Controls.Add(this.metroLabel1);
            this.mainPanelUserHomePageForm.Controls.Add(this.userHistoryGridUserHomePageForm);
            this.mainPanelUserHomePageForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelUserHomePageForm.HorizontalScrollbarBarColor = true;
            this.mainPanelUserHomePageForm.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanelUserHomePageForm.HorizontalScrollbarSize = 10;
            this.mainPanelUserHomePageForm.Location = new System.Drawing.Point(20, 60);
            this.mainPanelUserHomePageForm.Name = "mainPanelUserHomePageForm";
            this.mainPanelUserHomePageForm.Size = new System.Drawing.Size(825, 430);
            this.mainPanelUserHomePageForm.TabIndex = 0;
            this.mainPanelUserHomePageForm.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mainPanelUserHomePageForm.VerticalScrollbarBarColor = true;
            this.mainPanelUserHomePageForm.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanelUserHomePageForm.VerticalScrollbarSize = 10;
            this.mainPanelUserHomePageForm.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanelUserHomePageForm_Paint);
            // 
            // logOutButtonUserHomePageForm
            // 
            this.logOutButtonUserHomePageForm.Location = new System.Drawing.Point(3, 405);
            this.logOutButtonUserHomePageForm.Name = "logOutButtonUserHomePageForm";
            this.logOutButtonUserHomePageForm.Size = new System.Drawing.Size(91, 22);
            this.logOutButtonUserHomePageForm.TabIndex = 10;
            this.logOutButtonUserHomePageForm.Text = "Log Out";
            this.logOutButtonUserHomePageForm.UseSelectable = true;
            this.logOutButtonUserHomePageForm.Click += new System.EventHandler(this.logOutButtonUserHomePageForm_Click);
            // 
            // editDetailsHomepageForm
            // 
            this.editDetailsHomepageForm.Location = new System.Drawing.Point(38, 231);
            this.editDetailsHomepageForm.Name = "editDetailsHomepageForm";
            this.editDetailsHomepageForm.Size = new System.Drawing.Size(171, 47);
            this.editDetailsHomepageForm.TabIndex = 9;
            this.editDetailsHomepageForm.Text = "Edit Details";
            this.editDetailsHomepageForm.UseSelectable = true;
            this.editDetailsHomepageForm.Click += new System.EventHandler(this.editDetailsHomepageForm_Click);
            // 
            // donateButtonUserHomePageForm
            // 
            this.donateButtonUserHomePageForm.Location = new System.Drawing.Point(38, 185);
            this.donateButtonUserHomePageForm.Name = "donateButtonUserHomePageForm";
            this.donateButtonUserHomePageForm.Size = new System.Drawing.Size(171, 40);
            this.donateButtonUserHomePageForm.TabIndex = 8;
            this.donateButtonUserHomePageForm.Text = "Donate Blood";
            this.donateButtonUserHomePageForm.UseSelectable = true;
            this.donateButtonUserHomePageForm.Click += new System.EventHandler(this.donateButtonUserHomePageForm_Click);
            // 
            // requestButtonUserHomePageForm
            // 
            this.requestButtonUserHomePageForm.Location = new System.Drawing.Point(38, 138);
            this.requestButtonUserHomePageForm.Name = "requestButtonUserHomePageForm";
            this.requestButtonUserHomePageForm.Size = new System.Drawing.Size(171, 41);
            this.requestButtonUserHomePageForm.TabIndex = 7;
            this.requestButtonUserHomePageForm.Text = "Request Blood";
            this.requestButtonUserHomePageForm.UseSelectable = true;
            this.requestButtonUserHomePageForm.Click += new System.EventHandler(this.requestButtonUserHomePageForm_Click);
            // 
            // userNameUserHomePageForm
            // 
            this.userNameUserHomePageForm.AutoSize = true;
            this.userNameUserHomePageForm.Location = new System.Drawing.Point(152, 86);
            this.userNameUserHomePageForm.Name = "userNameUserHomePageForm";
            this.userNameUserHomePageForm.Size = new System.Drawing.Size(54, 19);
            this.userNameUserHomePageForm.TabIndex = 6;
            this.userNameUserHomePageForm.Text = "\"Name\"";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "User Name";
            // 
            // userIdLabelUserHomePageForm
            // 
            this.userIdLabelUserHomePageForm.AutoSize = true;
            this.userIdLabelUserHomePageForm.Location = new System.Drawing.Point(152, 49);
            this.userIdLabelUserHomePageForm.Name = "userIdLabelUserHomePageForm";
            this.userIdLabelUserHomePageForm.Size = new System.Drawing.Size(16, 19);
            this.userIdLabelUserHomePageForm.TabIndex = 4;
            this.userIdLabelUserHomePageForm.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(90, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "User ID";
            // 
            // userHistoryGridUserHomePageForm
            // 
            this.userHistoryGridUserHomePageForm.AllowUserToResizeRows = false;
            this.userHistoryGridUserHomePageForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userHistoryGridUserHomePageForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userHistoryGridUserHomePageForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userHistoryGridUserHomePageForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userHistoryGridUserHomePageForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userHistoryGridUserHomePageForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userHistoryGridUserHomePageForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userHistoryGridUserHomePageForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userHistoryGridUserHomePageForm.DefaultCellStyle = dataGridViewCellStyle5;
            this.userHistoryGridUserHomePageForm.EnableHeadersVisualStyles = false;
            this.userHistoryGridUserHomePageForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userHistoryGridUserHomePageForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userHistoryGridUserHomePageForm.Location = new System.Drawing.Point(225, 4);
            this.userHistoryGridUserHomePageForm.Name = "userHistoryGridUserHomePageForm";
            this.userHistoryGridUserHomePageForm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userHistoryGridUserHomePageForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.userHistoryGridUserHomePageForm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userHistoryGridUserHomePageForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userHistoryGridUserHomePageForm.Size = new System.Drawing.Size(597, 423);
            this.userHistoryGridUserHomePageForm.TabIndex = 2;
            this.userHistoryGridUserHomePageForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userHistoryGridUserHomePageForm_CellContentClick);
            // 
            // UserHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 510);
            this.Controls.Add(this.mainPanelUserHomePageForm);
            this.Name = "UserHomePageForm";
            this.Text = "User Homepage";
            this.Load += new System.EventHandler(this.UserHomePageForm_Load);
            this.mainPanelUserHomePageForm.ResumeLayout(false);
            this.mainPanelUserHomePageForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userHistoryGridUserHomePageForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanelUserHomePageForm;
        private MetroFramework.Controls.MetroGrid userHistoryGridUserHomePageForm;
        private MetroFramework.Controls.MetroButton logOutButtonUserHomePageForm;
        private MetroFramework.Controls.MetroButton donateButtonUserHomePageForm;
        private MetroFramework.Controls.MetroButton requestButtonUserHomePageForm;
        private MetroFramework.Controls.MetroLabel userNameUserHomePageForm;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel userIdLabelUserHomePageForm;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton editDetailsHomepageForm;
    }
}