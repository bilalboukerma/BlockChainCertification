
namespace BlockChainCertification
{
    partial class Home
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
            this.CertificationsGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Addnew = new Guna.UI.WinForms.GunaButton();
            this.PanelAdd = new Guna.UI.WinForms.GunaPanel();
            this.save = new Guna.UI.WinForms.GunaButton();
            this.CreateDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.Notes = new Guna.UI.WinForms.GunaTextBox();
            this.CertificateTitle = new Guna.UI.WinForms.GunaTextBox();
            this.Close = new Guna.UI.WinForms.GunaButton();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CertificationsGridView)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // CertificationsGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CertificationsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CertificationsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CertificationsGridView.BackgroundColor = System.Drawing.Color.White;
            this.CertificationsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CertificationsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CertificationsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CertificationsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CertificationsGridView.ColumnHeadersHeight = 4;
            this.CertificationsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CertificationsGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.CertificationsGridView.EnableHeadersVisualStyles = false;
            this.CertificationsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CertificationsGridView.Location = new System.Drawing.Point(22, 107);
            this.CertificationsGridView.MultiSelect = false;
            this.CertificationsGridView.Name = "CertificationsGridView";
            this.CertificationsGridView.ReadOnly = true;
            this.CertificationsGridView.RowHeadersVisible = false;
            this.CertificationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CertificationsGridView.Size = new System.Drawing.Size(749, 321);
            this.CertificationsGridView.TabIndex = 1;
            this.CertificationsGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CertificationsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CertificationsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CertificationsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CertificationsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CertificationsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CertificationsGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CertificationsGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CertificationsGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CertificationsGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CertificationsGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CertificationsGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CertificationsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CertificationsGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.CertificationsGridView.ThemeStyle.ReadOnly = true;
            this.CertificationsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CertificationsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CertificationsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CertificationsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CertificationsGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CertificationsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CertificationsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CertificationsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CertificationsGridView_CellContentClick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 29F);
            this.gunaLabel1.Location = new System.Drawing.Point(241, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(246, 52);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Certifications";
            // 
            // Addnew
            // 
            this.Addnew.AnimationHoverSpeed = 0.07F;
            this.Addnew.AnimationSpeed = 0.03F;
            this.Addnew.BaseColor = System.Drawing.Color.SeaGreen;
            this.Addnew.BorderColor = System.Drawing.Color.Black;
            this.Addnew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Addnew.FocusedColor = System.Drawing.Color.Empty;
            this.Addnew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Addnew.ForeColor = System.Drawing.Color.White;
            this.Addnew.Image = null;
            this.Addnew.ImageSize = new System.Drawing.Size(20, 20);
            this.Addnew.Location = new System.Drawing.Point(640, 65);
            this.Addnew.Name = "Addnew";
            this.Addnew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Addnew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Addnew.OnHoverForeColor = System.Drawing.Color.White;
            this.Addnew.OnHoverImage = null;
            this.Addnew.OnPressedColor = System.Drawing.Color.Black;
            this.Addnew.Size = new System.Drawing.Size(95, 36);
            this.Addnew.TabIndex = 3;
            this.Addnew.Text = "Add new";
            this.Addnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Addnew.Click += new System.EventHandler(this.Addnew_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelAdd.Controls.Add(this.save);
            this.PanelAdd.Controls.Add(this.CreateDate);
            this.PanelAdd.Controls.Add(this.gunaLabel4);
            this.PanelAdd.Controls.Add(this.gunaLabel3);
            this.PanelAdd.Controls.Add(this.gunaLabel2);
            this.PanelAdd.Controls.Add(this.Notes);
            this.PanelAdd.Controls.Add(this.CertificateTitle);
            this.PanelAdd.Location = new System.Drawing.Point(22, 107);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(704, 331);
            this.PanelAdd.TabIndex = 4;
            this.PanelAdd.Visible = false;
            // 
            // save
            // 
            this.save.AnimationHoverSpeed = 0.07F;
            this.save.AnimationSpeed = 0.03F;
            this.save.BaseColor = System.Drawing.Color.SeaGreen;
            this.save.BorderColor = System.Drawing.Color.Black;
            this.save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.save.FocusedColor = System.Drawing.Color.Empty;
            this.save.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Image = null;
            this.save.ImageSize = new System.Drawing.Size(20, 20);
            this.save.Location = new System.Drawing.Point(241, 274);
            this.save.Name = "save";
            this.save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.save.OnHoverForeColor = System.Drawing.Color.White;
            this.save.OnHoverImage = null;
            this.save.OnPressedColor = System.Drawing.Color.Black;
            this.save.Size = new System.Drawing.Size(229, 36);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // CreateDate
            // 
            this.CreateDate.BaseColor = System.Drawing.Color.White;
            this.CreateDate.BorderColor = System.Drawing.Color.Silver;
            this.CreateDate.CustomFormat = null;
            this.CreateDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.CreateDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CreateDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CreateDate.ForeColor = System.Drawing.Color.Black;
            this.CreateDate.Location = new System.Drawing.Point(110, 196);
            this.CreateDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CreateDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.CreateDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CreateDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CreateDate.OnPressedColor = System.Drawing.Color.Black;
            this.CreateDate.Size = new System.Drawing.Size(234, 45);
            this.CreateDate.TabIndex = 6;
            this.CreateDate.Text = "Thursday, April 08, 2021";
            this.CreateDate.Value = new System.DateTime(2021, 4, 8, 11, 15, 39, 144);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel4.Location = new System.Drawing.Point(138, 154);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(114, 28);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Create Date";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.Location = new System.Drawing.Point(469, 154);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 28);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Notes";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel2.Location = new System.Drawing.Point(274, 30);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(142, 28);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Certificate Title";
            // 
            // Notes
            // 
            this.Notes.BaseColor = System.Drawing.Color.White;
            this.Notes.BorderColor = System.Drawing.Color.Silver;
            this.Notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Notes.FocusedBaseColor = System.Drawing.Color.White;
            this.Notes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Notes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Notes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Notes.Location = new System.Drawing.Point(370, 196);
            this.Notes.Name = "Notes";
            this.Notes.PasswordChar = '\0';
            this.Notes.Size = new System.Drawing.Size(272, 45);
            this.Notes.TabIndex = 1;
            // 
            // CertificateTitle
            // 
            this.CertificateTitle.BaseColor = System.Drawing.Color.White;
            this.CertificateTitle.BorderColor = System.Drawing.Color.Silver;
            this.CertificateTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CertificateTitle.FocusedBaseColor = System.Drawing.Color.White;
            this.CertificateTitle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CertificateTitle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.CertificateTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CertificateTitle.Location = new System.Drawing.Point(110, 88);
            this.CertificateTitle.Name = "CertificateTitle";
            this.CertificateTitle.PasswordChar = '\0';
            this.CertificateTitle.Size = new System.Drawing.Size(532, 45);
            this.CertificateTitle.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.AnimationHoverSpeed = 0.07F;
            this.Close.AnimationSpeed = 0.03F;
            this.Close.BaseColor = System.Drawing.Color.Transparent;
            this.Close.BorderColor = System.Drawing.Color.Black;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Close.FocusedColor = System.Drawing.Color.Empty;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Image = null;
            this.Close.ImageSize = new System.Drawing.Size(20, 20);
            this.Close.Location = new System.Drawing.Point(761, -2);
            this.Close.Name = "Close";
            this.Close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close.OnHoverForeColor = System.Drawing.Color.Maroon;
            this.Close.OnHoverImage = null;
            this.Close.OnPressedColor = System.Drawing.Color.Black;
            this.Close.Size = new System.Drawing.Size(42, 33);
            this.Close.TabIndex = 5;
            this.Close.Text = "X";
            this.Close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.Addnew);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.CertificationsGridView);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CertificationsGridView)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView CertificationsGridView;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton Addnew;
        private Guna.UI.WinForms.GunaPanel PanelAdd;
        private Guna.UI.WinForms.GunaTextBox Notes;
        private Guna.UI.WinForms.GunaTextBox CertificateTitle;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDateTimePicker CreateDate;
        private Guna.UI.WinForms.GunaButton save;
        private Guna.UI.WinForms.GunaButton Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
    }
}