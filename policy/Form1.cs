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
using policy.Models;

namespace policy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VN4O91E;Initial Catalog=policy;Integrated Security=True");
        public void KayitGetir()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PolicyInfo order by 1 desc", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime BegDate = Convert.ToDateTime(PolicyBegDate.Text);
            DateTime EndDate = Convert.ToDateTime(PolicyEndDate.Text);
            TimeSpan Sonuc = EndDate - BegDate;
            var totalDays = Convert.ToInt32(Sonuc.TotalDays);
            label13.Text = totalDays.ToString();
            label15.Text = PolicyBegDate.Value.ToString();
            int dailytotal = 0;
            int monthlytotal = 0;            
                
            if (Monthly.Checked)
            {
                int aylikpolice, taksitsayisi;
                aylikpolice = Convert.ToInt32(policyprice.Text);
                taksitsayisi = Convert.ToInt32(InstallmentNo.Text);
                monthlytotal = aylikpolice / taksitsayisi;
                label20.Text = monthlytotal +" TL";
            }
            else if (Daily.Checked)
            {
                int gunlukpolice;
                int gunsayisi = 365;
                gunlukpolice = Convert.ToInt32(policyprice.Text);
                dailytotal = (gunlukpolice / gunsayisi) * totalDays;
                label18.Text = dailytotal +" TL";

            }
            else
            {
                MessageBox.Show("Giriş yapılmadı.");
                return;

            }

            var allDates = new List<InstallmentInformationModel>();
            for (DateTime date = BegDate; date <= EndDate; date = date.AddMonths(1))
            {
                
                int days = DateTime.DaysInMonth(date.Year, date.Month);

                allDates.Add(new InstallmentInformationModel()
                {
                    Date = date.ToString("dd.MM.yyyy"),
                    Days = days,
                    Amount = monthlytotal > 0 ? monthlytotal : dailytotal

                });
            }

            allDates.Add(new InstallmentInformationModel()
            {
                Date = "Toplam :",
                Amount = allDates.Select(x => x.Amount).Sum(),
                Days= allDates.Select(x => x.Days).Sum()
            });




            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into PolicyInfo(ExpenseType,Cardname,CardLastName,DocNum,PolicyNum,PolicyBegDate,InstallmentNo,PolicyEndDate,Comments,Methodology,DailyPrice,MonthlyPrice) VALUES(@ExpenseType,@CardName,@CardLastName,@DocNum,@PolicyNum,@PolicyBegDate,@InstallmentNo,@PolicyEndDate,@Comments,@Methodology,@DailyPrice,@MonthlyPrice)", baglanti);
            cmd.Parameters.AddWithValue("@ExpenseType", ExpenseType.SelectedItem);
            cmd.Parameters.AddWithValue("@CardName", CardName.Text);
            cmd.Parameters.AddWithValue("@CardLastName", CardLastName.Text);
            cmd.Parameters.AddWithValue("@DocNum", DocNum.Text);
            cmd.Parameters.AddWithValue("@PolicyNum", PolicyNum.Text);
            cmd.Parameters.AddWithValue("@PolicyBegDate", PolicyBegDate.Value);
            cmd.Parameters.AddWithValue("@InstallmentNo", InstallmentNo.Text);
            cmd.Parameters.AddWithValue("@PolicyEndDate", PolicyEndDate.Value);
            cmd.Parameters.AddWithValue("@Comments", Comments.Text);
            cmd.Parameters.AddWithValue("@Methodology", Daily.Checked);
            cmd.Parameters.AddWithValue("@DailyPrice", dailytotal);
            cmd.Parameters.AddWithValue("@MonthlyPrice", monthlytotal);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            KayitGetir();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = allDates;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.policyInfoTableAdapter2.Fill(this.policyDataSet3.PolicyInfo);
            this.policyInfoTableAdapter1.Fill(this.policyDataSet1.PolicyInfo);
            this.policyInfoTableAdapter.Fill(this.policyDataSet.PolicyInfo);
            KayitGetir();
            dataGridView2.Visible = false;
            ExpenseType.Items.Add("Sigorta");
            ExpenseType.Items.Add("Kira");
            ExpenseType.Items.Add("Kasko");


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExpenseType.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            CardName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CardLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DocNum.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            PolicyNum.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            PolicyBegDate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            InstallmentNo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            PolicyEndDate.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Comments.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            label18.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            label20.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();


        }

        private void policyprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExpenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
