using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bat_test
{
    public partial class Form_all : Form
    {
        public Form_all()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bool isFind = false;

            foreach (Form form in this.MdiChildren)
            {

                if (form.Name == "Form1")
                {
                    isFind = true;
                    form.MdiParent = this;
                    form.Focus();
                }

            }

            if (isFind == false)
            {
                Form1 fm = new Form1();
                fm.MdiParent = this;
                fm.Show();
            }

            //Form1 fm = new Form1();
            //fm.MdiParent = this;
            //fm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool isFind = false;

            foreach (Form form in this.MdiChildren)
            {

                if (form.Name == "Form2")
                {
                    isFind = true;
                    form.MdiParent = this;
                    form.Focus();
                }

            }

            if (isFind == false)
            {
                Form2 fm = new Form2();
                fm.MdiParent = this;
                fm.Show();
            }

            //Form2 fm = new Form2();
            //fm.MdiParent = this;
            //fm.Show();
        }
    }
}
