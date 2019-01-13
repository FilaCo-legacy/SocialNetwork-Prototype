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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.actionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsNetwork.SuspendLayout();
            this.mainMenu.SuspendLayout();
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
            this.tabExample.Location = new System.Drawing.Point(4, 22);
            this.tabExample.Name = "tabExample";
            this.tabExample.Size = new System.Drawing.Size(1256, 631);
            this.tabExample.TabIndex = 0;
            this.tabExample.Text = "ФИО";
            this.tabExample.UseVisualStyleBackColor = true;
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
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsNetwork;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem actionTool;
        private System.Windows.Forms.ToolStripMenuItem toolAddPerson;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private AddPerson addPerson;
        private System.Windows.Forms.TabPage tabExample;
    }
}

