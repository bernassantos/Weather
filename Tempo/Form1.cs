using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Tempo
{
    public partial class Form1 : Form
    {
        public static string City;
        private static int Dia;
        public Form1()
        {
            InitializeComponent();
            City = "Castelo Branco";
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            var regions = Methods.GetRegion();
            var json = 0;

            foreach (var r in regions.Data.Where(r=>r.Local.Equals(City)))
            {
                json = r.GlobalIdLocal;
            }

            GetData(json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void alterarCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new CitiesList(this);
            
            form2.Show();
        }

        private void GetData(int city)
        {
            var weather = Methods.GetWeather(city);
            var regions = Methods.GetRegion();
            var wind = Methods.GetWindClass();
            var weatherType = Methods.GetWeatherType();
            var dayOfWeek = "";


            foreach (var r in regions.Data.Where(r => r.GlobalIdLocal == weather.GlobalIdLocal))
            {
                textBox4.Text = r.Local;
            }

            foreach (var w in wind.Data.Where(w=>w.ClassWindSpeed.Equals(weather.Data[Dia].classWindSpeed.ToString())))
            {
                textBox5.Text = w.DescClassWindSpeedDailyPt;
            }

            foreach (var wt in weatherType.Data.Where(wt=>wt.IdWeatherType == weather.Data[Dia].idWeatherType))
            {
                textBox6.Text = wt.DescIdWeatherTypePt;
            }

            var days =  weather.DataUpdate.AddDays(Dia);
            
            dayOfWeek = days.DayOfWeek switch
            {
                DayOfWeek.Monday => "Segunda-Feira",
                DayOfWeek.Tuesday => "Terça-feira",
                DayOfWeek.Wednesday => "Quarta-Feira",
                DayOfWeek.Thursday => "Quinta-Feira",
                DayOfWeek.Friday => "Sexta-Feira",
                DayOfWeek.Saturday => "Sábado",
                DayOfWeek.Sunday => "Domingo",
                _ => dayOfWeek
            };
            
            diasToolStripMenuItem.Text = weather.DataUpdate.AddDays(2).DayOfWeek.ToString();
            diasToolStripMenuItem1.Text = weather.DataUpdate.AddDays(3).DayOfWeek.ToString();
            ºDiaToolStripMenuItem.Text = weather.DataUpdate.AddDays(4).DayOfWeek.ToString();

            label1.Text = Dia switch
            {
                0 => "Hoje - " + dayOfWeek,
                1 => "Amanhã - " + dayOfWeek,
                2 => dayOfWeek,
                3 => dayOfWeek,
                4 => dayOfWeek,
                _ => "Erro",
            };

            textBox1.Text = weather.Data[Dia].tMax;
            textBox2.Text = weather.Data[Dia].tMin;
            textBox3.Text = weather.DataUpdate.AddHours(1).ToString(CultureInfo.InvariantCulture);
            textBox7.Text = weather.Data[Dia].predWindDir;

            pictureBox1.Image = weather.Data[Dia].idWeatherType switch
            {
                1 => Image.FromFile("sun.png"),
                2 => Image.FromFile("cloud_sun.png"),
                3 => Image.FromFile("cloud_sun.png"),
                4 => Image.FromFile("cloud.png"),
                9 => Image.FromFile("cloud_rain.png"),
                15 => Image.FromFile("rain_drops.png"),
                18 => Image.FromFile("cloud_snow.png"),
                27 => Image.FromFile("cloud.png"),
                _ => pictureBox1.Image
            };
            
        }

        private void hojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dia = 0;
            Form1_Load(sender, e);
        }

        private void amanhãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dia = 1;
            Form1_Load(sender, e);
        }
        
        private void diasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dia = 2;
            Form1_Load(sender, e);
        }

        private void diasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dia = 3;
            Form1_Load(sender, e);
        }

        private void ºDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dia = 4;
            Form1_Load(sender, e);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}