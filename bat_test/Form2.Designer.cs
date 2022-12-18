
namespace bat_test
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_csv = new System.Windows.Forms.Button();
            this.lbl_datedown = new System.Windows.Forms.Label();
            this.lbl_batnum = new System.Windows.Forms.Label();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dateup = new System.Windows.Forms.Label();
            this.dpicker_down = new System.Windows.Forms.DateTimePicker();
            this.dpicker_up = new System.Windows.Forms.DateTimePicker();
            this.txt_batnum = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_inp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_select = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(1022, 129);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(136, 74);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "動態新增內容";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_csv
            // 
            this.btn_csv.Location = new System.Drawing.Point(1022, 31);
            this.btn_csv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(136, 76);
            this.btn_csv.TabIndex = 28;
            this.btn_csv.Text = "輸出excel";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // lbl_datedown
            // 
            this.lbl_datedown.AutoSize = true;
            this.lbl_datedown.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_datedown.Location = new System.Drawing.Point(322, 146);
            this.lbl_datedown.Name = "lbl_datedown";
            this.lbl_datedown.Size = new System.Drawing.Size(133, 30);
            this.lbl_datedown.TabIndex = 27;
            this.lbl_datedown.Text = "日期下界";
            // 
            // lbl_batnum
            // 
            this.lbl_batnum.AutoSize = true;
            this.lbl_batnum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_batnum.Location = new System.Drawing.Point(615, 31);
            this.lbl_batnum.Name = "lbl_batnum";
            this.lbl_batnum.Size = new System.Drawing.Size(133, 30);
            this.lbl_batnum.TabIndex = 26;
            this.lbl_batnum.Text = "幾號電池";
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_barcode.Location = new System.Drawing.Point(785, 31);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(193, 30);
            this.lbl_barcode.TabIndex = 25;
            this.lbl_barcode.Text = "輸入電池編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(290, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "輸入工單號";
            // 
            // lbl_dateup
            // 
            this.lbl_dateup.AutoSize = true;
            this.lbl_dateup.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_dateup.Location = new System.Drawing.Point(566, 146);
            this.lbl_dateup.Name = "lbl_dateup";
            this.lbl_dateup.Size = new System.Drawing.Size(133, 30);
            this.lbl_dateup.TabIndex = 23;
            this.lbl_dateup.Text = "日期上界";
            // 
            // dpicker_down
            // 
            this.dpicker_down.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpicker_down.Location = new System.Drawing.Point(327, 189);
            this.dpicker_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpicker_down.Name = "dpicker_down";
            this.dpicker_down.Size = new System.Drawing.Size(227, 43);
            this.dpicker_down.TabIndex = 22;
            // 
            // dpicker_up
            // 
            this.dpicker_up.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dpicker_up.Location = new System.Drawing.Point(571, 189);
            this.dpicker_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpicker_up.Name = "dpicker_up";
            this.dpicker_up.Size = new System.Drawing.Size(227, 43);
            this.dpicker_up.TabIndex = 21;
            // 
            // txt_batnum
            // 
            this.txt_batnum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_batnum.Location = new System.Drawing.Point(611, 81);
            this.txt_batnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_batnum.Name = "txt_batnum";
            this.txt_batnum.Size = new System.Drawing.Size(146, 43);
            this.txt_batnum.TabIndex = 20;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_barcode.Location = new System.Drawing.Point(791, 81);
            this.txt_barcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(210, 43);
            this.txt_barcode.TabIndex = 19;
            // 
            // txt_inp
            // 
            this.txt_inp.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_inp.Location = new System.Drawing.Point(286, 81);
            this.txt_inp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_inp.Name = "txt_inp";
            this.txt_inp.Size = new System.Drawing.Size(303, 43);
            this.txt_inp.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 283);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 388);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(167, 176);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(136, 82);
            this.btn_reload.TabIndex = 15;
            this.btn_reload.Text = "重新載入";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 82);
            this.button1.TabIndex = 14;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(44, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "查詢條件";
            // 
            // cmb_select
            // 
            this.cmb_select.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_select.FormattingEnabled = true;
            this.cmb_select.Location = new System.Drawing.Point(13, 86);
            this.cmb_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_select.Name = "cmb_select";
            this.cmb_select.Size = new System.Drawing.Size(244, 38);
            this.cmb_select.TabIndex = 17;
            this.cmb_select.SelectedIndexChanged += new System.EventHandler(this.cmb_select_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 712);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_csv);
            this.Controls.Add(this.lbl_datedown);
            this.Controls.Add(this.lbl_batnum);
            this.Controls.Add(this.lbl_barcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dateup);
            this.Controls.Add(this.dpicker_down);
            this.Controls.Add(this.dpicker_up);
            this.Controls.Add(this.txt_batnum);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.txt_inp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_select);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Label lbl_datedown;
        private System.Windows.Forms.Label lbl_batnum;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dateup;
        private System.Windows.Forms.DateTimePicker dpicker_down;
        private System.Windows.Forms.DateTimePicker dpicker_up;
        private System.Windows.Forms.TextBox txt_batnum;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_inp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_select;
    }
}