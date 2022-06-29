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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homeTeamLabel = new System.Windows.Forms.Label();
            this.visitorTeamLable = new System.Windows.Forms.Label();
            this.homeTeamScore = new System.Windows.Forms.Label();
            this.qtrLabel = new System.Windows.Forms.Label();
            this.numQuarter = new System.Windows.Forms.Label();
            this.numDown = new System.Windows.Forms.Label();
            this.numYardsToGo = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            this.toGoLabel = new System.Windows.Forms.Label();
            this.numBallPosition = new System.Windows.Forms.Label();
            this.ballPositionLabel = new System.Windows.Forms.Label();
            this.visitorTimeOutLabel = new System.Windows.Forms.Label();
            this.visitorTimeOutNum = new System.Windows.Forms.Label();
            this.homeTimeOutNum = new System.Windows.Forms.Label();
            this.homeTimeOutLabel = new System.Windows.Forms.Label();
            this.tccdMascotImageBox = new System.Windows.Forms.PictureBox();
            this.updateControllerButton = new System.Windows.Forms.Button();
            this.visitorTeamScore = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tccdMascotImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTeamLabel
            // 
            this.homeTeamLabel.AutoSize = true;
            this.homeTeamLabel.Font = new System.Drawing.Font("Tahoma", 42.125F, System.Drawing.FontStyle.Bold);
            this.homeTeamLabel.ForeColor = System.Drawing.Color.White;
            this.homeTeamLabel.Location = new System.Drawing.Point(24, -15);
            this.homeTeamLabel.Margin = new System.Windows.Forms.Padding(0);
            this.homeTeamLabel.MaximumSize = new System.Drawing.Size(700, 200);
            this.homeTeamLabel.Name = "homeTeamLabel";
            this.homeTeamLabel.Size = new System.Drawing.Size(401, 136);
            this.homeTeamLabel.TabIndex = 0;
            this.homeTeamLabel.Text = "HOME";
            this.homeTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitorTeamLable
            // 
            this.visitorTeamLable.AutoSize = true;
            this.visitorTeamLable.Font = new System.Drawing.Font("Tahoma", 42.125F, System.Drawing.FontStyle.Bold);
            this.visitorTeamLable.ForeColor = System.Drawing.Color.White;
            this.visitorTeamLable.Location = new System.Drawing.Point(1048, -15);
            this.visitorTeamLable.Margin = new System.Windows.Forms.Padding(0);
            this.visitorTeamLable.MaximumSize = new System.Drawing.Size(700, 200);
            this.visitorTeamLable.Name = "visitorTeamLable";
            this.visitorTeamLable.Size = new System.Drawing.Size(553, 136);
            this.visitorTeamLable.TabIndex = 1;
            this.visitorTeamLable.Text = "VISITOR";
            this.visitorTeamLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homeTeamScore
            // 
            this.homeTeamScore.AutoSize = true;
            this.homeTeamScore.BackColor = System.Drawing.SystemColors.MenuText;
            this.homeTeamScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homeTeamScore.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamScore.ForeColor = System.Drawing.Color.Yellow;
            this.homeTeamScore.Location = new System.Drawing.Point(58, 110);
            this.homeTeamScore.Margin = new System.Windows.Forms.Padding(0);
            this.homeTeamScore.MaximumSize = new System.Drawing.Size(350, 300);
            this.homeTeamScore.Name = "homeTeamScore";
            this.homeTeamScore.Padding = new System.Windows.Forms.Padding(3);
            this.homeTeamScore.Size = new System.Drawing.Size(313, 239);
            this.homeTeamScore.TabIndex = 2;
            this.homeTeamScore.Text = "00";
            this.homeTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qtrLabel
            // 
            this.qtrLabel.AutoSize = true;
            this.qtrLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.qtrLabel.ForeColor = System.Drawing.Color.White;
            this.qtrLabel.Location = new System.Drawing.Point(390, 475);
            this.qtrLabel.Margin = new System.Windows.Forms.Padding(0);
            this.qtrLabel.Name = "qtrLabel";
            this.qtrLabel.Size = new System.Drawing.Size(114, 77);
            this.qtrLabel.TabIndex = 4;
            this.qtrLabel.Text = "QTR";
            this.qtrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQuarter
            // 
            this.numQuarter.AutoSize = true;
            this.numQuarter.BackColor = System.Drawing.SystemColors.ControlText;
            this.numQuarter.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 52F, System.Drawing.FontStyle.Bold);
            this.numQuarter.ForeColor = System.Drawing.Color.Yellow;
            this.numQuarter.Location = new System.Drawing.Point(375, 543);
            this.numQuarter.Margin = new System.Windows.Forms.Padding(0);
            this.numQuarter.Name = "numQuarter";
            this.numQuarter.Size = new System.Drawing.Size(137, 167);
            this.numQuarter.TabIndex = 5;
            this.numQuarter.Text = "0";
            this.numQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numDown
            // 
            this.numDown.AutoSize = true;
            this.numDown.BackColor = System.Drawing.SystemColors.ControlText;
            this.numDown.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 52F, System.Drawing.FontStyle.Bold);
            this.numDown.ForeColor = System.Drawing.Color.Yellow;
            this.numDown.Location = new System.Drawing.Point(1070, 543);
            this.numDown.Margin = new System.Windows.Forms.Padding(0);
            this.numDown.MaximumSize = new System.Drawing.Size(137, 167);
            this.numDown.Name = "numDown";
            this.numDown.Size = new System.Drawing.Size(137, 167);
            this.numDown.TabIndex = 6;
            this.numDown.Text = "0";
            this.numDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numYardsToGo
            // 
            this.numYardsToGo.AutoSize = true;
            this.numYardsToGo.BackColor = System.Drawing.SystemColors.ControlText;
            this.numYardsToGo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numYardsToGo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 52F, System.Drawing.FontStyle.Bold);
            this.numYardsToGo.ForeColor = System.Drawing.Color.Yellow;
            this.numYardsToGo.Location = new System.Drawing.Point(1317, 543);
            this.numYardsToGo.Name = "numYardsToGo";
            this.numYardsToGo.Size = new System.Drawing.Size(203, 169);
            this.numYardsToGo.TabIndex = 7;
            this.numYardsToGo.Text = "00";
            this.numYardsToGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downLabel
            // 
            this.downLabel.AutoSize = true;
            this.downLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.downLabel.ForeColor = System.Drawing.Color.White;
            this.downLabel.Location = new System.Drawing.Point(1067, 475);
            this.downLabel.Margin = new System.Windows.Forms.Padding(0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(154, 77);
            this.downLabel.TabIndex = 8;
            this.downLabel.Text = "DOWN";
            this.downLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toGoLabel
            // 
            this.toGoLabel.AutoSize = true;
            this.toGoLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.toGoLabel.ForeColor = System.Drawing.Color.White;
            this.toGoLabel.Location = new System.Drawing.Point(1341, 475);
            this.toGoLabel.Name = "toGoLabel";
            this.toGoLabel.Size = new System.Drawing.Size(153, 77);
            this.toGoLabel.TabIndex = 9;
            this.toGoLabel.Text = "TO GO";
            // 
            // numBallPosition
            // 
            this.numBallPosition.AutoSize = true;
            this.numBallPosition.BackColor = System.Drawing.SystemColors.ControlText;
            this.numBallPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numBallPosition.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 52F, System.Drawing.FontStyle.Bold);
            this.numBallPosition.ForeColor = System.Drawing.Color.Yellow;
            this.numBallPosition.Location = new System.Drawing.Point(58, 543);
            this.numBallPosition.Margin = new System.Windows.Forms.Padding(0);
            this.numBallPosition.Name = "numBallPosition";
            this.numBallPosition.Size = new System.Drawing.Size(203, 169);
            this.numBallPosition.TabIndex = 11;
            this.numBallPosition.Text = "00";
            this.numBallPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ballPositionLabel
            // 
            this.ballPositionLabel.AutoSize = true;
            this.ballPositionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.ballPositionLabel.ForeColor = System.Drawing.Color.White;
            this.ballPositionLabel.Location = new System.Drawing.Point(54, 466);
            this.ballPositionLabel.Name = "ballPositionLabel";
            this.ballPositionLabel.Size = new System.Drawing.Size(205, 77);
            this.ballPositionLabel.TabIndex = 12;
            this.ballPositionLabel.Text = "BALL ON";
            this.ballPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitorTimeOutLabel
            // 
            this.visitorTimeOutLabel.AutoSize = true;
            this.visitorTimeOutLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.visitorTimeOutLabel.ForeColor = System.Drawing.Color.White;
            this.visitorTimeOutLabel.Location = new System.Drawing.Point(1085, 146);
            this.visitorTimeOutLabel.Name = "visitorTimeOutLabel";
            this.visitorTimeOutLabel.Size = new System.Drawing.Size(107, 77);
            this.visitorTimeOutLabel.TabIndex = 14;
            this.visitorTimeOutLabel.Text = "TOL";
            this.visitorTimeOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitorTimeOutNum
            // 
            this.visitorTimeOutNum.AutoSize = true;
            this.visitorTimeOutNum.BackColor = System.Drawing.SystemColors.ControlText;
            this.visitorTimeOutNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 52F, System.Drawing.FontStyle.Bold);
            this.visitorTimeOutNum.ForeColor = System.Drawing.Color.Yellow;
            this.visitorTimeOutNum.Location = new System.Drawing.Point(1070, 213);
            this.visitorTimeOutNum.Margin = new System.Windows.Forms.Padding(0);
            this.visitorTimeOutNum.MaximumSize = new System.Drawing.Size(137, 167);
            this.visitorTimeOutNum.Name = "visitorTimeOutNum";
            this.visitorTimeOutNum.Size = new System.Drawing.Size(137, 167);
            this.visitorTimeOutNum.TabIndex = 13;
            this.visitorTimeOutNum.Text = "0";
            this.visitorTimeOutNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTimeOutNum
            // 
            this.homeTimeOutNum.AutoSize = true;
            this.homeTimeOutNum.BackColor = System.Drawing.SystemColors.ControlText;
            this.homeTimeOutNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 52F, System.Drawing.FontStyle.Bold);
            this.homeTimeOutNum.ForeColor = System.Drawing.Color.Yellow;
            this.homeTimeOutNum.Location = new System.Drawing.Point(375, 213);
            this.homeTimeOutNum.Margin = new System.Windows.Forms.Padding(0);
            this.homeTimeOutNum.MaximumSize = new System.Drawing.Size(137, 167);
            this.homeTimeOutNum.Name = "homeTimeOutNum";
            this.homeTimeOutNum.Size = new System.Drawing.Size(137, 167);
            this.homeTimeOutNum.TabIndex = 15;
            this.homeTimeOutNum.Text = "0";
            this.homeTimeOutNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeTimeOutLabel
            // 
            this.homeTimeOutLabel.AutoSize = true;
            this.homeTimeOutLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.homeTimeOutLabel.ForeColor = System.Drawing.Color.White;
            this.homeTimeOutLabel.Location = new System.Drawing.Point(390, 146);
            this.homeTimeOutLabel.Name = "homeTimeOutLabel";
            this.homeTimeOutLabel.Size = new System.Drawing.Size(107, 77);
            this.homeTimeOutLabel.TabIndex = 16;
            this.homeTimeOutLabel.Text = "TOL";
            this.homeTimeOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tccdMascotImageBox
            // 
            this.tccdMascotImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tccdMascotImageBox.ErrorImage = null;
            this.tccdMascotImageBox.Image = ((System.Drawing.Image)(resources.GetObject("tccdMascotImageBox.Image")));
            this.tccdMascotImageBox.InitialImage = null;
            this.tccdMascotImageBox.Location = new System.Drawing.Point(507, 213);
            this.tccdMascotImageBox.Name = "tccdMascotImageBox";
            this.tccdMascotImageBox.Padding = new System.Windows.Forms.Padding(1);
            this.tccdMascotImageBox.Size = new System.Drawing.Size(540, 454);
            this.tccdMascotImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tccdMascotImageBox.TabIndex = 17;
            this.tccdMascotImageBox.TabStop = false;
            // 
            // updateControllerButton
            // 
            this.updateControllerButton.AutoSize = true;
            this.updateControllerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateControllerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateControllerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateControllerButton.FlatAppearance.BorderSize = 0;
            this.updateControllerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateControllerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.updateControllerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateControllerButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.updateControllerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateControllerButton.Location = new System.Drawing.Point(507, 673);
            this.updateControllerButton.Name = "updateControllerButton";
            this.updateControllerButton.Size = new System.Drawing.Size(540, 47);
            this.updateControllerButton.TabIndex = 18;
            this.updateControllerButton.Text = "Update ScoreBoard";
            this.updateControllerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.updateControllerButton.UseVisualStyleBackColor = false;
            this.updateControllerButton.Click += new System.EventHandler(this.updateControllerButton_Click);
            // 
            // visitorTeamScore
            // 
            this.visitorTeamScore.AutoSize = true;
            this.visitorTeamScore.BackColor = System.Drawing.SystemColors.MenuText;
            this.visitorTeamScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visitorTeamScore.Font = new System.Drawing.Font("Bahnschrift", 72F, System.Drawing.FontStyle.Bold);
            this.visitorTeamScore.ForeColor = System.Drawing.Color.Yellow;
            this.visitorTeamScore.Location = new System.Drawing.Point(1211, 110);
            this.visitorTeamScore.Margin = new System.Windows.Forms.Padding(0);
            this.visitorTeamScore.MaximumSize = new System.Drawing.Size(350, 300);
            this.visitorTeamScore.Name = "visitorTeamScore";
            this.visitorTeamScore.Size = new System.Drawing.Size(307, 233);
            this.visitorTeamScore.TabIndex = 3;
            this.visitorTeamScore.Text = "00";
            this.visitorTeamScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.visitorTeamScore.Click += new System.EventHandler(this.visitorTeamScore_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Bahnschrift", 59F, System.Drawing.FontStyle.Bold);
            this.timerLabel.ForeColor = System.Drawing.Color.Yellow;
            this.timerLabel.Location = new System.Drawing.Point(592, -32);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timerLabel.MinimumSize = new System.Drawing.Size(420, 188);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(448, 190);
            this.timerLabel.TabIndex = 20;
            this.timerLabel.Text = "00:00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(624, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(787, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(FootBallScoreBoard.Form1);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(FootBallScoreBoard.Form2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1574, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.visitorTeamScore);
            this.Controls.Add(this.visitorTimeOutLabel);
            this.Controls.Add(this.visitorTeamLable);
            this.Controls.Add(this.homeTimeOutLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.updateControllerButton);
            this.Controls.Add(this.tccdMascotImageBox);
            this.Controls.Add(this.numDown);
            this.Controls.Add(this.numYardsToGo);
            this.Controls.Add(this.numBallPosition);
            this.Controls.Add(this.ballPositionLabel);
            this.Controls.Add(this.homeTeamScore);
            this.Controls.Add(this.homeTeamLabel);
            this.Controls.Add(this.toGoLabel);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.qtrLabel);
            this.Controls.Add(this.visitorTimeOutNum);
            this.Controls.Add(this.homeTimeOutNum);
            this.Controls.Add(this.numQuarter);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "Form1";
            this.Text = "TrailBlazers ScoreBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tccdMascotImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homeTeamLabel;
        private System.Windows.Forms.Label visitorTeamLable;
        public System.Windows.Forms.Label homeTeamScore;
        public System.Windows.Forms.Label visitorTeamScore;
        private System.Windows.Forms.Label qtrLabel;
        public System.Windows.Forms.Label numQuarter;
        public System.Windows.Forms.Label numDown;
        public System.Windows.Forms.Label numYardsToGo;
        private System.Windows.Forms.Label downLabel;
        private System.Windows.Forms.Label toGoLabel;
        public System.Windows.Forms.Label numBallPosition;
        private System.Windows.Forms.Label ballPositionLabel;
        private System.Windows.Forms.Label visitorTimeOutLabel;
        public System.Windows.Forms.Label visitorTimeOutNum;
        public System.Windows.Forms.Label homeTimeOutNum;
        private System.Windows.Forms.Label homeTimeOutLabel;
        private System.Windows.Forms.PictureBox tccdMascotImageBox;
        private System.Windows.Forms.Button updateControllerButton;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form2BindingSource;
        public System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

