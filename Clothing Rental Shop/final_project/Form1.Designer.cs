namespace final_project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new final_project.DataSet1();
            this.customerTableAdapter1 = new final_project.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.rentaL_STATUSTableAdapter1 = new final_project.DataSet1TableAdapters.RENTAL_STATUSTableAdapter();
            this.reservationTableAdapter1 = new final_project.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.reviewTableAdapter1 = new final_project.DataSet1TableAdapters.REVIEWTableAdapter();
            this.btn_login = new System.Windows.Forms.Button();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new final_project.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTableAdapter2 = new final_project.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.pRODUCTTableAdapter = new final_project.DataSet1TableAdapters.PRODUCTTableAdapter();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCONDITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSIZEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECEIVINGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENTALPERIODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAVAILABILITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // rentaL_STATUSTableAdapter1
            // 
            this.rentaL_STATUSTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // reviewTableAdapter1
            // 
            this.reviewTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(899, 60);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(737, 60);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(153, 21);
            this.tbx_password.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(662, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(494, 59);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(160, 21);
            this.tbx_ID.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pTYPEDataGridViewTextBoxColumn,
            this.pLOCATIONDataGridViewTextBoxColumn,
            this.pFEEDataGridViewTextBoxColumn,
            this.pCONDITIONDataGridViewTextBoxColumn,
            this.pSIZEDataGridViewTextBoxColumn,
            this.pCOLORDataGridViewTextBoxColumn,
            this.pRECEIVINGDATEDataGridViewTextBoxColumn,
            this.pRENTALPERIODDataGridViewTextBoxColumn,
            this.pAVAILABILITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(979, 560);
            this.dataGridView1.TabIndex = 0;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(349, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "대여 가능 용품 현황";
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "물품 번호";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // pTYPEDataGridViewTextBoxColumn
            // 
            this.pTYPEDataGridViewTextBoxColumn.DataPropertyName = "P_TYPE";
            this.pTYPEDataGridViewTextBoxColumn.HeaderText = "물품 종류";
            this.pTYPEDataGridViewTextBoxColumn.Name = "pTYPEDataGridViewTextBoxColumn";
            // 
            // pLOCATIONDataGridViewTextBoxColumn
            // 
            this.pLOCATIONDataGridViewTextBoxColumn.DataPropertyName = "P_LOCATION";
            this.pLOCATIONDataGridViewTextBoxColumn.HeaderText = "위치";
            this.pLOCATIONDataGridViewTextBoxColumn.Name = "pLOCATIONDataGridViewTextBoxColumn";
            // 
            // pFEEDataGridViewTextBoxColumn
            // 
            this.pFEEDataGridViewTextBoxColumn.DataPropertyName = "P_FEE";
            this.pFEEDataGridViewTextBoxColumn.HeaderText = "대여료";
            this.pFEEDataGridViewTextBoxColumn.Name = "pFEEDataGridViewTextBoxColumn";
            // 
            // pCONDITIONDataGridViewTextBoxColumn
            // 
            this.pCONDITIONDataGridViewTextBoxColumn.DataPropertyName = "P_CONDITION";
            this.pCONDITIONDataGridViewTextBoxColumn.HeaderText = "물품 상태";
            this.pCONDITIONDataGridViewTextBoxColumn.Name = "pCONDITIONDataGridViewTextBoxColumn";
            // 
            // pSIZEDataGridViewTextBoxColumn
            // 
            this.pSIZEDataGridViewTextBoxColumn.DataPropertyName = "P_SIZE";
            this.pSIZEDataGridViewTextBoxColumn.HeaderText = "사이즈";
            this.pSIZEDataGridViewTextBoxColumn.Name = "pSIZEDataGridViewTextBoxColumn";
            // 
            // pCOLORDataGridViewTextBoxColumn
            // 
            this.pCOLORDataGridViewTextBoxColumn.DataPropertyName = "P_COLOR";
            this.pCOLORDataGridViewTextBoxColumn.HeaderText = "색상";
            this.pCOLORDataGridViewTextBoxColumn.Name = "pCOLORDataGridViewTextBoxColumn";
            // 
            // pRECEIVINGDATEDataGridViewTextBoxColumn
            // 
            this.pRECEIVINGDATEDataGridViewTextBoxColumn.DataPropertyName = "P_RECEIVINGDATE";
            this.pRECEIVINGDATEDataGridViewTextBoxColumn.HeaderText = "입고일";
            this.pRECEIVINGDATEDataGridViewTextBoxColumn.Name = "pRECEIVINGDATEDataGridViewTextBoxColumn";
            // 
            // pRENTALPERIODDataGridViewTextBoxColumn
            // 
            this.pRENTALPERIODDataGridViewTextBoxColumn.DataPropertyName = "P_RENTALPERIOD";
            this.pRENTALPERIODDataGridViewTextBoxColumn.HeaderText = "대여 기간";
            this.pRENTALPERIODDataGridViewTextBoxColumn.Name = "pRENTALPERIODDataGridViewTextBoxColumn";
            // 
            // pAVAILABILITYDataGridViewTextBoxColumn
            // 
            this.pAVAILABILITYDataGridViewTextBoxColumn.DataPropertyName = "P_AVAILABILITY";
            this.pAVAILABILITYDataGridViewTextBoxColumn.HeaderText = "대여 가능 여부";
            this.pAVAILABILITYDataGridViewTextBoxColumn.Name = "pAVAILABILITYDataGridViewTextBoxColumn";
            this.pAVAILABILITYDataGridViewTextBoxColumn.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private DataSet1TableAdapters.RENTAL_STATUSTableAdapter rentaL_STATUSTableAdapter1;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREATALPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter2;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private DataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCONDITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSIZEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECEIVINGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENTALPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAVAILABILITYDataGridViewTextBoxColumn;
    }
}

