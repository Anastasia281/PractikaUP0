using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractikaAbonents
{
    public partial class CRM : Form
    {
        public CRM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            УправОборуд управОборуд = new УправОборуд();
            управОборуд.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Биллинг биллинг = new Биллинг();
            биллинг.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Активы активы = new Активы();
            активы.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ПоддерПользов поддерПользов = new ПоддерПользов();
            поддерПользов.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Главная главнаяАбоненты = new Главная();
            главнаяАбоненты.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
