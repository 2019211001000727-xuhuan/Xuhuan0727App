using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Xuhuan0727Project3CLSApp
{
    public partial class frmCreative : Form
    {
        private Icon m_ready = new Icon(SystemIcons.WinLogo,40,40);
        private Icon m_info = new Icon(SystemIcons.Information, 40, 40);
        private Icon m_error = new Icon(SystemIcons.Error, 40, 40);

        public frmCreative()
        {
            InitializeComponent();
        }

        private void frmCreative_Load(object sender, EventArgs e)
        {
            txtSource.Text = "D:\\Creative\\Source\\";
            txtProcessedFile.Text = "D:\\Creative\\Processed\\";
            txtDest.Text = "D:\\Creative\\Destination\\";
            optGenerateLog.Checked = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //source text box validation
            if (!Directory.Exists(txtSource.Text))
            {
                errMessage.SetError(txtSource, "Invaild Source Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtSource, "");//no error
            //processedFile text box validation
            if (!Directory.Exists(txtProcessedFile.Text))
            {
                errMessage.SetError(txtProcessedFile, "Invaild ProcessedFile Directory");
                txtProcessedFile.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtProcessedFile, "");//no error
             //destination text box validation
            if (!Directory.Exists(txtDest.Text))
            {
                errMessage.SetError(txtDest, "Invaild Destination Directory");
                txtDest.Focus();
                tabControl1.SelectedTab = tabDest;
                return;
            }
            else
                errMessage.SetError(txtDest, "");//no error

            watchDir.EnableRaisingEvents = true;
            watchDir.Path = txtSource.Text;

            mnuNotify.Icon = m_ready;
            mnuNotify.Visible = true;
            this.ShowInTaskbar = true;
            this.Hide();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProcessedFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSource_KeyUp(object sender, KeyEventArgs e)
        {
            //validate source
            if (Directory.Exists(txtSource.Text))
            {
                //no error
                txtSource.BackColor = Color.White;
            }
            else
            {
                //error
                txtSource.BackColor = Color.Pink;
            }
        }

        private void txtProcessedFile_KeyUp(object sender, KeyEventArgs e)
        {
            //validate Processed File
            if (Directory.Exists(txtProcessedFile.Text))
            {
                //no error
                txtProcessedFile.BackColor = Color.White;
            }
            else
            {
                //error
                txtProcessedFile.BackColor = Color.Pink;
            }
        }

        private void txtDest_KeyUp(object sender, KeyEventArgs e)
        {
            //validate Destination
            if (Directory.Exists(txtDest.Text))
            {
                //no error
                txtDest.BackColor = Color.White;
            }
            else
            {
                //error
                txtDest.BackColor = Color.Pink;
            } 
        }

        private void configureApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNotify_DoubleClick(object sender, EventArgs e)
        {
            mnuNotify.Visible=false;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void watchDir_Created(object sender, FileSystemEventArgs e)
        {
            watchDir.EnableRaisingEvents = false;
            mnuNotify.Icon = m_info;
            mnuNotify.Text = "Processed: " + e.Name;
            Microsoft.Office.Interop.Word.Application wdapp = new Microsoft.Office.Interop.Word.Application();
            object optional = System.Reflection.Missing.Value;
            XmlTextWriter xmlTextWriter = new XmlTextWriter(txtDest.Text + "summary.xml",null);
            try
            {
                Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
                object filename = e.Name;
                doc = wdapp.Documents.Open(ref filename, ref optional, ref optional, ref optional, ref optional, ref optional,
                    ref optional, ref optional, ref optional, ref optional, ref optional);

                Microsoft.Office.Interop.Word.Range wdRange;
                wdRange = doc.Paragraphs[2].Range;

                string strMemo, strAmount;
                int intParacount;
                strMemo = wdRange.Text;
                strAmount = strMemo.Substring(15, 4);
                intParacount = doc.Paragraphs.Count;
                intParacount = intParacount - 2;

                wdRange - doc.Paragraphs[(intParacount].Range;
                Object count = -1;
                Object wdCharecter = "1";

                wdRange.MoveEnd(ref wdCharecter, ref count);
                strAmount = wdRange.Text;

                strAmount = strAmount.Substring(23);

                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.WriteDocType("Sales", null, null, null);
                xmlTextWriter.WriteComment("Summary of sales at Creative Learning");
                xmlTextWriter.WriteStartElement("Sales");
                xmlTextWriter.WriteStartElement(Convert.ToString(DateTime.Today));
                xmlTextWriter.WriteElementString("Meno", strMemo);
                xmlTextWriter.WriteElementString("Amount", strAmount);
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();
                mnuNotify.Icon = m_ready;
            }
            catch (Exception ex)
            {
                mnuNotify.Icon = m_error;
                mnuNotify.Text = "Error in " + e.Name;
                if(optGenerateLog.Checked == true)
                {
                    eventLog1.WriteEntry(e.Name + ": " + ex.Message);
                }
            }
            finally
            {
                xmlTextWriter.Flush();
                xmlTextWriter.Close();

                wdapp.Quit(ref optional, ref optional, ref optional);
                wdapp = null;
                watchDir.EnableRaisingEvents = true;
            }
            tryagain:
            try
            {
                File.Move(e.FullPath, txtProcessedFile.Text + e.Name);
            }
            catch
            {
                goto tryagain;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
            eventLog1.Log = "Application";
            eventLog1.MachineName = ".";
            foreach(EventLogEntry logEntry in eventLog1.Entries)
            {
                if(logEntry.Source == "CreativeLearning")
                {
                    lstEvents.Items.Add(logEntry.Message);
                }
            }
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            StreamReader strRead;
            try
            {
                strRead = new StreamReader(txtDest.Text + "Summary.xml");
                MessageBox.Show(strRead.ReadToEnd(), txtDest.Text + "summary.xml", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                strRead.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error was returned: " + ex.Message + "Please check the destination folder for summary");
            }
        }
    }
}
