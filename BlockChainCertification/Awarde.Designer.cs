
namespace BlockChainCertification
{
    partial class Awarde
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Close = new Guna.UI.WinForms.GunaButton();
            this.PanelAdd = new Guna.UI.WinForms.GunaPanel();
            this.save = new Guna.UI.WinForms.GunaButton();
            this.TransactionDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.Notes = new Guna.UI.WinForms.GunaTextBox();
            this.Addnew = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.CertificationsGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.provider = new Guna.UI.WinForms.GunaTextBox();
            this.Moyen = new Guna.UI.WinForms.GunaTextBox();
            this.Recipient = new Guna.UI.WinForms.GunaTextBox();
            this.CrtificateNumber = new Guna.UI.WinForms.GunaTextBox();
            this.PanelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CertificationsGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Close.Location = new System.Drawing.Point(756, 1);
            this.Close.Name = "Close";
            this.Close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Close.OnHoverForeColor = System.Drawing.Color.Maroon;
            this.Close.OnHoverImage = null;
            this.Close.OnPressedColor = System.Drawing.Color.Black;
            this.Close.Size = new System.Drawing.Size(42, 33);
            this.Close.TabIndex = 10;
            this.Close.Text = "X";
            this.Close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelAdd.Controls.Add(this.CrtificateNumber);
            this.PanelAdd.Controls.Add(this.Recipient);
            this.PanelAdd.Controls.Add(this.Moyen);
            this.PanelAdd.Controls.Add(this.provider);
            this.PanelAdd.Controls.Add(this.gunaLabel7);
            this.PanelAdd.Controls.Add(this.gunaLabel6);
            this.PanelAdd.Controls.Add(this.gunaLabel5);
            this.PanelAdd.Controls.Add(this.save);
            this.PanelAdd.Controls.Add(this.TransactionDate);
            this.PanelAdd.Controls.Add(this.gunaLabel4);
            this.PanelAdd.Controls.Add(this.gunaLabel3);
            this.PanelAdd.Controls.Add(this.gunaLabel2);
            this.PanelAdd.Controls.Add(this.Notes);
            this.PanelAdd.Location = new System.Drawing.Point(17, 110);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(766, 331);
            this.PanelAdd.TabIndex = 9;
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
            this.save.Location = new System.Drawing.Point(251, 285);
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
            // TransactionDate
            // 
            this.TransactionDate.BaseColor = System.Drawing.Color.White;
            this.TransactionDate.BorderColor = System.Drawing.Color.Silver;
            this.TransactionDate.CustomFormat = null;
            this.TransactionDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TransactionDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TransactionDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TransactionDate.ForeColor = System.Drawing.Color.Black;
            this.TransactionDate.Location = new System.Drawing.Point(207, 214);
            this.TransactionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TransactionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.TransactionDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TransactionDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TransactionDate.OnPressedColor = System.Drawing.Color.Black;
            this.TransactionDate.Size = new System.Drawing.Size(234, 45);
            this.TransactionDate.TabIndex = 6;
            this.TransactionDate.Text = "Thursday, April 08, 2021";
            this.TransactionDate.Value = new System.DateTime(2021, 4, 8, 11, 15, 39, 144);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel4.Location = new System.Drawing.Point(243, 172);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(156, 28);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Transaction Date";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.Location = new System.Drawing.Point(567, 174);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 28);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Notes";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel2.Location = new System.Drawing.Point(50, 80);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(92, 28);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Recipient";
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
            this.Notes.Location = new System.Drawing.Point(465, 214);
            this.Notes.Name = "Notes";
            this.Notes.PasswordChar = '\0';
            this.Notes.Size = new System.Drawing.Size(272, 45);
            this.Notes.TabIndex = 1;
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
            this.Addnew.Location = new System.Drawing.Point(635, 68);
            this.Addnew.Name = "Addnew";
            this.Addnew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Addnew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Addnew.OnHoverForeColor = System.Drawing.Color.White;
            this.Addnew.OnHoverImage = null;
            this.Addnew.OnPressedColor = System.Drawing.Color.Black;
            this.Addnew.Size = new System.Drawing.Size(95, 36);
            this.Addnew.TabIndex = 8;
            this.Addnew.Text = "Add new";
            this.Addnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Addnew.Click += new System.EventHandler(this.Addnew_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 29F);
            this.gunaLabel1.Location = new System.Drawing.Point(236, 32);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(246, 52);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Certifications";
            // 
            // CertificationsGridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.CertificationsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.CertificationsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CertificationsGridView.BackgroundColor = System.Drawing.Color.White;
            this.CertificationsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CertificationsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CertificationsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CertificationsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.CertificationsGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CertificationsGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.CertificationsGridView.EnableHeadersVisualStyles = false;
            this.CertificationsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CertificationsGridView.Location = new System.Drawing.Point(17, 110);
            this.CertificationsGridView.Name = "CertificationsGridView";
            this.CertificationsGridView.RowHeadersVisible = false;
            this.CertificationsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CertificationsGridView.Size = new System.Drawing.Size(749, 321);
            this.CertificationsGridView.TabIndex = 6;
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
            this.CertificationsGridView.ThemeStyle.ReadOnly = false;
            this.CertificationsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CertificationsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CertificationsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CertificationsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CertificationsGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CertificationsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CertificationsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel5.Location = new System.Drawing.Point(50, 126);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(86, 28);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Provider";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel6.Location = new System.Drawing.Point(27, 30);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(167, 28);
            this.gunaLabel6.TabIndex = 9;
            this.gunaLabel6.Text = "Crtificate Number";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel7.Location = new System.Drawing.Point(50, 172);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(73, 28);
            this.gunaLabel7.TabIndex = 10;
            this.gunaLabel7.Text = "Moyen";
            // 
            // provider
            // 
            this.provider.BaseColor = System.Drawing.Color.White;
            this.provider.BorderColor = System.Drawing.Color.Silver;
            this.provider.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.provider.FocusedBaseColor = System.Drawing.Color.White;
            this.provider.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.provider.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.provider.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.provider.Location = new System.Drawing.Point(200, 126);
            this.provider.Name = "provider";
            this.provider.PasswordChar = '\0';
            this.provider.Size = new System.Drawing.Size(537, 36);
            this.provider.TabIndex = 12;
            // 
            // Moyen
            // 
            this.Moyen.BaseColor = System.Drawing.Color.White;
            this.Moyen.BorderColor = System.Drawing.Color.Silver;
            this.Moyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Moyen.FocusedBaseColor = System.Drawing.Color.White;
            this.Moyen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Moyen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Moyen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Moyen.Location = new System.Drawing.Point(35, 214);
            this.Moyen.Name = "Moyen";
            this.Moyen.PasswordChar = '\0';
            this.Moyen.Size = new System.Drawing.Size(136, 45);
            this.Moyen.TabIndex = 13;
            // 
            // Recipient
            // 
            this.Recipient.BaseColor = System.Drawing.Color.White;
            this.Recipient.BorderColor = System.Drawing.Color.Silver;
            this.Recipient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Recipient.FocusedBaseColor = System.Drawing.Color.White;
            this.Recipient.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Recipient.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Recipient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Recipient.Location = new System.Drawing.Point(200, 82);
            this.Recipient.Name = "Recipient";
            this.Recipient.PasswordChar = '\0';
            this.Recipient.Size = new System.Drawing.Size(537, 36);
            this.Recipient.TabIndex = 14;
            // 
            // CrtificateNumber
            // 
            this.CrtificateNumber.BaseColor = System.Drawing.Color.White;
            this.CrtificateNumber.BorderColor = System.Drawing.Color.Silver;
            this.CrtificateNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CrtificateNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.CrtificateNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CrtificateNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.CrtificateNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CrtificateNumber.Location = new System.Drawing.Point(200, 22);
            this.CrtificateNumber.Name = "CrtificateNumber";
            this.CrtificateNumber.PasswordChar = '\0';
            this.CrtificateNumber.Size = new System.Drawing.Size(537, 36);
            this.CrtificateNumber.TabIndex = 15;
            // 
            // Awarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.Addnew);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.CertificationsGridView);
            this.Name = "Awarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Awarde_Load);
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CertificationsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton Close;
        private Guna.UI.WinForms.GunaPanel PanelAdd;
        private Guna.UI.WinForms.GunaButton save;
        private Guna.UI.WinForms.GunaDateTimePicker TransactionDate;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox Notes;
        private Guna.UI.WinForms.GunaButton Addnew;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView CertificationsGridView;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox CrtificateNumber;
        private Guna.UI.WinForms.GunaTextBox Recipient;
        private Guna.UI.WinForms.GunaTextBox Moyen;
        private Guna.UI.WinForms.GunaTextBox provider;
    }
}