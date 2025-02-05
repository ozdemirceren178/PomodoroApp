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
    public partial class istatistikler_formu : Form
    {
        public istatistikler_formu()
        {
            InitializeComponent();
        }
        sglbaglanti bgl = new sglbaglanti();


        private void istatistikler_formu_Load(object sender, EventArgs e)
        {
            // Eğer "calısmalar" adlı seri yoksa oluştur
            if (!chart1.Series.Any(s => s.Name == "Günlük Çalışma"))
            {
                chart1.Series.Add("Günlük Çalışma");
                chart1.Series["Günlük Çalışma"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Bar chart
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                using (SqlCommand komutg1 = new SqlCommand("SELECT Date, SUM(Saat) FROM TblBilgi GROUP BY Date", conn))
                {
                    using (SqlDataReader dr1 = komutg1.ExecuteReader())
                    {
                        while (dr1.Read())
                        {
                            chart1.Series["Günlük Çalışma"].Points.AddXY(dr1[0].ToString(), Convert.ToInt32(dr1[1]));
                        }
                    }
                }
            }
        }

    }
}
