namespace policy
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Daily = new System.Windows.Forms.RadioButton();
            this.Monthly = new System.Windows.Forms.RadioButton();
            this.CardLastName = new System.Windows.Forms.TextBox();
            this.CardName = new System.Windows.Forms.TextBox();
            this.DocNum = new System.Windows.Forms.TextBox();
            this.PolicyNum = new System.Windows.Forms.TextBox();
            this.InstallmentNo = new System.Windows.Forms.TextBox();
            this.Comments = new System.Windows.Forms.TextBox();
            this.PolicyBegDate = new System.Windows.Forms.DateTimePicker();
            this.PolicyEndDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.policyprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyBegDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstallmentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.policyInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.policyDataSet3 = new policy.policyDataSet3();
            this.policyInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.policyDataSet = new policy.policyDataSet();
            this.policyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExpenseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.policyInfoTableAdapter = new policy.policyDataSetTableAdapters.PolicyInfoTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.policyDataSet1 = new policy.policyDataSet1();
            this.policyInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.policyInfoTableAdapter1 = new policy.policyDataSet1TableAdapters.PolicyInfoTableAdapter();
            this.policyInfoTableAdapter2 = new policy.policyDataSet3TableAdapters.PolicyInfoTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Belge No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Poliçe No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Başlangıç Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Taksit Sayısı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bitiş Tarihi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Açıklamalar :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hesaplama Yöntemi :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.Location = new System.Drawing.Point(692, 97);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(59, 17);
            this.Daily.TabIndex = 11;
            this.Daily.Text = "Günlük";
            this.Daily.UseVisualStyleBackColor = true;
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.Checked = true;
            this.Monthly.Location = new System.Drawing.Point(639, 97);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(47, 17);
            this.Monthly.TabIndex = 12;
            this.Monthly.TabStop = true;
            this.Monthly.Text = "Aylık";
            this.Monthly.UseVisualStyleBackColor = true;
            // 
            // CardLastName
            // 
            this.CardLastName.Location = new System.Drawing.Point(132, 138);
            this.CardLastName.Name = "CardLastName";
            this.CardLastName.Size = new System.Drawing.Size(144, 20);
            this.CardLastName.TabIndex = 13;
            // 
            // CardName
            // 
            this.CardName.Location = new System.Drawing.Point(132, 98);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(144, 20);
            this.CardName.TabIndex = 14;
            // 
            // DocNum
            // 
            this.DocNum.Location = new System.Drawing.Point(132, 172);
            this.DocNum.Name = "DocNum";
            this.DocNum.Size = new System.Drawing.Size(144, 20);
            this.DocNum.TabIndex = 15;
            // 
            // PolicyNum
            // 
            this.PolicyNum.Location = new System.Drawing.Point(132, 210);
            this.PolicyNum.Name = "PolicyNum";
            this.PolicyNum.Size = new System.Drawing.Size(144, 20);
            this.PolicyNum.TabIndex = 16;
            // 
            // InstallmentNo
            // 
            this.InstallmentNo.Location = new System.Drawing.Point(132, 289);
            this.InstallmentNo.Name = "InstallmentNo";
            this.InstallmentNo.Size = new System.Drawing.Size(144, 20);
            this.InstallmentNo.TabIndex = 17;
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(132, 372);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(191, 106);
            this.Comments.TabIndex = 18;
            // 
            // PolicyBegDate
            // 
            this.PolicyBegDate.Location = new System.Drawing.Point(132, 247);
            this.PolicyBegDate.Name = "PolicyBegDate";
            this.PolicyBegDate.Size = new System.Drawing.Size(200, 20);
            this.PolicyBegDate.TabIndex = 19;
            // 
            // PolicyEndDate
            // 
            this.PolicyEndDate.Location = new System.Drawing.Point(132, 331);
            this.PolicyEndDate.Name = "PolicyEndDate";
            this.PolicyEndDate.Size = new System.Drawing.Size(200, 20);
            this.PolicyEndDate.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Poliçe Tutarı :";
            // 
            // policyprice
            // 
            this.policyprice.Location = new System.Drawing.Point(588, 62);
            this.policyprice.Name = "policyprice";
            this.policyprice.Size = new System.Drawing.Size(144, 20);
            this.policyprice.TabIndex = 22;
            this.policyprice.TextChanged += new System.EventHandler(this.policyprice_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(506, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Kullanılan Gün Sayısı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Poliçe Taksit Tarihi :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(636, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(532, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Günlük Hesap :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(636, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(532, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Aylık Hesap :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(636, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.DailyPrice,
            this.MonthlyPrice,
            this.dataGridViewTextBoxColumn1,
            this.cardNameDataGridViewTextBoxColumn,
            this.cardLastNameDataGridViewTextBoxColumn,
            this.docNumDataGridViewTextBoxColumn,
            this.policyNumDataGridViewTextBoxColumn,
            this.policyBegDateDataGridViewTextBoxColumn,
            this.ınstallmentNoDataGridViewTextBoxColumn,
            this.policyenddateDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.methodologyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.policyInfoBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(357, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1190, 159);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DailyPrice
            // 
            this.DailyPrice.DataPropertyName = "DailyPrice";
            this.DailyPrice.HeaderText = "DailyPrice";
            this.DailyPrice.Name = "DailyPrice";
            // 
            // MonthlyPrice
            // 
            this.MonthlyPrice.DataPropertyName = "MonthlyPrice";
            this.MonthlyPrice.HeaderText = "MonthlyPrice";
            this.MonthlyPrice.Name = "MonthlyPrice";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ExpenseType";
            this.dataGridViewTextBoxColumn1.HeaderText = "ExpenseType";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cardNameDataGridViewTextBoxColumn
            // 
            this.cardNameDataGridViewTextBoxColumn.DataPropertyName = "CardName";
            this.cardNameDataGridViewTextBoxColumn.HeaderText = "CardName";
            this.cardNameDataGridViewTextBoxColumn.Name = "cardNameDataGridViewTextBoxColumn";
            // 
            // cardLastNameDataGridViewTextBoxColumn
            // 
            this.cardLastNameDataGridViewTextBoxColumn.DataPropertyName = "CardLastName";
            this.cardLastNameDataGridViewTextBoxColumn.HeaderText = "CardLastName";
            this.cardLastNameDataGridViewTextBoxColumn.Name = "cardLastNameDataGridViewTextBoxColumn";
            // 
            // docNumDataGridViewTextBoxColumn
            // 
            this.docNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum";
            this.docNumDataGridViewTextBoxColumn.HeaderText = "DocNum";
            this.docNumDataGridViewTextBoxColumn.Name = "docNumDataGridViewTextBoxColumn";
            // 
            // policyNumDataGridViewTextBoxColumn
            // 
            this.policyNumDataGridViewTextBoxColumn.DataPropertyName = "PolicyNum";
            this.policyNumDataGridViewTextBoxColumn.HeaderText = "PolicyNum";
            this.policyNumDataGridViewTextBoxColumn.Name = "policyNumDataGridViewTextBoxColumn";
            // 
            // policyBegDateDataGridViewTextBoxColumn
            // 
            this.policyBegDateDataGridViewTextBoxColumn.DataPropertyName = "PolicyBegDate";
            this.policyBegDateDataGridViewTextBoxColumn.HeaderText = "PolicyBegDate";
            this.policyBegDateDataGridViewTextBoxColumn.Name = "policyBegDateDataGridViewTextBoxColumn";
            // 
            // ınstallmentNoDataGridViewTextBoxColumn
            // 
            this.ınstallmentNoDataGridViewTextBoxColumn.DataPropertyName = "InstallmentNo";
            this.ınstallmentNoDataGridViewTextBoxColumn.HeaderText = "InstallmentNo";
            this.ınstallmentNoDataGridViewTextBoxColumn.Name = "ınstallmentNoDataGridViewTextBoxColumn";
            // 
            // policyenddateDataGridViewTextBoxColumn
            // 
            this.policyenddateDataGridViewTextBoxColumn.DataPropertyName = "policyenddate";
            this.policyenddateDataGridViewTextBoxColumn.HeaderText = "policyenddate";
            this.policyenddateDataGridViewTextBoxColumn.Name = "policyenddateDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // methodologyDataGridViewTextBoxColumn
            // 
            this.methodologyDataGridViewTextBoxColumn.DataPropertyName = "Methodology";
            this.methodologyDataGridViewTextBoxColumn.HeaderText = "Methodology";
            this.methodologyDataGridViewTextBoxColumn.Name = "methodologyDataGridViewTextBoxColumn";
            // 
            // policyInfoBindingSource3
            // 
            this.policyInfoBindingSource3.DataMember = "PolicyInfo";
            this.policyInfoBindingSource3.DataSource = this.policyDataSet3;
            // 
            // policyDataSet3
            // 
            this.policyDataSet3.DataSetName = "policyDataSet3";
            this.policyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policyInfoBindingSource1
            // 
            this.policyInfoBindingSource1.DataMember = "PolicyInfo";
            this.policyInfoBindingSource1.DataSource = this.policyDataSet;
            // 
            // policyDataSet
            // 
            this.policyDataSet.DataSetName = "policyDataSet";
            this.policyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpenseType
            // 
            this.ExpenseType.Location = new System.Drawing.Point(132, 57);
            this.ExpenseType.Name = "ExpenseType";
            this.ExpenseType.Size = new System.Drawing.Size(144, 21);
            this.ExpenseType.TabIndex = 1;
            this.ExpenseType.SelectedIndexChanged += new System.EventHandler(this.ExpenseType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // policyInfoTableAdapter
            // 
            this.policyInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Gider Tipi :";
            // 
            // policyDataSet1
            // 
            this.policyDataSet1.DataSetName = "policyDataSet1";
            this.policyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policyInfoBindingSource2
            // 
            this.policyInfoBindingSource2.DataMember = "PolicyInfo";
            this.policyInfoBindingSource2.DataSource = this.policyDataSet1;
            // 
            // policyInfoTableAdapter1
            // 
            this.policyInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // policyInfoTableAdapter2
            // 
            this.policyInfoTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(830, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(364, 216);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1625, 652);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpenseType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.policyprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PolicyEndDate);
            this.Controls.Add(this.PolicyBegDate);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.InstallmentNo);
            this.Controls.Add(this.PolicyNum);
            this.Controls.Add(this.DocNum);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.CardLastName);
            this.Controls.Add(this.Monthly);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Daily;
        private System.Windows.Forms.RadioButton Monthly;
        private System.Windows.Forms.TextBox CardLastName;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.TextBox DocNum;
        private System.Windows.Forms.TextBox PolicyNum;
        private System.Windows.Forms.TextBox InstallmentNo;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.DateTimePicker PolicyBegDate;
        private System.Windows.Forms.DateTimePicker PolicyEndDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox policyprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource policyDataSetBindingSource;

        private System.Windows.Forms.BindingSource policyBindingSource;

        private System.Windows.Forms.ComboBox ExpenseType;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.BindingSource policyInfoBindingSource;
        private policyDataSet policyDataSet;
        private System.Windows.Forms.BindingSource policyInfoBindingSource1;
        private policyDataSetTableAdapters.PolicyInfoTableAdapter policyInfoTableAdapter;
        private System.Windows.Forms.Label label16;
        private policyDataSet1 policyDataSet1;
        private System.Windows.Forms.BindingSource policyInfoBindingSource2;
        private policyDataSet1TableAdapters.PolicyInfoTableAdapter policyInfoTableAdapter1;
        private policyDataSet3 policyDataSet3;
        private System.Windows.Forms.BindingSource policyInfoBindingSource3;
        private policyDataSet3TableAdapters.PolicyInfoTableAdapter policyInfoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyBegDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstallmentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn policyenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

