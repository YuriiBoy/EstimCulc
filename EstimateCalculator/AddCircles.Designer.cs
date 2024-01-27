namespace EstimateCalculator
{
    partial class AddCircles
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
            this.Caption = new System.Windows.Forms.Label();
            this.RadiusC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NextB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Location = new System.Drawing.Point(332, 54);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(110, 25);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "Коло №_/_";
            // 
            // RadiusC
            // 
            this.RadiusC.AutoSize = true;
            this.RadiusC.Location = new System.Drawing.Point(252, 105);
            this.RadiusC.Name = "RadiusC";
            this.RadiusC.Size = new System.Drawing.Size(78, 25);
            this.RadiusC.TabIndex = 1;
            this.RadiusC.Text = "Radius:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextB
            // 
            this.NextB.Location = new System.Drawing.Point(175, 173);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(155, 36);
            this.NextB.TabIndex = 3;
            this.NextB.Text = "Continue";
            this.NextB.UseVisualStyleBackColor = true;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(562, 173);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(155, 36);
            this.ClearB.TabIndex = 4;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // AddCircles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 292);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.NextB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RadiusC);
            this.Controls.Add(this.Caption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddCircles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCircles";
            this.Load += new System.EventHandler(this.AddCircles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Label RadiusC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Button ClearB;
    }
}