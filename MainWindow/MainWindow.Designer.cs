namespace MainWindow
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.addPerson = new AddPersonDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsNetwork
            // 
            this.tabsNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsNetwork.Location = new System.Drawing.Point(0, 24);
            this.tabsNetwork.Multiline = true;
            this.tabsNetwork.Name = "tabsNetwork";
            this.tabsNetwork.SelectedIndex = 0;
            this.tabsNetwork.Size = new System.Drawing.Size(800, 426);
            this.tabsNetwork.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            this.toolAddPerson.Size = new System.Drawing.Size(180, 22);
            this.toolAddPerson.Text = "Создать аккаунт";
            this.toolAddPerson.Click += new System.EventHandler(this.toolAddPerson_Click);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(180, 22);
            this.toolExit.Text = "Выход";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsNetwork);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.Text = "Kungur Social Network";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsNetwork;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionTool;
        private System.Windows.Forms.ToolStripMenuItem toolAddPerson;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private AddPersonDialog addPerson; 
    }
}

