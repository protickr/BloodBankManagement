namespace BBM.Ui
{
    partial class ReportForm
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
            this.mainPanelReportForm = new MetroFramework.Controls.MetroPanel();
            this.searchButtonReportForm = new MetroFramework.Controls.MetroButton();
            this.searchBoxReportForm = new MetroFramework.Controls.MetroTextBox();
            this.requestTypeComboBoxReportForm = new MetroFramework.Controls.MetroComboBox();
            this.bloodReportGridReportForm = new MetroFramework.Controls.MetroGrid();
            this.realoadButton = new MetroFramework.Controls.MetroButton();
            this.mainPanelReportForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodReportGridReportForm)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelReportForm
            // 
            this.mainPanelReportForm.Controls.Add(this.realoadButton);
            this.mainPanelReportForm.Controls.Add(this.searchButtonReportForm);
            this.mainPanelReportForm.Controls.Add(this.searchBoxReportForm);
            this.mainPanelReportForm.Controls.Add(this.requestTypeComboBoxReportForm);
            this.mainPanelReportForm.Controls.Add(this.bloodReportGridReportForm);
            this.mainPanelReportForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelReportForm.HorizontalScrollbarBarColor = true;
            this.mainPanelReportForm.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanelReportForm.HorizontalScrollbarSize = 10;
            this.mainPanelReportForm.Location = new System.Drawing.Point(20, 60);
            this.mainPanelReportForm.Name = "mainPanelReportForm";
            this.mainPanelReportForm.Size = new System.Drawing.Size(766, 464);
            this.mainPanelReportForm.TabIndex = 0;
            this.mainPanelReportForm.VerticalScrollbarBarColor = true;
            this.mainPanelReportForm.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanelReportForm.VerticalScrollbarSize = 10;
            // 
            // searchButtonReportForm
            // 
            this.searchButtonReportForm.Location = new System.Drawing.Point(486, 3);
            this.searchButtonReportForm.Name = "searchButtonReportForm";
            this.searchButtonReportForm.Size = new System.Drawing.Size(145, 28);
            this.searchButtonReportForm.TabIndex = 5;
            this.searchButtonReportForm.Text = "Search";
            this.searchButtonReportForm.UseSelectable = true;
            this.searchButtonReportForm.Click += new System.EventHandler(this.searchButtonReportForm_Click);
            // 
            // searchBoxReportForm
            // 
            // 
            // 
            // 
            this.searchBoxReportForm.CustomButton.Image = null;
            this.searchBoxReportForm.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.searchBoxReportForm.CustomButton.Name = "";
            this.searchBoxReportForm.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.searchBoxReportForm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBoxReportForm.CustomButton.TabIndex = 1;
            this.searchBoxReportForm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBoxReportForm.CustomButton.UseSelectable = true;
            this.searchBoxReportForm.CustomButton.Visible = false;
            this.searchBoxReportForm.Lines = new string[0];
            this.searchBoxReportForm.Location = new System.Drawing.Point(205, 4);
            this.searchBoxReportForm.MaxLength = 32767;
            this.searchBoxReportForm.Name = "searchBoxReportForm";
            this.searchBoxReportForm.PasswordChar = '\0';
            this.searchBoxReportForm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBoxReportForm.SelectedText = "";
            this.searchBoxReportForm.SelectionLength = 0;
            this.searchBoxReportForm.SelectionStart = 0;
            this.searchBoxReportForm.Size = new System.Drawing.Size(275, 28);
            this.searchBoxReportForm.TabIndex = 4;
            this.searchBoxReportForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBoxReportForm.UseSelectable = true;
            this.searchBoxReportForm.WaterMark = "Enter Username to Search";
            this.searchBoxReportForm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBoxReportForm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // requestTypeComboBoxReportForm
            // 
            this.requestTypeComboBoxReportForm.FormattingEnabled = true;
            this.requestTypeComboBoxReportForm.ItemHeight = 23;
            this.requestTypeComboBoxReportForm.Items.AddRange(new object[] {
            "Select Request Type",
            "Donate",
            "Obtain"});
            this.requestTypeComboBoxReportForm.Location = new System.Drawing.Point(4, 3);
            this.requestTypeComboBoxReportForm.Name = "requestTypeComboBoxReportForm";
            this.requestTypeComboBoxReportForm.Size = new System.Drawing.Size(161, 29);
            this.requestTypeComboBoxReportForm.TabIndex = 3;
            this.requestTypeComboBoxReportForm.UseSelectable = true;
            this.requestTypeComboBoxReportForm.SelectedIndexChanged += new System.EventHandler(this.requestTypeComboBoxReportForm_SelectedIndexChanged);
            // 
            // bloodReportGridReportForm
            // 
            this.bloodReportGridReportForm.AllowUserToResizeRows = false;
            this.bloodReportGridReportForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bloodReportGridReportForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bloodReportGridReportForm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bloodReportGridReportForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bloodReportGridReportForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bloodReportGridReportForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bloodReportGridReportForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bloodReportGridReportForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bloodReportGridReportForm.DefaultCellStyle = dataGridViewCellStyle5;
            this.bloodReportGridReportForm.EnableHeadersVisualStyles = false;
            this.bloodReportGridReportForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bloodReportGridReportForm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bloodReportGridReportForm.Location = new System.Drawing.Point(4, 52);
            this.bloodReportGridReportForm.Name = "bloodReportGridReportForm";
            this.bloodReportGridReportForm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bloodReportGridReportForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bloodReportGridReportForm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bloodReportGridReportForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bloodReportGridReportForm.Size = new System.Drawing.Size(762, 412);
            this.bloodReportGridReportForm.TabIndex = 2;
            this.bloodReportGridReportForm.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // realoadButton
            // 
            this.realoadButton.Location = new System.Drawing.Point(637, 4);
            this.realoadButton.Name = "realoadButton";
            this.realoadButton.Size = new System.Drawing.Size(126, 27);
            this.realoadButton.TabIndex = 6;
            this.realoadButton.Text = "Reload";
            this.realoadButton.UseSelectable = true;
            this.realoadButton.Click += new System.EventHandler(this.realoadButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 544);
            this.Controls.Add(this.mainPanelReportForm);
            this.Name = "ReportForm";
            this.Text = "Blood Exchange History";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.mainPanelReportForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bloodReportGridReportForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanelReportForm;
        private MetroFramework.Controls.MetroGrid bloodReportGridReportForm;
        private MetroFramework.Controls.MetroButton searchButtonReportForm;
        private MetroFramework.Controls.MetroTextBox searchBoxReportForm;
        private MetroFramework.Controls.MetroComboBox requestTypeComboBoxReportForm;
        private MetroFramework.Controls.MetroButton realoadButton;
    }
}