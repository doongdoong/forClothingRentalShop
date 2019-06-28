namespace final_project
{
    partial class Form2
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
            Oracle.DataAccess.Client.OracleParameter oracleParameter8 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter9 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter10 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter11 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter12 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter13 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter14 = new Oracle.DataAccess.Client.OracleParameter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new final_project.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_pID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_review = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_title = new System.Windows.Forms.TextBox();
            this.tbx_contents = new System.Windows.Forms.TextBox();
            this.lbx_review = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbx_rental_pID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbx_size = new System.Windows.Forms.TextBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbx_color = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_fee = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.lbx_pID = new System.Windows.Forms.ListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_contents2 = new System.Windows.Forms.TextBox();
            this.tbx_title2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.dataSet1 = new final_project.DataSet1();
            this.dataSet11 = new final_project.DataSet1();
            this.customerTableAdapter1 = new final_project.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.rentaL_STATUSTableAdapter1 = new final_project.DataSet1TableAdapters.RENTAL_STATUSTableAdapter();
            this.reservationTableAdapter1 = new final_project.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.reviewTableAdapter1 = new final_project.DataSet1TableAdapters.REVIEWTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(417, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "고객 화면";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(974, 227);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "- 물품 현황";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "- 물품 리뷰";
            // 
            // tbx_pID
            // 
            this.tbx_pID.Location = new System.Drawing.Point(76, 36);
            this.tbx_pID.Name = "tbx_pID";
            this.tbx_pID.Size = new System.Drawing.Size(100, 21);
            this.tbx_pID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "물품 번호";
            // 
            // btn_review
            // 
            this.btn_review.Location = new System.Drawing.Point(193, 34);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(75, 23);
            this.btn_review.TabIndex = 17;
            this.btn_review.Text = "리뷰 검색";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "제 목";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "내 용";
            // 
            // tbx_title
            // 
            this.tbx_title.Location = new System.Drawing.Point(291, 90);
            this.tbx_title.Name = "tbx_title";
            this.tbx_title.Size = new System.Drawing.Size(654, 21);
            this.tbx_title.TabIndex = 20;
            // 
            // tbx_contents
            // 
            this.tbx_contents.Location = new System.Drawing.Point(291, 138);
            this.tbx_contents.Multiline = true;
            this.tbx_contents.Name = "tbx_contents";
            this.tbx_contents.Size = new System.Drawing.Size(654, 159);
            this.tbx_contents.TabIndex = 21;
            // 
            // lbx_review
            // 
            this.lbx_review.FormattingEnabled = true;
            this.lbx_review.ItemHeight = 12;
            this.lbx_review.Location = new System.Drawing.Point(15, 65);
            this.lbx_review.Name = "lbx_review";
            this.lbx_review.Size = new System.Drawing.Size(253, 232);
            this.lbx_review.TabIndex = 22;
            this.lbx_review.SelectedIndexChanged += new System.EventHandler(this.lbx_review_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 314);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 342);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbx_rental_pID);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btn_rent);
            this.tabPage3.Controls.Add(this.btn_search);
            this.tabPage3.Controls.Add(this.tbx_size);
            this.tabPage3.Controls.Add(this.cbx_type);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.cbx_color);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cbx_fee);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(966, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "대여 신청";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbx_rental_pID
            // 
            this.tbx_rental_pID.Location = new System.Drawing.Point(155, 183);
            this.tbx_rental_pID.Name = "tbx_rental_pID";
            this.tbx_rental_pID.Size = new System.Drawing.Size(148, 21);
            this.tbx_rental_pID.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 12);
            this.label14.TabIndex = 17;
            this.label14.Text = "물품 번호";
            // 
            // btn_rent
            // 
            this.btn_rent.Location = new System.Drawing.Point(769, 175);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(75, 23);
            this.btn_rent.TabIndex = 14;
            this.btn_rent.Text = "대여 신청";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search.Location = new System.Drawing.Point(769, 79);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "검 색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbx_size
            // 
            this.tbx_size.Location = new System.Drawing.Point(651, 80);
            this.tbx_size.Name = "tbx_size";
            this.tbx_size.Size = new System.Drawing.Size(100, 21);
            this.tbx_size.TabIndex = 12;
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "coat",
            "jacket",
            "sweater",
            "vest",
            "shirts",
            "pants",
            "jeans",
            "shoes",
            "bag",
            "hat"});
            this.cbx_type.Location = new System.Drawing.Point(127, 79);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(121, 20);
            this.cbx_type.TabIndex = 11;
            this.cbx_type.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(92, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "종 류";
            // 
            // cbx_color
            // 
            this.cbx_color.FormattingEnabled = true;
            this.cbx_color.Items.AddRange(new object[] {
            "black",
            "white",
            "red",
            "green",
            "yellow",
            "blue",
            "purple",
            "blue",
            "beige",
            "brown",
            "orange",
            "navy"});
            this.cbx_color.Location = new System.Drawing.Point(476, 80);
            this.cbx_color.Name = "cbx_color";
            this.cbx_color.Size = new System.Drawing.Size(121, 20);
            this.cbx_color.TabIndex = 5;
            this.cbx_color.SelectedIndexChanged += new System.EventHandler(this.cbx_color_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "색 상";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "사이즈";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "가 격";
            // 
            // cbx_fee
            // 
            this.cbx_fee.FormattingEnabled = true;
            this.cbx_fee.Items.AddRange(new object[] {
            "1000원 미만",
            "1000원 이상 2000원 미만",
            "2000원 이상 3000원 미만",
            "3000원 이상 4000원 미만",
            "4000원 이상 5000원 미만",
            "5000원 이상"});
            this.cbx_fee.Location = new System.Drawing.Point(288, 79);
            this.cbx_fee.Name = "cbx_fee";
            this.cbx_fee.Size = new System.Drawing.Size(143, 20);
            this.cbx_fee.TabIndex = 0;
            this.cbx_fee.SelectedIndexChanged += new System.EventHandler(this.cbx_fee_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbx_review);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbx_contents);
            this.tabPage1.Controls.Add(this.tbx_pID);
            this.tabPage1.Controls.Add(this.tbx_title);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btn_review);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "리뷰 보기";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lbx_pID);
            this.tabPage2.Controls.Add(this.btn_save);
            this.tabPage2.Controls.Add(this.tbx_contents2);
            this.tabPage2.Controls.Add(this.tbx_title2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "리뷰 작성";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "물품 번호";
            // 
            // lbx_pID
            // 
            this.lbx_pID.FormattingEnabled = true;
            this.lbx_pID.ItemHeight = 12;
            this.lbx_pID.Location = new System.Drawing.Point(20, 38);
            this.lbx_pID.Name = "lbx_pID";
            this.lbx_pID.Size = new System.Drawing.Size(120, 256);
            this.lbx_pID.TabIndex = 27;
            this.lbx_pID.SelectedIndexChanged += new System.EventHandler(this.lbx_pID_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(885, 276);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "저 장";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_contents2
            // 
            this.tbx_contents2.Location = new System.Drawing.Point(185, 85);
            this.tbx_contents2.Multiline = true;
            this.tbx_contents2.Name = "tbx_contents2";
            this.tbx_contents2.Size = new System.Drawing.Size(696, 213);
            this.tbx_contents2.TabIndex = 25;
            // 
            // tbx_title2
            // 
            this.tbx_title2.Location = new System.Drawing.Point(185, 37);
            this.tbx_title2.Name = "tbx_title2";
            this.tbx_title2.Size = new System.Drawing.Size(696, 21);
            this.tbx_title2.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "내 용";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "제 목";
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=KIMSIYOUNG;USER ID=A5234150;password=A5234150;";
            // 
            // oracleCommand1
            // 
            oracleParameter8.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter8.ParameterName = "aa";
            oracleParameter9.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter9.ParameterName = "bb";
            oracleParameter10.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter10.ParameterName = "cc";
            oracleParameter11.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter11.ParameterName = "dd";
            this.oracleCommand1.Parameters.Add(oracleParameter8);
            this.oracleCommand1.Parameters.Add(oracleParameter9);
            this.oracleCommand1.Parameters.Add(oracleParameter10);
            this.oracleCommand1.Parameters.Add(oracleParameter11);
            this.oracleCommand1.Transaction = null;
            // 
            // oracleCommand2
            // 
            oracleParameter12.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter12.ParameterName = "aa";
            oracleParameter13.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter13.ParameterName = "bb";
            oracleParameter14.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter14.ParameterName = "cc";
            this.oracleCommand2.Parameters.Add(oracleParameter12);
            this.oracleCommand2.Parameters.Add(oracleParameter13);
            this.oracleCommand2.Parameters.Add(oracleParameter14);
            this.oracleCommand2.Transaction = null;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private DataSet1TableAdapters.RENTAL_STATUSTableAdapter rentaL_STATUSTableAdapter1;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREATALPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_pID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_title;
        private System.Windows.Forms.TextBox tbx_contents;
        private System.Windows.Forms.ListBox lbx_review;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbx_pID;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_contents2;
        private System.Windows.Forms.TextBox tbx_title2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbx_color;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_fee;
        private System.Windows.Forms.TextBox tbx_size;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbx_rental_pID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_rent;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private DataSet1 dataSet12;
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