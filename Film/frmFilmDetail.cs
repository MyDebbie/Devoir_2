using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class frmFilmDetail : Form
    {
        public frmFilmDetail()
        {
            InitializeComponent();
        }

        private void frmFilmDetail_Load(object sender, EventArgs e)
        {
            Film film = SplashScreen.films.ElementAt(frmFilms.index);

            lbTitle.Text = film.title;
            lbOverview.Text = film.overview;
            lbOriginalLanguange.Text = "Languange: "+film.original_language;
            lbReleaseDate.Text = "release_date: "+film.release_date;
            lbVoteAverage.Text = "vote_average: "+film.vote_average.ToString();
            lbVoteCount.Text = "vote_count: "+film.vote_count.ToString();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFilms frmfilms = new frmFilms();
            frmfilms.Show();

            //hide this form
            this.Hide();
        }
    }
}
