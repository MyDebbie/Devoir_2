using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Film.SplashScreen;
using static System.Net.WebRequestMethods;

namespace Film
{
    /// <summary>
    /// Nom: Mydleyka Dimanche
    /// Devoir2
    /// </summary>
    public partial class frmFilms : Form
    {
        public static List<Film> films = SplashScreen.films;
        public static int index = 0;

        public frmFilms()
        {
            InitializeComponent();
        }

        private void frmFilms_Load(object sender, EventArgs e)
        {
            if (Utilities.IsConnectedToInternet())
            {
                button1.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            Film film = films.ElementAt(index);
            display_film();
            

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
                index--;
                display_film();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            display_film();
        }
        /// <summary>
        /// Display info film in the form
        /// </summary>
        private void display_film()
        {
                Film film = films.ElementAt(index);
                lbTitle.Text = film.title;
                lbDescription.Text = film.overview;
                pbImageFilm.LoadAsync(@"https://image.tmdb.org/t/p/w342" + film.backdrop_path);
                pbImageFilm.SizeMode = PictureBoxSizeMode.StretchImage;
              
            if (index == 0)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }

            if (index == films.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        private void pbImageFilm_Click(object sender, EventArgs e)
        {
            frmFilmDetail filmDetail = new frmFilmDetail();
            filmDetail.Show();
            
        }
        
    }
}
