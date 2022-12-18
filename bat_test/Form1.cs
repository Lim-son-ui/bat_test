using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bat_test
{
    public partial class Form1 : Form
    {

        SerialPort sp;

        string portname = ConfigurationManager.AppSettings["COMPORT"].ToString();


        //string aa = confi
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_setcom_Click(object sender, EventArgs e)
        {
            portname = txt_com.Text;
            connect();
        }

        void connect()
        {
            sp = new SerialPort(portname, 9600, Parity.None, 8, StopBits.One);
            sp.Open();
            Thread.Sleep(200);

            sp.WriteLine("*IDN?");

            string idn = sp.ReadLine();
            if (idn != "")
            {
                lbl_device.Text = idn;
            }
            else
            {
                lbl_device.Text = "not connected";
            }

        }

        void all_false()
        {

            txt_barcode.Enabled = false;
            btn_barcode.Enabled = false;

            txt_worknum.Enabled = false;
            txt_minvol.Enabled = false;
            txt_maxvol.Enabled = false;
            txt_dv.Enabled = false;
            button1.Enabled = false;
        }

        void change_showvolt()
        {

            //dataGridView1.Rows.Clear();

            dataGridView1.Rows[0].Cells[0].Value = "工單號碼";
            for (int i = 1; i < (baterynum + 1); i++)                         
                dataGridView1.Rows[i].Cells[0].Value = "Volt." + (i).ToString();
            dataGridView1.Rows[baterynum + 1].Cells[0].Value = "MaxVoltage";
            dataGridView1.Rows[baterynum + 2].Cells[0].Value = "MinVoltage";
            dataGridView1.Rows[baterynum + 3].Cells[0].Value = "dv(電壓差)";
            dataGridView1.Rows[baterynum + 4].Cells[0].Value = "Total_Result";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                txt_com.Visible = false;
                btn_closecon.Visible = false;
                btn_setcom.Visible = false;
                button1.Enabled = false;
                connect();
                // initial gridview


                dataGridView1.Rows.Add(17);

                dataGridView1.Rows[0].Cells[0].Value = "工單號碼";
                for (int i = 1; i < 13; i++)                        
                    dataGridView1.Rows[i].Cells[0].Value = "Volt." + (i).ToString();

                dataGridView1.Rows[13].Cells[0].Value = "MaxVoltage";
                //dataGridView1["About_volt",13].Value = "MaxVoltage";
                dataGridView1.Rows[14].Cells[0].Value = "MinVoltage";
                dataGridView1.Rows[15].Cells[0].Value = "dv(電壓差)";
                dataGridView1.Rows[16].Cells[0].Value = "Total_Result";


            }
            catch (Exception ex)
            {
                //lblMessage.Text = "not connected";
                MessageBox.Show(ex.Message);
            }


            all_false();
        }
        List<double> voltage = new List<double>();
        List<string> barcode = new List<string>();
        int count = 1;
        int baterynum = 0;

        private void btnbatnum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            baterynum = Convert.ToInt32(txt_batnum.Text);
            txt_barcode.Enabled = true;
            btn_barcode.Enabled = true;
            change_showvolt();
            MessageBox.Show("已經設定好電池數量,可以輸入電池條碼");
        }

        private void btnbarcode_Click(object sender, EventArgs e)
        {

            if (count == baterynum)
            {
                txt_worknum.Enabled = true;
                txt_minvol.Enabled = true;
                txt_maxvol.Enabled = true;
                txt_dv.Enabled = true;

                button1.Enabled = true;
                MessageBox.Show("可以測試電壓");
            }
            else if (count == 1)
            {
                barcode.Clear();
                dataGridView1.DataSource = null;
            }
            dataGridView1.Rows[count].Cells[1].Value = txt_barcode.Text;
            barcode.Add(txt_barcode.Text);
            //dataGridView1["barcode",count].Value = txt_barcode.Text;
            count++;

        }

        private void button1_Click(object sender, EventArgs e)      //顯示是否有通過
        {
            string[] tmp;
            sp.WriteLine("MEAS:VOLT:DC? 10,0.0001,(@101:112)");
            Thread.Sleep(100);
            string values = sp.ReadLine();
            string res = "NG";
            double maxvol = 0.00;
            double minvol = 0.00;
            int flag = 0;
            bool ng = false;
            count = 1;
            tmp = values.Split(',');


            if (txt_worknum.Text == "") txt_worknum.Text = "無";
            dataGridView1.Rows[0].Cells[2].Value = txt_worknum.Text;



            #region
            if (txt_minvol.Text != "" && txt_maxvol.Text != "")
            {  //會有四種高低壓輸入情況 用以判斷
                maxvol = Convert.ToDouble(txt_maxvol.Text);
                minvol = Convert.ToDouble(txt_minvol.Text);
                flag = 1;
            }

            else if (txt_minvol.Text != "" && txt_maxvol.Text == "")
            {
                minvol = Convert.ToDouble(txt_minvol.Text);
                flag = 2;
            }

            else if (txt_minvol.Text == "" && txt_maxvol.Text != "")
            {
                maxvol = Convert.ToDouble(txt_maxvol.Text);
                flag = 3;
            }
            #endregion

            for (int i = 0; i < baterynum; i++)
            {
                //dataGridView1.Rows[i+1].Cells[1].Value = (Convert.ToDouble(tmp[i]) * 1000).ToString("F1");
                voltage.Add((Convert.ToDouble(tmp[i]) * 1000));
                dataGridView1.Rows[i + 1].Cells[2].Value = (Convert.ToDouble(tmp[i]) * 1000).ToString("0.00");
                dataGridView1.Rows[i + 1].Cells[3].Value = "Pass";



                #region
                if (flag == 1)
                {  //會有四種高低壓輸入情況 用以判斷

                    if (maxvol < (Convert.ToDouble(tmp[i]) * 1000) || minvol > (Convert.ToDouble(tmp[i]) * 1000))
                    {
                        dataGridView1.Rows[i + 1].Cells[3].Value = "NG";
                        ng = true;

                    }

                }


                else if (flag == 2)
                {

                    if (minvol > (Convert.ToDouble(tmp[i]) * 1000))
                    {
                        dataGridView1.Rows[i + 1].Cells[3].Value = "NG";
                        ng = true;
                    }

                }

                else if (flag == 3)
                {
                    if (maxvol < (Convert.ToDouble(tmp[i]) * 1000))
                    {

                        dataGridView1.Rows[i + 1].Cells[3].Value = "NG";
                        ng = true;

                    }

                }

                else
                {
                    dataGridView1.Rows[i + 1].Cells[3].Value = "NG";
                    ng = true;

                }

                #endregion


            }


            dataGridView1.Rows[13].Cells[2].Value = voltage.Max().ToString("0.00");
            dataGridView1.Rows[14].Cells[2].Value = voltage.Min().ToString("0.00");
            dataGridView1.Rows[15].Cells[2].Value = (voltage.Max() - voltage.Min()).ToString("0.00");



            double max = voltage.Max();
            double min = voltage.Min();

            dataGridView1.Rows[16].Cells[2].Value = "Pass";
            if (txt_dv.Text != "")
            {        //total_pass

                if ((max - min) > Convert.ToDouble(txt_dv.Text) || ng == true)    //當如果超出壓差範圍  錯誤
                {
                    dataGridView1.Rows[16].Cells[2].Value = "NG";
                }

            }


            string queryString = "insert into table1 ([worknum],[Vcell_1],[Vcell_2],[Vcell_3],[Vcell_4],[Vcell_5],[Vcell_6],[Vcell_7],[Vcell_8],[Vcell_9],[Vcell_10],[Vcell_11],[Vcell_12],[Max_volt],[Min_volt],[dv],[test_time],[barcode_1],[barcode_2],[barcode_3],[barcode_4],[barcode_5],[barcode_6],[barcode_7],[barcode_8],[barcode_9],[barcode_10],[barcode_11],[barcode_12],[Result]) " +
                "values ('" + txt_worknum.Text + "','" + voltage[0] + "','" + voltage[1] + "','" + voltage[2] + "','" + voltage[3] + "','" + voltage[4] + "','" + voltage[5] + "','" + voltage[6] + "','" + voltage[7] + "','" + voltage[8] + "','" + voltage[9] + "','" + voltage[10] + "','" + voltage[11] + "','" + max + "','" + min + "','" + (max - min) + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','"
                + barcode[0] + "','" + barcode[1] + "','" + barcode[2] + "','" + barcode[3] + "','" + barcode[4] + "','" + barcode[5] + "','" + barcode[6] + "','" + barcode[7] + "','" + barcode[8] + "','" + barcode[9] + "','" + barcode[10] + "','" + barcode[11] + "','" + res + "')";

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\測試用資料庫\practice_2.mdb"))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);

                try
                {
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("已經新增資料");
                    }

                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

        }

        private void btn_opencom_Click(object sender, EventArgs e)
        {
            txt_com.Visible = true;
            btn_setcom.Visible = true;
            btn_closecon.Visible = true;
            btn_opencom.Visible = false;
        }

        private void btn_closcom_Click(object sender, EventArgs e)
        {
            txt_com.Visible = false;
            btn_setcom.Visible = false;
            btn_closecon.Visible = false;
            btn_opencom.Visible = true;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}
