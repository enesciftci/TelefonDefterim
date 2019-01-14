namespace TelefonDefteri
{
    partial class AdminUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddPersonel = new MetroFramework.Controls.MetroButton();
            this.cmbPersonelManager = new MetroFramework.Controls.MetroComboBox();
            this.cmbDepartment = new MetroFramework.Controls.MetroComboBox();
            this.txtTelNumberInput = new MetroFramework.Controls.MetroTextBox();
            this.txtSurnameInput = new MetroFramework.Controls.MetroTextBox();
            this.txtNameInput = new MetroFramework.Controls.MetroTextBox();
            this.txtAdminInfo = new System.Windows.Forms.TextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.TabEmployeesEvents = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnPersonelChange = new MetroFramework.Controls.MetroButton();
            this.txtPersonelTel = new MetroFramework.Controls.MetroTextBox();
            this.txtPersonelSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtPersonelName = new MetroFramework.Controls.MetroTextBox();
            this.cmbPersonelStatus = new MetroFramework.Controls.MetroComboBox();
            this.cmbPersonelPosition = new MetroFramework.Controls.MetroComboBox();
            this.cmbEmployeesEventsChoose = new MetroFramework.Controls.MetroComboBox();
            this.dgwEmployeess = new MetroFramework.Controls.MetroGrid();
            this.TabAddPersonel = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TabDepartmentEvents = new MetroFramework.Controls.MetroTabPage();
            this.btnDepartmentChooser = new MetroFramework.Controls.MetroButton();
            this.txtDepartmentChooser = new MetroFramework.Controls.MetroTextBox();
            this.txtPreview = new MetroFramework.Controls.MetroTextBox();
            this.cmbDepartmanEventsChoose = new MetroFramework.Controls.MetroComboBox();
            this.dgwDepartmentSettings = new MetroFramework.Controls.MetroGrid();
            this.lblChangePass = new MetroFramework.Controls.MetroLink();
            this.metroTabControl1.SuspendLayout();
            this.TabEmployeesEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployeess)).BeginInit();
            this.TabAddPersonel.SuspendLayout();
            this.TabDepartmentEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartmentSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPersonel
            // 
            this.btnAddPersonel.Location = new System.Drawing.Point(151, 227);
            this.btnAddPersonel.Name = "btnAddPersonel";
            this.btnAddPersonel.Size = new System.Drawing.Size(121, 32);
            this.btnAddPersonel.TabIndex = 20;
            this.btnAddPersonel.Text = "Personel Ekle";
            this.btnAddPersonel.UseSelectable = true;
            this.btnAddPersonel.Click += new System.EventHandler(this.btnAddPersonel_Click);
            // 
            // cmbPersonelManager
            // 
            this.cmbPersonelManager.FormattingEnabled = true;
            this.cmbPersonelManager.ItemHeight = 24;
            this.cmbPersonelManager.Location = new System.Drawing.Point(151, 181);
            this.cmbPersonelManager.Name = "cmbPersonelManager";
            this.cmbPersonelManager.Size = new System.Drawing.Size(121, 30);
            this.cmbPersonelManager.TabIndex = 19;
            this.cmbPersonelManager.UseSelectable = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.ItemHeight = 24;
            this.cmbDepartment.Location = new System.Drawing.Point(151, 133);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 30);
            this.cmbDepartment.TabIndex = 18;
            this.cmbDepartment.UseSelectable = true;
            // 
            // txtTelNumberInput
            // 
            // 
            // 
            // 
            this.txtTelNumberInput.CustomButton.Image = null;
            this.txtTelNumberInput.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtTelNumberInput.CustomButton.Name = "";
            this.txtTelNumberInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelNumberInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelNumberInput.CustomButton.TabIndex = 1;
            this.txtTelNumberInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelNumberInput.CustomButton.UseSelectable = true;
            this.txtTelNumberInput.CustomButton.Visible = false;
            this.txtTelNumberInput.Lines = new string[0];
            this.txtTelNumberInput.Location = new System.Drawing.Point(151, 95);
            this.txtTelNumberInput.MaxLength = 32767;
            this.txtTelNumberInput.Name = "txtTelNumberInput";
            this.txtTelNumberInput.PasswordChar = '\0';
            this.txtTelNumberInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelNumberInput.SelectedText = "";
            this.txtTelNumberInput.SelectionLength = 0;
            this.txtTelNumberInput.SelectionStart = 0;
            this.txtTelNumberInput.ShortcutsEnabled = true;
            this.txtTelNumberInput.Size = new System.Drawing.Size(121, 23);
            this.txtTelNumberInput.TabIndex = 17;
            this.txtTelNumberInput.UseSelectable = true;
            this.txtTelNumberInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelNumberInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSurnameInput
            // 
            // 
            // 
            // 
            this.txtSurnameInput.CustomButton.Image = null;
            this.txtSurnameInput.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtSurnameInput.CustomButton.Name = "";
            this.txtSurnameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurnameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurnameInput.CustomButton.TabIndex = 1;
            this.txtSurnameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurnameInput.CustomButton.UseSelectable = true;
            this.txtSurnameInput.CustomButton.Visible = false;
            this.txtSurnameInput.Lines = new string[0];
            this.txtSurnameInput.Location = new System.Drawing.Point(151, 59);
            this.txtSurnameInput.MaxLength = 32767;
            this.txtSurnameInput.Name = "txtSurnameInput";
            this.txtSurnameInput.PasswordChar = '\0';
            this.txtSurnameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurnameInput.SelectedText = "";
            this.txtSurnameInput.SelectionLength = 0;
            this.txtSurnameInput.SelectionStart = 0;
            this.txtSurnameInput.ShortcutsEnabled = true;
            this.txtSurnameInput.Size = new System.Drawing.Size(121, 23);
            this.txtSurnameInput.TabIndex = 16;
            this.txtSurnameInput.UseSelectable = true;
            this.txtSurnameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurnameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameInput
            // 
            // 
            // 
            // 
            this.txtNameInput.CustomButton.Image = null;
            this.txtNameInput.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtNameInput.CustomButton.Name = "";
            this.txtNameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameInput.CustomButton.TabIndex = 1;
            this.txtNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameInput.CustomButton.UseSelectable = true;
            this.txtNameInput.CustomButton.Visible = false;
            this.txtNameInput.Lines = new string[0];
            this.txtNameInput.Location = new System.Drawing.Point(151, 20);
            this.txtNameInput.MaxLength = 32767;
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.PasswordChar = '\0';
            this.txtNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameInput.SelectedText = "";
            this.txtNameInput.SelectionLength = 0;
            this.txtNameInput.SelectionStart = 0;
            this.txtNameInput.ShortcutsEnabled = true;
            this.txtNameInput.Size = new System.Drawing.Size(121, 23);
            this.txtNameInput.TabIndex = 15;
            this.txtNameInput.UseSelectable = true;
            this.txtNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdminInfo
            // 
            this.txtAdminInfo.Location = new System.Drawing.Point(1202, 466);
            this.txtAdminInfo.Name = "txtAdminInfo";
            this.txtAdminInfo.ReadOnly = true;
            this.txtAdminInfo.Size = new System.Drawing.Size(169, 22);
            this.txtAdminInfo.TabIndex = 5;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.TabEmployeesEvents);
            this.metroTabControl1.Controls.Add(this.TabAddPersonel);
            this.metroTabControl1.Controls.Add(this.TabDepartmentEvents);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1352, 433);
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // TabEmployeesEvents
            // 
            this.TabEmployeesEvents.Controls.Add(this.metroLabel11);
            this.TabEmployeesEvents.Controls.Add(this.metroLabel6);
            this.TabEmployeesEvents.Controls.Add(this.metroLabel7);
            this.TabEmployeesEvents.Controls.Add(this.metroLabel8);
            this.TabEmployeesEvents.Controls.Add(this.metroLabel9);
            this.TabEmployeesEvents.Controls.Add(this.metroLabel10);
            this.TabEmployeesEvents.Controls.Add(this.btnPersonelChange);
            this.TabEmployeesEvents.Controls.Add(this.txtPersonelTel);
            this.TabEmployeesEvents.Controls.Add(this.txtPersonelSurname);
            this.TabEmployeesEvents.Controls.Add(this.txtPersonelName);
            this.TabEmployeesEvents.Controls.Add(this.cmbPersonelStatus);
            this.TabEmployeesEvents.Controls.Add(this.cmbPersonelPosition);
            this.TabEmployeesEvents.Controls.Add(this.cmbEmployeesEventsChoose);
            this.TabEmployeesEvents.Controls.Add(this.dgwEmployeess);
            this.TabEmployeesEvents.HorizontalScrollbarBarColor = true;
            this.TabEmployeesEvents.HorizontalScrollbarHighlightOnWheel = false;
            this.TabEmployeesEvents.HorizontalScrollbarSize = 10;
            this.TabEmployeesEvents.Location = new System.Drawing.Point(4, 38);
            this.TabEmployeesEvents.Name = "TabEmployeesEvents";
            this.TabEmployeesEvents.Size = new System.Drawing.Size(1299, 391);
            this.TabEmployeesEvents.TabIndex = 0;
            this.TabEmployeesEvents.Text = "Çalışan İşlemleri";
            this.TabEmployeesEvents.VerticalScrollbarBarColor = true;
            this.TabEmployeesEvents.VerticalScrollbarHighlightOnWheel = false;
            this.TabEmployeesEvents.VerticalScrollbarSize = 10;
            this.TabEmployeesEvents.Click += new System.EventHandler(this.TabEmployeesEvents_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(600, 24);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(95, 20);
            this.metroLabel11.TabIndex = 34;
            this.metroLabel11.Text = "İşlem Türü     :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(601, 255);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 20);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Yönetici        :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(601, 196);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 20);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Departman   :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(601, 148);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 20);
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "Telefon         :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(601, 106);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 20);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Soyad           :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(601, 64);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(93, 20);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Ad                :";
            // 
            // btnPersonelChange
            // 
            this.btnPersonelChange.Location = new System.Drawing.Point(730, 282);
            this.btnPersonelChange.Name = "btnPersonelChange";
            this.btnPersonelChange.Size = new System.Drawing.Size(121, 34);
            this.btnPersonelChange.TabIndex = 28;
            this.btnPersonelChange.Text = "Giriş";
            this.btnPersonelChange.UseSelectable = true;
            this.btnPersonelChange.Click += new System.EventHandler(this.btnPersonelChange_Click);
            // 
            // txtPersonelTel
            // 
            // 
            // 
            // 
            this.txtPersonelTel.CustomButton.Image = null;
            this.txtPersonelTel.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtPersonelTel.CustomButton.Name = "";
            this.txtPersonelTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPersonelTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonelTel.CustomButton.TabIndex = 1;
            this.txtPersonelTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonelTel.CustomButton.UseSelectable = true;
            this.txtPersonelTel.CustomButton.Visible = false;
            this.txtPersonelTel.Lines = new string[0];
            this.txtPersonelTel.Location = new System.Drawing.Point(730, 145);
            this.txtPersonelTel.MaxLength = 32767;
            this.txtPersonelTel.Name = "txtPersonelTel";
            this.txtPersonelTel.PasswordChar = '\0';
            this.txtPersonelTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonelTel.SelectedText = "";
            this.txtPersonelTel.SelectionLength = 0;
            this.txtPersonelTel.SelectionStart = 0;
            this.txtPersonelTel.ShortcutsEnabled = true;
            this.txtPersonelTel.Size = new System.Drawing.Size(121, 23);
            this.txtPersonelTel.TabIndex = 27;
            this.txtPersonelTel.UseSelectable = true;
            this.txtPersonelTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonelTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPersonelSurname
            // 
            // 
            // 
            // 
            this.txtPersonelSurname.CustomButton.Image = null;
            this.txtPersonelSurname.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtPersonelSurname.CustomButton.Name = "";
            this.txtPersonelSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPersonelSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonelSurname.CustomButton.TabIndex = 1;
            this.txtPersonelSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonelSurname.CustomButton.UseSelectable = true;
            this.txtPersonelSurname.CustomButton.Visible = false;
            this.txtPersonelSurname.Lines = new string[0];
            this.txtPersonelSurname.Location = new System.Drawing.Point(730, 103);
            this.txtPersonelSurname.MaxLength = 32767;
            this.txtPersonelSurname.Name = "txtPersonelSurname";
            this.txtPersonelSurname.PasswordChar = '\0';
            this.txtPersonelSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonelSurname.SelectedText = "";
            this.txtPersonelSurname.SelectionLength = 0;
            this.txtPersonelSurname.SelectionStart = 0;
            this.txtPersonelSurname.ShortcutsEnabled = true;
            this.txtPersonelSurname.Size = new System.Drawing.Size(121, 23);
            this.txtPersonelSurname.TabIndex = 26;
            this.txtPersonelSurname.UseSelectable = true;
            this.txtPersonelSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonelSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPersonelName
            // 
            // 
            // 
            // 
            this.txtPersonelName.CustomButton.Image = null;
            this.txtPersonelName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtPersonelName.CustomButton.Name = "";
            this.txtPersonelName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPersonelName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonelName.CustomButton.TabIndex = 1;
            this.txtPersonelName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonelName.CustomButton.UseSelectable = true;
            this.txtPersonelName.CustomButton.Visible = false;
            this.txtPersonelName.Lines = new string[0];
            this.txtPersonelName.Location = new System.Drawing.Point(730, 64);
            this.txtPersonelName.MaxLength = 32767;
            this.txtPersonelName.Name = "txtPersonelName";
            this.txtPersonelName.PasswordChar = '\0';
            this.txtPersonelName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonelName.SelectedText = "";
            this.txtPersonelName.SelectionLength = 0;
            this.txtPersonelName.SelectionStart = 0;
            this.txtPersonelName.ShortcutsEnabled = true;
            this.txtPersonelName.Size = new System.Drawing.Size(121, 23);
            this.txtPersonelName.TabIndex = 25;
            this.txtPersonelName.UseSelectable = true;
            this.txtPersonelName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonelName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbPersonelStatus
            // 
            this.cmbPersonelStatus.FormattingEnabled = true;
            this.cmbPersonelStatus.ItemHeight = 24;
            this.cmbPersonelStatus.Location = new System.Drawing.Point(730, 245);
            this.cmbPersonelStatus.Name = "cmbPersonelStatus";
            this.cmbPersonelStatus.Size = new System.Drawing.Size(121, 30);
            this.cmbPersonelStatus.TabIndex = 24;
            this.cmbPersonelStatus.UseSelectable = true;
            // 
            // cmbPersonelPosition
            // 
            this.cmbPersonelPosition.FormattingEnabled = true;
            this.cmbPersonelPosition.ItemHeight = 24;
            this.cmbPersonelPosition.Location = new System.Drawing.Point(730, 189);
            this.cmbPersonelPosition.Name = "cmbPersonelPosition";
            this.cmbPersonelPosition.Size = new System.Drawing.Size(121, 30);
            this.cmbPersonelPosition.TabIndex = 23;
            this.cmbPersonelPosition.UseSelectable = true;
            // 
            // cmbEmployeesEventsChoose
            // 
            this.cmbEmployeesEventsChoose.FormattingEnabled = true;
            this.cmbEmployeesEventsChoose.ItemHeight = 24;
            this.cmbEmployeesEventsChoose.Items.AddRange(new object[] {
            "İşlem Seçiniz",
            "Güncelleme",
            "Silme"});
            this.cmbEmployeesEventsChoose.Location = new System.Drawing.Point(730, 14);
            this.cmbEmployeesEventsChoose.Name = "cmbEmployeesEventsChoose";
            this.cmbEmployeesEventsChoose.Size = new System.Drawing.Size(121, 30);
            this.cmbEmployeesEventsChoose.TabIndex = 21;
            this.cmbEmployeesEventsChoose.UseSelectable = true;
            this.cmbEmployeesEventsChoose.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeesEventsChoose_SelectedIndexChanged);
            // 
            // dgwEmployeess
            // 
            this.dgwEmployeess.AllowUserToResizeRows = false;
            this.dgwEmployeess.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwEmployeess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwEmployeess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwEmployeess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwEmployeess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgwEmployeess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwEmployeess.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgwEmployeess.EnableHeadersVisualStyles = false;
            this.dgwEmployeess.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgwEmployeess.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwEmployeess.Location = new System.Drawing.Point(3, 16);
            this.dgwEmployeess.MultiSelect = false;
            this.dgwEmployeess.Name = "dgwEmployeess";
            this.dgwEmployeess.ReadOnly = true;
            this.dgwEmployeess.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwEmployeess.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgwEmployeess.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwEmployeess.RowTemplate.Height = 24;
            this.dgwEmployeess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEmployeess.Size = new System.Drawing.Size(592, 276);
            this.dgwEmployeess.TabIndex = 20;
            this.dgwEmployeess.Click += new System.EventHandler(this.dgwEmployeess_Click);
            // 
            // TabAddPersonel
            // 
            this.TabAddPersonel.Controls.Add(this.metroLabel5);
            this.TabAddPersonel.Controls.Add(this.metroLabel4);
            this.TabAddPersonel.Controls.Add(this.metroLabel3);
            this.TabAddPersonel.Controls.Add(this.metroLabel2);
            this.TabAddPersonel.Controls.Add(this.metroLabel1);
            this.TabAddPersonel.Controls.Add(this.btnAddPersonel);
            this.TabAddPersonel.Controls.Add(this.cmbPersonelManager);
            this.TabAddPersonel.Controls.Add(this.cmbDepartment);
            this.TabAddPersonel.Controls.Add(this.txtNameInput);
            this.TabAddPersonel.Controls.Add(this.txtTelNumberInput);
            this.TabAddPersonel.Controls.Add(this.txtSurnameInput);
            this.TabAddPersonel.HorizontalScrollbarBarColor = true;
            this.TabAddPersonel.HorizontalScrollbarHighlightOnWheel = false;
            this.TabAddPersonel.HorizontalScrollbarSize = 10;
            this.TabAddPersonel.Location = new System.Drawing.Point(4, 38);
            this.TabAddPersonel.Name = "TabAddPersonel";
            this.TabAddPersonel.Size = new System.Drawing.Size(1299, 391);
            this.TabAddPersonel.TabIndex = 1;
            this.TabAddPersonel.Text = "Personel Ekle";
            this.TabAddPersonel.VerticalScrollbarBarColor = true;
            this.TabAddPersonel.VerticalScrollbarHighlightOnWheel = false;
            this.TabAddPersonel.VerticalScrollbarSize = 10;
            this.TabAddPersonel.Click += new System.EventHandler(this.TabAddPersonel_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 191);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 20);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Yönetici        :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 143);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 20);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Departman   :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 20);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Telefon         :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 20);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Soyad           :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 20);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Ad                :";
            // 
            // TabDepartmentEvents
            // 
            this.TabDepartmentEvents.Controls.Add(this.btnDepartmentChooser);
            this.TabDepartmentEvents.Controls.Add(this.txtDepartmentChooser);
            this.TabDepartmentEvents.Controls.Add(this.txtPreview);
            this.TabDepartmentEvents.Controls.Add(this.cmbDepartmanEventsChoose);
            this.TabDepartmentEvents.Controls.Add(this.dgwDepartmentSettings);
            this.TabDepartmentEvents.HorizontalScrollbarBarColor = true;
            this.TabDepartmentEvents.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDepartmentEvents.HorizontalScrollbarSize = 10;
            this.TabDepartmentEvents.Location = new System.Drawing.Point(4, 38);
            this.TabDepartmentEvents.Name = "TabDepartmentEvents";
            this.TabDepartmentEvents.Size = new System.Drawing.Size(1344, 391);
            this.TabDepartmentEvents.TabIndex = 2;
            this.TabDepartmentEvents.Text = "Departman İşlemleri";
            this.TabDepartmentEvents.VerticalScrollbarBarColor = true;
            this.TabDepartmentEvents.VerticalScrollbarHighlightOnWheel = false;
            this.TabDepartmentEvents.VerticalScrollbarSize = 10;
            this.TabDepartmentEvents.Click += new System.EventHandler(this.TabDepartmentEvents_Click);
            // 
            // btnDepartmentChooser
            // 
            this.btnDepartmentChooser.Location = new System.Drawing.Point(497, 179);
            this.btnDepartmentChooser.Name = "btnDepartmentChooser";
            this.btnDepartmentChooser.Size = new System.Drawing.Size(121, 70);
            this.btnDepartmentChooser.TabIndex = 15;
            this.btnDepartmentChooser.Text = "Departman";
            this.btnDepartmentChooser.UseSelectable = true;
            this.btnDepartmentChooser.Click += new System.EventHandler(this.btnDepartmentChooser_Click);
            // 
            // txtDepartmentChooser
            // 
            // 
            // 
            // 
            this.txtDepartmentChooser.CustomButton.Image = null;
            this.txtDepartmentChooser.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtDepartmentChooser.CustomButton.Name = "";
            this.txtDepartmentChooser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDepartmentChooser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepartmentChooser.CustomButton.TabIndex = 1;
            this.txtDepartmentChooser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepartmentChooser.CustomButton.UseSelectable = true;
            this.txtDepartmentChooser.CustomButton.Visible = false;
            this.txtDepartmentChooser.Lines = new string[0];
            this.txtDepartmentChooser.Location = new System.Drawing.Point(497, 127);
            this.txtDepartmentChooser.MaxLength = 32767;
            this.txtDepartmentChooser.Name = "txtDepartmentChooser";
            this.txtDepartmentChooser.PasswordChar = '\0';
            this.txtDepartmentChooser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepartmentChooser.SelectedText = "";
            this.txtDepartmentChooser.SelectionLength = 0;
            this.txtDepartmentChooser.SelectionStart = 0;
            this.txtDepartmentChooser.ShortcutsEnabled = true;
            this.txtDepartmentChooser.Size = new System.Drawing.Size(121, 23);
            this.txtDepartmentChooser.TabIndex = 14;
            this.txtDepartmentChooser.UseSelectable = true;
            this.txtDepartmentChooser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepartmentChooser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPreview
            // 
            // 
            // 
            // 
            this.txtPreview.CustomButton.Image = null;
            this.txtPreview.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtPreview.CustomButton.Name = "";
            this.txtPreview.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreview.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPreview.CustomButton.TabIndex = 1;
            this.txtPreview.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreview.CustomButton.UseSelectable = true;
            this.txtPreview.CustomButton.Visible = false;
            this.txtPreview.Lines = new string[0];
            this.txtPreview.Location = new System.Drawing.Point(497, 87);
            this.txtPreview.MaxLength = 32767;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.PasswordChar = '\0';
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreview.SelectedText = "";
            this.txtPreview.SelectionLength = 0;
            this.txtPreview.SelectionStart = 0;
            this.txtPreview.ShortcutsEnabled = true;
            this.txtPreview.Size = new System.Drawing.Size(121, 23);
            this.txtPreview.TabIndex = 13;
            this.txtPreview.UseSelectable = true;
            this.txtPreview.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreview.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbDepartmanEventsChoose
            // 
            this.cmbDepartmanEventsChoose.FormattingEnabled = true;
            this.cmbDepartmanEventsChoose.ItemHeight = 24;
            this.cmbDepartmanEventsChoose.Items.AddRange(new object[] {
            "İşlem Seçin",
            "Güncelleme",
            "Ekleme",
            "Silme"});
            this.cmbDepartmanEventsChoose.Location = new System.Drawing.Point(497, 28);
            this.cmbDepartmanEventsChoose.Name = "cmbDepartmanEventsChoose";
            this.cmbDepartmanEventsChoose.Size = new System.Drawing.Size(121, 30);
            this.cmbDepartmanEventsChoose.TabIndex = 12;
            this.cmbDepartmanEventsChoose.UseSelectable = true;
            this.cmbDepartmanEventsChoose.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanEventsChoose_SelectedIndexChanged);
            // 
            // dgwDepartmentSettings
            // 
            this.dgwDepartmentSettings.AllowUserToResizeRows = false;
            this.dgwDepartmentSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwDepartmentSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwDepartmentSettings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwDepartmentSettings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwDepartmentSettings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgwDepartmentSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDepartmentSettings.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgwDepartmentSettings.EnableHeadersVisualStyles = false;
            this.dgwDepartmentSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgwDepartmentSettings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgwDepartmentSettings.Location = new System.Drawing.Point(4, 14);
            this.dgwDepartmentSettings.MultiSelect = false;
            this.dgwDepartmentSettings.Name = "dgwDepartmentSettings";
            this.dgwDepartmentSettings.ReadOnly = true;
            this.dgwDepartmentSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwDepartmentSettings.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgwDepartmentSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwDepartmentSettings.RowTemplate.Height = 24;
            this.dgwDepartmentSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDepartmentSettings.Size = new System.Drawing.Size(378, 247);
            this.dgwDepartmentSettings.TabIndex = 11;
            this.dgwDepartmentSettings.Click += new System.EventHandler(this.dgwDepartmentSettings_Click);
            // 
            // lblChangePass
            // 
            this.lblChangePass.Location = new System.Drawing.Point(995, 466);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(201, 23);
            this.lblChangePass.TabIndex = 18;
            this.lblChangePass.Text = "Şifre Değiştir";
            this.lblChangePass.UseSelectable = true;
            this.lblChangePass.Click += new System.EventHandler(this.lblChangePass_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 532);
            this.Controls.Add(this.lblChangePass);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.txtAdminInfo);
            this.Name = "AdminUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUI_FormClosing);
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.TabEmployeesEvents.ResumeLayout(false);
            this.TabEmployeesEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployeess)).EndInit();
            this.TabAddPersonel.ResumeLayout(false);
            this.TabAddPersonel.PerformLayout();
            this.TabDepartmentEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartmentSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAdminInfo;
        private MetroFramework.Controls.MetroComboBox cmbPersonelManager;
        private MetroFramework.Controls.MetroComboBox cmbDepartment;
        private MetroFramework.Controls.MetroTextBox txtTelNumberInput;
        private MetroFramework.Controls.MetroTextBox txtSurnameInput;
        private MetroFramework.Controls.MetroTextBox txtNameInput;
        private MetroFramework.Controls.MetroButton btnAddPersonel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage TabEmployeesEvents;
        private MetroFramework.Controls.MetroTabPage TabAddPersonel;
        private MetroFramework.Controls.MetroTabPage TabDepartmentEvents;
        private MetroFramework.Controls.MetroGrid dgwEmployeess;
        private MetroFramework.Controls.MetroButton btnPersonelChange;
        private MetroFramework.Controls.MetroTextBox txtPersonelTel;
        private MetroFramework.Controls.MetroTextBox txtPersonelSurname;
        private MetroFramework.Controls.MetroTextBox txtPersonelName;
        private MetroFramework.Controls.MetroComboBox cmbPersonelStatus;
        private MetroFramework.Controls.MetroComboBox cmbPersonelPosition;
        private MetroFramework.Controls.MetroComboBox cmbEmployeesEventsChoose;
        private MetroFramework.Controls.MetroTextBox txtDepartmentChooser;
        private MetroFramework.Controls.MetroTextBox txtPreview;
        private MetroFramework.Controls.MetroComboBox cmbDepartmanEventsChoose;
        private MetroFramework.Controls.MetroGrid dgwDepartmentSettings;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnDepartmentChooser;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLink lblChangePass;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}