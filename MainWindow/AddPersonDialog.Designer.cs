namespace MainWindow
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
            this.radioButMan = new System.Windows.Forms.RadioButton();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tableData.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Location = new System.Drawing.Point(296, 286);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(377, 286);
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
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.Controls.Add(this.panelGender, 1, 2);
            this.tableData.Location = new System.Drawing.Point(207, 36);
            this.tableData.Name = "tableData";
            this.tableData.RowCount = 6;
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableData.Size = new System.Drawing.Size(220, 230);
            this.tableData.TabIndex = 5;
            // 
            // radioButMan
            // 
            this.radioButMan.AutoSize = true;
            this.radioButMan.Location = new System.Drawing.Point(3, 3);
            this.radioButMan.Name = "radioButMan";
            this.radioButMan.Size = new System.Drawing.Size(34, 17);
            this.radioButMan.TabIndex = 0;
            this.radioButMan.TabStop = true;
            this.radioButMan.Text = "М";
            this.radioButMan.UseVisualStyleBackColor = true;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radioButtonWoman);
            this.panelGender.Controls.Add(this.radioButMan);
            this.panelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGender.Location = new System.Drawing.Point(113, 79);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(104, 32);
            this.panelGender.TabIndex = 1;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(43, 3);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(36, 17);
            this.radioButtonWoman.TabIndex = 1;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Ж";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // AddPersonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
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
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tableData.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButMan;
    }
}