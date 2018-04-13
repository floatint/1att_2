namespace VisualOfSort
{
    partial class VisualOfSort
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
            this.runButton = new System.Windows.Forms.Button();
            this.runVisualButton = new System.Windows.Forms.Button();
            this.prevStepButton = new System.Windows.Forms.Button();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.prevStepLabel = new System.Windows.Forms.Label();
            this.curStepLabal = new System.Windows.Forms.Label();
            this.nextStepLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(3, 12);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "График";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // runVisualButton
            // 
            this.runVisualButton.Location = new System.Drawing.Point(3, 41);
            this.runVisualButton.Name = "runVisualButton";
            this.runVisualButton.Size = new System.Drawing.Size(75, 23);
            this.runVisualButton.TabIndex = 1;
            this.runVisualButton.Text = "Показать сортировку";
            this.runVisualButton.UseVisualStyleBackColor = true;
            this.runVisualButton.Click += new System.EventHandler(this.runVisualButton_Click);
            // 
            // prevStepButton
            // 
            this.prevStepButton.Enabled = false;
            this.prevStepButton.Location = new System.Drawing.Point(510, 86);
            this.prevStepButton.Name = "prevStepButton";
            this.prevStepButton.Size = new System.Drawing.Size(38, 23);
            this.prevStepButton.TabIndex = 2;
            this.prevStepButton.Text = " ↑";
            this.prevStepButton.UseVisualStyleBackColor = true;
            this.prevStepButton.Click += new System.EventHandler(this.prevStepButton_Click);
            // 
            // nextStepButton
            // 
            this.nextStepButton.Enabled = false;
            this.nextStepButton.Location = new System.Drawing.Point(510, 176);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(38, 23);
            this.nextStepButton.TabIndex = 3;
            this.nextStepButton.Text = " ↓";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // prevStepLabel
            // 
            this.prevStepLabel.AutoSize = true;
            this.prevStepLabel.Location = new System.Drawing.Point(0, 86);
            this.prevStepLabel.Name = "prevStepLabel";
            this.prevStepLabel.Size = new System.Drawing.Size(101, 13);
            this.prevStepLabel.TabIndex = 4;
            this.prevStepLabel.Text = "Предыдущий шаг :";
            // 
            // curStepLabal
            // 
            this.curStepLabal.AutoSize = true;
            this.curStepLabal.Location = new System.Drawing.Point(0, 130);
            this.curStepLabal.Name = "curStepLabal";
            this.curStepLabal.Size = new System.Drawing.Size(80, 13);
            this.curStepLabal.TabIndex = 5;
            this.curStepLabal.Text = "Текущий шаг :";
            // 
            // nextStepLabel
            // 
            this.nextStepLabel.AutoSize = true;
            this.nextStepLabel.Location = new System.Drawing.Point(0, 176);
            this.nextStepLabel.Name = "nextStepLabel";
            this.nextStepLabel.Size = new System.Drawing.Size(94, 13);
            this.nextStepLabel.TabIndex = 6;
            this.nextStepLabel.Text = "Следующий шаг :";
            // 
            // VisualOfSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 398);
            this.Controls.Add(this.nextStepLabel);
            this.Controls.Add(this.curStepLabal);
            this.Controls.Add(this.prevStepLabel);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.prevStepButton);
            this.Controls.Add(this.runVisualButton);
            this.Controls.Add(this.runButton);
            this.Name = "VisualOfSort";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button runVisualButton;
        private System.Windows.Forms.Button prevStepButton;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Label prevStepLabel;
        private System.Windows.Forms.Label curStepLabal;
        private System.Windows.Forms.Label nextStepLabel;
    }
}

