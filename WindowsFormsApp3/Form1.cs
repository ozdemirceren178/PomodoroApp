using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int timeLeft;
        private bool veriEklendi = false;
        private DateTime baslangicZamani;
        private DateTime bitisZamani;
        public int sum;
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000; // 1 saniyede bir kontrol et
            timer2.Tick += timer2_Tick_1;
            timer2.Start();
        }
        sglbaglanti bgl = new sglbaglanti();
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpomodoro_Click(object sender, EventArgs e)
        {
            this.timeLeft = 25 * 60;
            lblminute.Text = (this.timeLeft / 60).ToString("00");
            lblsaniye.Text = (this.timeLeft % 60).ToString("00");
             //başlatmak gerek
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeLeft--;
            if (this.timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show(" Süren Dolduu");
            }
            else
            {
                lblminute.Text = (this.timeLeft / 60).ToString("00");
                lblsaniye.Text = (this.timeLeft % 60).ToString("00");
            }
            
        }

        
        private void btnstart_Click(object sender, EventArgs e)
        {
            baslangicZamani = DateTime.Now;
            string taskName = txtTaskName.Text.Trim();
            timer1.Start();
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Lütfen Pomodoro'ya bir ad verin!");
                return;
            }
            SqlCommand komut = new SqlCommand("INSERT INTO pomodorolog (taskName, startTime) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", taskName);
            komut.Parameters.AddWithValue("@p2", DateTime.Now);
            komut.ExecuteNonQuery();
            MessageBox.Show("Pomodro Başladı");
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            bitisZamani = DateTime.Now;

            TimeSpan fark = bitisZamani - baslangicZamani; // İki saat arasındaki fark

            int gecenDakika = (int)fark.TotalMinutes;
            
            sum = sum + gecenDakika;

            timer1.Stop();
            SqlCommand komut = new SqlCommand(" UPDATE pomodorolog SET endTime=@p1 , duration=DATEDIFF(Minute, StartTime, @p1) where endTime is NULL", bgl.baglanti());
            DateTime endTime = DateTime.Now;
            komut.Parameters.AddWithValue("@p1", endTime);
            komut.ExecuteNonQuery();
            MessageBox.Show(" Pomodro Tamamlandı");
        }

        private void btnlongb_Click(object sender, EventArgs e)
        {

            this.timeLeft = 15 * 60;
            lblminute.Text = (this.timeLeft / 60).ToString("00");
            lblsaniye.Text = (this.timeLeft % 60).ToString("00");
        }

        private void btnshortb_Click(object sender, EventArgs e)
        {

            this.timeLeft = 5 * 60;
            lblminute.Text = (this.timeLeft / 60).ToString("00");
            lblsaniye.Text = (this.timeLeft % 60).ToString("00");
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
          // this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.WindowState = FormWindowState.Minimized;


        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            int saat = simdi.Hour;
            int dakika = simdi.Minute;

            if (saat == 23 && dakika == 59  && !veriEklendi)
            {
                DateTime bugun = DateTime.Now.Date;

                using (SqlConnection conn = bgl.baglanti())
                {
                    using (SqlCommand komut = new SqlCommand("INSERT INTO TblBilgi (Date, Saat) VALUES (@tarih, @saat)", conn))
                    {
                        komut.Parameters.AddWithValue("@tarih", bugun);
                        komut.Parameters.AddWithValue("@saat", sum);
                        komut.ExecuteNonQuery();
                    }
                }

                veriEklendi = true; // Aynı gün tekrar ekleme yapmasın
                sum = 0;
            }

            // Gün değişirse tekrar ekleme yapılabilir
            if (saat == 0 && dakika == 0)
            {
                veriEklendi = false;
            }
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            istatistikler_formu frm = new istatistikler_formu();
            frm.Show();
        }
    }
}
