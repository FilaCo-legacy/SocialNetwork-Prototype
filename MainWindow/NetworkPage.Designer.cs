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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPage = new System.Windows.Forms.TableLayoutPanel();
            this.groupUpdates = new System.Windows.Forms.GroupBox();
            this.groupNews = new System.Windows.Forms.GroupBox();
            this.dataViewNews = new System.Windows.Forms.DataGridView();
            this.pictureNext = new System.Windows.Forms.PictureBox();
            this.picturePref = new System.Windows.Forms.PictureBox();
            this.pictureCur = new System.Windows.Forms.PictureBox();
            this.dataGroup = new System.Windows.Forms.GroupBox();
            this.dataViewPerson = new System.Windows.Forms.DataGridView();
            this.butAddPic = new System.Windows.Forms.Button();
            this.textNews = new System.Windows.Forms.TextBox();
            this.groupAlbum = new System.Windows.Forms.GroupBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.panelProfilePic = new System.Windows.Forms.Panel();
            this.butEditInfo = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.groupFriends = new System.Windows.Forms.GroupBox();
            this.panelInfo_Album = new System.Windows.Forms.Panel();
            this.panelNews_Updates = new System.Windows.Forms.Panel();
            this.panelPic_Edit = new System.Windows.Forms.Panel();
            this.panelFriends_Table = new System.Windows.Forms.Panel();
            this.tableLayoutPage.SuspendLayout();
            this.groupNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCur)).BeginInit();
            this.dataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPerson)).BeginInit();
            this.groupAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.panelProfilePic.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.groupFriends.SuspendLayout();
            this.panelInfo_Album.SuspendLayout();
            this.panelNews_Updates.SuspendLayout();
            this.panelPic_Edit.SuspendLayout();
            this.panelFriends_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPage
            // 
            this.tableLayoutPage.ColumnCount = 2;
            this.tableLayoutPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPage.Controls.Add(this.panelNews_Updates, 1, 1);
            this.tableLayoutPage.Controls.Add(this.panelInfo_Album, 1, 0);
            this.tableLayoutPage.Controls.Add(this.panelPic_Edit, 0, 0);
            this.tableLayoutPage.Controls.Add(this.panelFriends_Table, 0, 1);
            this.tableLayoutPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPage.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPage.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPage.Name = "tableLayoutPage";
            this.tableLayoutPage.RowCount = 2;
            this.tableLayoutPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPage.Size = new System.Drawing.Size(1256, 631);
            this.tableLayoutPage.TabIndex = 0;
            // 
            // groupUpdates
            // 
            this.groupUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupUpdates.BackColor = System.Drawing.Color.White;
            this.groupUpdates.Location = new System.Drawing.Point(762, 10);
            this.groupUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.groupUpdates.Name = "groupUpdates";
            this.groupUpdates.Size = new System.Drawing.Size(244, 321);
            this.groupUpdates.TabIndex = 22;
            this.groupUpdates.TabStop = false;
            this.groupUpdates.Text = "Уведомления";
            // 
            // groupNews
            // 
            this.groupNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNews.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupNews.BackColor = System.Drawing.Color.White;
            this.groupNews.Controls.Add(this.dataViewNews);
            this.groupNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNews.Location = new System.Drawing.Point(10, 42);
            this.groupNews.Margin = new System.Windows.Forms.Padding(0);
            this.groupNews.Name = "groupNews";
            this.groupNews.Padding = new System.Windows.Forms.Padding(25);
            this.groupNews.Size = new System.Drawing.Size(732, 289);
            this.groupNews.TabIndex = 20;
            this.groupNews.TabStop = false;
            this.groupNews.Text = "Новости";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewNews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataViewNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewNews.ColumnHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewNews.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataViewNews.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewNews.EnableHeadersVisualStyles = false;
            this.dataViewNews.Location = new System.Drawing.Point(25, 38);
            this.dataViewNews.Margin = new System.Windows.Forms.Padding(0);
            this.dataViewNews.Name = "dataViewNews";
            this.dataViewNews.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataViewNews.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataViewNews.RowHeadersVisible = false;
            this.dataViewNews.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataViewNews.Size = new System.Drawing.Size(682, 226);
            this.dataViewNews.TabIndex = 0;
            // 
            // pictureNext
            // 
            this.pictureNext.Location = new System.Drawing.Point(526, 50);
            this.pictureNext.Margin = new System.Windows.Forms.Padding(0);
            this.pictureNext.Name = "pictureNext";
            this.pictureNext.Size = new System.Drawing.Size(100, 100);
            this.pictureNext.TabIndex = 2;
            this.pictureNext.TabStop = false;
            // 
            // picturePref
            // 
            this.picturePref.Location = new System.Drawing.Point(77, 50);
            this.picturePref.Margin = new System.Windows.Forms.Padding(0);
            this.picturePref.Name = "picturePref";
            this.picturePref.Size = new System.Drawing.Size(100, 100);
            this.picturePref.TabIndex = 1;
            this.picturePref.TabStop = false;
            // 
            // pictureCur
            // 
            this.pictureCur.Location = new System.Drawing.Point(285, 25);
            this.pictureCur.Margin = new System.Windows.Forms.Padding(0);
            this.pictureCur.Name = "pictureCur";
            this.pictureCur.Size = new System.Drawing.Size(150, 150);
            this.pictureCur.TabIndex = 0;
            this.pictureCur.TabStop = false;
            // 
            // dataGroup
            // 
            this.dataGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroup.Controls.Add(this.dataViewPerson);
            this.dataGroup.Location = new System.Drawing.Point(25, 69);
            this.dataGroup.Margin = new System.Windows.Forms.Padding(0);
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewPerson.DefaultCellStyle = dataGridViewCellStyle12;
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
            // butAddPic
            // 
            this.butAddPic.Location = new System.Drawing.Point(323, 202);
            this.butAddPic.Margin = new System.Windows.Forms.Padding(0);
            this.butAddPic.Name = "butAddPic";
            this.butAddPic.Size = new System.Drawing.Size(75, 23);
            this.butAddPic.TabIndex = 3;
            this.butAddPic.Text = "Добавить";
            this.butAddPic.UseVisualStyleBackColor = true;
            // 
            // textNews
            // 
            this.textNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNews.BackColor = System.Drawing.Color.White;
            this.textNews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNews.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNews.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNews.Location = new System.Drawing.Point(10, 10);
            this.textNews.Margin = new System.Windows.Forms.Padding(0);
            this.textNews.Multiline = true;
            this.textNews.Name = "textNews";
            this.textNews.Size = new System.Drawing.Size(732, 25);
            this.textNews.TabIndex = 21;
            this.textNews.Text = "Что у Вас нового?";
            // 
            // groupAlbum
            // 
            this.groupAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAlbum.BackColor = System.Drawing.Color.White;
            this.groupAlbum.Controls.Add(this.butAddPic);
            this.groupAlbum.Controls.Add(this.pictureNext);
            this.groupAlbum.Controls.Add(this.picturePref);
            this.groupAlbum.Controls.Add(this.pictureCur);
            this.groupAlbum.Location = new System.Drawing.Point(330, 20);
            this.groupAlbum.Margin = new System.Windows.Forms.Padding(0);
            this.groupAlbum.Name = "groupAlbum";
            this.groupAlbum.Padding = new System.Windows.Forms.Padding(25);
            this.groupAlbum.Size = new System.Drawing.Size(676, 250);
            this.groupAlbum.TabIndex = 19;
            this.groupAlbum.TabStop = false;
            this.groupAlbum.Text = "Альбом";
            // 
            // pictureProfile
            // 
            this.pictureProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureProfile.BackgroundImage = global::SocialNetwork.Properties.Resources.EmptyProfilePic;
            this.pictureProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProfile.Location = new System.Drawing.Point(25, 25);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(0);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(150, 150);
            this.pictureProfile.TabIndex = 4;
            this.pictureProfile.TabStop = false;
            // 
            // panelProfilePic
            // 
            this.panelProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfilePic.BackColor = System.Drawing.Color.White;
            this.panelProfilePic.Controls.Add(this.butEditInfo);
            this.panelProfilePic.Controls.Add(this.pictureProfile);
            this.panelProfilePic.Location = new System.Drawing.Point(20, 20);
            this.panelProfilePic.Margin = new System.Windows.Forms.Padding(0);
            this.panelProfilePic.Name = "panelProfilePic";
            this.panelProfilePic.Padding = new System.Windows.Forms.Padding(25);
            this.panelProfilePic.Size = new System.Drawing.Size(200, 250);
            this.panelProfilePic.TabIndex = 17;
            // 
            // butEditInfo
            // 
            this.butEditInfo.Location = new System.Drawing.Point(50, 202);
            this.butEditInfo.Margin = new System.Windows.Forms.Padding(0);
            this.butEditInfo.Name = "butEditInfo";
            this.butEditInfo.Size = new System.Drawing.Size(100, 23);
            this.butEditInfo.TabIndex = 5;
            this.butEditInfo.Text = "Редактировать";
            this.butEditInfo.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.labelFullName);
            this.panelInfo.Controls.Add(this.dataGroup);
            this.panelInfo.Location = new System.Drawing.Point(10, 20);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(25);
            this.panelInfo.Size = new System.Drawing.Size(300, 250);
            this.panelInfo.TabIndex = 16;
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
            // panelFriends
            // 
            this.panelFriends.AutoScroll = true;
            this.panelFriends.BackColor = System.Drawing.Color.Transparent;
            this.panelFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFriends.Location = new System.Drawing.Point(10, 23);
            this.panelFriends.Margin = new System.Windows.Forms.Padding(0);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(180, 252);
            this.panelFriends.TabIndex = 6;
            // 
            // groupFriends
            // 
            this.groupFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFriends.BackColor = System.Drawing.Color.White;
            this.groupFriends.Controls.Add(this.panelFriends);
            this.groupFriends.Location = new System.Drawing.Point(20, 10);
            this.groupFriends.Margin = new System.Windows.Forms.Padding(0);
            this.groupFriends.Name = "groupFriends";
            this.groupFriends.Padding = new System.Windows.Forms.Padding(10);
            this.groupFriends.Size = new System.Drawing.Size(200, 285);
            this.groupFriends.TabIndex = 18;
            this.groupFriends.TabStop = false;
            this.groupFriends.Text = "Друзья";
            // 
            // panelInfo_Album
            // 
            this.panelInfo_Album.Controls.Add(this.panelInfo);
            this.panelInfo_Album.Controls.Add(this.groupAlbum);
            this.panelInfo_Album.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo_Album.Location = new System.Drawing.Point(230, 0);
            this.panelInfo_Album.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfo_Album.Name = "panelInfo_Album";
            this.panelInfo_Album.Padding = new System.Windows.Forms.Padding(10, 20, 20, 10);
            this.panelInfo_Album.Size = new System.Drawing.Size(1026, 280);
            this.panelInfo_Album.TabIndex = 0;
            // 
            // panelNews_Updates
            // 
            this.panelNews_Updates.Controls.Add(this.groupUpdates);
            this.panelNews_Updates.Controls.Add(this.textNews);
            this.panelNews_Updates.Controls.Add(this.groupNews);
            this.panelNews_Updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNews_Updates.Location = new System.Drawing.Point(230, 280);
            this.panelNews_Updates.Margin = new System.Windows.Forms.Padding(0);
            this.panelNews_Updates.Name = "panelNews_Updates";
            this.panelNews_Updates.Padding = new System.Windows.Forms.Padding(10, 10, 20, 20);
            this.panelNews_Updates.Size = new System.Drawing.Size(1026, 351);
            this.panelNews_Updates.TabIndex = 1;
            // 
            // panelPic_Edit
            // 
            this.panelPic_Edit.Controls.Add(this.panelProfilePic);
            this.panelPic_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPic_Edit.Location = new System.Drawing.Point(0, 0);
            this.panelPic_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.panelPic_Edit.Name = "panelPic_Edit";
            this.panelPic_Edit.Padding = new System.Windows.Forms.Padding(20, 20, 10, 10);
            this.panelPic_Edit.Size = new System.Drawing.Size(230, 280);
            this.panelPic_Edit.TabIndex = 19;
            // 
            // panelFriends_Table
            // 
            this.panelFriends_Table.Controls.Add(this.groupFriends);
            this.panelFriends_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFriends_Table.Location = new System.Drawing.Point(0, 280);
            this.panelFriends_Table.Margin = new System.Windows.Forms.Padding(0);
            this.panelFriends_Table.Name = "panelFriends_Table";
            this.panelFriends_Table.Padding = new System.Windows.Forms.Padding(20, 10, 10, 20);
            this.panelFriends_Table.Size = new System.Drawing.Size(230, 351);
            this.panelFriends_Table.TabIndex = 20;
            // 
            // NetworkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1256, 631);
            this.Name = "NetworkPage";
            this.Size = new System.Drawing.Size(1256, 631);
            this.tableLayoutPage.ResumeLayout(false);
            this.groupNews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCur)).EndInit();
            this.dataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPerson)).EndInit();
            this.groupAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.panelProfilePic.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.groupFriends.ResumeLayout(false);
            this.panelInfo_Album.ResumeLayout(false);
            this.panelNews_Updates.ResumeLayout(false);
            this.panelNews_Updates.PerformLayout();
            this.panelPic_Edit.ResumeLayout(false);
            this.panelFriends_Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private EditPerson editPerson;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPage;
        private System.Windows.Forms.Panel panelNews_Updates;
        private System.Windows.Forms.Panel panelInfo_Album;
        private System.Windows.Forms.GroupBox groupUpdates;
        private System.Windows.Forms.GroupBox groupNews;
        private System.Windows.Forms.DataGridView dataViewNews;
        private System.Windows.Forms.PictureBox pictureNext;
        private System.Windows.Forms.PictureBox picturePref;
        private System.Windows.Forms.PictureBox pictureCur;
        private System.Windows.Forms.GroupBox dataGroup;
        private System.Windows.Forms.DataGridView dataViewPerson;
        private System.Windows.Forms.Button butAddPic;
        private System.Windows.Forms.TextBox textNews;
        private System.Windows.Forms.GroupBox groupAlbum;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Panel panelProfilePic;
        private System.Windows.Forms.Button butEditInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.FlowLayoutPanel panelFriends;
        private System.Windows.Forms.GroupBox groupFriends;
        private System.Windows.Forms.Panel panelPic_Edit;
        private System.Windows.Forms.Panel panelFriends_Table;
    }
}
