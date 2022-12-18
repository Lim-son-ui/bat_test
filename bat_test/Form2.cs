using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bat_test
{
    public partial class Form2 : Form
    {
        //Dbpractice Dbcontext = new Dbpractice();
        int flag = 0;
        public Form2()
        {
            InitializeComponent();
        }

        void reload()
        {

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\測試用資料庫\practice_2.mdb"))
            {

                try
                {
                    DataSet ds = new DataSet();
                    string sql = $"select * from table1";


                    connection.Open();
                    #region
                    //OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);
                    //adapter.Fill(ds);
                    //dataGridView1.DataSource = ds.Tables[0];
                    #endregion

                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];


                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.cmb_select.Items.Add("工單號碼");
            this.cmb_select.Items.Add("條碼");
            this.cmb_select.Items.Add("測試時間範圍");

            reload();
            all_false();
        }

        void all_false()
        {
            label1.Enabled = false;
            txt_inp.Enabled = false;

            lbl_batnum.Enabled = false;
            lbl_barcode.Enabled = false;
            txt_batnum.Enabled = false;
            txt_barcode.Enabled = false;

            lbl_dateup.Enabled = false;
            lbl_datedown.Enabled = false;
            dpicker_up.Enabled = false;
            dpicker_down.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string queryString = $"select * from table1 where 工單號碼 = '{cmb_work.Text}' ";
            #region
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\測試用資料庫\practice_2.mdb"))
            {
                //OleDbCommand command = new OleDbCommand(queryString, connection);

                try
                {
                    DataSet ds = new DataSet();
                    connection.Open();

                    //string sql = "select * from table1";
                    string sql = "";

                    if (flag == 1)
                    {
                        sql = $"select * from table1 where worknum = '{txt_inp.Text}' ";
                    }
                    else if (flag == 2)
                    {
                        sql = $"select * from table1 where barcode_{txt_batnum.Text} = '{txt_barcode.Text}' ";
                    }
                    else if (flag == 3)
                    {
                        sql = $"select * from table1 where test_time between '#{dpicker_down.Value.Date}#' and '#{dpicker_up.Value.Date}#'";
                        //sql = $"select * from table1 where test_time >= '{dpicker_down.Value.ToString("yyyy/M/d")}' and test_time <= '{dpicker_up.Value.ToString("yyyy/M/d")}' ";
                    }

                    dataGridView1.DataSource = null;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    #region
                    //OleDbDataReader reader = command.ExecuteReader();

                    //while (reader.Read())
                    //{
                    //    //string worknum = reader[0].ToString();
                    //    double volt1 = (double)reader[2];


                    //}

                    //reader.Close();
                    #endregion

                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            #endregion


            #region
            //var tes = new Dbpractice();

            ////var result = Dbcontext.table1.Select(a => a).ToList();

            //var result = tes.table1.Select(a => a).ToList();
            #endregion
            //dataGridView1.DataSource = result;

            //dataGridView1.DataSource = this.Dbcontext.table1;


        }

        void change_txtbox()
        {
            label1.Enabled = true;
            txt_inp.Enabled = true;
        }

        void change_batery()
        {
            lbl_batnum.Enabled = true;
            lbl_barcode.Enabled = true;
            txt_batnum.Enabled = true;
            txt_barcode.Enabled = true;
        }
        void change_datepicker()
        {
            lbl_datedown.Enabled = true;
            lbl_dateup.Enabled = true;
            dpicker_down.Enabled = true;
            dpicker_up.Enabled = true;
        }

        private void cmb_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select.SelectedIndex == 0)
            {    //工單號碼
                all_false();
                change_txtbox();
                flag = 1;
            }
            else if (cmb_select.SelectedIndex == 1)
            {   //條碼
                all_false();
                change_batery();
                flag = 2;
            }
            else
            {                  //測試時間
                all_false();
                change_datepicker();
                flag = 3;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string queryString = "insert into table1 ([worknum],[Vcell_1],[Vcell_2],[Vcell_3],[Vcell_4],[Vcell_5],[Vcell_6],[Vcell_7],[Vcell_8],[Vcell_9],[Vcell_10],[Vcell_11],[Vcell_12],[Max_volt],[Min_volt],[dv],[test_time],[barcode_1],[barcode_2],[barcode_3],[barcode_4],[barcode_5],[barcode_6],[barcode_7],[barcode_8],[barcode_9],[barcode_10],[barcode_11],[barcode_12],[Result]) " +
              "values ('" + 124 + "','" + 1 + "','" + 2 + "','" + 3 + "','" + 4 + "','" + 5 + "','" + 6 + "','" + 7 + "','" + 8 + "','" + 9 + "','" + 10 + "','" + 11 + "','" + 12 + "','" + 12 + "','" + 1 + "','" + 11 + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','"
              + 1 + "','" + 2 + "','" + 3 + "','" + 4 + "','" + 5 + "','" + 6 + "','" + 7 + "','" + 8 + "','" + 9 + "','" + 10 + "','" + 11 + "','" + 12 + "','PASS')";

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

        private void btn_csv_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\測試用資料庫\practice_2.mdb"))
            {
                //OleDbCommand command = new OleDbCommand(queryString, connection);

                try
                {
                    DataSet ds = new DataSet();
                    connection.Open();

                    string sql = "select * from table1";


                    OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);
                    adapter.Fill(ds);

                    //string col = "";
                    //string row = "";

                    List<string> col = new List<string>();
                    //List<string> row = new List<string>();

                    foreach (DataColumn cl in ds.Tables[0].Columns)
                    {
                        //col = cl.ColumnName;
                        col.Add(cl.ColumnName);
                    }
                    #region
                    //foreach (DataRow dr in ds.Tables[0].Rows) {
                    //    for (int i = 0;i < ds.Tables[0].Columns.Count; i++) {
                    //        //row = dr[i].ToString();
                    //        row.Add(dr[i].ToString());
                    //    }
                    //}
                    #endregion

                    using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\mylog.csv"))
                    {
                        string tmp2 = "";
                        


                        foreach (string c in col)
                        {
                            tmp2 += c + ",";
                        }
                        sw.WriteLine(tmp2);
                        #region
                        //int j = 0;
                        //tmp2 = "";
                        //foreach(string r in row)
                        //{
                        //    tmp2 += r + ",";
                        //    j++;
                        //    if (j == 31) {
                        //        sw.WriteLine(tmp2);
                        //        j = 0;
                        //        tmp2 = "";

                        //    }
                        //}
                        #endregion

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            tmp2 = "";
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                tmp2 += dataGridView1.Rows[i].Cells[k].Value + ",";
                            }
                            sw.WriteLine(tmp2);
                        }


                        sw.Close();
                    }

                    #region
                    //OleDbDataReader reader = command.ExecuteReader();

                    //while (reader.Read())
                    //{
                    //    //string worknum = reader[0].ToString();
                    //    double volt1 = (double)reader[2];


                    //}

                    //reader.Close();
                    #endregion

                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
