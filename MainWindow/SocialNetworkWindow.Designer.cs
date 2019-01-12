namespace SocialNetwork
{
    partial class SocialNetworkWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabsNetwork = new System.Windows.Forms.TabControl();
            this.tabExample = new System.Windows.Forms.TabPage();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.mainInfo = new System.Windows.Forms.GroupBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.actionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFriends = new System.Windows.Forms.Label();
            this.dataViewPerson = new System.Windows.Forms.DataGridView();
            this.tabsNetwork.SuspendLayout();
            this.tabExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.mainInfo.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsNetwork
            // 
            this.tabsNetwork.Controls.Add(this.tabExample);
            this.tabsNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsNetwork.Location = new System.Drawing.Point(0, 24);
            this.tabsNetwork.Multiline = true;
            this.tabsNetwork.Name = "tabsNetwork";
            this.tabsNetwork.SelectedIndex = 0;
            this.tabsNetwork.Size = new System.Drawing.Size(1264, 657);
            this.tabsNetwork.TabIndex = 1;
            // 
            // tabExample
            // 
            this.tabExample.Controls.Add(this.labelFriends);
            this.tabExample.Controls.Add(this.panelFriends);
            this.tabExample.Controls.Add(this.pictureProfile);
            this.tabExample.Controls.Add(this.mainInfo);
            this.tabExample.Location = new System.Drawing.Point(4, 22);
            this.tabExample.Name = "tabExample";
            this.tabExample.Size = new System.Drawing.Size(1256, 631);
            this.tabExample.TabIndex = 0;
            this.tabExample.Text = "ФИО";
            this.tabExample.UseVisualStyleBackColor = true;
            // 
            // pictureProfile
            // 
            this.pictureProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProfile.Image = global::SocialNetwork.Properties.Resources.EmptyProfilePic;
            this.pictureProfile.Location = new System.Drawing.Point(22, 21);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(256, 256);
            this.pictureProfile.TabIndex = 0;
            this.pictureProfile.TabStop = false;
            // 
            // mainInfo
            // 
            this.mainInfo.Controls.Add(this.dataViewPerson);
            this.mainInfo.Location = new System.Drawing.Point(289, 23);
            this.mainInfo.Name = "mainInfo";
            this.mainInfo.Size = new System.Drawing.Size(300, 256);
            this.mainInfo.TabIndex = 0;
            this.mainInfo.TabStop = false;
            this.mainInfo.Text = "Основная информация";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionTool});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1264, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // actionTool
            // 
            this.actionTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddPerson,
            this.toolExit});
            this.actionTool.Name = "actionTool";
            this.actionTool.Size = new System.Drawing.Size(70, 20);
            this.actionTool.Text = "Действие";
            // 
            // toolAddPerson
            // 
            this.toolAddPerson.Name = "toolAddPerson";
            this.toolAddPerson.Size = new System.Drawing.Size(162, 22);
            this.toolAddPerson.Text = "Создать аккаунт";
            this.toolAddPerson.Click += new System.EventHandler(this.toolAddPerson_Click);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(162, 22);
            this.toolExit.Text = "Выход";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // panelFriends
            // 
            this.panelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriends.AutoScroll = true;
            this.panelFriends.BackColor = System.Drawing.Color.LightGray;
            this.panelFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFriends.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelFriends.Location = new System.Drawing.Point(1036, 42);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(200, 571);
            this.panelFriends.TabIndex = 1;
            // 
            // labelFriends
            // 
            this.labelFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(1033, 21);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(45, 13);
            this.labelFriends.TabIndex = 2;
            this.labelFriends.Text = "Друзья";
            // 
            // dataViewPerson
            // 
            this.dataViewPerson.AllowUserToAddRows = false;
            this.dataViewPerson.AllowUserToDeleteRows = false;
            this.dataViewPerson.AllowUserToResizeColumns = false;
            this.dataViewPerson.AllowUserToResizeRows = false;
            this.dataViewPerson.BackgroundColor = System.Drawing.Color.White;
            this.dataViewPerson.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewPerson.ColumnHeadersVisible = false;
            this.dataViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewPerson.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewPerson.EnableHeadersVisualStyles = false;
            this.dataViewPerson.Location = new System.Drawing.Point(3, 16);
            this.dataViewPerson.Name = "dataViewPerson";
            this.dataViewPerson.ReadOnly = true;
            this.dataViewPerson.RowHeadersVisible = false;
            this.dataViewPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataViewPerson.Size = new System.Drawing.Size(294, 237);
            this.dataViewPerson.TabIndex = 0;
            // 
            // SocialNetworkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabsNetwork);
            this.Controls.Add(this.mainMenu);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "SocialNetworkWindow";
            this.Text = "Kungur Social Network";
            this.tabsNetwork.ResumeLayout(false);
            this.tabExample.ResumeLayout(false);
            this.tabExample.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.mainInfo.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsNetwork;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem actionTool;
        private System.Windows.Forms.ToolStripMenuItem toolAddPerson;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private AddPersonDialog addPerson;
        private System.Windows.Forms.TabPage tabExample;
        private System.Windows.Forms.GroupBox mainInfo;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.FlowLayoutPanel panelFriends;
        private System.Windows.Forms.DataGridView dataViewPerson;
    }
}

