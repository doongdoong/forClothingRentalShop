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
    public partial class Form2 : Form
    {
        String ID;
        String pID;
        String type;
        String fee1;
        String fee2;
        String color;
        String size;
        
        int fee_index;

        DataTable c_table;
        DataTable p_table;
        DataTable rv_table;
        DataTable r_table;
        DataTable rt_table;

        public Form2(String ID)
        {
            InitializeComponent();

            this.ID = ID;
            pID = "-1";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet12.PRODUCT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet12.PRODUCT);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTTableAdapter.Fill(this.dataSet1.PRODUCT);
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

            DataRow[] foundRows = p_table.Select("");

            lbx_pID.Items.Clear();

            foreach (DataRow mydataRow in foundRows)
            {
                lbx_pID.Items.Add(mydataRow["P_ID"]);
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            DataRow[] foundRows = rv_table.Select(string.Format("p_ID='{0}'", tbx_pID.Text));

            lbx_review.Items.Clear();

            foreach (DataRow mydataRow in foundRows)
            {
                lbx_review.Items.Add(mydataRow["RV_NO"] + " " + mydataRow["P_ID"] + " " + mydataRow["C_ID"] + " " + mydataRow["RV_TITLE"]);
            }

            tbx_pID.Clear();
        }

        private void lbx_review_SelectedIndexChanged(object sender, EventArgs e)
        {
            String rv_id = lbx_review.SelectedItem.ToString().Substring(0, 1);
            String p_id = lbx_review.SelectedItem.ToString().Substring(2, 7);

            DataRow[] foundRows = rv_table.Select(string.Format("RV_NO='{0}' AND P_ID='{1}'", rv_id, p_id));

            foreach (DataRow mydataRow in foundRows)
            {
                tbx_title.Text = mydataRow["RV_TITLE"].ToString();
                tbx_contents.Text = mydataRow["RV_CONTENTS"].ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pID != "-1")
            {
                oracleConnection1.Open();
                oracleCommand1.Connection = oracleConnection1;
                oracleCommand1.CommandText = "INSERT INTO REVIEW (RV_NO, C_ID, P_ID, RV_TITLE, RV_CONTENTS) VALUES (RV_NO_SEQ.nextval, :aa, :bb, :cc, :dd)";

                oracleCommand1.Parameters["aa"].Value = ID;
                oracleCommand1.Parameters["bb"].Value = pID;
                oracleCommand1.Parameters["cc"].Value = tbx_title2.Text;
                oracleCommand1.Parameters["dd"].Value = tbx_contents2.Text;

                if (oracleCommand1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("리뷰 작성 성공><");
                    reviewTableAdapter1.Fill(dataSet1.REVIEW);
                }
                else
                {
                    MessageBox.Show("리뷰 작성 실패ㅠㅠ");
                }
            }
            else
            {
                MessageBox.Show("물품을 선택해주떼욤~ >< 삉삉");
            }

            oracleConnection1.Close();
        }

        private void lbx_pID_SelectedIndexChanged(object sender, EventArgs e)
        {
            pID = lbx_pID.SelectedItem.ToString();
        }

        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = cbx_type.SelectedItem.ToString();
            //MessageBox.Show(type);
        }

        private void cbx_fee_SelectedIndexChanged(object sender, EventArgs e)
        {
            fee_index = cbx_fee.SelectedIndex;

            //MessageBox.Show(fee_index + "");

            if (fee_index == 0 || fee_index == 5)
            {
                String fee = cbx_fee.SelectedItem.ToString();
                fee1 = fee.Substring(0, 4);
                //MessageBox.Show(fee1);
            }
            else
            {
                String fee = cbx_fee.SelectedItem.ToString();
                fee1 = fee.Substring(0, 4);
                fee2 = fee.Substring(9, 4);

                //MessageBox.Show(fee1 + " " + fee2);
            }
        }

        private void cbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = cbx_color.SelectedItem.ToString();
            //MessageBox.Show(color);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            size = tbx_size.Text;
            //MessageBox.Show(size);

            if (cbx_type.SelectedItem == null || cbx_fee.SelectedItem == null || cbx_color.SelectedItem == null || tbx_size.Text == "")
            {
                MessageBox.Show("검색에 필요한 모든 데이터를 입력하세요.\n");
            }
            else{
                if (pRODUCTBindingSource.Filter != null)
            {
                pRODUCTBindingSource.RemoveFilter();
            }

            if (fee_index == 0)
                pRODUCTBindingSource.Filter = "P_TYPE = '" + type + "' AND P_FEE < " + int.Parse(fee1) + " AND P_COLOR = '" + color + "' AND P_SIZE = '" + size + "'";
            else if (fee_index == 5)
                pRODUCTBindingSource.Filter = "P_TYPE = '" + type + "' AND P_FEE >= " + int.Parse(fee1) + " AND P_COLOR = '" + color + "' AND P_SIZE = '" + size + "'";
            else
                pRODUCTBindingSource.Filter = "P_TYPE = '" + type + "' AND P_FEE >= " + int.Parse(fee1) + " AND P_FEE < " + int.Parse(fee2) + " AND P_COLOR = '" + color + "' AND P_SIZE = '" + size + "'";
            }
            

            type = "";
            fee1 = "";
            fee2 = "";
            color = "";
            size = "";
            fee_index = 0;

            tbx_size.Text = "";

            try {
                cbx_type.SelectedItem = null;   
            }
            catch(Exception E)
            {
            }

            try
            {
                cbx_fee.SelectedItem = null;
            }
            catch (Exception E)
            {
            }

            try
            {
                cbx_color.SelectedItem = null;
            }
            catch (Exception E)
            {
            }
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            DataRow foundRow2 = c_table.Rows.Find(ID);
            String blacklist = foundRow2["C_BLACKLIST"].ToString();
            

            if (tbx_rental_pID.Text == "")
            {
                MessageBox.Show("물품 번호를 입력하세요");
            }

            else
            {
                DataRow foundRow = p_table.Rows.Find(tbx_rental_pID.Text);

                if (foundRow == null)
                {
                    MessageBox.Show("존재하지 않는 물품 번호입니다.");
                }

                else if (blacklist == "true" &&  foundRow["P_CONDITION"].ToString() == "good")
                {
                    MessageBox.Show("고객님은 해당 상품(좋은 상태 제품)을 대여할 수 없습니다.");
                }

                else
                {

                    DataRow[] foundRows = r_table.Select(string.Format("P_ID='{0}'", tbx_rental_pID.Text));

                    int check = 0;

                    foreach (DataRow mydataRow in foundRows)
                    {
                        check = 1;
                    }

                    //예약이 없을 때
                    if (check == 0)
                    {

                        DataRow myNewDataRow = r_table.NewRow();
                        myNewDataRow["R_NO"] = "1";
                        myNewDataRow["C_ID"] = ID;
                        myNewDataRow["P_ID"] = tbx_rental_pID.Text;

                        DataRow temp = p_table.Rows.Find(tbx_rental_pID.Text);
                        String deposit = temp["P_FEE"].ToString();
                        
                        Form5 deposit_form = new Form5(deposit);
                        deposit_form.ShowDialog();

                        myNewDataRow["R_DEPOSIT"] = deposit;

                        r_table.Rows.Add(myNewDataRow);

                        int numOfRows = reservationTableAdapter1.Update(dataSet1.RESERVATION);

                        if (numOfRows < 1)
                            MessageBox.Show("예약 실패");
                        else
                            MessageBox.Show("예약 성공");
                    }
                    //예약이 있을 때
                    else
                    {
                        int maxR_NO = 1;

                        foreach (DataRow mydataRow in foundRows)
                        {
                            if (int.Parse(mydataRow["R_NO"].ToString()) > maxR_NO)
                            {
                                maxR_NO = int.Parse(mydataRow["R_NO"].ToString());
                            }
                        }

                        DataRow myNewDataRow = r_table.NewRow();
                        myNewDataRow["R_NO"] = (maxR_NO + 1).ToString();
                        myNewDataRow["C_ID"] = ID;
                        myNewDataRow["P_ID"] = tbx_rental_pID.Text;

                        DataRow temp = p_table.Rows.Find(tbx_rental_pID.Text);
                        String deposit = temp["P_FEE"].ToString();

                        Form5 deposit_form = new Form5(deposit);
                        deposit_form.ShowDialog();

                        myNewDataRow["R_DEPOSIT"] = deposit;

                        r_table.Rows.Add(myNewDataRow);

                        int numOfRows = reservationTableAdapter1.Update(dataSet1.RESERVATION);

                        if (numOfRows < 1)
                            MessageBox.Show("예약 실패");
                        else
                            MessageBox.Show("예약 성공");
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_rental_pID.Text = this.dataGridView1.Rows[this.dataGridView1.CurrentCellAddress.Y].Cells[0].Value.ToString();
        }
    }
}
