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
                if (flag == false)
                    return;
                else{
                    //database code - later
                    sqlDataAdapter1.Update(customerDataSet1);
                    MessageBox.Show("Database Updated");
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            customerDataSet1.Clear();
            sqlDataAdapter1.Fill(customerDataSet1);
            CurrentPosition();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.BindingContext[customerDataSet1, "tblCustomer"].Position += 1;
            CurrentPosition();
        }
        private void CurrentPosition()
        {
            int currentPosition, ctr;
            ctr = this.BindingContext[customerDataSet1, "tblCustomer"].Count;
            if(ctr == 0)
            {
                textBox5.Text = "No record";
            }
            else
            {
                currentPosition = this.BindingContext[customerDataSet1, "tblCustomer"].Position += 1;
                textBox5.Text = currentPosition.ToString()+" of "+ctr.ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnPrevious.BindingContext[customerDataSet1, "tblCustomer"].Position -= 1;
            CurrentPosition();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            customerDataSet1.Clear();
        }
    }
}
