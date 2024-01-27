namespace EstimateCalculator
{
    partial class AddTriangle
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
            this.label4 = new System.Windows.Forms.Label();
            this.SideABox = new System.Windows.Forms.TextBox();
            this.SideCBox = new System.Windows.Forms.TextBox();
            this.SideBBox = new System.Windows.Forms.TextBox();
            this.ContB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Location = new System.Drawing.Point(343, 38);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(164, 25);
            this.Caption.TabIndex = 0;
            this.Caption.Text = "Трикутник __/__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона а";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сторона c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сторона b";
            // 
            // SideABox
            // 
            this.SideABox.Location = new System.Drawing.Point(563, 107);
            this.SideABox.Name = "SideABox";
            this.SideABox.Size = new System.Drawing.Size(100, 30);
            this.SideABox.TabIndex = 4;
            // 
            // SideCBox
            // 
            this.SideCBox.Location = new System.Drawing.Point(563, 226);
            this.SideCBox.Name = "SideCBox";
            this.SideCBox.Size = new System.Drawing.Size(100, 30);
            this.SideCBox.TabIndex = 5;
            // 
            // SideBBox
            // 
            this.SideBBox.Location = new System.Drawing.Point(563, 163);
            this.SideBBox.Name = "SideBBox";
            this.SideBBox.Size = new System.Drawing.Size(100, 30);
            this.SideBBox.TabIndex = 6;
            // 
            // ContB
            // 
            this.ContB.Location = new System.Drawing.Point(144, 292);
            this.ContB.Name = "ContB";
            this.ContB.Size = new System.Drawing.Size(166, 52);
            this.ContB.TabIndex = 7;
            this.ContB.Text = "Continue";
            this.ContB.UseVisualStyleBackColor = true;
            this.ContB.Click += new System.EventHandler(this.ContB_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(537, 292);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(166, 52);
            this.ClearB.TabIndex = 8;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // AddTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 381);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.ContB);
            this.Controls.Add(this.SideBBox);
            this.Controls.Add(this.SideCBox);
            this.Controls.Add(this.SideABox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Caption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddTriangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTriangle";
            this.Load += new System.EventHandler(this.AddTriangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SideABox;
        private System.Windows.Forms.TextBox SideCBox;
        private System.Windows.Forms.TextBox SideBBox;
        private System.Windows.Forms.Button ContB;
        private System.Windows.Forms.Button ClearB;
    }
}