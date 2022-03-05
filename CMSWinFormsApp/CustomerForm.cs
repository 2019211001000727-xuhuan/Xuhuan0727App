using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCusForm.SetError(textBox1, "");
            errCusForm.SetError(textBox2, "");
            errCusForm.SetError(textBox3, "");
            errCusForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                if(textBox1.Text == "")
                {
                    errCusForm.SetError(textBox1, "Please Specify a Vaild Car Number.");
                    flag = false;
                }
                else{
                    errCusForm.SetError(textBox1, "");
                }
                if(textBox2.Text == "")
                {
                    errCusForm.SetError(textBox2, "Please Specify a Vaild Name.");
                    flag = false;
                }
                else{
                    errCusForm.SetError(textBox2, "");
                }
                if (textBox2.Text == "")
                {
                    errCusForm.SetError(textBox3, "Please Specify a Vaild Address.");
                    flag = false;
                }
                else
                {
                    errCusForm.SetError(textBox3, "");
                }
                if (textBox2.Text == "")
                {
                    errCusForm.SetError(textBox4, "Please Specify a Vaild Make.");
                    flag = false;
                }
                else
                {
                    errCusForm.SetError(textBox4, "");
                }
                if (false == false)
                    return;
                else{
                    //database code - later
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
