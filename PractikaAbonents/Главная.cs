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

namespace PractikaAbonents
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        string conn = @"Data Source=LAPTOP-1SF0COUQ\SQLEXPRESS;Initial Catalog=ПровайдерПрактика;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "провайдерПрактикаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.провайдерПрактикаDataSet.Сотрудники);
            string zapros = "SELECT НомерАбонента, ФИО FROM Абоненты";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(zapros, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            УправОборуд управОборуд = new УправОборуд();
            управОборуд.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Биллинг биллинг = new Биллинг();
            биллинг.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Активы активы = new Активы();
            активы.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ПоддерПользов поддерПользов = new ПоддерПользов();
            поддерПользов.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false; 
            button6.Enabled = false;
            button7.Enabled = false;
            if (comboBox1.SelectedValue.ToString() == "1")
            {
                button4.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }
            if (comboBox1.SelectedValue.ToString() == "2")
            {
                button6.Enabled = true;
                button7.Enabled = true;
            }
            if (comboBox1.SelectedValue.ToString() == "3" || comboBox1.SelectedValue.ToString() == "4")
            {
                button2.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }
            if (comboBox1.SelectedValue.ToString() == "5")
            {

                button3.Enabled = true;
                button4.Enabled = true;
                button7.Enabled = true;
            }
            if (comboBox1.SelectedValue.ToString() == "6")
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }
            if (comboBox1.SelectedValue.ToString() == "6")
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
            }
            //string zapros = "SELECT * FROM Сотрудники";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(zapros, connection);
                //DataSet dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);
                //for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                //{
                //    DateTime time = Convert.ToDateTime(dataSet.Tables[0].Rows[i][3].ToString());
                //    if (time.Equals("0:00")) listView1.Items.Add(dataSet.Tables[0].Rows[i][4].ToString());
                //    else listView1.Items.Add(time.ToShortTimeString() + " \n" + dataSet.Tables[0].Rows[i][4].ToString());
                //}
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
