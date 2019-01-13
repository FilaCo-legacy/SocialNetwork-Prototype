namespace SocialNetwork
{
    partial class NetworkPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGroup = new System.Windows.Forms.GroupBox();
            this.dataViewPerson = new System.Windows.Forms.DataGridView();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelProfilePic = new System.Windows.Forms.Panel();
            this.panelFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.groupFriends = new System.Windows.Forms.GroupBox();
            this.pictureCur = new System.Windows.Forms.PictureBox();
            this.picturePref = new System.Windows.Forms.PictureBox();
            this.pictureNext = new System.Windows.Forms.PictureBox();
            this.butAddPic = new System.Windows.Forms.Button();
            this.groupAlbum = new System.Windows.Forms.GroupBox();
            this.dataViewNews = new System.Windows.Forms.DataGridView();
            this.groupNews = new System.Windows.Forms.GroupBox();
            this.textNews = new System.Windows.Forms.TextBox();
            this.groupUpdates = new System.Windows.Forms.GroupBox();
            this.dataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPerson)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.panelProfilePic.SuspendLayout();
            this.groupFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNext)).BeginInit();
            this.groupAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewNews)).BeginInit();
            this.groupNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGroup
            // 
            this.dataGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroup.Controls.Add(this.dataViewPerson);
            this.dataGroup.Location = new System.Drawing.Point(25, 69);
            this.dataGroup.Name = "dataGroup";
            this.dataGroup.Size = new System.Drawing.Size(247, 153);
            this.dataGroup.TabIndex = 5;
            this.dataGroup.TabStop = false;
            this.dataGroup.Text = "Основная информация";
            // 
            // dataViewPerson
            // 
            this.dataViewPerson.AllowUserToAddRows = false;
            this.dataViewPerson.AllowUserToDeleteRows = false;
            this.dataViewPerson.AllowUserToResizeColumns = false;
            this.dataViewPerson.AllowUserToResizeRows = false;
            this.dataViewPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewPerson.BackgroundColor = System.Drawing.Color.White;
            this.dataViewPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViewPerson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataViewPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewPerson.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewPerson.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewPerson.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewPerson.EnableHeadersVisualStyles = false;
            this.dataViewPerson.Location = new System.Drawing.Point(3, 16);
            this.dataViewPerson.Margin = new System.Windows.Forms.Padding(0);
            this.dataViewPerson.Name = "dataViewPerson";
            this.dataViewPerson.ReadOnly = true;
            this.dataViewPerson.RowHeadersVisible = false;
            this.dataViewPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataViewPerson.Size = new System.Drawing.Size(241, 134);
            this.dataViewPerson.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.Location = new System.Drawing.Point(25, 25);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(72, 33);
            this.labelFullName.TabIndex = 8;
            this.labelFullName.Text = "ФИО";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.labelFullName);
            this.panelInfo.Controls.Add(this.dataGroup);
            this.panelInfo.Location = new System.Drawing.Point(254, 25);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(25);
            this.panelInfo.Size = new System.Drawing.Size(300, 250);
            this.panelInfo.TabIndex = 9;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureProfile.BackgroundImage = global::SocialNetwork.Properties.Resources.EmptyProfilePic;
            this.pictureProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProfile.Location = new System.Drawing.Point(25, 25);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(150, 150);
            this.pictureProfile.TabIndex = 4;
            this.pictureProfile.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelProfilePic
            // 
            this.panelProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfilePic.BackColor = System.Drawing.Color.White;
            this.panelProfilePic.Controls.Add(this.button1);
            this.panelProfilePic.Controls.Add(this.pictureProfile);
            this.panelProfilePic.Location = new System.Drawing.Point(25, 25);
            this.panelProfilePic.Name = "panelProfilePic";
            this.panelProfilePic.Padding = new System.Windows.Forms.Padding(25);
            this.panelProfilePic.Size = new System.Drawing.Size(200, 250);
            this.panelProfilePic.TabIndex = 10;
            // 
            // panelFriends
            // 
            this.panelFriends.AutoScroll = true;
            this.panelFriends.BackColor = System.Drawing.Color.Transparent;
            this.panelFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFriends.Location = new System.Drawing.Point(10, 23);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(180, 271);
            this.panelFriends.TabIndex = 6;
            // 
            // groupFriends
            // 
            this.groupFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFriends.BackColor = System.Drawing.Color.White;
            this.groupFriends.Controls.Add(this.panelFriends);
            this.groupFriends.Location = new System.Drawing.Point(25, 299);
            this.groupFriends.Name = "groupFriends";
            this.groupFriends.Padding = new System.Windows.Forms.Padding(10);
            this.groupFriends.Size = new System.Drawing.Size(200, 304);
            this.groupFriends.TabIndex = 11;
            this.groupFriends.TabStop = false;
            this.groupFriends.Text = "Друзья";
            // 
            // pictureCur
            // 
            this.pictureCur.Location = new System.Drawing.Point(247, 30);
            this.pictureCur.Name = "pictureCur";
            this.pictureCur.Size = new System.Drawing.Size(150, 150);
            this.pictureCur.TabIndex = 0;
            this.pictureCur.TabStop = false;
            // 
            // picturePref
            // 
            this.picturePref.Location = new System.Drawing.Point(77, 60);
            this.picturePref.Name = "picturePref";
            this.picturePref.Size = new System.Drawing.Size(100, 100);
            this.picturePref.TabIndex = 1;
            this.picturePref.TabStop = false;
            // 
            // pictureNext
            // 
            this.pictureNext.Location = new System.Drawing.Point(472, 60);
            this.pictureNext.Name = "pictureNext";
            this.pictureNext.Size = new System.Drawing.Size(100, 100);
            this.pictureNext.TabIndex = 2;
            this.pictureNext.TabStop = false;
            // 
            // butAddPic
            // 
            this.butAddPic.Location = new System.Drawing.Point(287, 199);
            this.butAddPic.Name = "butAddPic";
            this.butAddPic.Size = new System.Drawing.Size(75, 23);
            this.butAddPic.TabIndex = 3;
            this.butAddPic.Text = "Добавить";
            this.butAddPic.UseVisualStyleBackColor = true;
            // 
            // groupAlbum
            // 
            this.groupAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAlbum.BackColor = System.Drawing.Color.White;
            this.groupAlbum.Controls.Add(this.butAddPic);
            this.groupAlbum.Controls.Add(this.pictureNext);
            this.groupAlbum.Controls.Add(this.picturePref);
            this.groupAlbum.Controls.Add(this.pictureCur);
            this.groupAlbum.Location = new System.Drawing.Point(584, 25);
            this.groupAlbum.Name = "groupAlbum";
            this.groupAlbum.Padding = new System.Windows.Forms.Padding(25);
            this.groupAlbum.Size = new System.Drawing.Size(644, 250);
            this.groupAlbum.TabIndex = 12;
            this.groupAlbum.TabStop = false;
            this.groupAlbum.Text = "Альбом";
            // 
            // dataViewNews
            // 
            this.dataViewNews.AllowUserToAddRows = false;
            this.dataViewNews.AllowUserToDeleteRows = false;
            this.dataViewNews.AllowUserToResizeColumns = false;
            this.dataViewNews.AllowUserToResizeRows = false;
            this.dataViewNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewNews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewNews.BackgroundColor = System.Drawing.Color.White;
            this.dataViewNews.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataViewNews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataViewNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewNews.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewNews.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataViewNews.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewNews.EnableHeadersVisualStyles = false;
            this.dataViewNews.Location = new System.Drawing.Point(25, 38);
            this.dataViewNews.Margin = new System.Windows.Forms.Padding(0);
            this.dataViewNews.Name = "dataViewNews";
            this.dataViewNews.ReadOnly = true;
            this.dataViewNews.RowHeadersVisible = false;
            this.dataViewNews.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataViewNews.Size = new System.Drawing.Size(645, 200);
            this.dataViewNews.TabIndex = 0;
            // 
            // groupNews
            // 
            this.groupNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNews.BackColor = System.Drawing.Color.White;
            this.groupNews.Controls.Add(this.dataViewNews);
            this.groupNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNews.Location = new System.Drawing.Point(254, 340);
            this.groupNews.Name = "groupNews";
            this.groupNews.Padding = new System.Windows.Forms.Padding(25);
            this.groupNews.Size = new System.Drawing.Size(695, 263);
            this.groupNews.TabIndex = 13;
            this.groupNews.TabStop = false;
            this.groupNews.Text = "Новости";
            // 
            // textNews
            // 
            this.textNews.BackColor = System.Drawing.Color.White;
            this.textNews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNews.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNews.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNews.Location = new System.Drawing.Point(254, 299);
            this.textNews.Multiline = true;
            this.textNews.Name = "textNews";
            this.textNews.Size = new System.Drawing.Size(695, 25);
            this.textNews.TabIndex = 14;
            this.textNews.Text = "Что у Вас нового?";
            // 
            // groupUpdates
            // 
            this.groupUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupUpdates.BackColor = System.Drawing.Color.White;
            this.groupUpdates.Location = new System.Drawing.Point(977, 299);
            this.groupUpdates.Name = "groupUpdates";
            this.groupUpdates.Size = new System.Drawing.Size(244, 304);
            this.groupUpdates.TabIndex = 15;
            this.groupUpdates.TabStop = false;
            this.groupUpdates.Text = "Уведомления";
            // 
            // NetworkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.groupUpdates);
            this.Controls.Add(this.textNews);
            this.Controls.Add(this.groupNews);
            this.Controls.Add(this.groupAlbum);
            this.Controls.Add(this.groupFriends);
            this.Controls.Add(this.panelProfilePic);
            this.Controls.Add(this.panelInfo);
            this.Margin = new System.Windows.Forms.Padding(25);
            this.MinimumSize = new System.Drawing.Size(1256, 631);
            this.Name = "NetworkPage";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(1256, 631);
            this.dataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPerson)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.panelProfilePic.ResumeLayout(false);
            this.groupFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNext)).EndInit();
            this.groupAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewNews)).EndInit();
            this.groupNews.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dataGroup;
        private System.Windows.Forms.DataGridView dataViewPerson;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelProfilePic;
        private System.Windows.Forms.FlowLayoutPanel panelFriends;
        private System.Windows.Forms.GroupBox groupFriends;
        private System.Windows.Forms.PictureBox pictureCur;
        private System.Windows.Forms.PictureBox picturePref;
        private System.Windows.Forms.PictureBox pictureNext;
        private System.Windows.Forms.Button butAddPic;
        private System.Windows.Forms.GroupBox groupAlbum;
        private System.Windows.Forms.DataGridView dataViewNews;
        private System.Windows.Forms.GroupBox groupNews;
        private System.Windows.Forms.TextBox textNews;
        private System.Windows.Forms.GroupBox groupUpdates;
    }
}
