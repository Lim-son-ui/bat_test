
namespace bat_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_query = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_device = new System.Windows.Forms.Label();
            this.btn_setcom = new System.Windows.Forms.Button();
            this.btn_closecon = new System.Windows.Forms.Button();
            this.btn_opencom = new System.Windows.Forms.Button();
            this.txt_com = new System.Windows.Forms.TextBox();
            this.txt_batnum = new System.Windows.Forms.TextBox();
            this.btn_barcode = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_batnum = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maxvol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_minvol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_worknum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(40, 671);
            this.btn_query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(149, 74);
            this.btn_query.TabIndex = 22;
            this.btn_query.Text = "進入查詢";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(35, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "量測電池數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(35, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "電池條碼";
            // 
            // lbl_device
            // 
            this.lbl_device.AutoSize = true;
            this.lbl_device.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_device.Location = new System.Drawing.Point(35, 786);
            this.lbl_device.Name = "lbl_device";
            this.lbl_device.Size = new System.Drawing.Size(83, 30);
            this.lbl_device.TabIndex = 19;
            this.lbl_device.Text = "label7";
            // 
            // btn_setcom
            // 
            this.btn_setcom.Location = new System.Drawing.Point(983, 47);
            this.btn_setcom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setcom.Name = "btn_setcom";
            this.btn_setcom.Size = new System.Drawing.Size(120, 62);
            this.btn_setcom.TabIndex = 14;
            this.btn_setcom.Text = "設定com";
            this.btn_setcom.UseVisualStyleBackColor = true;
            this.btn_setcom.Click += new System.EventHandler(this.btn_setcom_Click);
            // 
            // btn_closecon
            // 
            this.btn_closecon.Location = new System.Drawing.Point(548, 49);
            this.btn_closecon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_closecon.Name = "btn_closecon";
            this.btn_closecon.Size = new System.Drawing.Size(120, 58);
            this.btn_closecon.TabIndex = 15;
            this.btn_closecon.Text = "關閉設定com";
            this.btn_closecon.UseVisualStyleBackColor = true;
            this.btn_closecon.Click += new System.EventHandler(this.btn_closcom_Click);
            // 
            // btn_opencom
            // 
            this.btn_opencom.Location = new System.Drawing.Point(548, 49);
            this.btn_opencom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_opencom.Name = "btn_opencom";
            this.btn_opencom.Size = new System.Drawing.Size(120, 58);
            this.btn_opencom.TabIndex = 16;
            this.btn_opencom.Text = "開啟設定com";
            this.btn_opencom.UseVisualStyleBackColor = true;
            this.btn_opencom.Click += new System.EventHandler(this.btn_opencom_Click);
            // 
            // txt_com
            // 
            this.txt_com.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_com.Location = new System.Drawing.Point(703, 49);
            this.txt_com.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_com.Name = "txt_com";
            this.txt_com.Size = new System.Drawing.Size(246, 59);
            this.txt_com.TabIndex = 9;
            // 
            // txt_batnum
            // 
            this.txt_batnum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_batnum.Location = new System.Drawing.Point(40, 71);
            this.txt_batnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_batnum.Name = "txt_batnum";
            this.txt_batnum.Size = new System.Drawing.Size(273, 43);
            this.txt_batnum.TabIndex = 10;
            // 
            // btn_barcode
            // 
            this.btn_barcode.Location = new System.Drawing.Point(399, 144);
            this.btn_barcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(136, 82);
            this.btn_barcode.TabIndex = 17;
            this.btn_barcode.Text = "輸入條碼";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.btnbarcode_Click);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_barcode.Location = new System.Drawing.Point(40, 183);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(273, 43);
            this.txt_barcode.TabIndex = 11;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Result";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "value";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // btn_batnum
            // 
            this.btn_batnum.Location = new System.Drawing.Point(399, 40);
            this.btn_batnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_batnum.Name = "btn_batnum";
            this.btn_batnum.Size = new System.Drawing.Size(136, 82);
            this.btn_batnum.TabIndex = 18;
            this.btn_batnum.Text = "設定數量";
            this.btn_batnum.UseVisualStyleBackColor = true;
            this.btn_batnum.Click += new System.EventHandler(this.btnbatnum_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "barcode";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(548, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(881, 590);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Row_name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(44, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "顯示設定條件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 82);
            this.button1.TabIndex = 4;
            this.button1.Text = "測試";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_dv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_maxvol);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_minvol);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_worknum);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(35, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 366);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "工單號碼";
            // 
            // txt_dv
            // 
            this.txt_dv.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_dv.Location = new System.Drawing.Point(363, 302);
            this.txt_dv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dv.Name = "txt_dv";
            this.txt_dv.Size = new System.Drawing.Size(107, 43);
            this.txt_dv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(191, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "最低電壓";
            // 
            // txt_maxvol
            // 
            this.txt_maxvol.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_maxvol.Location = new System.Drawing.Point(363, 222);
            this.txt_maxvol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maxvol.Name = "txt_maxvol";
            this.txt_maxvol.Size = new System.Drawing.Size(107, 43);
            this.txt_maxvol.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(191, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "最高電壓";
            // 
            // txt_minvol
            // 
            this.txt_minvol.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_minvol.Location = new System.Drawing.Point(363, 152);
            this.txt_minvol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_minvol.Name = "txt_minvol";
            this.txt_minvol.Size = new System.Drawing.Size(107, 43);
            this.txt_minvol.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(191, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "dv(壓差)";
            // 
            // txt_worknum
            // 
            this.txt_worknum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_worknum.Location = new System.Drawing.Point(196, 39);
            this.txt_worknum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_worknum.Name = "txt_worknum";
            this.txt_worknum.Size = new System.Drawing.Size(273, 43);
            this.txt_worknum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "量測範圍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 844);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_device);
            this.Controls.Add(this.btn_setcom);
            this.Controls.Add(this.btn_closecon);
            this.Controls.Add(this.btn_opencom);
            this.Controls.Add(this.txt_com);
            this.Controls.Add(this.txt_batnum);
            this.Controls.Add(this.btn_barcode);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.btn_batnum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_device;
        private System.Windows.Forms.Button btn_setcom;
        private System.Windows.Forms.Button btn_closecon;
        private System.Windows.Forms.Button btn_opencom;
        private System.Windows.Forms.TextBox txt_com;
        private System.Windows.Forms.TextBox txt_batnum;
        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_batnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maxvol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_minvol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_worknum;
        private System.Windows.Forms.Label label4;
    }
}

