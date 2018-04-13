namespace queue
{
    partial class QueueForm
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
            this.leftBound = new System.Windows.Forms.TextBox();
            this.rightBound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srcArr = new System.Windows.Forms.TextBox();
            this.resArr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftBound
            // 
            this.leftBound.Location = new System.Drawing.Point(8, 44);
            this.leftBound.Margin = new System.Windows.Forms.Padding(2);
            this.leftBound.Name = "leftBound";
            this.leftBound.Size = new System.Drawing.Size(87, 20);
            this.leftBound.TabIndex = 0;
            // 
            // rightBound
            // 
            this.rightBound.Location = new System.Drawing.Point(121, 44);
            this.rightBound.Margin = new System.Windows.Forms.Padding(2);
            this.rightBound.Name = "rightBound";
            this.rightBound.Size = new System.Drawing.Size(79, 20);
            this.rightBound.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Левая граница";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Правая граница";
            // 
            // srcArr
            // 
            this.srcArr.Location = new System.Drawing.Point(8, 103);
            this.srcArr.Margin = new System.Windows.Forms.Padding(2);
            this.srcArr.Name = "srcArr";
            this.srcArr.Size = new System.Drawing.Size(449, 20);
            this.srcArr.TabIndex = 4;
            // 
            // resArr
            // 
            this.resArr.Location = new System.Drawing.Point(8, 147);
            this.resArr.Margin = new System.Windows.Forms.Padding(2);
            this.resArr.Name = "resArr";
            this.resArr.Size = new System.Drawing.Size(449, 20);
            this.resArr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Исходное множество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Обработанное множество";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(11, 188);
            this.runBtn.Margin = new System.Windows.Forms.Padding(2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(50, 24);
            this.runBtn.TabIndex = 8;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 246);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resArr);
            this.Controls.Add(this.srcArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightBound);
            this.Controls.Add(this.leftBound);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Not Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftBound;
        private System.Windows.Forms.TextBox rightBound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srcArr;
        private System.Windows.Forms.TextBox resArr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button runBtn;
    }
}

