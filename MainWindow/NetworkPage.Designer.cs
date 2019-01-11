namespace MainWindow
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
            this.prefPicture = new System.Windows.Forms.PictureBox();
            this.curPicture = new System.Windows.Forms.PictureBox();
            this.nextPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prefPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // prefPicture
            // 
            this.prefPicture.Location = new System.Drawing.Point(0, 0);
            this.prefPicture.Name = "prefPicture";
            this.prefPicture.Size = new System.Drawing.Size(100, 50);
            this.prefPicture.TabIndex = 0;
            this.prefPicture.TabStop = false;
            // 
            // curPicture
            // 
            this.curPicture.Location = new System.Drawing.Point(0, 0);
            this.curPicture.Name = "curPicture";
            this.curPicture.Size = new System.Drawing.Size(100, 50);
            this.curPicture.TabIndex = 0;
            this.curPicture.TabStop = false;
            // 
            // nextPicture
            // 
            this.nextPicture.Location = new System.Drawing.Point(0, 0);
            this.nextPicture.Name = "nextPicture";
            this.nextPicture.Size = new System.Drawing.Size(100, 50);
            this.nextPicture.TabIndex = 0;
            this.nextPicture.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)(this.prefPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox prefPicture;
        private System.Windows.Forms.PictureBox curPicture;
        private System.Windows.Forms.PictureBox nextPicture;
    }
}
