
namespace Film
{
    partial class frmFilmDetail
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
            this.lbOriginalTitle = new System.Windows.Forms.Label();
            this.lbVoteAverage = new System.Windows.Forms.Label();
            this.lbVoteCount = new System.Windows.Forms.Label();
            this.lbOverview = new System.Windows.Forms.Label();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.lbOriginalLanguange = new System.Windows.Forms.Label();
            this.lbGenreIds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOriginalTitle
            // 
            this.lbOriginalTitle.AutoSize = true;
            this.lbOriginalTitle.Location = new System.Drawing.Point(119, 92);
            this.lbOriginalTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOriginalTitle.Name = "lbOriginalTitle";
            this.lbOriginalTitle.Size = new System.Drawing.Size(73, 25);
            this.lbOriginalTitle.TabIndex = 0;
            this.lbOriginalTitle.Text = "label1";
            // 
            // lbVoteAverage
            // 
            this.lbVoteAverage.AutoSize = true;
            this.lbVoteAverage.Location = new System.Drawing.Point(119, 386);
            this.lbVoteAverage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVoteAverage.Name = "lbVoteAverage";
            this.lbVoteAverage.Size = new System.Drawing.Size(73, 25);
            this.lbVoteAverage.TabIndex = 1;
            this.lbVoteAverage.Text = "label2";
            // 
            // lbVoteCount
            // 
            this.lbVoteCount.AutoSize = true;
            this.lbVoteCount.Location = new System.Drawing.Point(119, 310);
            this.lbVoteCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVoteCount.Name = "lbVoteCount";
            this.lbVoteCount.Size = new System.Drawing.Size(73, 25);
            this.lbVoteCount.TabIndex = 2;
            this.lbVoteCount.Text = "label1";
            // 
            // lbOverview
            // 
            this.lbOverview.AutoSize = true;
            this.lbOverview.Location = new System.Drawing.Point(119, 181);
            this.lbOverview.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(73, 25);
            this.lbOverview.TabIndex = 3;
            this.lbOverview.Text = "label1";
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(119, 249);
            this.lbReleaseDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(73, 25);
            this.lbReleaseDate.TabIndex = 4;
            this.lbReleaseDate.Text = "label1";
            // 
            // lbOriginalLanguange
            // 
            this.lbOriginalLanguange.AutoSize = true;
            this.lbOriginalLanguange.Location = new System.Drawing.Point(617, 92);
            this.lbOriginalLanguange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOriginalLanguange.Name = "lbOriginalLanguange";
            this.lbOriginalLanguange.Size = new System.Drawing.Size(73, 25);
            this.lbOriginalLanguange.TabIndex = 5;
            this.lbOriginalLanguange.Text = "label1";
            // 
            // lbGenreIds
            // 
            this.lbGenreIds.AutoSize = true;
            this.lbGenreIds.Location = new System.Drawing.Point(617, 249);
            this.lbGenreIds.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbGenreIds.Name = "lbGenreIds";
            this.lbGenreIds.Size = new System.Drawing.Size(73, 25);
            this.lbGenreIds.TabIndex = 7;
            this.lbGenreIds.Text = "label1";
            // 
            // frmFilmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.lbGenreIds);
            this.Controls.Add(this.lbOriginalLanguange);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.lbOverview);
            this.Controls.Add(this.lbVoteCount);
            this.Controls.Add(this.lbVoteAverage);
            this.Controls.Add(this.lbOriginalTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmFilmDetail";
            this.Text = "frmFilmDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOriginalTitle;
        private System.Windows.Forms.Label lbVoteAverage;
        private System.Windows.Forms.Label lbVoteCount;
        private System.Windows.Forms.Label lbOverview;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.Label lbOriginalLanguange;
        private System.Windows.Forms.Label lbGenreIds;
    }
}