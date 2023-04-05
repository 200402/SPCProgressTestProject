namespace SPCProgress
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.birthdayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quickSearchTextBox = new System.Windows.Forms.TextBox();
            this.advancedSearchButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.visitDataGridView = new System.Windows.Forms.DataGridView();
            this.generatePatientButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.generateVisitButton = new System.Windows.Forms.Button();
            this.bigGenerateButton = new System.Windows.Forms.Button();
            this.clearDBButton = new System.Windows.Forms.Button();
            this.newVisitButton = new System.Windows.Forms.Button();
            this.saveChangedButton = new System.Windows.Forms.Button();
            this.uploadToXMLButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(490, 96);
            this.birthdayTextBox.Mask = "00/00/0000";
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.RejectInputOnFirstFailure = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(482, 22);
            this.birthdayTextBox.TabIndex = 36;
            this.birthdayTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(490, 124);
            this.telephoneTextBox.Mask = "+7 (999) 000-00-00";
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(482, 22);
            this.telephoneTextBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(360, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(360, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дата рождения";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(435, 68);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(537, 22);
            this.patronymicTextBox.TabIndex = 32;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(435, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(537, 22);
            this.nameTextBox.TabIndex = 31;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(435, 12);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(537, 22);
            this.surnameTextBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(360, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(360, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Фамилия";
            // 
            // quickSearchTextBox
            // 
            this.quickSearchTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quickSearchTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quickSearchTextBox.Location = new System.Drawing.Point(12, 48);
            this.quickSearchTextBox.Name = "quickSearchTextBox";
            this.quickSearchTextBox.Size = new System.Drawing.Size(332, 27);
            this.quickSearchTextBox.TabIndex = 25;
            this.quickSearchTextBox.Text = "ФИО пациента";
            this.quickSearchTextBox.Enter += new System.EventHandler(this.quickSearchTextBox_Enter);
            this.quickSearchTextBox.Leave += new System.EventHandler(this.quickSearchTextBox_Leave);
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.AutoSize = true;
            this.advancedSearchButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.advancedSearchButton.Location = new System.Drawing.Point(178, 12);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(166, 30);
            this.advancedSearchButton.TabIndex = 24;
            this.advancedSearchButton.Text = "Расширенный поиск";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            // 
            // addPatientButton
            // 
            this.addPatientButton.AutoSize = true;
            this.addPatientButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPatientButton.Location = new System.Drawing.Point(12, 12);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(160, 30);
            this.addPatientButton.TabIndex = 23;
            this.addPatientButton.Text = "Добавить пациента";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AllowUserToOrderColumns = true;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(12, 81);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(332, 468);
            this.patientDataGridView.TabIndex = 22;
            // 
            // visitDataGridView
            // 
            this.visitDataGridView.AllowUserToAddRows = false;
            this.visitDataGridView.AllowUserToDeleteRows = false;
            this.visitDataGridView.AllowUserToOrderColumns = true;
            this.visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGridView.Location = new System.Drawing.Point(360, 185);
            this.visitDataGridView.Name = "visitDataGridView";
            this.visitDataGridView.ReadOnly = true;
            this.visitDataGridView.RowTemplate.Height = 24;
            this.visitDataGridView.Size = new System.Drawing.Size(612, 364);
            this.visitDataGridView.TabIndex = 26;
            // 
            // generatePatientButton
            // 
            this.generatePatientButton.Location = new System.Drawing.Point(12, 576);
            this.generatePatientButton.Name = "generatePatientButton";
            this.generatePatientButton.Size = new System.Drawing.Size(204, 23);
            this.generatePatientButton.TabIndex = 37;
            this.generatePatientButton.Text = "Сгенерировать запись в пациентах";
            this.generatePatientButton.UseVisualStyleBackColor = true;
            this.generatePatientButton.Click += new System.EventHandler(this.generatePatientButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "для тестирования";
            // 
            // generateVisitButton
            // 
            this.generateVisitButton.Location = new System.Drawing.Point(222, 576);
            this.generateVisitButton.Name = "generateVisitButton";
            this.generateVisitButton.Size = new System.Drawing.Size(210, 23);
            this.generateVisitButton.TabIndex = 39;
            this.generateVisitButton.Text = "Сгенерировать запись в посещениях";
            this.generateVisitButton.UseVisualStyleBackColor = true;
            this.generateVisitButton.Click += new System.EventHandler(this.generateVisitButton_Click);
            // 
            // bigGenerateButton
            // 
            this.bigGenerateButton.Location = new System.Drawing.Point(438, 576);
            this.bigGenerateButton.Name = "bigGenerateButton";
            this.bigGenerateButton.Size = new System.Drawing.Size(210, 23);
            this.bigGenerateButton.TabIndex = 40;
            this.bigGenerateButton.Text = "десяток и того и того";
            this.bigGenerateButton.UseVisualStyleBackColor = true;
            this.bigGenerateButton.Click += new System.EventHandler(this.bigGenerateButton_Click);
            // 
            // clearDBButton
            // 
            this.clearDBButton.Location = new System.Drawing.Point(654, 576);
            this.clearDBButton.Name = "clearDBButton";
            this.clearDBButton.Size = new System.Drawing.Size(210, 23);
            this.clearDBButton.TabIndex = 41;
            this.clearDBButton.Text = "очистить бд";
            this.clearDBButton.UseVisualStyleBackColor = true;
            this.clearDBButton.Click += new System.EventHandler(this.clearDBButton_Click);
            // 
            // newVisitButton
            // 
            this.newVisitButton.AutoSize = true;
            this.newVisitButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newVisitButton.Location = new System.Drawing.Point(360, 149);
            this.newVisitButton.Name = "newVisitButton";
            this.newVisitButton.Size = new System.Drawing.Size(196, 30);
            this.newVisitButton.TabIndex = 43;
            this.newVisitButton.Text = "Новое посещение";
            this.newVisitButton.UseVisualStyleBackColor = true;
            // 
            // saveChangedButton
            // 
            this.saveChangedButton.AutoSize = true;
            this.saveChangedButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveChangedButton.Location = new System.Drawing.Point(770, 149);
            this.saveChangedButton.Name = "saveChangedButton";
            this.saveChangedButton.Size = new System.Drawing.Size(202, 30);
            this.saveChangedButton.TabIndex = 44;
            this.saveChangedButton.Text = "Сохранить изменения";
            this.saveChangedButton.UseVisualStyleBackColor = true;
            // 
            // uploadToXMLButton
            // 
            this.uploadToXMLButton.AutoSize = true;
            this.uploadToXMLButton.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uploadToXMLButton.Location = new System.Drawing.Point(562, 149);
            this.uploadToXMLButton.Name = "uploadToXMLButton";
            this.uploadToXMLButton.Size = new System.Drawing.Size(202, 30);
            this.uploadToXMLButton.TabIndex = 45;
            this.uploadToXMLButton.Text = "Выгрузить в XML";
            this.uploadToXMLButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.uploadToXMLButton);
            this.Controls.Add(this.saveChangedButton);
            this.Controls.Add(this.newVisitButton);
            this.Controls.Add(this.clearDBButton);
            this.Controls.Add(this.bigGenerateButton);
            this.Controls.Add(this.generateVisitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.generatePatientButton);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quickSearchTextBox);
            this.Controls.Add(this.advancedSearchButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.visitDataGridView);
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox birthdayTextBox;
        private MaskedTextBox telephoneTextBox;
        private Label label5;
        private Label label4;
        private TextBox patronymicTextBox;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox quickSearchTextBox;
        private Button advancedSearchButton;
        private Button addPatientButton;
        private DataGridView patientDataGridView;
        private DataGridView visitDataGridView;
        private Button generatePatientButton;
        private Label label6;
        private Button generateVisitButton;
        private Button bigGenerateButton;
        private Button clearDBButton;
        private Button newVisitButton;
        private Button saveChangedButton;
        private Button uploadToXMLButton;
    }
}