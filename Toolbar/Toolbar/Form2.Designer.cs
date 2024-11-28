namespace Toolbar
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Xpos = new System.Windows.Forms.TextBox();
            this.Ypos = new System.Windows.Forms.TextBox();
            this.slopeX = new System.Windows.Forms.TextBox();
            this.slopeY = new System.Windows.Forms.TextBox();
            this.Speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Xpos
            // 
            this.Xpos.Location = new System.Drawing.Point(97, 118);
            this.Xpos.Name = "Xpos";
            this.Xpos.Size = new System.Drawing.Size(100, 26);
            this.Xpos.TabIndex = 3;
            // 
            // Ypos
            // 
            this.Ypos.Location = new System.Drawing.Point(230, 118);
            this.Ypos.Name = "Ypos";
            this.Ypos.Size = new System.Drawing.Size(100, 26);
            this.Ypos.TabIndex = 4;
            // 
            // slopeX
            // 
            this.slopeX.Location = new System.Drawing.Point(97, 150);
            this.slopeX.Name = "slopeX";
            this.slopeX.Size = new System.Drawing.Size(100, 26);
            this.slopeX.TabIndex = 5;
            // 
            // slopeY
            // 
            this.slopeY.Location = new System.Drawing.Point(230, 150);
            this.slopeY.Name = "slopeY";
            this.slopeY.Size = new System.Drawing.Size(100, 26);
            this.slopeY.TabIndex = 6;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(161, 182);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(100, 26);
            this.Speed.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Speed (50 = 1ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Slope";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.slopeY);
            this.Controls.Add(this.slopeX);
            this.Controls.Add(this.Ypos);
            this.Controls.Add(this.Xpos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Onload);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Xpos;
        private System.Windows.Forms.TextBox Ypos;
        private System.Windows.Forms.TextBox slopeX;
        private System.Windows.Forms.TextBox slopeY;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}