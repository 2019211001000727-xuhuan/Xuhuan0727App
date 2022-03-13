namespace CMSWinFormsApp
{
    partial class JobDetailsForm2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetailsForm2));
            System.Windows.Forms.Label carNoLabel;
            System.Windows.Forms.Label jobDateLabel;
            System.Windows.Forms.Label workerIDLabel;
            System.Windows.Forms.Label kMsLabel;
            System.Windows.Forms.Label tunningLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label balancingLabel;
            System.Windows.Forms.Label tiresLabel;
            System.Windows.Forms.Label weightsLabel;
            System.Windows.Forms.Label oilChangedLabel;
            System.Windows.Forms.Label oilQryLabel;
            System.Windows.Forms.Label oilFilterLabel;
            System.Windows.Forms.Label gearOilLabel;
            System.Windows.Forms.Label gearOilQryLabel;
            System.Windows.Forms.Label pointLabel;
            System.Windows.Forms.Label condenserLabel;
            System.Windows.Forms.Label plugLabel;
            System.Windows.Forms.Label plugQtyLabel;
            System.Windows.Forms.Label fuelFilterLabel;
            System.Windows.Forms.Label airFilterLabel;
            System.Windows.Forms.Label remarksLabel;
            this.cMSDBDataSet1 = new CMSWinFormsApp.CMSDBDataSet1();
            this.tb_JobDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_JobDetailsTableAdapter = new CMSWinFormsApp.CMSDBDataSet1TableAdapters.tb_JobDetailsTableAdapter();
            this.tableAdapterManager = new CMSWinFormsApp.CMSDBDataSet1TableAdapters.TableAdapterManager();
            this.tb_JobDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_JobDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carNoTextBox = new System.Windows.Forms.TextBox();
            this.jobDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerIDTextBox = new System.Windows.Forms.TextBox();
            this.kMsTextBox = new System.Windows.Forms.TextBox();
            this.tunningTextBox = new System.Windows.Forms.TextBox();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.balancingTextBox = new System.Windows.Forms.TextBox();
            this.tiresTextBox = new System.Windows.Forms.TextBox();
            this.weightsTextBox = new System.Windows.Forms.TextBox();
            this.oilChangedTextBox = new System.Windows.Forms.TextBox();
            this.oilQryTextBox = new System.Windows.Forms.TextBox();
            this.oilFilterTextBox = new System.Windows.Forms.TextBox();
            this.gearOilTextBox = new System.Windows.Forms.TextBox();
            this.gearOilQryTextBox = new System.Windows.Forms.TextBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.condenserTextBox = new System.Windows.Forms.TextBox();
            this.plugTextBox = new System.Windows.Forms.TextBox();
            this.plugQtyTextBox = new System.Windows.Forms.TextBox();
            this.fuelFilterTextBox = new System.Windows.Forms.TextBox();
            this.airFilterTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            carNoLabel = new System.Windows.Forms.Label();
            jobDateLabel = new System.Windows.Forms.Label();
            workerIDLabel = new System.Windows.Forms.Label();
            kMsLabel = new System.Windows.Forms.Label();
            tunningLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            balancingLabel = new System.Windows.Forms.Label();
            tiresLabel = new System.Windows.Forms.Label();
            weightsLabel = new System.Windows.Forms.Label();
            oilChangedLabel = new System.Windows.Forms.Label();
            oilQryLabel = new System.Windows.Forms.Label();
            oilFilterLabel = new System.Windows.Forms.Label();
            gearOilLabel = new System.Windows.Forms.Label();
            gearOilQryLabel = new System.Windows.Forms.Label();
            pointLabel = new System.Windows.Forms.Label();
            condenserLabel = new System.Windows.Forms.Label();
            plugLabel = new System.Windows.Forms.Label();
            plugQtyLabel = new System.Windows.Forms.Label();
            fuelFilterLabel = new System.Windows.Forms.Label();
            airFilterLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_JobDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_JobDetailsBindingNavigator)).BeginInit();
            this.tb_JobDetailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMSDBDataSet1
            // 
            this.cMSDBDataSet1.DataSetName = "CMSDBDataSet1";
            this.cMSDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_JobDetailsBindingSource
            // 
            this.tb_JobDetailsBindingSource.DataMember = "tb|JobDetails";
            this.tb_JobDetailsBindingSource.DataSource = this.cMSDBDataSet1;
            // 
            // tb_JobDetailsTableAdapter
            // 
            this.tb_JobDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_JobDetailsTableAdapter = this.tb_JobDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMSWinFormsApp.CMSDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_JobDetailsBindingNavigator
            // 
            this.tb_JobDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_JobDetailsBindingNavigator.BindingSource = this.tb_JobDetailsBindingSource;
            this.tb_JobDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_JobDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_JobDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_JobDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_JobDetailsBindingNavigatorSaveItem});
            this.tb_JobDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_JobDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_JobDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_JobDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_JobDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_JobDetailsBindingNavigator.Name = "tb_JobDetailsBindingNavigator";
            this.tb_JobDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_JobDetailsBindingNavigator.Size = new System.Drawing.Size(923, 27);
            this.tb_JobDetailsBindingNavigator.TabIndex = 0;
            this.tb_JobDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 20);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // tb_JobDetailsBindingNavigatorSaveItem
            // 
            this.tb_JobDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_JobDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_JobDetailsBindingNavigatorSaveItem.Image")));
            this.tb_JobDetailsBindingNavigatorSaveItem.Name = "tb_JobDetailsBindingNavigatorSaveItem";
            this.tb_JobDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tb_JobDetailsBindingNavigatorSaveItem.Text = "保存数据";
            this.tb_JobDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_JobDetailsBindingNavigatorSaveItem_Click);
            // 
            // carNoLabel
            // 
            carNoLabel.AutoSize = true;
            carNoLabel.Location = new System.Drawing.Point(71, 53);
            carNoLabel.Name = "carNoLabel";
            carNoLabel.Size = new System.Drawing.Size(63, 15);
            carNoLabel.TabIndex = 1;
            carNoLabel.Text = "Car No:";
            // 
            // carNoTextBox
            // 
            this.carNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "CarNo", true));
            this.carNoTextBox.Location = new System.Drawing.Point(140, 50);
            this.carNoTextBox.Name = "carNoTextBox";
            this.carNoTextBox.Size = new System.Drawing.Size(100, 25);
            this.carNoTextBox.TabIndex = 2;
            // 
            // jobDateLabel
            // 
            jobDateLabel.AutoSize = true;
            jobDateLabel.Location = new System.Drawing.Point(55, 98);
            jobDateLabel.Name = "jobDateLabel";
            jobDateLabel.Size = new System.Drawing.Size(79, 15);
            jobDateLabel.TabIndex = 3;
            jobDateLabel.Text = "Job Date:";
            // 
            // jobDateDateTimePicker
            // 
            this.jobDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_JobDetailsBindingSource, "JobDate", true));
            this.jobDateDateTimePicker.Location = new System.Drawing.Point(140, 94);
            this.jobDateDateTimePicker.Name = "jobDateDateTimePicker";
            this.jobDateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.jobDateDateTimePicker.TabIndex = 4;
            // 
            // workerIDLabel
            // 
            workerIDLabel.AutoSize = true;
            workerIDLabel.Location = new System.Drawing.Point(47, 142);
            workerIDLabel.Name = "workerIDLabel";
            workerIDLabel.Size = new System.Drawing.Size(87, 15);
            workerIDLabel.TabIndex = 5;
            workerIDLabel.Text = "Worker ID:";
            // 
            // workerIDTextBox
            // 
            this.workerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "WorkerID", true));
            this.workerIDTextBox.Location = new System.Drawing.Point(140, 139);
            this.workerIDTextBox.Name = "workerIDTextBox";
            this.workerIDTextBox.Size = new System.Drawing.Size(100, 25);
            this.workerIDTextBox.TabIndex = 6;
            // 
            // kMsLabel
            // 
            kMsLabel.AutoSize = true;
            kMsLabel.Location = new System.Drawing.Point(95, 188);
            kMsLabel.Name = "kMsLabel";
            kMsLabel.Size = new System.Drawing.Size(39, 15);
            kMsLabel.TabIndex = 7;
            kMsLabel.Text = "KMs:";
            // 
            // kMsTextBox
            // 
            this.kMsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "KMs", true));
            this.kMsTextBox.Location = new System.Drawing.Point(140, 185);
            this.kMsTextBox.Name = "kMsTextBox";
            this.kMsTextBox.Size = new System.Drawing.Size(100, 25);
            this.kMsTextBox.TabIndex = 8;
            // 
            // tunningLabel
            // 
            tunningLabel.AutoSize = true;
            tunningLabel.Location = new System.Drawing.Point(63, 234);
            tunningLabel.Name = "tunningLabel";
            tunningLabel.Size = new System.Drawing.Size(71, 15);
            tunningLabel.TabIndex = 9;
            tunningLabel.Text = "Tunning:";
            // 
            // tunningTextBox
            // 
            this.tunningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Tunning", true));
            this.tunningTextBox.Location = new System.Drawing.Point(140, 231);
            this.tunningTextBox.Name = "tunningTextBox";
            this.tunningTextBox.Size = new System.Drawing.Size(100, 25);
            this.tunningTextBox.TabIndex = 10;
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new System.Drawing.Point(47, 281);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(87, 15);
            alignmentLabel.TabIndex = 11;
            alignmentLabel.Text = "Alignment:";
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Alignment", true));
            this.alignmentTextBox.Location = new System.Drawing.Point(140, 278);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.Size = new System.Drawing.Size(100, 25);
            this.alignmentTextBox.TabIndex = 12;
            // 
            // balancingLabel
            // 
            balancingLabel.AutoSize = true;
            balancingLabel.Location = new System.Drawing.Point(47, 328);
            balancingLabel.Name = "balancingLabel";
            balancingLabel.Size = new System.Drawing.Size(87, 15);
            balancingLabel.TabIndex = 13;
            balancingLabel.Text = "Balancing:";
            // 
            // balancingTextBox
            // 
            this.balancingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Balancing", true));
            this.balancingTextBox.Location = new System.Drawing.Point(140, 325);
            this.balancingTextBox.Name = "balancingTextBox";
            this.balancingTextBox.Size = new System.Drawing.Size(100, 25);
            this.balancingTextBox.TabIndex = 14;
            // 
            // tiresLabel
            // 
            tiresLabel.AutoSize = true;
            tiresLabel.Location = new System.Drawing.Point(79, 376);
            tiresLabel.Name = "tiresLabel";
            tiresLabel.Size = new System.Drawing.Size(55, 15);
            tiresLabel.TabIndex = 15;
            tiresLabel.Text = "Tires:";
            // 
            // tiresTextBox
            // 
            this.tiresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Tires", true));
            this.tiresTextBox.Location = new System.Drawing.Point(140, 373);
            this.tiresTextBox.Name = "tiresTextBox";
            this.tiresTextBox.Size = new System.Drawing.Size(100, 25);
            this.tiresTextBox.TabIndex = 16;
            // 
            // weightsLabel
            // 
            weightsLabel.AutoSize = true;
            weightsLabel.Location = new System.Drawing.Point(63, 427);
            weightsLabel.Name = "weightsLabel";
            weightsLabel.Size = new System.Drawing.Size(71, 15);
            weightsLabel.TabIndex = 17;
            weightsLabel.Text = "Weights:";
            // 
            // weightsTextBox
            // 
            this.weightsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Weights", true));
            this.weightsTextBox.Location = new System.Drawing.Point(140, 424);
            this.weightsTextBox.Name = "weightsTextBox";
            this.weightsTextBox.Size = new System.Drawing.Size(100, 25);
            this.weightsTextBox.TabIndex = 18;
            // 
            // oilChangedLabel
            // 
            oilChangedLabel.AutoSize = true;
            oilChangedLabel.Location = new System.Drawing.Point(31, 477);
            oilChangedLabel.Name = "oilChangedLabel";
            oilChangedLabel.Size = new System.Drawing.Size(103, 15);
            oilChangedLabel.TabIndex = 19;
            oilChangedLabel.Text = "Oil Changed:";
            // 
            // oilChangedTextBox
            // 
            this.oilChangedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "OilChanged", true));
            this.oilChangedTextBox.Location = new System.Drawing.Point(140, 474);
            this.oilChangedTextBox.Name = "oilChangedTextBox";
            this.oilChangedTextBox.Size = new System.Drawing.Size(100, 25);
            this.oilChangedTextBox.TabIndex = 20;
            // 
            // oilQryLabel
            // 
            oilQryLabel.AutoSize = true;
            oilQryLabel.Location = new System.Drawing.Point(63, 525);
            oilQryLabel.Name = "oilQryLabel";
            oilQryLabel.Size = new System.Drawing.Size(71, 15);
            oilQryLabel.TabIndex = 21;
            oilQryLabel.Text = "Oil Qry:";
            // 
            // oilQryTextBox
            // 
            this.oilQryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "OilQry", true));
            this.oilQryTextBox.Location = new System.Drawing.Point(140, 522);
            this.oilQryTextBox.Name = "oilQryTextBox";
            this.oilQryTextBox.Size = new System.Drawing.Size(100, 25);
            this.oilQryTextBox.TabIndex = 22;
            // 
            // oilFilterLabel
            // 
            oilFilterLabel.AutoSize = true;
            oilFilterLabel.Location = new System.Drawing.Point(529, 53);
            oilFilterLabel.Name = "oilFilterLabel";
            oilFilterLabel.Size = new System.Drawing.Size(95, 15);
            oilFilterLabel.TabIndex = 23;
            oilFilterLabel.Text = "Oil Filter:";
            // 
            // oilFilterTextBox
            // 
            this.oilFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "OilFilter", true));
            this.oilFilterTextBox.Location = new System.Drawing.Point(630, 50);
            this.oilFilterTextBox.Name = "oilFilterTextBox";
            this.oilFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.oilFilterTextBox.TabIndex = 24;
            // 
            // gearOilLabel
            // 
            gearOilLabel.AutoSize = true;
            gearOilLabel.Location = new System.Drawing.Point(545, 98);
            gearOilLabel.Name = "gearOilLabel";
            gearOilLabel.Size = new System.Drawing.Size(79, 15);
            gearOilLabel.TabIndex = 25;
            gearOilLabel.Text = "Gear Oil:";
            // 
            // gearOilTextBox
            // 
            this.gearOilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "GearOil", true));
            this.gearOilTextBox.Location = new System.Drawing.Point(630, 95);
            this.gearOilTextBox.Name = "gearOilTextBox";
            this.gearOilTextBox.Size = new System.Drawing.Size(100, 25);
            this.gearOilTextBox.TabIndex = 26;
            // 
            // gearOilQryLabel
            // 
            gearOilQryLabel.AutoSize = true;
            gearOilQryLabel.Location = new System.Drawing.Point(513, 142);
            gearOilQryLabel.Name = "gearOilQryLabel";
            gearOilQryLabel.Size = new System.Drawing.Size(111, 15);
            gearOilQryLabel.TabIndex = 27;
            gearOilQryLabel.Text = "Gear Oil Qry:";
            // 
            // gearOilQryTextBox
            // 
            this.gearOilQryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "GearOilQry", true));
            this.gearOilQryTextBox.Location = new System.Drawing.Point(630, 139);
            this.gearOilQryTextBox.Name = "gearOilQryTextBox";
            this.gearOilQryTextBox.Size = new System.Drawing.Size(100, 25);
            this.gearOilQryTextBox.TabIndex = 28;
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Location = new System.Drawing.Point(569, 188);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new System.Drawing.Size(55, 15);
            pointLabel.TabIndex = 29;
            pointLabel.Text = "Point:";
            // 
            // pointTextBox
            // 
            this.pointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Point", true));
            this.pointTextBox.Location = new System.Drawing.Point(630, 185);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(100, 25);
            this.pointTextBox.TabIndex = 30;
            // 
            // condenserLabel
            // 
            condenserLabel.AutoSize = true;
            condenserLabel.Location = new System.Drawing.Point(537, 234);
            condenserLabel.Name = "condenserLabel";
            condenserLabel.Size = new System.Drawing.Size(87, 15);
            condenserLabel.TabIndex = 31;
            condenserLabel.Text = "Condenser:";
            // 
            // condenserTextBox
            // 
            this.condenserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Condenser", true));
            this.condenserTextBox.Location = new System.Drawing.Point(630, 231);
            this.condenserTextBox.Name = "condenserTextBox";
            this.condenserTextBox.Size = new System.Drawing.Size(100, 25);
            this.condenserTextBox.TabIndex = 32;
            // 
            // plugLabel
            // 
            plugLabel.AutoSize = true;
            plugLabel.Location = new System.Drawing.Point(577, 281);
            plugLabel.Name = "plugLabel";
            plugLabel.Size = new System.Drawing.Size(47, 15);
            plugLabel.TabIndex = 33;
            plugLabel.Text = "Plug:";
            // 
            // plugTextBox
            // 
            this.plugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Plug", true));
            this.plugTextBox.Location = new System.Drawing.Point(630, 278);
            this.plugTextBox.Name = "plugTextBox";
            this.plugTextBox.Size = new System.Drawing.Size(100, 25);
            this.plugTextBox.TabIndex = 34;
            // 
            // plugQtyLabel
            // 
            plugQtyLabel.AutoSize = true;
            plugQtyLabel.Location = new System.Drawing.Point(545, 328);
            plugQtyLabel.Name = "plugQtyLabel";
            plugQtyLabel.Size = new System.Drawing.Size(79, 15);
            plugQtyLabel.TabIndex = 35;
            plugQtyLabel.Text = "Plug Qty:";
            // 
            // plugQtyTextBox
            // 
            this.plugQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "PlugQty", true));
            this.plugQtyTextBox.Location = new System.Drawing.Point(630, 325);
            this.plugQtyTextBox.Name = "plugQtyTextBox";
            this.plugQtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.plugQtyTextBox.TabIndex = 36;
            // 
            // fuelFilterLabel
            // 
            fuelFilterLabel.AutoSize = true;
            fuelFilterLabel.Location = new System.Drawing.Point(521, 376);
            fuelFilterLabel.Name = "fuelFilterLabel";
            fuelFilterLabel.Size = new System.Drawing.Size(103, 15);
            fuelFilterLabel.TabIndex = 37;
            fuelFilterLabel.Text = "Fuel Filter:";
            // 
            // fuelFilterTextBox
            // 
            this.fuelFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "FuelFilter", true));
            this.fuelFilterTextBox.Location = new System.Drawing.Point(630, 373);
            this.fuelFilterTextBox.Name = "fuelFilterTextBox";
            this.fuelFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.fuelFilterTextBox.TabIndex = 38;
            // 
            // airFilterLabel
            // 
            airFilterLabel.AutoSize = true;
            airFilterLabel.Location = new System.Drawing.Point(529, 427);
            airFilterLabel.Name = "airFilterLabel";
            airFilterLabel.Size = new System.Drawing.Size(95, 15);
            airFilterLabel.TabIndex = 39;
            airFilterLabel.Text = "Air Filter:";
            // 
            // airFilterTextBox
            // 
            this.airFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "AirFilter", true));
            this.airFilterTextBox.Location = new System.Drawing.Point(630, 424);
            this.airFilterTextBox.Name = "airFilterTextBox";
            this.airFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.airFilterTextBox.TabIndex = 40;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(553, 477);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(71, 15);
            remarksLabel.TabIndex = 41;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_JobDetailsBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(630, 474);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(100, 25);
            this.remarksTextBox.TabIndex = 42;
            // 
            // JobDetailsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 765);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(airFilterLabel);
            this.Controls.Add(this.airFilterTextBox);
            this.Controls.Add(fuelFilterLabel);
            this.Controls.Add(this.fuelFilterTextBox);
            this.Controls.Add(plugQtyLabel);
            this.Controls.Add(this.plugQtyTextBox);
            this.Controls.Add(plugLabel);
            this.Controls.Add(this.plugTextBox);
            this.Controls.Add(condenserLabel);
            this.Controls.Add(this.condenserTextBox);
            this.Controls.Add(pointLabel);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(gearOilQryLabel);
            this.Controls.Add(this.gearOilQryTextBox);
            this.Controls.Add(gearOilLabel);
            this.Controls.Add(this.gearOilTextBox);
            this.Controls.Add(oilFilterLabel);
            this.Controls.Add(this.oilFilterTextBox);
            this.Controls.Add(oilQryLabel);
            this.Controls.Add(this.oilQryTextBox);
            this.Controls.Add(oilChangedLabel);
            this.Controls.Add(this.oilChangedTextBox);
            this.Controls.Add(weightsLabel);
            this.Controls.Add(this.weightsTextBox);
            this.Controls.Add(tiresLabel);
            this.Controls.Add(this.tiresTextBox);
            this.Controls.Add(balancingLabel);
            this.Controls.Add(this.balancingTextBox);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(this.alignmentTextBox);
            this.Controls.Add(tunningLabel);
            this.Controls.Add(this.tunningTextBox);
            this.Controls.Add(kMsLabel);
            this.Controls.Add(this.kMsTextBox);
            this.Controls.Add(workerIDLabel);
            this.Controls.Add(this.workerIDTextBox);
            this.Controls.Add(jobDateLabel);
            this.Controls.Add(this.jobDateDateTimePicker);
            this.Controls.Add(carNoLabel);
            this.Controls.Add(this.carNoTextBox);
            this.Controls.Add(this.tb_JobDetailsBindingNavigator);
            this.Name = "JobDetailsForm2";
            this.Text = "JobDetailsForm2";
            this.Load += new System.EventHandler(this.JobDetailsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cMSDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_JobDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_JobDetailsBindingNavigator)).EndInit();
            this.tb_JobDetailsBindingNavigator.ResumeLayout(false);
            this.tb_JobDetailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CMSDBDataSet1 cMSDBDataSet1;
        private System.Windows.Forms.BindingSource tb_JobDetailsBindingSource;
        private CMSDBDataSet1TableAdapters.tb_JobDetailsTableAdapter tb_JobDetailsTableAdapter;
        private CMSDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_JobDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_JobDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox carNoTextBox;
        private System.Windows.Forms.DateTimePicker jobDateDateTimePicker;
        private System.Windows.Forms.TextBox workerIDTextBox;
        private System.Windows.Forms.TextBox kMsTextBox;
        private System.Windows.Forms.TextBox tunningTextBox;
        private System.Windows.Forms.TextBox alignmentTextBox;
        private System.Windows.Forms.TextBox balancingTextBox;
        private System.Windows.Forms.TextBox tiresTextBox;
        private System.Windows.Forms.TextBox weightsTextBox;
        private System.Windows.Forms.TextBox oilChangedTextBox;
        private System.Windows.Forms.TextBox oilQryTextBox;
        private System.Windows.Forms.TextBox oilFilterTextBox;
        private System.Windows.Forms.TextBox gearOilTextBox;
        private System.Windows.Forms.TextBox gearOilQryTextBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.TextBox condenserTextBox;
        private System.Windows.Forms.TextBox plugTextBox;
        private System.Windows.Forms.TextBox plugQtyTextBox;
        private System.Windows.Forms.TextBox fuelFilterTextBox;
        private System.Windows.Forms.TextBox airFilterTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
    }
}