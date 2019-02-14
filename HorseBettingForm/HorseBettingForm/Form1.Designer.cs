namespace HorseBettingForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblRaceCourse = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblWinorLoss = new System.Windows.Forms.Label();
            this.txtRaceCourse = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboWinorLoss = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPopularCourse = new System.Windows.Forms.Button();
            this.btnBetsDateOrder = new System.Windows.Forms.Button();
            this.btnLargestWonLost = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lstAmountsByYear = new System.Windows.Forms.ListBox();
            this.lstMostPopularCourse = new System.Windows.Forms.ListBox();
            this.lstBetsByDate = new System.Windows.Forms.ListBox();
            this.lstLargestWinLoss = new System.Windows.Forms.ListBox();
            this.lstSuccess = new System.Windows.Forms.ListBox();
            this.btnAmountsByYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(184, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(427, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HotTipster Horse Betting App";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSubtitle.Location = new System.Drawing.Point(187, 93);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(193, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Please enter your bet details:";
            // 
            // lblRaceCourse
            // 
            this.lblRaceCourse.AutoSize = true;
            this.lblRaceCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRaceCourse.Location = new System.Drawing.Point(211, 137);
            this.lblRaceCourse.Name = "lblRaceCourse";
            this.lblRaceCourse.Size = new System.Drawing.Size(94, 17);
            this.lblRaceCourse.TabIndex = 2;
            this.lblRaceCourse.Text = "Race Course:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDate.Location = new System.Drawing.Point(211, 160);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date of Race:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAmount.Location = new System.Drawing.Point(211, 186);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(141, 17);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount Won or Lost:";
            // 
            // lblWinorLoss
            // 
            this.lblWinorLoss.AutoSize = true;
            this.lblWinorLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblWinorLoss.Location = new System.Drawing.Point(211, 212);
            this.lblWinorLoss.Name = "lblWinorLoss";
            this.lblWinorLoss.Size = new System.Drawing.Size(87, 17);
            this.lblWinorLoss.TabIndex = 5;
            this.lblWinorLoss.Text = "Win or Loss:";
            // 
            // txtRaceCourse
            // 
            this.txtRaceCourse.Location = new System.Drawing.Point(387, 134);
            this.txtRaceCourse.Name = "txtRaceCourse";
            this.txtRaceCourse.Size = new System.Drawing.Size(175, 20);
            this.txtRaceCourse.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(387, 186);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(175, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // cboWinorLoss
            // 
            this.cboWinorLoss.FormattingEnabled = true;
            this.cboWinorLoss.Items.AddRange(new object[] {
            "Win",
            "Loss"});
            this.cboWinorLoss.Location = new System.Drawing.Point(387, 212);
            this.cboWinorLoss.Name = "cboWinorLoss";
            this.cboWinorLoss.Size = new System.Drawing.Size(175, 21);
            this.cboWinorLoss.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(387, 252);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(473, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPopularCourse
            // 
            this.btnPopularCourse.Location = new System.Drawing.Point(185, 346);
            this.btnPopularCourse.Name = "btnPopularCourse";
            this.btnPopularCourse.Size = new System.Drawing.Size(138, 53);
            this.btnPopularCourse.TabIndex = 13;
            this.btnPopularCourse.Text = "Most Popular Course";
            this.btnPopularCourse.UseVisualStyleBackColor = true;
            this.btnPopularCourse.Click += new System.EventHandler(this.btnPopularCourse_Click);
            // 
            // btnBetsDateOrder
            // 
            this.btnBetsDateOrder.Location = new System.Drawing.Point(329, 346);
            this.btnBetsDateOrder.Name = "btnBetsDateOrder";
            this.btnBetsDateOrder.Size = new System.Drawing.Size(138, 53);
            this.btnBetsDateOrder.TabIndex = 14;
            this.btnBetsDateOrder.Text = "Bets by Date";
            this.btnBetsDateOrder.UseVisualStyleBackColor = true;
            this.btnBetsDateOrder.Click += new System.EventHandler(this.btnBetsDateOrder_Click);
            // 
            // btnLargestWonLost
            // 
            this.btnLargestWonLost.Location = new System.Drawing.Point(473, 346);
            this.btnLargestWonLost.Name = "btnLargestWonLost";
            this.btnLargestWonLost.Size = new System.Drawing.Size(138, 53);
            this.btnLargestWonLost.TabIndex = 15;
            this.btnLargestWonLost.Text = "Largest Won and Lost";
            this.btnLargestWonLost.UseVisualStyleBackColor = true;
            this.btnLargestWonLost.Click += new System.EventHandler(this.btnLargestWonLost_Click);
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(617, 346);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(138, 53);
            this.btnSuccess.TabIndex = 16;
            this.btnSuccess.Text = "HotTipster Success";
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(387, 160);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(175, 20);
            this.dtpDate.TabIndex = 17;
            // 
            // lstAmountsByYear
            // 
            this.lstAmountsByYear.FormattingEnabled = true;
            this.lstAmountsByYear.Location = new System.Drawing.Point(41, 416);
            this.lstAmountsByYear.Name = "lstAmountsByYear";
            this.lstAmountsByYear.Size = new System.Drawing.Size(138, 134);
            this.lstAmountsByYear.TabIndex = 18;
            // 
            // lstMostPopularCourse
            // 
            this.lstMostPopularCourse.FormattingEnabled = true;
            this.lstMostPopularCourse.Location = new System.Drawing.Point(185, 416);
            this.lstMostPopularCourse.Name = "lstMostPopularCourse";
            this.lstMostPopularCourse.Size = new System.Drawing.Size(138, 134);
            this.lstMostPopularCourse.TabIndex = 19;
            // 
            // lstBetsByDate
            // 
            this.lstBetsByDate.FormattingEnabled = true;
            this.lstBetsByDate.Items.AddRange(new object[] {
            "Course",
            "Date",
            "Amount",
            "Win"});
            this.lstBetsByDate.Location = new System.Drawing.Point(329, 416);
            this.lstBetsByDate.Name = "lstBetsByDate";
            this.lstBetsByDate.Size = new System.Drawing.Size(138, 134);
            this.lstBetsByDate.TabIndex = 20;
            // 
            // lstLargestWinLoss
            // 
            this.lstLargestWinLoss.FormattingEnabled = true;
            this.lstLargestWinLoss.Location = new System.Drawing.Point(474, 416);
            this.lstLargestWinLoss.Name = "lstLargestWinLoss";
            this.lstLargestWinLoss.Size = new System.Drawing.Size(138, 134);
            this.lstLargestWinLoss.TabIndex = 21;
            // 
            // lstSuccess
            // 
            this.lstSuccess.FormattingEnabled = true;
            this.lstSuccess.Location = new System.Drawing.Point(618, 416);
            this.lstSuccess.Name = "lstSuccess";
            this.lstSuccess.Size = new System.Drawing.Size(137, 134);
            this.lstSuccess.TabIndex = 22;
            // 
            // btnAmountsByYear
            // 
            this.btnAmountsByYear.Location = new System.Drawing.Point(41, 346);
            this.btnAmountsByYear.Name = "btnAmountsByYear";
            this.btnAmountsByYear.Size = new System.Drawing.Size(138, 53);
            this.btnAmountsByYear.TabIndex = 23;
            this.btnAmountsByYear.Text = "Win/Loss by Year";
            this.btnAmountsByYear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 648);
            this.Controls.Add(this.btnAmountsByYear);
            this.Controls.Add(this.lstSuccess);
            this.Controls.Add(this.lstLargestWinLoss);
            this.Controls.Add(this.lstBetsByDate);
            this.Controls.Add(this.lstMostPopularCourse);
            this.Controls.Add(this.lstAmountsByYear);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.btnLargestWonLost);
            this.Controls.Add(this.btnBetsDateOrder);
            this.Controls.Add(this.btnPopularCourse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboWinorLoss);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtRaceCourse);
            this.Controls.Add(this.lblWinorLoss);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRaceCourse);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRaceCourse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblWinorLoss;
        private System.Windows.Forms.TextBox txtRaceCourse;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboWinorLoss;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPopularCourse;
        private System.Windows.Forms.Button btnBetsDateOrder;
        private System.Windows.Forms.Button btnLargestWonLost;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListBox lstLargestWinLoss;
        private System.Windows.Forms.ListBox lstBetsByDate;
        private System.Windows.Forms.ListBox lstMostPopularCourse;
        private System.Windows.Forms.ListBox lstAmountsByYear;
        private System.Windows.Forms.ListBox lstSuccess;
        private System.Windows.Forms.Button btnAmountsByYear;
    }
}

