using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class SplashScreen : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataReader sqlite_rdr;

        public static List<Film> films;
        Film film = new Film();




        public SplashScreen()
        {
            InitializeComponent();
        }



        public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            

            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }


        public Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }


       
        /// <summary>
        /// Create database
        /// </summary>
        private void CreateDatabase()
        {
            films = Utilities.getMovieDbList();
            

            // create a new database connection:
            using (sqlite_conn = new SQLiteConnection("Data Source=film.db;Version=3;New=True;Compress=True;")) 
            {

                // open the connection:
                sqlite_conn.Open();

                // create a new SQL command:
                sqlite_cmd = sqlite_conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Film (id integer, title varchar(30), overview varchar(200), original_language varchar(30), release_date varchar(30), vote_count integer, vote_average decimal, popularity decimal, poster_path1 BLOB, " +
                "Unique(id, title, overview, original_language, release_date, vote_count, vote_average, popularity, poster_path1))";

                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();

                foreach (Film film in films)
                {
                    Image backdrop;

                    using (WebClient webClient = new WebClient())
                    {
                        using (Stream stream = webClient.OpenRead(@"https://image.tmdb.org/t/p/w342" + film.backdrop_path))
                        {
                            backdrop = new Bitmap(Image.FromStream(stream));
                        }

                    }

                    byte[] data = ImageToByte(backdrop, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT OR IGNORE INTO Film(id, title, overview, original_language, release_date, vote_count, vote_average, popularity, poster_path1) VALUES(@id, @title, @overview, @original_language, @release_date, @vote_count, @vote_average, @popularity, @poster_path1)";
                    
                    
                    sqlite_cmd.Parameters.AddWithValue("@id", film.id);
                    sqlite_cmd.Parameters.AddWithValue("@title", film.title);
                    sqlite_cmd.Parameters.AddWithValue("@overview", film.overview);
                    sqlite_cmd.Parameters.AddWithValue("@original_language", film.original_language);
                    sqlite_cmd.Parameters.AddWithValue("@release_date", film.release_date);
                    sqlite_cmd.Parameters.AddWithValue("@vote_count", film.vote_count);
                    sqlite_cmd.Parameters.AddWithValue("@vote_average", film.vote_average);
                    sqlite_cmd.Parameters.AddWithValue("@popularity", film.popularity);
                    sqlite_cmd.Parameters.AddWithValue("@poster_path1", data);

                   


                    sqlite_cmd.Prepare();

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();

                }

            }

                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbSplashscreen.Increment(1);
            if (pbSplashscreen.Value == 100)
            {
                timer1.Stop();
                if (Utilities.IsConnectedToInternet())
                {
                    CreateDatabase();
                }
                else
                {
                    films = dataFromDatabase();
                }

                //display the frmFilms
                frmFilms frmfilms = new frmFilms();
                frmfilms.Show();

                //hide this form
                this.Hide();
            }

        }
        /// <summary>
        /// Read fro
        /// </summary>
        /// <returns></returns>
        private  List<Film> dataFromDatabase()
        {
            var Lesfilms = new List<Film>();

            using (sqlite_conn = new SQLiteConnection("Data Source=film.db"))
            {
                // open the connection:
                sqlite_conn.Open();

                string stm = "SELECT * FROM Film";
                sqlite_cmd = new SQLiteCommand(stm, sqlite_conn);
                sqlite_rdr = sqlite_cmd.ExecuteReader();
                while (sqlite_rdr.Read())
                {
                    Film MonFilm = new Film();
                    MonFilm.id = sqlite_rdr.GetInt32(0);
                    MonFilm.title = sqlite_rdr.GetString(1);
                    MonFilm.overview = sqlite_rdr.GetString(2);
                    MonFilm.original_language = sqlite_rdr.GetString(3);
                    MonFilm.release_date = sqlite_rdr.GetString(4);
                    MonFilm.vote_count = sqlite_rdr.GetInt32(5);
                    MonFilm.vote_average = sqlite_rdr.GetFloat(6);
                    MonFilm.popularity = sqlite_rdr.GetFloat(7);
                    byte[]imagee = (System.Byte[])sqlite_rdr[8];
                    MonFilm.poster_path = imagee.ToString();
                    Lesfilms.Add(MonFilm);
                }
            }
            return Lesfilms;
               
        }


        public class Utilities
        {
            private static string siteLink;
            public static List<Film> getMovieDbList(/*String address*/)
            {
                String reponse = "";
                List<Film> Films = null;
                siteLink = "https://api.themoviedb.org/3/movie/now_playing?api_key=a07e22bc18f5cb106bfe4cc1f83ad8ed";
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        reponse = webClient.DownloadString(siteLink);
                    }
                    //Console.WriteLine(retVal);
                    using (JsonDocument document = JsonDocument.Parse(reponse))
                    {
                        JsonElement root = document.RootElement;
                        JsonElement resultsList = root.GetProperty("results");
                        Films = JsonSerializer.Deserialize<List<Film>>(resultsList);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return Films;
            }

            public static bool IsConnectedToInternet()
            {
                string host = "www.google.com";
                bool result = false;
                Ping p = new Ping();
                try
                {
                    PingReply reply = p.Send(host, 3000);
                    if (reply.Status == IPStatus.Success)
                        return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return result;
            }
        }
    }
}
