namespace stack
{
    partial class StackForm
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
            this.run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(8, 17);
            this.run.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(65, 21);
            this.run.TabIndex = 0;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 203);
            this.Controls.Add(this.run);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Not Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button run;
    }
}

