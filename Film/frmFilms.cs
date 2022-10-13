using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Film
{
    public partial class frmFilms : Form
    {
        public static List<Film> films = Utilities.getMovieDbList();
        int index = 0;

        public frmFilms()
        {
            InitializeComponent();
        }

        private void frmFilms_Load(object sender, EventArgs e)
        {
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

       
    }
}
