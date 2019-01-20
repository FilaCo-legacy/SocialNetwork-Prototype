namespace SocialNetwork
{
    partial class MsgTextBox
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
            this.tabLayoutTxtBox = new System.Windows.Forms.TableLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.textMsg = new System.Windows.Forms.RichTextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.tabLayoutTxtBox.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayoutTxtBox
            // 
            this.tabLayoutTxtBox.ColumnCount = 1;
            this.tabLayoutTxtBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutTxtBox.Controls.Add(this.panelButton, 0, 1);
            this.tabLayoutTxtBox.Controls.Add(this.textMsg, 0, 0);
            this.tabLayoutTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayoutTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabLayoutTxtBox.Location = new System.Drawing.Point(0, 0);
            this.tabLayoutTxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.tabLayoutTxtBox.MinimumSize = new System.Drawing.Size(0, 69);
            this.tabLayoutTxtBox.Name = "tabLayoutTxtBox";
            this.tabLayoutTxtBox.RowCount = 2;
            this.tabLayoutTxtBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutTxtBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tabLayoutTxtBox.Size = new System.Drawing.Size(150, 71);
            this.tabLayoutTxtBox.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.butSend);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(0, 38);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelButton.Size = new System.Drawing.Size(150, 33);
            this.panelButton.TabIndex = 1;
            // 
            // textMsg
            // 
            this.textMsg.AcceptsTab = true;
            this.textMsg.BackColor = System.Drawing.Color.AliceBlue;
            this.textMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMsg.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textMsg.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg.Location = new System.Drawing.Point(0, 0);
            this.textMsg.Margin = new System.Windows.Forms.Padding(0);
            this.textMsg.Name = "textMsg";
            this.textMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textMsg.Size = new System.Drawing.Size(150, 38);
            this.textMsg.TabIndex = 2;
            this.textMsg.Text = "Что у Вас нового?";
            // 
            // butSend
            // 
            this.butSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSend.Location = new System.Drawing.Point(75, 10);
            this.butSend.Margin = new System.Windows.Forms.Padding(0);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "Отправить";
            this.butSend.UseVisualStyleBackColor = true;
            // 
            // MsgTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tabLayoutTxtBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(0, 100);
            this.MinimumSize = new System.Drawing.Size(150, 35);
            this.Name = "MsgTextBox";
            this.Size = new System.Drawing.Size(150, 71);
            this.tabLayoutTxtBox.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayoutTxtBox;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.RichTextBox textMsg;
        public System.Windows.Forms.Button butSend;
    }
}
