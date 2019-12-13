using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageebSoft.WinFormControl.FormX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmdAr_Click(object sender, EventArgs e)
        {
            var frm = getForm1();
            frm.lblUserName.Text = "اسم المستخدم";
            frm.lblPassWord.Text = "كلمة السر";
            frm.cmdOk.Text = "موافق";
            frm.cmdCancel.Text = "الغاء الأمر";
        }

        public Form1 getForm1()
        {
           var frm1=(Form1)Application.OpenForms[nameof(Form1)];
            if(frm1==null)
            {
                frm1 = new Form1();
                frm1.Show();
            }
            return frm1;
        }

        private void cmdEng_Click(object sender, EventArgs e)
        {
            var frm = getForm1();
            frm.lblUserName.Text = "User Name";
            frm.lblPassWord.Text = "Pass Word";
            frm.cmdOk.Text = "OK";
            frm.cmdCancel.Text = "Cancel";
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            var frm = getForm1();
            frm.Top = frm.Top - 20;
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            var frm = getForm1();
            frm.Top = frm.Top + 20;
        }

        private void cmdR_Click(object sender, EventArgs e)
        {
            var frm = getForm1();
            frm.Left = frm.Left + 20;
        }

        private void cmdL_Click(object sender, EventArgs e)
        {
            var frm = getForm1();
            frm.Left = frm.Left - 20;
        }

        private void CmdRUp_Click(object sender, EventArgs e)
        {

            cmdR_Click(null,null);
            cmdUp_Click(null, null);

        }

        private void cmdLUp_Click(object sender, EventArgs e)
        {
            cmdL_Click(null, null);
            cmdUp_Click(null, null);
        }

        private void cmdRDown_Click(object sender, EventArgs e)
        {
            cmdR_Click(null, null);
            cmdDown_Click(null, null);
        }

        private void cmdLDown_Click(object sender, EventArgs e)
        {
            cmdL_Click(null, null);
            cmdDown_Click(null, null);
        }
    }
}
