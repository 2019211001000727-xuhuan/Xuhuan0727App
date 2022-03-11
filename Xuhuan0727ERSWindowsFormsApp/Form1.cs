using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xuhuan0727ERSWindowsFormsApp
{
    public partial class EmployeeRecordsForm : Form
    {
        private TreeNode tvRootNode;

        public EmployeeRecordsForm()
        {
            InitializeComponent();
            PopulateTreeView();
            InitalizeListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulateTreeView()
        {
            statusBarPanel1.Tag = "Refreshing Employee Code. Please Wait...";
            this.Cursor = Cursors.WaitCursor;
            treeView1.Nodes.Clear();
            tvRootNode = new TreeNode("Employee Record");
            this.Cursor = Cursors.Default;
            treeView1.Nodes.Add(tvRootNode);

            TreeNodeCollection nodeCollection = tvRootNode.Nodes;
            XmlTextReader reader = new XmlTextReader("C:\\Users\\xuhuan\\source\\repos\\Xuhuan0727App\\Xuhuan0727ERSWindowsFormsApp\\EmpRec.xml");
            reader.MoveToElement();
            try
            {
                while (reader.Read())
                {
                    if(reader.HasAttributes && reader.NodeType == XmlNodeType.Element)
                    {
                        reader.MoveToElement();//<EmpRecordsData>
                        reader.MoveToElement();//<Ecode>

                        reader.MoveToAttribute("Id");//Id="E001"
                        String strVal = reader.Value;//E001 

                        reader.Read();
                        reader.Read();
                        if(reader.Name == "Dept")
                        {
                            reader.Read();
                        }
                        TreeNode EcodeNode = new TreeNode(strVal);
                        nodeCollection.Add(EcodeNode);
                    }
                }
                statusBarPanel1.Text = "Click on an employee code to see their record.";
            }
            catch(XmlException ex){
                MessageBox.Show(ex.Message);

            }
        }
        protected void InitalizeListView()
        {
            listView1.Clear();
            listView1.Columns.Add("Employee Name", 255,HorizontalAlignment.Left);
            listView1.Columns.Add("Date of Join", 70, HorizontalAlignment.Right);
            listView1.Columns.Add("Gread", 105, HorizontalAlignment.Left);
            listView1.Columns.Add("Salary", 105, HorizontalAlignment.Left);
        }
        protected void PopulateListView(TreeNode crrNode)
        {
            InitalizeListView();
            XmlTextReader listRead = new XmlTextReader("C:\\Users\\xuhuan\\source\\repos\\Xuhuan0727App\\Xuhuan0727ERSWindowsFormsApp\\EmpRec.xml");
            listRead.MoveToElement();
            while (listRead.Read())
            {
                String strNodeName;
                String strNodePath;
                String name;
                String gread;
                String doj;
                String sal;
                String[] strItemArr = new String[4];
                listRead.MoveToFirstAttribute();//Id="E001"
                strNodeName = listRead.Value;
                strNodePath = crrNode.FullPath.Remove(0,17);
                if(strNodePath == strNodeName)
                {
                    ListViewItem lvi;
                    listRead.MoveToNextAttribute();
                    name = listRead.Value;//Name="Michael Preey"
                    lvi = listView1.Items.Add(name);

                    listRead.Read();
                    listRead.Read();

                    listRead.MoveToFirstAttribute();
                    doj = listRead.Value;//DateofJoin="02-02-1999"
                    lvi.SubItems.Add(doj);

                    listRead.MoveToNextAttribute();
                    gread = listRead.Value;//Gread="A"
                    lvi.SubItems.Add(gread);

                    listRead.MoveToNextAttribute();
                    sal = listRead.Value;//Salary="1750"
                    lvi.SubItems.Add(sal);

                    listRead.MoveToNextAttribute();
                    listRead.MoveToElement();
                    listRead.ReadString();
                }

            }
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currNode = e.Node;
            if(tvRootNode == currNode)
            {
                InitalizeListView();
                statusBarPanel1.Text = "Double Click the Employee Records.";
                return;
            }
            else
            {
                statusBarPanel1.Text = "Click an Employee code to view Individual record";
            }
            PopulateListView(currNode);
        }
    }
}
