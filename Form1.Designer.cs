namespace guif
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SumForRub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SumForRub
            // 
            this.SumForRub.Location = new System.Drawing.Point(12, 33);
            this.SumForRub.Name = "SumForRub";
            this.SumForRub.Size = new System.Drawing.Size(195, 27);
            this.SumForRub.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите стоимость в копейках";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(109, 66);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(98, 29);
            this.Count.TabIndex = 2;
            this.Count.Text = "Рассчитать";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 66);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(91, 29);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Task
            // 
            this.Task.Location = new System.Drawing.Point(288, 145);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(77, 29);
            this.Task.TabIndex = 4;
            this.Task.Text = "Задание";
            this.Task.UseVisualStyleBackColor = true;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 186);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumForRub);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Рассчет стоимости в рублях";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SumForRub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Task;
    }
}

