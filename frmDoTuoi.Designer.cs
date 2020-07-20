namespace QLHSNV
{
    partial class frmDoTuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoTuoi));
            this.btnthanhnien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTrungnien = new System.Windows.Forms.Button();
            this.btnCaonien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qLHoSoNVDataSet1 = new QLHSNV.QLHoSoNVDataSet1();
            this.loaddotuoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaddotuoiTableAdapter = new QLHSNV.QLHoSoNVDataSet1TableAdapters.loaddotuoiTableAdapter();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoSoNVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaddotuoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthanhnien
            // 
            this.btnthanhnien.Image = ((System.Drawing.Image)(resources.GetObject("btnthanhnien.Image")));
            this.btnthanhnien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthanhnien.Location = new System.Drawing.Point(84, 60);
            this.btnthanhnien.Name = "btnthanhnien";
            this.btnthanhnien.Size = new System.Drawing.Size(132, 33);
            this.btnthanhnien.TabIndex = 7;
            this.btnthanhnien.Text = "Thanh niên(18-35)";
            this.btnthanhnien.UseVisualStyleBackColor = true;
            this.btnthanhnien.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn độ tuổi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dataGridView1.DataSource = this.loaddotuoiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 237);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(648, 390);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 48);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "In báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTrungnien
            // 
            this.btnTrungnien.Image = ((System.Drawing.Image)(resources.GetObject("btnTrungnien.Image")));
            this.btnTrungnien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrungnien.Location = new System.Drawing.Point(269, 60);
            this.btnTrungnien.Name = "btnTrungnien";
            this.btnTrungnien.Size = new System.Drawing.Size(128, 33);
            this.btnTrungnien.TabIndex = 11;
            this.btnTrungnien.Text = "Trung niên(36-50)";
            this.btnTrungnien.UseVisualStyleBackColor = true;
            this.btnTrungnien.Click += new System.EventHandler(this.btnTrungnien_Click);
            // 
            // btnCaonien
            // 
            this.btnCaonien.Image = ((System.Drawing.Image)(resources.GetObject("btnCaonien.Image")));
            this.btnCaonien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaonien.Location = new System.Drawing.Point(442, 61);
            this.btnCaonien.Name = "btnCaonien";
            this.btnCaonien.Size = new System.Drawing.Size(119, 32);
            this.btnCaonien.TabIndex = 12;
            this.btnCaonien.Text = "Cao niên(>50)";
            this.btnCaonien.UseVisualStyleBackColor = true;
            this.btnCaonien.Click += new System.EventHandler(this.btnCaonien_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(615, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Xem tất cả";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // qLHoSoNVDataSet1
            // 
            this.qLHoSoNVDataSet1.DataSetName = "QLHoSoNVDataSet1";
            this.qLHoSoNVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaddotuoiBindingSource
            // 
            this.loaddotuoiBindingSource.DataMember = "loaddotuoi";
            this.loaddotuoiBindingSource.DataSource = this.qLHoSoNVDataSet1;
            // 
            // loaddotuoiTableAdapter
            // 
            this.loaddotuoiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn15.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "HoTenNV";
            this.dataGridViewTextBoxColumn16.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "GT";
            this.dataGridViewTextBoxColumn17.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "NS";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DT";
            this.dataGridViewTextBoxColumn19.HeaderText = "Dân tộc";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "DC";
            this.dataGridViewTextBoxColumn20.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn21.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "LuongCB";
            this.dataGridViewTextBoxColumn22.HeaderText = "Lương CB";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "LuongPC";
            this.dataGridViewTextBoxColumn23.HeaderText = "Lương PC";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Heso";
            this.dataGridViewTextBoxColumn24.HeaderText = "Hệ số";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "AVATAR";
            this.dataGridViewImageColumn2.HeaderText = "Hình";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Phongban";
            this.dataGridViewTextBoxColumn25.HeaderText = "Phòng ban";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Chucvu";
            this.dataGridViewTextBoxColumn26.HeaderText = "Chức vụ";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "TDHV";
            this.dataGridViewTextBoxColumn27.HeaderText = "TĐHV";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Ngaynhanchuc";
            this.dataGridViewTextBoxColumn28.HeaderText = "Ngày nhận chức";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // frmDoTuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCaonien);
            this.Controls.Add(this.btnTrungnien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnthanhnien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDoTuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo về độ tuổi";
            this.Load += new System.EventHandler(this.frmDoTuoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHoSoNVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaddotuoiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthanhnien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTrungnien;
        private System.Windows.Forms.Button btnCaonien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aVATARDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDHVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhanchucDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private QLHoSoNVDataSet1 qLHoSoNVDataSet1;
        private System.Windows.Forms.BindingSource loaddotuoiBindingSource;
        private QLHoSoNVDataSet1TableAdapters.loaddotuoiTableAdapter loaddotuoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    }
}