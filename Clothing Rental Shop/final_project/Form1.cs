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
    public partial class Form1 : Form
    {
        DataTable c_table;
        DataTable p_table;
        DataTable rv_table;
        DataTable r_table;
        DataTable rt_table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.PRODUCT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet11.PRODUCT);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.FillByAvailability(this.dataSet1.PRODUCT);
            customerTableAdapter1.Fill(dataSet1.CUSTOMER);
            pRODUCTTableAdapter.Fill(dataSet1.PRODUCT);
            rentaL_STATUSTableAdapter1.Fill(dataSet1.RENTAL_STATUS);
            reservationTableAdapter1.Fill(dataSet1.RESERVATION);
            reviewTableAdapter1.Fill(dataSet1.REVIEW);

            c_table = dataSet1.Tables["CUSTOMER"];
            p_table = dataSet1.Tables["PRODUCT"];
            rv_table = dataSet1.Tables["REVIEW"];
            r_table = dataSet1.Tables["RESERVATION"];
            rt_table = dataSet1.Tables["RENTAL_STATUS"];

            tbx_ID.Text = "M00001";
            tbx_password.Text = "M00001";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String password = "-1";

            DataRow[] foundRows = c_table.Select(string.Format("C_ID='{0}'", tbx_ID.Text));

            foreach (DataRow mydataRow in foundRows)
                password = mydataRow["C_PASSWORD"].ToString();

            if (password == "-1")
                MessageBox.Show("ID를 확인해주떼욤><");

            else if (password == tbx_password.Text)
            {
                MessageBox.Show("로귄 성공><");
                if (tbx_ID.Text.Substring(0, 1) == "C")
                {
                    Form2 customer_form = new Form2(tbx_ID.Text);
                    customer_form.Show();
                    //this.Hide();
                }
                else if (tbx_ID.Text.Substring(0, 1) == "E")
                {
                    Form3 employee_form = new Form3(tbx_ID.Text);
                    employee_form.Show();
                    //this.Hide();
                }
                else if (tbx_ID.Text.Substring(0, 1) == "M")
                {
                    Form4 manager_form = new Form4(tbx_ID.Text);
                    manager_form.Show();
                    //this.Hide();
                }

                //로그인 후
            }
            else
            {
                MessageBox.Show("패스워드를 확인해주떼욤><");
            }
        }
    }
}
