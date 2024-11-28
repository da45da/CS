namespace Big_Chungus_Assignment
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
            this.Player1 = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.TextBox();
            this.P1_Score = new System.Windows.Forms.TextBox();
            this.P2_Score = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player1.BackColor = System.Drawing.Color.White;
            this.Player1.Enabled = false;
            this.Player1.Location = new System.Drawing.Point(31, 124);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(75, 207);
            this.Player1.TabIndex = 0;
            this.Player1.UseVisualStyleBackColor = false;
            // 
            // Player2
            // 
            this.Player2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Player2.BackColor = System.Drawing.Color.White;
            this.Player2.Enabled = false;
            this.Player2.Location = new System.Drawing.Point(690, 124);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(75, 207);
            this.Player2.TabIndex = 1;
            this.Player2.UseVisualStyleBackColor = false;
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.BackColor = System.Drawing.Color.White;
            this.Ball.Enabled = false;
            this.Ball.Location = new System.Drawing.Point(363, 192);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(31, 31);
            this.Ball.TabIndex = 2;
            this.Ball.UseVisualStyleBackColor = false;
            // 
            // e
            // 
            this.e.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.e.BackColor = System.Drawing.Color.Black;
            this.e.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.ForeColor = System.Drawing.SystemColors.Window;
            this.e.Location = new System.Drawing.Point(532, 26);
            this.e.Name = "e";
            this.e.ReadOnly = true;
            this.e.Size = new System.Drawing.Size(100, 101);
            this.e.TabIndex = 4;
            this.e.Text = "0";
            this.e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.e.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Movement);
            // 
            // P1_Score
            // 
            this.P1_Score.BackColor = System.Drawing.Color.Black;
            this.P1_Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.P1_Score.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1_Score.ForeColor = System.Drawing.SystemColors.Window;
            this.P1_Score.Location = new System.Drawing.Point(149, 26);
            this.P1_Score.Name = "P1_Score";
            this.P1_Score.ReadOnly = true;
            this.P1_Score.Size = new System.Drawing.Size(100, 101);
            this.P1_Score.TabIndex = 5;
            this.P1_Score.Text = "0";
            this.P1_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P2_Score
            // 
            this.P2_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P2_Score.BackColor = System.Drawing.Color.Black;
            this.P2_Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.P2_Score.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2_Score.ForeColor = System.Drawing.SystemColors.Window;
            this.P2_Score.Location = new System.Drawing.Point(532, 26);
            this.P2_Score.Name = "P2_Score";
            this.P2_Score.ReadOnly = true;
            this.P2_Score.Size = new System.Drawing.Size(100, 101);
            this.P2_Score.TabIndex = 6;
            this.P2_Score.Text = "0";
            this.P2_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P2_Score);
            this.Controls.Add(this.P1_Score);
            this.Controls.Add(this.e);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Player1;
        private System.Windows.Forms.Button Player2;
        private System.Windows.Forms.Button Ball;
        private System.Windows.Forms.TextBox e;
        private System.Windows.Forms.TextBox P1_Score;
        private System.Windows.Forms.TextBox P2_Score;
    }
}

