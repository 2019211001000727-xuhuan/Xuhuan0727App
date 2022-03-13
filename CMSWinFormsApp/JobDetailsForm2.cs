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
    public partial class JobDetailsForm2 : Form
    {
        public JobDetailsForm2()
        {
            InitializeComponent();
        }

        private void tb_JobDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_JobDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cMSDBDataSet1);

        }

        private void JobDetailsForm2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSDBDataSet1._tb_JobDetails”中。您可以根据需要移动或移除它。
            this.tb_JobDetailsTableAdapter.Fill(this.cMSDBDataSet1._tb_JobDetails);

        }
    }
}
