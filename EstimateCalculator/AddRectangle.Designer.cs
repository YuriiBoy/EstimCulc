namespace EstimateCalculator
{
    partial class AddRectangle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SideABox = new System.Windows.Forms.TextBox();
            this.SideBBox = new System.Windows.Forms.TextBox();
            this.ContB = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Location = new System.Drawing.Point(344, 49);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(173, 25);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "Rectangle N __/__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Довжина";
            // 
            // SideABox
            // 
            this.SideABox.ForeColor = System.Drawing.Color.Maroon;
            this.SideABox.Location = new System.Drawing.Point(560, 119);
            this.SideABox.Name = "SideABox";
            this.SideABox.Size = new System.Drawing.Size(100, 30);
            this.SideABox.TabIndex = 3;
            this.SideABox.Text = "0";
            this.SideABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SideBBox
            // 
            this.SideBBox.ForeColor = System.Drawing.Color.Maroon;
            this.SideBBox.Location = new System.Drawing.Point(560, 185);
            this.SideBBox.Name = "SideBBox";
            this.SideBBox.Size = new System.Drawing.Size(100, 30);
            this.SideBBox.TabIndex = 4;
            this.SideBBox.Text = "0";
            this.SideBBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContB
            // 
            this.ContB.Location = new System.Drawing.Point(233, 280);
            this.ContB.Name = "ContB";
            this.ContB.Size = new System.Drawing.Size(177, 50);
            this.ContB.TabIndex = 5;
            this.ContB.Text = "Continue";
            this.ContB.UseVisualStyleBackColor = true;
            this.ContB.Click += new System.EventHandler(this.ContB_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(530, 280);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(177, 50);
            this.ClearBut.TabIndex = 6;
            this.ClearBut.Text = "Clear";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // AddRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 411);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.ContB);
            this.Controls.Add(this.SideBBox);
            this.Controls.Add(this.SideABox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Caption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddRectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRectangle";
            this.Load += new System.EventHandler(this.AddRectangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SideABox;
        private System.Windows.Forms.TextBox SideBBox;
        private System.Windows.Forms.Button ContB;
        private System.Windows.Forms.Button ClearBut;
    }
}