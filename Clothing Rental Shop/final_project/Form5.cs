using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form5 : Form
    {
        String deposit;

        public Form5(String deposit)
        {
            InitializeComponent();
            this.deposit = deposit;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "입금액은 " + deposit + "원입니다.";
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (tbx_deposit.Text != deposit)
            {
                MessageBox.Show("입금액이 잘못되었습니다.");
            }
            else
            {
                MessageBox.Show("입금되었습니다.");
                this.Close();
            }
        }
    }
}
