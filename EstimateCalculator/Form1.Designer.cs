namespace EstimateCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.TrianglesCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RectanglesCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CircleCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrianglesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.CalcButton);
            this.groupBox1.Controls.Add(this.TrianglesCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RectanglesCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CircleCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель управління";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(47, 452);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(150, 43);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Скинути";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(47, 385);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 43);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистити";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(47, 319);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 43);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Зберегти";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(47, 253);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(150, 43);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.Text = "Обчислити";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // TrianglesCount
            // 
            this.TrianglesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrianglesCount.Location = new System.Drawing.Point(148, 176);
            this.TrianglesCount.Name = "TrianglesCount";
            this.TrianglesCount.Size = new System.Drawing.Size(89, 30);
            this.TrianglesCount.TabIndex = 5;
            this.TrianglesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Трикутників";
            // 
            // RectanglesCount
            // 
            this.RectanglesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectanglesCount.Location = new System.Drawing.Point(148, 103);
            this.RectanglesCount.Name = "RectanglesCount";
            this.RectanglesCount.Size = new System.Drawing.Size(89, 30);
            this.RectanglesCount.TabIndex = 3;
            this.RectanglesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прямокутників";
            // 
            // CircleCount
            // 
            this.CircleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleCount.Location = new System.Drawing.Point(148, 36);
            this.CircleCount.Name = "CircleCount";
            this.CircleCount.Size = new System.Drawing.Size(89, 30);
            this.CircleCount.TabIndex = 1;
            this.CircleCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість кіл";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Results);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(266, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 562);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Панель результатів";
            // 
            // Results
            // 
            this.Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Results.Location = new System.Drawing.Point(3, 23);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Results.Size = new System.Drawing.Size(565, 536);
            this.Results.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrianglesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectanglesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown CircleCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.NumericUpDown TrianglesCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RectanglesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox Results;
    }
}

