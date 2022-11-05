
namespace Film
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.pbSplashscreen = new System.Windows.Forms.ProgressBar();
            this.lbMovie = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbSplashscreen
            // 
            this.pbSplashscreen.Location = new System.Drawing.Point(-2, 576);
            this.pbSplashscreen.Name = "pbSplashscreen";
            this.pbSplashscreen.Size = new System.Drawing.Size(804, 31);
            this.pbSplashscreen.TabIndex = 1;
            // 
            // lbMovie
            // 
            this.lbMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMovie.AutoSize = true;
            this.lbMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMovie.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie.Location = new System.Drawing.Point(318, 221);
            this.lbMovie.Name = "lbMovie";
            this.lbMovie.Size = new System.Drawing.Size(183, 59);
            this.lbMovie.TabIndex = 2;
            this.lbMovie.Text = "Movie";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.lbMovie);
            this.Controls.Add(this.pbSplashscreen);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbSplashscreen;
        private System.Windows.Forms.Label lbMovie;
        private System.Windows.Forms.Timer timer1;
    }
}