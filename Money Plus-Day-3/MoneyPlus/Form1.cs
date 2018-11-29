using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);

            Dollar dollar1 = new Dollar(n1);
            Dollar dollar2 = new Dollar(n2);
            Dollar totaldallars = new Dollar(0);
            totaldallars = dollar1 + dollar2;
            string msg = dollar1.ToString() + "+" + dollar2.ToString();
            msg = msg + "=" + totaldallars.ToString();
            MessageBox.Show(msg, "新台幣計算");
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        class Dollar
        {
            private int dollars;
            public Dollar(int n)
            {
                this.dollars = n;

            }
            private int GetDollars()
            {
                if (dollars <= 0)
                {
                    return 0;
                }
                else
                {
                    return dollars;
                }
            }
            public static Dollar operator+(Dollar N, Dollar M)
            {
                return new Dollar(N.GetDollars() + M.GetDollars());
            }
            public override string ToString()
            {
                return this.dollars.ToString() + "元";
            }
        }
    }
}
