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
    public partial class Form4 : Form
    {
        String ID;

        public Form4(String ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.TYPE_WEEKLY_RENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.tYPE_WEEKLY_RENTALTableAdapter.Fill(this.dataSet11.TYPE_WEEKLY_RENTAL);
            // TODO: 이 코드는 데이터를 'dataSet11.TYPE_TODAY_RENTAL' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.tYPE_TODAY_RENTALTableAdapter.Fill(this.dataSet11.TYPE_TODAY_RENTAL);
            // TODO: 이 코드는 데이터를 'dataSet1.MONTHLY_HOT_PRODUCT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.mONTHLY_HOT_PRODUCTTableAdapter.Fill(this.dataSet1.MONTHLY_HOT_PRODUCT);
            // TODO: 이 코드는 데이터를 'dataSet1.WEEKLY_HOT_PRODUCT' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.wEEKLY_HOT_PRODUCTTableAdapter.Fill(this.dataSet1.WEEKLY_HOT_PRODUCT);
            // TODO: 이 코드는 데이터를 'dataSet1.RENTAL_STATUS' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTAL_STATUSTableAdapter.Fill(this.dataSet1.RENTAL_STATUS);

            this.productTableAdapter2.Fill(this.dataSet11.PRODUCT);
            this.customerTableAdapter1.Fill(this.dataSet11.CUSTOMER);
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.AddNew();
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTBindingSource.EndEdit();
                int ret = this.productTableAdapter2.Update(this.dataSet11.PRODUCT);

                if (ret > 0)
                    MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            pRODUCTBindingSource.RemoveCurrent();

            try
            {
                this.pRODUCTBindingSource.EndEdit();
                int ret = this.productTableAdapter2.Update(this.dataSet11.PRODUCT);

                if (ret > 0)
                    MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btn_c_enter_Click(object sender, EventArgs e)
        {
            cUSTOMERBindingSource.AddNew();
        }

        private void btn_c_revise_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUSTOMERBindingSource.EndEdit();
                int ret = this.customerTableAdapter1.Update(this.dataSet11.CUSTOMER);

                if (ret > 0)
                    MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btn_c_remove_Click(object sender, EventArgs e)
        {
            cUSTOMERBindingSource.RemoveCurrent();

            try
            {
                this.cUSTOMERBindingSource.EndEdit();
                int ret = this.customerTableAdapter1.Update(this.dataSet11.CUSTOMER);

                if (ret > 0)
                    MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
