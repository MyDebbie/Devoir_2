
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbVoteAverage = new System.Windows.Forms.Label();
            this.lbVoteCount = new System.Windows.Forms.Label();
            this.lbOverview = new System.Windows.Forms.Label();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.lbOriginalLanguange = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(486, 89);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(80, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // lbVoteAverage
            // 
            this.lbVoteAverage.AutoSize = true;
            this.lbVoteAverage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbVoteAverage.Location = new System.Drawing.Point(871, 444);
            this.lbVoteAverage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVoteAverage.Name = "lbVoteAverage";
            this.lbVoteAverage.Size = new System.Drawing.Size(73, 25);
            this.lbVoteAverage.TabIndex = 1;
            this.lbVoteAverage.Text = "label2";
            // 
            // lbVoteCount
            // 
            this.lbVoteCount.AutoSize = true;
            this.lbVoteCount.Location = new System.Drawing.Point(80, 431);
            this.lbVoteCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVoteCount.Name = "lbVoteCount";
            this.lbVoteCount.Size = new System.Drawing.Size(73, 25);
            this.lbVoteCount.TabIndex = 2;
            this.lbVoteCount.Text = "label1";
            // 
            // lbOverview
            // 
            this.lbOverview.AutoSize = true;
            this.lbOverview.Location = new System.Drawing.Point(881, 223);
            this.lbOverview.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOverview.MaximumSize = new System.Drawing.Size(400, 400);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(73, 25);
            this.lbOverview.TabIndex = 3;
            this.lbOverview.Text = "label1";
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(80, 299);
            this.lbReleaseDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(73, 25);
            this.lbReleaseDate.TabIndex = 4;
            this.lbReleaseDate.Text = "label1";
            // 
            // lbOriginalLanguange
            // 
            this.lbOriginalLanguange.AutoSize = true;
            this.lbOriginalLanguange.Location = new System.Drawing.Point(91, 179);
            this.lbOriginalLanguange.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbOriginalLanguange.Name = "lbOriginalLanguange";
            this.lbOriginalLanguange.Size = new System.Drawing.Size(73, 25);
            this.lbOriginalLanguange.TabIndex = 5;
            this.lbOriginalLanguange.Text = "label1";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(545, 613);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 46);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFilmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lbOriginalLanguange);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.lbOverview);
            this.Controls.Add(this.lbVoteCount);
            this.Controls.Add(this.lbVoteAverage);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmFilmDetail";
            this.Text = "frmFilmDetail";
            this.Load += new System.EventHandler(this.frmFilmDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbVoteAverage;
        private System.Windows.Forms.Label lbVoteCount;
        private System.Windows.Forms.Label lbOverview;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.Label lbOriginalLanguange;
        private System.Windows.Forms.Button back;
    }
}