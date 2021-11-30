
namespace ProjectA
{
    partial class FUpdate
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
            this.comboBGenre = new System.Windows.Forms.ComboBox();
            this.txtBYearReleased = new System.Windows.Forms.TextBox();
            this.txtbDirector = new System.Windows.Forms.TextBox();
            this.txtTotalEarnings = new System.Windows.Forms.TextBox();
            this.txtBRottenTScore = new System.Windows.Forms.TextBox();
            this.txtBMovieTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBGenre
            // 
            this.comboBGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBGenre.FormattingEnabled = true;
            this.comboBGenre.Location = new System.Drawing.Point(151, 131);
            this.comboBGenre.Name = "comboBGenre";
            this.comboBGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBGenre.TabIndex = 29;
            // 
            // txtBYearReleased
            // 
            this.txtBYearReleased.Location = new System.Drawing.Point(151, 71);
            this.txtBYearReleased.Name = "txtBYearReleased";
            this.txtBYearReleased.Size = new System.Drawing.Size(43, 20);
            this.txtBYearReleased.TabIndex = 28;
            // 
            // txtbDirector
            // 
            this.txtbDirector.Location = new System.Drawing.Point(151, 101);
            this.txtbDirector.Name = "txtbDirector";
            this.txtbDirector.Size = new System.Drawing.Size(204, 20);
            this.txtbDirector.TabIndex = 27;
            // 
            // txtTotalEarnings
            // 
            this.txtTotalEarnings.Location = new System.Drawing.Point(151, 192);
            this.txtTotalEarnings.Name = "txtTotalEarnings";
            this.txtTotalEarnings.Size = new System.Drawing.Size(86, 20);
            this.txtTotalEarnings.TabIndex = 26;
            // 
            // txtBRottenTScore
            // 
            this.txtBRottenTScore.Location = new System.Drawing.Point(151, 160);
            this.txtBRottenTScore.Name = "txtBRottenTScore";
            this.txtBRottenTScore.Size = new System.Drawing.Size(51, 20);
            this.txtBRottenTScore.TabIndex = 25;
            // 
            // txtBMovieTitle
            // 
            this.txtBMovieTitle.Location = new System.Drawing.Point(151, 39);
            this.txtBMovieTitle.MaxLength = 50;
            this.txtBMovieTitle.Name = "txtBMovieTitle";
            this.txtBMovieTitle.Size = new System.Drawing.Size(204, 20);
            this.txtBMovieTitle.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Earnings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Year Released:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Movie Title:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(306, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(188, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(70, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(361, 37);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 23);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 342);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.comboBGenre);
            this.Controls.Add(this.txtBYearReleased);
            this.Controls.Add(this.txtbDirector);
            this.Controls.Add(this.txtTotalEarnings);
            this.Controls.Add(this.txtBRottenTScore);
            this.Controls.Add(this.txtBMovieTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Update a Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBGenre;
        private System.Windows.Forms.TextBox txtBYearReleased;
        private System.Windows.Forms.TextBox txtbDirector;
        private System.Windows.Forms.TextBox txtTotalEarnings;
        private System.Windows.Forms.TextBox txtBRottenTScore;
        private System.Windows.Forms.TextBox txtBMovieTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
    }
}