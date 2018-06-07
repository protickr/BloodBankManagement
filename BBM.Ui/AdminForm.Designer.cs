namespace BBM.Ui
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanelAdminForm = new MetroFramework.Controls.MetroPanel();
            this.inventoryButtonAdminForm = new MetroFramework.Controls.MetroButton();
            this.logOutButtonAdminForm = new MetroFramework.Controls.MetroButton();
            this.editDetailsButtonAdminForm = new MetroFramework.Controls.MetroButton();
            this.historyButtonAdminForm = new MetroFramework.Controls.MetroButton();
            this.userNameLabelAdminForm = new MetroFramework.Controls.MetroLabel();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.userIdLabelAdminForm = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.bloodStatGridAdminForm = new MetroFramework.Controls.MetroGrid();
            this.bloodStatTitleAdminForm = new MetroFramework.Controls.MetroTile();
            this.mainPanelAdminForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodStatGridAdminForm)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelAdminForm
            // 
            this.mainPanelAdminForm.Controls.Add(this.inventoryButtonAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.logOutButtonAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.editDetailsButtonAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.historyButtonAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.userNameLabelAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.label);
            this.mainPanelAdminForm.Controls.Add(this.userIdLabelAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.metroLabel5);
            this.mainPanelAdminForm.Controls.Add(this.bloodStatGridAdminForm);
            this.mainPanelAdminForm.Controls.Add(this.bloodStatTitleAdminForm);
            this.mainPanelAdminForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelAdminForm.HorizontalScrollbarBarColor = true;
            this.mainPanelAdminForm.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanelAdminForm.HorizontalScrollbarSize = 10;
            this.mainPanelAdminForm.Location = new System.Drawing.Point(20, 60);
            this.mainPanelAdminForm.Name = "mainPanelAdminForm";
            this.mainPanelAdminForm.Size = new System.Drawing.Size(764, 493);
            this.mainPanelAdminForm.TabIndex = 0;
            this.mainPanelAdminForm.VerticalScrollbarBarColor = true;
            this.mainPanelAdminForm.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanelAdminForm.VerticalScrollbarSize = 10;
            this.mainPanelAdminForm.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanelAdminForm_Paint);
            // 
            // inventoryButtonAdminForm
            // 
            this.inventoryButtonAdminForm.Location = new System.Drawing.Point(29, 181);
            this.inventoryButtonAdminForm.Name = "inventoryButtonAdminForm";
            this.inventoryButtonAdminForm.Size = new System.Drawing.Size(136, 48);
            this.inventoryButtonAdminForm.TabIndex = 17;
            this.inventoryButtonAdminForm.Text = "Blood Inventory";
            this.inventoryButtonAdminForm.UseSelectable = true;
            this.inventoryButtonAdminForm.Click += new System.EventHandler(this.inventoryButtonAdminForm_Click);
            // 
            // logOutButtonAdminForm
            // 
            this.logOutButtonAdminForm.Location = new System.Drawing.Point(4, 467);
            this.logOutButtonAdminForm.Name = "logOutButtonAdminForm";
            this.logOutButtonAdminForm.Size = new System.Drawing.Size(82, 23);
            this.logOutButtonAdminForm.TabIndex = 16;
            this.logOutButtonAdminForm.Text = "Log Out";
            this.logOutButtonAdminForm.UseSelectable = true;
            this.logOutButtonAdminForm.Click += new System.EventHandler(this.logOutButtonAdminForm_Click);
            // 
            // editDetailsButtonAdminForm
            // 
            this.editDetailsButtonAdminForm.Location = new System.Drawing.Point(29, 318);
            this.editDetailsButtonAdminForm.Name = "editDetailsButtonAdminForm";
            this.editDetailsButtonAdminForm.Size = new System.Drawing.Size(136, 48);
            this.editDetailsButtonAdminForm.TabIndex = 15;
            this.editDetailsButtonAdminForm.Text = "Edit Personal Details";
            this.editDetailsButtonAdminForm.UseSelectable = true;
            this.editDetailsButtonAdminForm.Click += new System.EventHandler(this.editDetailsButtonAdminForm_Click);
            // 
            // historyButtonAdminForm
            // 
            this.historyButtonAdminForm.Location = new System.Drawing.Point(29, 248);
            this.historyButtonAdminForm.Name = "historyButtonAdminForm";
            this.historyButtonAdminForm.Size = new System.Drawing.Size(136, 47);
            this.historyButtonAdminForm.TabIndex = 14;
            this.historyButtonAdminForm.Text = "Past History";
            this.historyButtonAdminForm.UseSelectable = true;
            this.historyButtonAdminForm.Click += new System.EventHandler(this.historyButtonAdminForm_Click);
            // 
            // userNameLabelAdminForm
            // 
            this.userNameLabelAdminForm.AutoSize = true;
            this.userNameLabelAdminForm.Location = new System.Drawing.Point(117, 99);
            this.userNameLabelAdminForm.Name = "userNameLabelAdminForm";
            this.userNameLabelAdminForm.Size = new System.Drawing.Size(45, 19);
            this.userNameLabelAdminForm.TabIndex = 12;
            this.userNameLabelAdminForm.Text = "Name";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 19);
            this.label.TabIndex = 11;
            this.label.Text = "User Name";
            // 
            // userIdLabelAdminForm
            // 
            this.userIdLabelAdminForm.AutoSize = true;
            this.userIdLabelAdminForm.Location = new System.Drawing.Point(117, 42);
            this.userIdLabelAdminForm.Name = "userIdLabelAdminForm";
            this.userIdLabelAdminForm.Size = new System.Drawing.Size(16, 19);
            this.userIdLabelAdminForm.TabIndex = 10;
            this.userIdLabelAdminForm.Text = "0";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(53, 42);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "User ID";
            // 
            // bloodStatGridAdminForm
            // 
            this.bloodStatGridAdminForm.AllowUserToResizeRows = false;
            this.bloodStatGridAdminForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bloodStatGridAdminForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bloodStatGridAdminForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bloodStatGridAdminForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bloodStatGridAdminForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bloodStatGridAdminForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bloodStatGridAdminForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bloodStatGridAdminForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bloodStatGridAdminForm.DefaultCellStyle = dataGridViewCellStyle8;
            this.bloodStatGridAdminForm.EnableHeadersVisualStyles = false;
            this.bloodStatGridAdminForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bloodStatGridAdminForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bloodStatGridAdminForm.Location = new System.Drawing.Point(425, 32);
            this.bloodStatGridAdminForm.Name = "bloodStatGridAdminForm";
            this.bloodStatGridAdminForm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bloodStatGridAdminForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.bloodStatGridAdminForm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bloodStatGridAdminForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bloodStatGridAdminForm.Size = new System.Drawing.Size(336, 458);
            this.bloodStatGridAdminForm.TabIndex = 4;
            this.bloodStatGridAdminForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bloodStatGridAdminForm_CellContentClick);
            // 
            // bloodStatTitleAdminForm
            // 
            this.bloodStatTitleAdminForm.ActiveControl = null;
            this.bloodStatTitleAdminForm.Location = new System.Drawing.Point(425, 3);
            this.bloodStatTitleAdminForm.Name = "bloodStatTitleAdminForm";
            this.bloodStatTitleAdminForm.Size = new System.Drawing.Size(326, 23);
            this.bloodStatTitleAdminForm.TabIndex = 2;
            this.bloodStatTitleAdminForm.Text = "Blood Available";
            this.bloodStatTitleAdminForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bloodStatTitleAdminForm.UseSelectable = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 573);
            this.Controls.Add(this.mainPanelAdminForm);
            this.Name = "AdminForm";
            this.Text = "Admin Panel Home Page";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.mainPanelAdminForm.ResumeLayout(false);
            this.mainPanelAdminForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodStatGridAdminForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanelAdminForm;
        private MetroFramework.Controls.MetroTile bloodStatTitleAdminForm;
        private MetroFramework.Controls.MetroGrid bloodStatGridAdminForm;
        private MetroFramework.Controls.MetroLabel userNameLabelAdminForm;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroLabel userIdLabelAdminForm;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton editDetailsButtonAdminForm;
        private MetroFramework.Controls.MetroButton historyButtonAdminForm;
        private MetroFramework.Controls.MetroButton logOutButtonAdminForm;
        private MetroFramework.Controls.MetroButton inventoryButtonAdminForm;
    }
}