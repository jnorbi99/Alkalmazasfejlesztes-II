
namespace Project.View
{
    partial class AddGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.homeClubTextBox = new System.Windows.Forms.TextBox();
            this.awayClubTextBox = new System.Windows.Forms.TextBox();
            this.homeScoreTextBox = new System.Windows.Forms.TextBox();
            this.awayScoreTextBox = new System.Windows.Forms.TextBox();
            this.homeTDTextBox = new System.Windows.Forms.TextBox();
            this.awayTDTextBox = new System.Windows.Forms.TextBox();
            this.weekUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.weekUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "HomeClubName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "AwayClubName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "HomeFinalScore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "AwayFinalScore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "HomeNumberOfTD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "AwayNumberOfTD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Week";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Year";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(90, 320);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(221, 320);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // homeClubTextBox
            // 
            this.homeClubTextBox.Location = new System.Drawing.Point(174, 31);
            this.homeClubTextBox.Name = "homeClubTextBox";
            this.homeClubTextBox.Size = new System.Drawing.Size(178, 23);
            this.homeClubTextBox.TabIndex = 10;
            // 
            // awayClubTextBox
            // 
            this.awayClubTextBox.Location = new System.Drawing.Point(174, 67);
            this.awayClubTextBox.Name = "awayClubTextBox";
            this.awayClubTextBox.Size = new System.Drawing.Size(178, 23);
            this.awayClubTextBox.TabIndex = 11;
            // 
            // homeScoreTextBox
            // 
            this.homeScoreTextBox.Location = new System.Drawing.Point(174, 102);
            this.homeScoreTextBox.Name = "homeScoreTextBox";
            this.homeScoreTextBox.Size = new System.Drawing.Size(178, 23);
            this.homeScoreTextBox.TabIndex = 12;
            // 
            // awayScoreTextBox
            // 
            this.awayScoreTextBox.Location = new System.Drawing.Point(174, 136);
            this.awayScoreTextBox.Name = "awayScoreTextBox";
            this.awayScoreTextBox.Size = new System.Drawing.Size(178, 23);
            this.awayScoreTextBox.TabIndex = 13;
            // 
            // homeTDTextBox
            // 
            this.homeTDTextBox.Location = new System.Drawing.Point(174, 171);
            this.homeTDTextBox.Name = "homeTDTextBox";
            this.homeTDTextBox.Size = new System.Drawing.Size(178, 23);
            this.homeTDTextBox.TabIndex = 14;
            // 
            // awayTDTextBox
            // 
            this.awayTDTextBox.Location = new System.Drawing.Point(174, 205);
            this.awayTDTextBox.Name = "awayTDTextBox";
            this.awayTDTextBox.Size = new System.Drawing.Size(178, 23);
            this.awayTDTextBox.TabIndex = 15;
            // 
            // weekUpDown
            // 
            this.weekUpDown.Location = new System.Drawing.Point(174, 234);
            this.weekUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.weekUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weekUpDown.Name = "weekUpDown";
            this.weekUpDown.Size = new System.Drawing.Size(178, 23);
            this.weekUpDown.TabIndex = 16;
            this.weekUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(174, 266);
            this.yearUpDown.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(178, 23);
            this.yearUpDown.TabIndex = 17;
            this.yearUpDown.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 386);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.weekUpDown);
            this.Controls.Add(this.awayTDTextBox);
            this.Controls.Add(this.homeTDTextBox);
            this.Controls.Add(this.awayScoreTextBox);
            this.Controls.Add(this.homeScoreTextBox);
            this.Controls.Add(this.awayClubTextBox);
            this.Controls.Add(this.homeClubTextBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGame";
            this.Text = "AddGame";
            ((System.ComponentModel.ISupportInitialize)(this.weekUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox homeClubTextBox;
        private System.Windows.Forms.TextBox awayClubTextBox;
        private System.Windows.Forms.TextBox homeScoreTextBox;
        private System.Windows.Forms.TextBox awayScoreTextBox;
        private System.Windows.Forms.TextBox homeTDTextBox;
        private System.Windows.Forms.TextBox awayTDTextBox;
        private System.Windows.Forms.NumericUpDown weekUpDown;
        private System.Windows.Forms.NumericUpDown yearUpDown;
    }
}