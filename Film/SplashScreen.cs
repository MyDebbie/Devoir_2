using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        //private SqliteConnection sql_con;
        //private SqliteCommand sql_cmd;
        //private SQLiteDataAdapter DB;
        //private DataSet DS = new DataSet();
        //private DataTable DT = new DataTable();

        SqliteConnection sqlite_conn;
        SqliteCommand sqlite_cmd;
        SqliteDataReader sqlite_datareader;



        public SplashScreen()
        {
            InitializeComponent();
        }


        //Use timer class
        Timer timer;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            timer = new Timer();

            //set time interval 3 sec
            timer.Interval = 3000;

            //starts the timer
            timer.Start();
            timer.Tick += timer_Tick;

            if(Utilities.IsConnectedToInternet())
            {
               


            }
        }
        
        

        private void timer_Tick(object sender, EventArgs e)
        {
            pbSplashscreen.Increment(1);
            if(pbSplashscreen.Value == 200)
            {
                //after 3 sec stop the timer
                timer.Stop();

                //display the frmFilms
                frmFilms frmfilms = new frmFilms();
                frmfilms.Show();

                //hide this form

                this.Hide();
            }
            
        }
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
