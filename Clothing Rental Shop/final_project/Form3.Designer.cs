namespace final_project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Oracle.DataAccess.Client.OracleParameter oracleParameter5 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter6 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter7 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter8 = new Oracle.DataAccess.Client.OracleParameter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_approval = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.R_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_return = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.rNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new final_project.DataSet1();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCONDITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSIZEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECEIVINGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAVAILABILITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new final_project.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.productTableAdapter1 = new final_project.DataSet1TableAdapters.PRODUCTTableAdapter();
            this.reservationTableAdapter1 = new final_project.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.reviewTableAdapter1 = new final_project.DataSet1TableAdapters.REVIEWTableAdapter();
            this.rENTALSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTAL_STATUSTableAdapter = new final_project.DataSet1TableAdapters.RENTAL_STATUSTableAdapter();
            this.rTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTRENTALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTEMPLOYEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTRENTALDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTFEEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTEMPLOYEEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALSTATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(413, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "직원 화면";
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
            this.pAVAILABILITYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(975, 181);
            this.dataGridView1.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 261);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 395);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.btn_approval);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "예약 목록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rTNODataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn1,
            this.pIDDataGridViewTextBoxColumn2,
            this.rTRENTALDATEDataGridViewTextBoxColumn,
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn,
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn,
            this.rTFEEDataGridViewTextBoxColumn,
            this.rTEMPLOYEEDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.rENTALSTATUSBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(541, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(423, 357);
            this.dataGridView3.TabIndex = 3;
            // 
            // btn_approval
            // 
            this.btn_approval.Location = new System.Drawing.Point(457, 175);
            this.btn_approval.Name = "btn_approval";
            this.btn_approval.Size = new System.Drawing.Size(75, 23);
            this.btn_approval.TabIndex = 1;
            this.btn_approval.Text = "대여 승인";
            this.btn_approval.UseVisualStyleBackColor = true;
            this.btn_approval.Click += new System.EventHandler(this.btn_approval_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rNODataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn1,
            this.R_DEPOSIT});
            this.dataGridView2.DataSource = this.rESERVATIONBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(445, 357);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // R_DEPOSIT
            // 
            this.R_DEPOSIT.DataPropertyName = "R_DEPOSIT";
            this.R_DEPOSIT.HeaderText = "입금액";
            this.R_DEPOSIT.Name = "R_DEPOSIT";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_return);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "반납 접수";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(856, 320);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(106, 23);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "반납 접수 승인";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click_1);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rTNODataGridViewTextBoxColumn1,
            this.cIDDataGridViewTextBoxColumn2,
            this.pIDDataGridViewTextBoxColumn3,
            this.rTRENTALDATEDataGridViewTextBoxColumn1,
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn1,
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn1,
            this.rTFEEDataGridViewTextBoxColumn1,
            this.rTEMPLOYEEDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.rENTALSTATUSBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(846, 357);
            this.dataGridView4.TabIndex = 1;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick_1);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=KIMSIYOUNG;USER ID=A5234150;password=A5234150;";
            // 
            // oracleCommand1
            // 
            oracleParameter5.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter5.ParameterName = "aa";
            oracleParameter6.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter6.ParameterName = "bb";
            oracleParameter7.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter7.ParameterName = "cc";
            oracleParameter8.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter8.ParameterName = "dd";
            this.oracleCommand1.Parameters.Add(oracleParameter5);
            this.oracleCommand1.Parameters.Add(oracleParameter6);
            this.oracleCommand1.Parameters.Add(oracleParameter7);
            this.oracleCommand1.Parameters.Add(oracleParameter8);
            this.oracleCommand1.Transaction = null;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.CommandText = "SELECT SYSDATE FROM DUAL";
            this.oracleCommand2.Transaction = null;
            // 
            // rNODataGridViewTextBoxColumn
            // 
            this.rNODataGridViewTextBoxColumn.DataPropertyName = "R_NO";
            this.rNODataGridViewTextBoxColumn.HeaderText = "예약 번호";
            this.rNODataGridViewTextBoxColumn.Name = "rNODataGridViewTextBoxColumn";
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "고객 ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // pIDDataGridViewTextBoxColumn1
            // 
            this.pIDDataGridViewTextBoxColumn1.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn1.HeaderText = "물품 번호";
            this.pIDDataGridViewTextBoxColumn1.Name = "pIDDataGridViewTextBoxColumn1";
            // 
            // rESERVATIONBindingSource
            // 
            this.rESERVATIONBindingSource.DataMember = "RESERVATION";
            this.rESERVATIONBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pAVAILABILITYDataGridViewTextBoxColumn
            // 
            this.pAVAILABILITYDataGridViewTextBoxColumn.DataPropertyName = "P_AVAILABILITY";
            this.pAVAILABILITYDataGridViewTextBoxColumn.HeaderText = "대여 가능 여부";
            this.pAVAILABILITYDataGridViewTextBoxColumn.Name = "pAVAILABILITYDataGridViewTextBoxColumn";
            this.pAVAILABILITYDataGridViewTextBoxColumn.Width = 120;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dataSet11;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // reviewTableAdapter1
            // 
            this.reviewTableAdapter1.ClearBeforeFill = true;
            // 
            // rENTALSTATUSBindingSource
            // 
            this.rENTALSTATUSBindingSource.DataMember = "RENTAL_STATUS";
            this.rENTALSTATUSBindingSource.DataSource = this.dataSet11;
            // 
            // rENTAL_STATUSTableAdapter
            // 
            this.rENTAL_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // rTNODataGridViewTextBoxColumn
            // 
            this.rTNODataGridViewTextBoxColumn.DataPropertyName = "RT_NO";
            this.rTNODataGridViewTextBoxColumn.HeaderText = "RT_NO";
            this.rTNODataGridViewTextBoxColumn.Name = "rTNODataGridViewTextBoxColumn";
            // 
            // cIDDataGridViewTextBoxColumn1
            // 
            this.cIDDataGridViewTextBoxColumn1.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn1.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn1.Name = "cIDDataGridViewTextBoxColumn1";
            // 
            // pIDDataGridViewTextBoxColumn2
            // 
            this.pIDDataGridViewTextBoxColumn2.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn2.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn2.Name = "pIDDataGridViewTextBoxColumn2";
            // 
            // rTRENTALDATEDataGridViewTextBoxColumn
            // 
            this.rTRENTALDATEDataGridViewTextBoxColumn.DataPropertyName = "RT_RENTALDATE";
            this.rTRENTALDATEDataGridViewTextBoxColumn.HeaderText = "RT_RENTALDATE";
            this.rTRENTALDATEDataGridViewTextBoxColumn.Name = "rTRENTALDATEDataGridViewTextBoxColumn";
            // 
            // rTRETURNDUEDATEDataGridViewTextBoxColumn
            // 
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn.DataPropertyName = "RT_RETURNDUEDATE";
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn.HeaderText = "RT_RETURNDUEDATE";
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn.Name = "rTRETURNDUEDATEDataGridViewTextBoxColumn";
            // 
            // rTACTUALRETURNDATEDataGridViewTextBoxColumn
            // 
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn.DataPropertyName = "RT_ACTUALRETURNDATE";
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn.HeaderText = "RT_ACTUALRETURNDATE";
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn.Name = "rTACTUALRETURNDATEDataGridViewTextBoxColumn";
            // 
            // rTFEEDataGridViewTextBoxColumn
            // 
            this.rTFEEDataGridViewTextBoxColumn.DataPropertyName = "RT_FEE";
            this.rTFEEDataGridViewTextBoxColumn.HeaderText = "RT_FEE";
            this.rTFEEDataGridViewTextBoxColumn.Name = "rTFEEDataGridViewTextBoxColumn";
            // 
            // rTEMPLOYEEDataGridViewTextBoxColumn
            // 
            this.rTEMPLOYEEDataGridViewTextBoxColumn.DataPropertyName = "RT_EMPLOYEE";
            this.rTEMPLOYEEDataGridViewTextBoxColumn.HeaderText = "RT_EMPLOYEE";
            this.rTEMPLOYEEDataGridViewTextBoxColumn.Name = "rTEMPLOYEEDataGridViewTextBoxColumn";
            // 
            // rTNODataGridViewTextBoxColumn1
            // 
            this.rTNODataGridViewTextBoxColumn1.DataPropertyName = "RT_NO";
            this.rTNODataGridViewTextBoxColumn1.HeaderText = "RT_NO";
            this.rTNODataGridViewTextBoxColumn1.Name = "rTNODataGridViewTextBoxColumn1";
            // 
            // cIDDataGridViewTextBoxColumn2
            // 
            this.cIDDataGridViewTextBoxColumn2.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn2.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn2.Name = "cIDDataGridViewTextBoxColumn2";
            // 
            // pIDDataGridViewTextBoxColumn3
            // 
            this.pIDDataGridViewTextBoxColumn3.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn3.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn3.Name = "pIDDataGridViewTextBoxColumn3";
            // 
            // rTRENTALDATEDataGridViewTextBoxColumn1
            // 
            this.rTRENTALDATEDataGridViewTextBoxColumn1.DataPropertyName = "RT_RENTALDATE";
            this.rTRENTALDATEDataGridViewTextBoxColumn1.HeaderText = "RT_RENTALDATE";
            this.rTRENTALDATEDataGridViewTextBoxColumn1.Name = "rTRENTALDATEDataGridViewTextBoxColumn1";
            // 
            // rTRETURNDUEDATEDataGridViewTextBoxColumn1
            // 
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn1.DataPropertyName = "RT_RETURNDUEDATE";
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn1.HeaderText = "RT_RETURNDUEDATE";
            this.rTRETURNDUEDATEDataGridViewTextBoxColumn1.Name = "rTRETURNDUEDATEDataGridViewTextBoxColumn1";
            // 
            // rTACTUALRETURNDATEDataGridViewTextBoxColumn1
            // 
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn1.DataPropertyName = "RT_ACTUALRETURNDATE";
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn1.HeaderText = "RT_ACTUALRETURNDATE";
            this.rTACTUALRETURNDATEDataGridViewTextBoxColumn1.Name = "rTACTUALRETURNDATEDataGridViewTextBoxColumn1";
            // 
            // rTFEEDataGridViewTextBoxColumn1
            // 
            this.rTFEEDataGridViewTextBoxColumn1.DataPropertyName = "RT_FEE";
            this.rTFEEDataGridViewTextBoxColumn1.HeaderText = "RT_FEE";
            this.rTFEEDataGridViewTextBoxColumn1.Name = "rTFEEDataGridViewTextBoxColumn1";
            // 
            // rTEMPLOYEEDataGridViewTextBoxColumn1
            // 
            this.rTEMPLOYEEDataGridViewTextBoxColumn1.DataPropertyName = "RT_EMPLOYEE";
            this.rTEMPLOYEEDataGridViewTextBoxColumn1.HeaderText = "RT_EMPLOYEE";
            this.rTEMPLOYEEDataGridViewTextBoxColumn1.Name = "rTEMPLOYEEDataGridViewTextBoxColumn1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 668);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTALSTATUSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private DataSet1TableAdapters.PRODUCTTableAdapter productTableAdapter1;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREATALPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_approval;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource rESERVATIONBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCONDITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSIZEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECEIVINGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAVAILABILITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_DEPOSIT;
        private System.Windows.Forms.BindingSource rENTALSTATUSBindingSource;
        private DataSet1TableAdapters.RENTAL_STATUSTableAdapter rENTAL_STATUSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTRENTALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTRETURNDUEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTACTUALRETURNDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTEMPLOYEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTRENTALDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTRETURNDUEDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTACTUALRETURNDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTFEEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTEMPLOYEEDataGridViewTextBoxColumn1;
    }
}