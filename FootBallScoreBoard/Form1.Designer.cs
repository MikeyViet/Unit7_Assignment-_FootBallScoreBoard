namespace FootBallScoreBoard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>        /// </summary>

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
            this.homeTeamLable = new System.Windows.Forms.Label();
            this.visitorTeamLable = new System.Windows.Forms.Label();
            this.homeTeamScore = new System.Windows.Forms.Label();
            this.visitorTeamScore = new System.Windows.Forms.Label();
            this.qtrLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeTeamLable
            // 
            this.homeTeamLable.AutoSize = true;
            this.homeTeamLable.Font = new System.Drawing.Font("Tahoma", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamLable.ForeColor = System.Drawing.Color.White;
            this.homeTeamLable.Location = new System.Drawing.Point(21, 19);
            this.homeTeamLable.MaximumSize = new System.Drawing.Size(700, 200);
            this.homeTeamLable.Name = "homeTeamLable";
            this.homeTeamLable.Size = new System.Drawing.Size(266, 90);
            this.homeTeamLable.TabIndex = 0;
            this.homeTeamLable.Text = "HOME";
            this.homeTeamLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeTeamLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // visitorTeamLable
            // 
            this.visitorTeamLable.AutoSize = true;
            this.visitorTeamLable.Font = new System.Drawing.Font("Tahoma", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorTeamLable.ForeColor = System.Drawing.Color.White;
            this.visitorTeamLable.Location = new System.Drawing.Point(843, 19);
            this.visitorTeamLable.MaximumSize = new System.Drawing.Size(700, 200);
            this.visitorTeamLable.Name = "visitorTeamLable";
            this.visitorTeamLable.Size = new System.Drawing.Size(367, 90);
            this.visitorTeamLable.TabIndex = 1;
            this.visitorTeamLable.Text = "VISITOR";
            this.visitorTeamLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.visitorTeamLable.Click += new System.EventHandler(this.visitorTeamLable_Click);
            // 
            // homeTeamScore
            // 
            this.homeTeamScore.AutoSize = true;
            this.homeTeamScore.BackColor = System.Drawing.SystemColors.ControlText;
            this.homeTeamScore.Font = new System.Drawing.Font("Bahnschrift", 55.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamScore.ForeColor = System.Drawing.Color.Yellow;
            this.homeTeamScore.Location = new System.Drawing.Point(43, 80);
            this.homeTeamScore.Margin = new System.Windows.Forms.Padding(0);
            this.homeTeamScore.MaximumSize = new System.Drawing.Size(250, 215);
            this.homeTeamScore.Name = "homeTeamScore";
            this.homeTeamScore.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.homeTeamScore.Size = new System.Drawing.Size(235, 178);
            this.homeTeamScore.TabIndex = 2;
            this.homeTeamScore.Text = "00";
            this.homeTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeTeamScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // visitorTeamScore
            // 
            this.visitorTeamScore.AutoSize = true;
            this.visitorTeamScore.BackColor = System.Drawing.SystemColors.ControlText;
            this.visitorTeamScore.Font = new System.Drawing.Font("Bahnschrift", 55.125F, System.Drawing.FontStyle.Bold);
            this.visitorTeamScore.ForeColor = System.Drawing.Color.Yellow;
            this.visitorTeamScore.Location = new System.Drawing.Point(950, 80);
            this.visitorTeamScore.Margin = new System.Windows.Forms.Padding(0);
            this.visitorTeamScore.MaximumSize = new System.Drawing.Size(250, 215);
            this.visitorTeamScore.Name = "visitorTeamScore";
            this.visitorTeamScore.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.visitorTeamScore.Size = new System.Drawing.Size(235, 178);
            this.visitorTeamScore.TabIndex = 3;
            this.visitorTeamScore.Text = "00";
            this.visitorTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.visitorTeamScore.Click += new System.EventHandler(this.visitorTeamScore_Click);
            // 
            // qtrLabel
            // 
            this.qtrLabel.AutoSize = true;
            this.qtrLabel.Font = new System.Drawing.Font("Tahoma", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtrLabel.ForeColor = System.Drawing.Color.White;
            this.qtrLabel.Location = new System.Drawing.Point(481, 227);
            this.qtrLabel.Margin = new System.Windows.Forms.Padding(0);
            this.qtrLabel.Name = "qtrLabel";
            this.qtrLabel.Size = new System.Drawing.Size(182, 90);
            this.qtrLabel.TabIndex = 4;
            this.qtrLabel.Text = "QTR";
            this.qtrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 44F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(641, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 141);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 46F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(101, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 147);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 46F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(941, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 147);
            this.label8.TabIndex = 7;
            this.label8.Text = "00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(210, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 77);
            this.label9.TabIndex = 8;
            this.label9.Text = "DOWN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(722, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 77);
            this.label10.TabIndex = 9;
            this.label10.Text = "TO GO";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1224, 588);
            this.Controls.Add(this.visitorTeamLable);
            this.Controls.Add(this.homeTeamLable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qtrLabel);
            this.Controls.Add(this.visitorTeamScore);
            this.Controls.Add(this.homeTeamScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeTeamLable;
        private System.Windows.Forms.Label visitorTeamLable;
        private System.Windows.Forms.Label homeTeamScore;
        private System.Windows.Forms.Label visitorTeamScore;
        private System.Windows.Forms.Label qtrLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

