namespace Calc
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SolutionPlus = new System.Windows.Forms.Button();
            this.SolutionMinus = new System.Windows.Forms.Button();
            this.SolutionMulti = new System.Windows.Forms.Button();
            this.SolutionDiv = new System.Windows.Forms.Button();
            this.SolutionDegree = new System.Windows.Forms.Button();
            this.DegreeFraction = new System.Windows.Forms.Button();
            this.SolutionLog = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cosSolution = new System.Windows.Forms.Button();
            this.radicalSolution = new System.Windows.Forms.Button();
            this.sinSolution = new System.Windows.Forms.Button();
            this.tanSolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Click += new System.EventHandler(this.ClickMain);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // SolutionPlus
            // 
            this.SolutionPlus.Location = new System.Drawing.Point(12, 90);
            this.SolutionPlus.Name = "SolutionPlus";
            this.SolutionPlus.Size = new System.Drawing.Size(75, 23);
            this.SolutionPlus.TabIndex = 3;
            this.SolutionPlus.Text = "+";
            this.SolutionPlus.UseVisualStyleBackColor = true;
            this.SolutionPlus.Click += new System.EventHandler(this.ClickMain);
            // 
            // SolutionMinus
            // 
            this.SolutionMinus.Location = new System.Drawing.Point(93, 90);
            this.SolutionMinus.Name = "SolutionMinus";
            this.SolutionMinus.Size = new System.Drawing.Size(75, 23);
            this.SolutionMinus.TabIndex = 4;
            this.SolutionMinus.Text = "-";
            this.SolutionMinus.UseVisualStyleBackColor = true;
            this.SolutionMinus.Click += new System.EventHandler(this.ClickMain);
            // 
            // SolutionMulti
            // 
            this.SolutionMulti.Location = new System.Drawing.Point(12, 119);
            this.SolutionMulti.Name = "SolutionMulti";
            this.SolutionMulti.Size = new System.Drawing.Size(75, 23);
            this.SolutionMulti.TabIndex = 5;
            this.SolutionMulti.Text = "*";
            this.SolutionMulti.UseVisualStyleBackColor = true;
            this.SolutionMulti.Click += new System.EventHandler(this.ClickMain);
            // 
            // SolutionDiv
            // 
            this.SolutionDiv.Location = new System.Drawing.Point(93, 119);
            this.SolutionDiv.Name = "SolutionDiv";
            this.SolutionDiv.Size = new System.Drawing.Size(75, 23);
            this.SolutionDiv.TabIndex = 6;
            this.SolutionDiv.Text = "/";
            this.SolutionDiv.UseVisualStyleBackColor = true;
            this.SolutionDiv.Click += new System.EventHandler(this.ClickMain);
            // 
            // SolutionDegree
            // 
            this.SolutionDegree.Location = new System.Drawing.Point(12, 148);
            this.SolutionDegree.Name = "SolutionDegree";
            this.SolutionDegree.Size = new System.Drawing.Size(156, 23);
            this.SolutionDegree.TabIndex = 7;
            this.SolutionDegree.Text = "Degree";
            this.SolutionDegree.UseVisualStyleBackColor = true;
            this.SolutionDegree.Click += new System.EventHandler(this.ClickMain);
            // 
            // DegreeFraction
            // 
            this.DegreeFraction.Location = new System.Drawing.Point(12, 177);
            this.DegreeFraction.Name = "DegreeFraction";
            this.DegreeFraction.Size = new System.Drawing.Size(156, 23);
            this.DegreeFraction.TabIndex = 8;
            this.DegreeFraction.Text = "Degree Fraction";
            this.DegreeFraction.UseVisualStyleBackColor = true;
            this.DegreeFraction.Click += new System.EventHandler(this.ClickMain);
            // 
            // SolutionLog
            // 
            this.SolutionLog.Location = new System.Drawing.Point(12, 206);
            this.SolutionLog.Name = "SolutionLog";
            this.SolutionLog.Size = new System.Drawing.Size(156, 23);
            this.SolutionLog.TabIndex = 9;
            this.SolutionLog.Text = "Log";
            this.SolutionLog.UseVisualStyleBackColor = true;
            this.SolutionLog.Click += new System.EventHandler(this.ClickMain);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(284, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // cosSolution
            // 
            this.cosSolution.Location = new System.Drawing.Point(296, 90);
            this.cosSolution.Name = "cosSolution";
            this.cosSolution.Size = new System.Drawing.Size(75, 23);
            this.cosSolution.TabIndex = 11;
            this.cosSolution.Text = "Cosine";
            this.cosSolution.UseVisualStyleBackColor = true;
            this.cosSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // radicalSolution
            // 
            this.radicalSolution.Location = new System.Drawing.Point(296, 119);
            this.radicalSolution.Name = "radicalSolution";
            this.radicalSolution.Size = new System.Drawing.Size(75, 23);
            this.radicalSolution.TabIndex = 12;
            this.radicalSolution.Text = "Radical";
            this.radicalSolution.UseVisualStyleBackColor = true;
            this.radicalSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // sinSolution
            // 
            this.sinSolution.Location = new System.Drawing.Point(296, 148);
            this.sinSolution.Name = "sinSolution";
            this.sinSolution.Size = new System.Drawing.Size(75, 23);
            this.sinSolution.TabIndex = 13;
            this.sinSolution.Text = "Sinus";
            this.sinSolution.UseVisualStyleBackColor = true;
            this.sinSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // tanSolution
            // 
            this.tanSolution.Location = new System.Drawing.Point(296, 177);
            this.tanSolution.Name = "tanSolution";
            this.tanSolution.Size = new System.Drawing.Size(75, 23);
            this.tanSolution.TabIndex = 14;
            this.tanSolution.Text = "Tangent";
            this.tanSolution.UseVisualStyleBackColor = true;
            this.tanSolution.Click += new System.EventHandler(this.ClickMainOne);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 314);
            this.Controls.Add(this.tanSolution);
            this.Controls.Add(this.sinSolution);
            this.Controls.Add(this.radicalSolution);
            this.Controls.Add(this.cosSolution);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.SolutionLog);
            this.Controls.Add(this.DegreeFraction);
            this.Controls.Add(this.SolutionDegree);
            this.Controls.Add(this.SolutionDiv);
            this.Controls.Add(this.SolutionMulti);
            this.Controls.Add(this.SolutionMinus);
            this.Controls.Add(this.SolutionPlus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SolutionPlus;
        private System.Windows.Forms.Button SolutionMinus;
        private System.Windows.Forms.Button SolutionMulti;
        private System.Windows.Forms.Button SolutionDiv;
        private System.Windows.Forms.Button SolutionDegree;
        private System.Windows.Forms.Button DegreeFraction;
        private System.Windows.Forms.Button SolutionLog;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button cosSolution;
        private System.Windows.Forms.Button radicalSolution;
        private System.Windows.Forms.Button sinSolution;
        private System.Windows.Forms.Button tanSolution;
    }
}

