namespace SocialNetwork
{
    partial class AddPersonDialog
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.buttonChoosePicture = new System.Windows.Forms.Button();
            this.labelEmptyPic = new System.Windows.Forms.Label();
            this.choosePicDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableData = new System.Windows.Forms.TableLayoutPanel();
            this.textMidName = new System.Windows.Forms.TextBox();
            this.textHighSchool = new System.Windows.Forms.TextBox();
            this.labelHighSchool = new System.Windows.Forms.Label();
            this.textSchool = new System.Windows.Forms.TextBox();
            this.labelSchool = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMidName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMaritalStatus = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioButWoman = new System.Windows.Forms.RadioButton();
            this.radioButMan = new System.Windows.Forms.RadioButton();
            this.listMaritalStatus = new System.Windows.Forms.ComboBox();
            this.chooseDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelNotification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tableData.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Location = new System.Drawing.Point(316, 276);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(397, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // profilePicture
            // 
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePicture.Location = new System.Drawing.Point(31, 36);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(128, 128);
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // buttonChoosePicture
            // 
            this.buttonChoosePicture.Location = new System.Drawing.Point(60, 170);
            this.buttonChoosePicture.Name = "buttonChoosePicture";
            this.buttonChoosePicture.Size = new System.Drawing.Size(75, 23);
            this.buttonChoosePicture.TabIndex = 3;
            this.buttonChoosePicture.Text = "Обзор";
            this.buttonChoosePicture.UseVisualStyleBackColor = true;
            this.buttonChoosePicture.Click += new System.EventHandler(this.buttonChoosePicture_Click);
            // 
            // labelEmptyPic
            // 
            this.labelEmptyPic.AutoSize = true;
            this.labelEmptyPic.BackColor = System.Drawing.Color.Transparent;
            this.labelEmptyPic.Location = new System.Drawing.Point(50, 95);
            this.labelEmptyPic.Name = "labelEmptyPic";
            this.labelEmptyPic.Size = new System.Drawing.Size(95, 13);
            this.labelEmptyPic.TabIndex = 4;
            this.labelEmptyPic.Text = "Добавить аватар\r\n";
            // 
            // choosePicDialog
            // 
            this.choosePicDialog.Filter = "Изображения | *.bmp; *.jpg; *.jpeg; *.png";
            // 
            // tableData
            // 
            this.tableData.ColumnCount = 2;
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableData.Controls.Add(this.textMidName, 1, 2);
            this.tableData.Controls.Add(this.textHighSchool, 1, 7);
            this.tableData.Controls.Add(this.labelHighSchool, 0, 7);
            this.tableData.Controls.Add(this.textSchool, 1, 6);
            this.tableData.Controls.Add(this.labelSchool, 0, 6);
            this.tableData.Controls.Add(this.textFirstName, 1, 1);
            this.tableData.Controls.Add(this.labelLastName, 0, 0);
            this.tableData.Controls.Add(this.labelFirstName, 0, 1);
            this.tableData.Controls.Add(this.labelMidName, 0, 2);
            this.tableData.Controls.Add(this.labelDateOfBirth, 0, 3);
            this.tableData.Controls.Add(this.labelGender, 0, 4);
            this.tableData.Controls.Add(this.labelMaritalStatus, 0, 5);
            this.tableData.Controls.Add(this.textLastName, 1, 0);
            this.tableData.Controls.Add(this.panelGender, 1, 4);
            this.tableData.Controls.Add(this.listMaritalStatus, 1, 5);
            this.tableData.Controls.Add(this.chooseDateOfBirth, 1, 3);
            this.tableData.Location = new System.Drawing.Point(200, 36);
            this.tableData.Margin = new System.Windows.Forms.Padding(0);
            this.tableData.Name = "tableData";
            this.tableData.RowCount = 8;
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.Size = new System.Drawing.Size(262, 160);
            this.tableData.TabIndex = 5;
            // 
            // textMidName
            // 
            this.textMidName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMidName.Location = new System.Drawing.Point(120, 40);
            this.textMidName.Margin = new System.Windows.Forms.Padding(0);
            this.textMidName.Name = "textMidName";
            this.textMidName.Size = new System.Drawing.Size(142, 20);
            this.textMidName.TabIndex = 17;
            this.textMidName.TextChanged += new System.EventHandler(this.textMidName_TextChanged);
            // 
            // textHighSchool
            // 
            this.textHighSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textHighSchool.Location = new System.Drawing.Point(120, 140);
            this.textHighSchool.Margin = new System.Windows.Forms.Padding(0);
            this.textHighSchool.Name = "textHighSchool";
            this.textHighSchool.Size = new System.Drawing.Size(142, 20);
            this.textHighSchool.TabIndex = 16;
            // 
            // labelHighSchool
            // 
            this.labelHighSchool.AutoSize = true;
            this.labelHighSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHighSchool.Location = new System.Drawing.Point(0, 140);
            this.labelHighSchool.Margin = new System.Windows.Forms.Padding(0);
            this.labelHighSchool.Name = "labelHighSchool";
            this.labelHighSchool.Size = new System.Drawing.Size(120, 20);
            this.labelHighSchool.TabIndex = 15;
            this.labelHighSchool.Text = "Вуз:";
            this.labelHighSchool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textSchool
            // 
            this.textSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSchool.Location = new System.Drawing.Point(120, 120);
            this.textSchool.Margin = new System.Windows.Forms.Padding(0);
            this.textSchool.Name = "textSchool";
            this.textSchool.Size = new System.Drawing.Size(142, 20);
            this.textSchool.TabIndex = 14;
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSchool.Location = new System.Drawing.Point(0, 120);
            this.labelSchool.Margin = new System.Windows.Forms.Padding(0);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(120, 20);
            this.labelSchool.TabIndex = 13;
            this.labelSchool.Text = "Школа:";
            this.labelSchool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textFirstName
            // 
            this.textFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFirstName.Location = new System.Drawing.Point(120, 20);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(142, 20);
            this.textFirstName.TabIndex = 9;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastName.Location = new System.Drawing.Point(0, 0);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(120, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Фамилия:*";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirstName.Location = new System.Drawing.Point(0, 20);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(120, 20);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Имя:*";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMidName.Location = new System.Drawing.Point(0, 40);
            this.labelMidName.Margin = new System.Windows.Forms.Padding(0);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(120, 20);
            this.labelMidName.TabIndex = 4;
            this.labelMidName.Text = "Отчество:*";
            this.labelMidName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDateOfBirth.Location = new System.Drawing.Point(0, 60);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(120, 20);
            this.labelDateOfBirth.TabIndex = 5;
            this.labelDateOfBirth.Text = "Дата рождения:*";
            this.labelDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGender.Location = new System.Drawing.Point(0, 80);
            this.labelGender.Margin = new System.Windows.Forms.Padding(0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(120, 20);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Пол:*";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaritalStatus
            // 
            this.labelMaritalStatus.AutoSize = true;
            this.labelMaritalStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaritalStatus.Location = new System.Drawing.Point(0, 100);
            this.labelMaritalStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaritalStatus.Name = "labelMaritalStatus";
            this.labelMaritalStatus.Size = new System.Drawing.Size(120, 20);
            this.labelMaritalStatus.TabIndex = 7;
            this.labelMaritalStatus.Text = "Семейное положение:";
            this.labelMaritalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLastName
            // 
            this.textLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLastName.Location = new System.Drawing.Point(120, 0);
            this.textLastName.Margin = new System.Windows.Forms.Padding(0);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(142, 20);
            this.textLastName.TabIndex = 8;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radioButWoman);
            this.panelGender.Controls.Add(this.radioButMan);
            this.panelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGender.Location = new System.Drawing.Point(123, 83);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(136, 14);
            this.panelGender.TabIndex = 1;
            // 
            // radioButWoman
            // 
            this.radioButWoman.AutoSize = true;
            this.radioButWoman.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButWoman.Location = new System.Drawing.Point(100, 0);
            this.radioButWoman.Margin = new System.Windows.Forms.Padding(0);
            this.radioButWoman.Name = "radioButWoman";
            this.radioButWoman.Size = new System.Drawing.Size(36, 14);
            this.radioButWoman.TabIndex = 1;
            this.radioButWoman.TabStop = true;
            this.radioButWoman.Text = "Ж";
            this.radioButWoman.UseVisualStyleBackColor = true;
            // 
            // radioButMan
            // 
            this.radioButMan.AutoSize = true;
            this.radioButMan.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButMan.Location = new System.Drawing.Point(0, 0);
            this.radioButMan.Margin = new System.Windows.Forms.Padding(0);
            this.radioButMan.Name = "radioButMan";
            this.radioButMan.Size = new System.Drawing.Size(34, 14);
            this.radioButMan.TabIndex = 0;
            this.radioButMan.TabStop = true;
            this.radioButMan.Text = "М";
            this.radioButMan.UseVisualStyleBackColor = true;
            this.radioButMan.CheckedChanged += new System.EventHandler(this.radioButMan_CheckedChanged);
            // 
            // listMaritalStatus
            // 
            this.listMaritalStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMaritalStatus.FormattingEnabled = true;
            this.listMaritalStatus.Items.AddRange(new object[] {
            "Не выбрано",
            "Не женат",
            "В отношениях",
            "Помолвлен",
            "Женат",
            "Влюблён",
            "Всё сложно",
            "В активном поиске"});
            this.listMaritalStatus.Location = new System.Drawing.Point(120, 100);
            this.listMaritalStatus.Margin = new System.Windows.Forms.Padding(0);
            this.listMaritalStatus.Name = "listMaritalStatus";
            this.listMaritalStatus.Size = new System.Drawing.Size(142, 21);
            this.listMaritalStatus.TabIndex = 19;
            // 
            // chooseDateOfBirth
            // 
            this.chooseDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseDateOfBirth.Location = new System.Drawing.Point(120, 60);
            this.chooseDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.chooseDateOfBirth.MaxDate = new System.DateTime(2019, 1, 12, 16, 30, 12, 403);
            this.chooseDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.chooseDateOfBirth.Name = "chooseDateOfBirth";
            this.chooseDateOfBirth.Size = new System.Drawing.Size(142, 20);
            this.chooseDateOfBirth.TabIndex = 20;
            this.chooseDateOfBirth.Value = new System.DateTime(2019, 1, 12, 0, 0, 0, 0);
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.Location = new System.Drawing.Point(149, 225);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(323, 26);
            this.labelNotification.TabIndex = 6;
            this.labelNotification.Text = "Внимание!\r\nПоля, отмеченные звёздочкой, обязательны для заполнения.";
            // 
            // AddPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.labelNotification);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.labelEmptyPic);
            this.Controls.Add(this.buttonChoosePicture);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPersonDialog";
            this.ShowInTaskbar = false;
            this.Text = "Создать аккаунт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPersonDialog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tableData.ResumeLayout(false);
            this.tableData.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button buttonChoosePicture;
        private System.Windows.Forms.Label labelEmptyPic;
        private System.Windows.Forms.OpenFileDialog choosePicDialog;
        private System.Windows.Forms.TableLayoutPanel tableData;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radioButWoman;
        private System.Windows.Forms.RadioButton radioButMan;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelMaritalStatus;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textHighSchool;
        private System.Windows.Forms.Label labelHighSchool;
        private System.Windows.Forms.TextBox textSchool;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.TextBox textMidName;
        private System.Windows.Forms.ComboBox listMaritalStatus;
        private System.Windows.Forms.DateTimePicker chooseDateOfBirth;
        private System.Windows.Forms.Label labelNotification;
    }
}