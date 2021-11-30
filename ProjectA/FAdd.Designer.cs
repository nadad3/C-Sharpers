
namespace ProjectA
{
    partial class FAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBMovieTitle = new System.Windows.Forms.TextBox();
            this.txtBRottenTScore = new System.Windows.Forms.TextBox();
            this.txtTotalEarnings = new System.Windows.Forms.TextBox();
            this.txtbDirector = new System.Windows.Forms.TextBox();
            this.txtBYearReleased = new System.Windows.Forms.TextBox();
            this.comboBGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movie Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year Released:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Earnings:";
            // 
            // txtBMovieTitle
            // 
            this.txtBMovieTitle.Location = new System.Drawing.Point(162, 40);
            this.txtBMovieTitle.MaxLength = 50;
            this.txtBMovieTitle.Name = "txtBMovieTitle";
            this.txtBMovieTitle.Size = new System.Drawing.Size(204, 20);
            this.txtBMovieTitle.TabIndex = 9;
            // 
            // txtBRottenTScore
            // 
            this.txtBRottenTScore.Location = new System.Drawing.Point(162, 161);
            this.txtBRottenTScore.Name = "txtBRottenTScore";
            this.txtBRottenTScore.Size = new System.Drawing.Size(51, 20);
            this.txtBRottenTScore.TabIndex = 10;
            // 
            // txtTotalEarnings
            // 
            this.txtTotalEarnings.Location = new System.Drawing.Point(162, 193);
            this.txtTotalEarnings.Name = "txtTotalEarnings";
            this.txtTotalEarnings.Size = new System.Drawing.Size(86, 20);
            this.txtTotalEarnings.TabIndex = 11;
            // 
            // txtbDirector
            // 
            this.txtbDirector.Location = new System.Drawing.Point(162, 102);
            this.txtbDirector.Name = "txtbDirector";
            this.txtbDirector.Size = new System.Drawing.Size(204, 20);
            this.txtbDirector.TabIndex = 12;
            // 
            // txtBYearReleased
            // 
            this.txtBYearReleased.Location = new System.Drawing.Point(162, 72);
            this.txtBYearReleased.Name = "txtBYearReleased";
            this.txtBYearReleased.Size = new System.Drawing.Size(43, 20);
            this.txtBYearReleased.TabIndex = 13;
            // 
            // comboBGenre
            // 
            this.comboBGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBGenre.FormattingEnabled = true;
            this.comboBGenre.Location = new System.Drawing.Point(162, 132);
            this.comboBGenre.Name = "comboBGenre";
            this.comboBGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBGenre.TabIndex = 14;
            // 
            // FAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 347);
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
            this.Controls.Add(this.btnAdd);
            this.Name = "FAdd";
            this.Text = "Add a Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBMovieTitle;
        private System.Windows.Forms.TextBox txtBRottenTScore;
        private System.Windows.Forms.TextBox txtTotalEarnings;
        private System.Windows.Forms.TextBox txtbDirector;
        private System.Windows.Forms.TextBox txtBYearReleased;
        private System.Windows.Forms.ComboBox comboBGenre;
    }
}