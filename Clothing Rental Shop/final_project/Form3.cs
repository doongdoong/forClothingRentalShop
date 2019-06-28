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
    public partial class Form3 : Form
    {
        String ID;
        String rNO;
        String cID;
        String pID;
        String rtNO;

        DataTable c_table;
        DataTable p_table;
        DataTable rv_table;
        DataTable r_table;
        DataTable rt_table;

        public Form3(String ID)
        {
            InitializeComponent();

            this.ID = ID;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.RENTAL_STATUS' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTAL_STATUSTableAdapter.Fill(this.dataSet11.RENTAL_STATUS);
            this.productTableAdapter1.Fill(this.dataSet11.PRODUCT);
            customerTableAdapter1.Fill(dataSet11.CUSTOMER);
            productTableAdapter1.Fill(dataSet11.PRODUCT);
            rENTAL_STATUSTableAdapter.Fill(dataSet11.RENTAL_STATUS);

            reservationTableAdapter1.Fill(dataSet11.RESERVATION);
            reviewTableAdapter1.Fill(dataSet11.REVIEW);

            c_table = dataSet11.Tables["CUSTOMER"];
            p_table = dataSet11.Tables["PRODUCT"];
            rv_table = dataSet11.Tables["REVIEW"];
            r_table = dataSet11.Tables["RESERVATION"];
            rt_table = dataSet11.Tables["RENTAL_STATUS"];
        }

        private void btn_approval_Click(object sender, EventArgs e)
        {
            if (rNO == null && cID == null && pID == null)
            {
                MessageBox.Show("대여를 승인하고자 하는 물품을 선택하세요.");
            }
            else
            {
                DataRow myDataRow = p_table.Rows.Find(pID);

                if (myDataRow["P_AVAILABILITY"] == "대여불가")
                {
                    MessageBox.Show("물품이 대여 중입니다.");
                }
                else if(rNO != "1")
                {
                    MessageBox.Show("예약번호 1번을 승인하세요");
                }
                else
                {
                    //예약 테이블에서 삭제 및 예약 번호 당기기

                    rESERVATIONBindingSource.RemoveCurrent();

                    DataRow[] foundRows = r_table.Select(string.Format("P_ID='{0}'", pID), "R_NO ASC");


                    foreach (DataRow mydataRow in foundRows)
                    {
                        mydataRow["R_NO"] = int.Parse(mydataRow["R_NO"].ToString()) - 1;
                    }

                    rESERVATIONBindingSource.EndEdit();

                    int numOfRows = reservationTableAdapter1.Update(this.dataSet11.RESERVATION);

                    if (numOfRows < 1)
                        MessageBox.Show("대여 승인 실패");
                    else
                        MessageBox.Show("대여 승인 성공");

                    //프로덕트 테이블에서 대여가능->대여불가

                    DataRow foundRow = p_table.Rows.Find(pID);

                    foundRow["P_AVAILABILITY"] = "대여불가";

                    pRODUCTBindingSource.EndEdit();
                    productTableAdapter1.Update(this.dataSet11.PRODUCT);

                    //대여 테이블 추가
                    //"INSERT INTO RENTAL_STATUS (RT_NO, C_ID, P_ID, RT_RENTALDATE, RT_RETURNDUEDATE) VALUES (RT_NO_SEQ.nextval, cID, pID, ~~, ~~)"
                    oracleConnection1.Open();
                    oracleCommand1.Connection = oracleConnection1;
                    oracleCommand2.Connection = oracleConnection1;
                    oracleCommand1.CommandText = "SELECT RT_NO_SEQ.nextval FROM DUAL";

                    DataRow mynewDataRow = rt_table.NewRow();
                    
                    //시퀀스로 넣기/////////////////////////////////////////////////////////////////////
                    mynewDataRow["RT_NO"] = oracleCommand1.ExecuteScalar();

                    if (mynewDataRow["RT_NO"].ToString() == "100")
                        MessageBox.Show("100번째 대여 고객입니다. 축하드려용~ 뽀뽀해드릴께욤><");

                    mynewDataRow["C_ID"] = cID;
                    mynewDataRow["P_ID"] = pID;

                    //오라클커맨드만들고 던져서 날짜 넣기
                    mynewDataRow["RT_RENTALDATE"] = Convert.ToDateTime(oracleCommand2.ExecuteScalar()).ToString("yy/MM/dd");

                    //실제 날짜에 프로덕트 테이블의 대여기간(P_RENTALPERIOD) 가져와서 더하기(AddDays(P_RENTALPERIOD))
                    DataRow datarow = p_table.Rows.Find(pID);
                    mynewDataRow["RT_RETURNDUEDATE"] = Convert.ToDateTime(oracleCommand2.ExecuteScalar()).AddDays(Convert.ToDouble(datarow["P_RENTALPERIOD"])).ToString("yy/MM/dd");
                    mynewDataRow["RT_EMPLOYEE"] = ID;
                    rt_table.Rows.Add(mynewDataRow);

                    rENTALSTATUSBindingSource.EndEdit();




                    numOfRows = rENTAL_STATUSTableAdapter.Update(dataSet11.RENTAL_STATUS);

                    if (numOfRows < 1)
                        MessageBox.Show("디비쓰기 실패");
                    else
                        MessageBox.Show("디비쓰기 성공");


                    oracleConnection1.Close();

                    rNO = null;
                    cID = null;
                    pID = null;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rNO = this.dataGridView2.Rows[this.dataGridView2.CurrentCellAddress.Y].Cells[0].Value.ToString();
            cID = this.dataGridView2.Rows[this.dataGridView2.CurrentCellAddress.Y].Cells[1].Value.ToString();
            pID = this.dataGridView2.Rows[this.dataGridView2.CurrentCellAddress.Y].Cells[2].Value.ToString();
        }

        private void btn_return_Click_1(object sender, EventArgs e)
        {
            if (rtNO == null && pID == null)
            {
                MessageBox.Show("반납을 승인하고자 하는 물품을 선택하세요.");
            }
            else
            {
                DataRow foundRow = p_table.Rows.Find(pID);

                foundRow["P_AVAILABILITY"] = "대여가능";

                pRODUCTBindingSource.EndEdit();
                productTableAdapter1.Update(this.dataSet11.PRODUCT);

                //오라클 커맨드로 실제 반납일 넣고 벌금있으면 넣는다.
                oracleConnection1.Open();
                oracleCommand2.Connection = oracleConnection1;

                DateTime actual_return_date = Convert.ToDateTime(oracleCommand2.ExecuteScalar());
                String actual_return_date_s = Convert.ToDateTime(oracleCommand2.ExecuteScalar()).ToString("yy/MM/dd");

                DataRow datarow = rt_table.Rows.Find(rtNO);

                DateTime return_due_date = Convert.ToDateTime(datarow["RT_RETURNDUEDATE"]);
                String return_due_date_s = Convert.ToDateTime(datarow["RT_RETURNDUEDATE"]).ToString("yy/MM/dd");

                datarow["RT_ACTUALRETURNDATE"] = actual_return_date_s;

                TimeSpan diff_date = actual_return_date - return_due_date;

                if (Convert.ToDouble(diff_date.Days) < 0)
                {
                    datarow["RT_FEE"] = "0";
                }
                else {
                    datarow["RT_FEE"] = ((Convert.ToDouble(diff_date.Days)) * 500).ToString();
                }

                int numOfRows = rENTAL_STATUSTableAdapter.Update(dataSet11.RENTAL_STATUS);

                if (numOfRows < 1)
                    MessageBox.Show("디비쓰기 실패");
                else
                    MessageBox.Show("디비쓰기 성공");

                oracleConnection1.Close();
            }

            rtNO = null;
            pID = null;
        }

        private void dataGridView4_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rtNO = this.dataGridView4.Rows[this.dataGridView4.CurrentCellAddress.Y].Cells[0].Value.ToString();
            pID = this.dataGridView4.Rows[this.dataGridView4.CurrentCellAddress.Y].Cells[2].Value.ToString();
        }
    }
}
