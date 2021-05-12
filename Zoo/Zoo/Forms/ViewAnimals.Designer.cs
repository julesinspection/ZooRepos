
namespace Zoo.Forms {
    partial class ViewAnimals {
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
            if (disposing && (components != null)) {
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
            System.Windows.Forms.Label nomerKormaLabel;
            System.Windows.Forms.Label vozrastJivotnogoLabel;
            System.Windows.Forms.Label polJivotnogoLabel;
            System.Windows.Forms.Label vidJivotnogoLabel;
            System.Windows.Forms.Label nomerValeraLabel;
            System.Windows.Forms.Label klichkaJivLabel;
            System.Windows.Forms.Label nomerJivLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAnimals));
            this.zooDataSet = new Zoo.ZooDataSet();
            this.jivotnoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jivotnoeTableAdapter = new Zoo.ZooDataSetTableAdapters.JivotnoeTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.kartochkaBolezneyTableAdapter = new Zoo.ZooDataSetTableAdapters.KartochkaBolezneyTableAdapter();
            this.potomstvoTableAdapter = new Zoo.ZooDataSetTableAdapters.PotomstvoTableAdapter();
            this.rabotaSJivotnimTableAdapter = new Zoo.ZooDataSetTableAdapters.RabotaSJivotnimTableAdapter();
            this.jivotnoeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vozrastJivotnogoTextBox = new System.Windows.Forms.TextBox();
            this.vidJivotnogoTextBox = new System.Windows.Forms.TextBox();
            this.nomerValeraTextBox = new System.Windows.Forms.TextBox();
            this.klichkaJivTextBox = new System.Windows.Forms.TextBox();
            this.nomerJivTextBox = new System.Windows.Forms.TextBox();
            this.polJivotnogoTextBox = new System.Windows.Forms.TextBox();
            this.nomerKormaTextBox = new System.Windows.Forms.TextBox();
            this.kartochkaBolezneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabotaSJivotnimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potomstvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potomstvoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kartochkaBolezneyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rabotaSJivotnimDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.potomstvoDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potomstvoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomerKormaLabel = new System.Windows.Forms.Label();
            vozrastJivotnogoLabel = new System.Windows.Forms.Label();
            polJivotnogoLabel = new System.Windows.Forms.Label();
            vidJivotnogoLabel = new System.Windows.Forms.Label();
            nomerValeraLabel = new System.Windows.Forms.Label();
            klichkaJivLabel = new System.Windows.Forms.Label();
            nomerJivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingNavigator)).BeginInit();
            this.jivotnoeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomerKormaLabel
            // 
            nomerKormaLabel.AutoSize = true;
            nomerKormaLabel.Location = new System.Drawing.Point(31, 280);
            nomerKormaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerKormaLabel.Name = "nomerKormaLabel";
            nomerKormaLabel.Size = new System.Drawing.Size(125, 20);
            nomerKormaLabel.TabIndex = 27;
            nomerKormaLabel.Text = "Номер корма:";
            // 
            // vozrastJivotnogoLabel
            // 
            vozrastJivotnogoLabel.AutoSize = true;
            vozrastJivotnogoLabel.Location = new System.Drawing.Point(72, 238);
            vozrastJivotnogoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vozrastJivotnogoLabel.Name = "vozrastJivotnogoLabel";
            vozrastJivotnogoLabel.Size = new System.Drawing.Size(84, 20);
            vozrastJivotnogoLabel.TabIndex = 25;
            vozrastJivotnogoLabel.Text = "Возраст:";
            // 
            // polJivotnogoLabel
            // 
            polJivotnogoLabel.AutoSize = true;
            polJivotnogoLabel.Location = new System.Drawing.Point(108, 198);
            polJivotnogoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            polJivotnogoLabel.Name = "polJivotnogoLabel";
            polJivotnogoLabel.Size = new System.Drawing.Size(48, 20);
            polJivotnogoLabel.TabIndex = 23;
            polJivotnogoLabel.Text = "Пол:";
            // 
            // vidJivotnogoLabel
            // 
            vidJivotnogoLabel.AutoSize = true;
            vidJivotnogoLabel.Location = new System.Drawing.Point(108, 156);
            vidJivotnogoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vidJivotnogoLabel.Name = "vidJivotnogoLabel";
            vidJivotnogoLabel.Size = new System.Drawing.Size(48, 20);
            vidJivotnogoLabel.TabIndex = 21;
            vidJivotnogoLabel.Text = "Вид:";
            // 
            // nomerValeraLabel
            // 
            nomerValeraLabel.AutoSize = true;
            nomerValeraLabel.Location = new System.Drawing.Point(11, 116);
            nomerValeraLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerValeraLabel.Name = "nomerValeraLabel";
            nomerValeraLabel.Size = new System.Drawing.Size(145, 20);
            nomerValeraLabel.TabIndex = 19;
            nomerValeraLabel.Text = "Номер вальера:";
            // 
            // klichkaJivLabel
            // 
            klichkaJivLabel.AutoSize = true;
            klichkaJivLabel.Location = new System.Drawing.Point(81, 76);
            klichkaJivLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            klichkaJivLabel.Name = "klichkaJivLabel";
            klichkaJivLabel.Size = new System.Drawing.Size(75, 20);
            klichkaJivLabel.TabIndex = 17;
            klichkaJivLabel.Text = "Кличка:";
            // 
            // nomerJivLabel
            // 
            nomerJivLabel.AutoSize = true;
            nomerJivLabel.Location = new System.Drawing.Point(87, 36);
            nomerJivLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerJivLabel.Name = "nomerJivLabel";
            nomerJivLabel.Size = new System.Drawing.Size(69, 20);
            nomerJivLabel.TabIndex = 15;
            nomerJivLabel.Text = "Номер:";
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jivotnoeBindingSource
            // 
            this.jivotnoeBindingSource.DataMember = "Jivotnoe";
            this.jivotnoeBindingSource.DataSource = this.zooDataSet;
            // 
            // jivotnoeTableAdapter
            // 
            this.jivotnoeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JivotnoeTableAdapter = this.jivotnoeTableAdapter;
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = this.kartochkaBolezneyTableAdapter;
            this.tableAdapterManager.KormTableAdapter = null;
            this.tableAdapterManager.PotomstvoTableAdapter = this.potomstvoTableAdapter;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = this.rabotaSJivotnimTableAdapter;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kartochkaBolezneyTableAdapter
            // 
            this.kartochkaBolezneyTableAdapter.ClearBeforeFill = true;
            // 
            // potomstvoTableAdapter
            // 
            this.potomstvoTableAdapter.ClearBeforeFill = true;
            // 
            // rabotaSJivotnimTableAdapter
            // 
            this.rabotaSJivotnimTableAdapter.ClearBeforeFill = true;
            // 
            // jivotnoeBindingNavigator
            // 
            this.jivotnoeBindingNavigator.AddNewItem = null;
            this.jivotnoeBindingNavigator.BindingSource = this.jivotnoeBindingSource;
            this.jivotnoeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jivotnoeBindingNavigator.DeleteItem = null;
            this.jivotnoeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.jivotnoeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jivotnoeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jivotnoeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jivotnoeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jivotnoeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jivotnoeBindingNavigator.Name = "jivotnoeBindingNavigator";
            this.jivotnoeBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.jivotnoeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jivotnoeBindingNavigator.Size = new System.Drawing.Size(999, 25);
            this.jivotnoeBindingNavigator.TabIndex = 0;
            this.jivotnoeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(81, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vozrastJivotnogoTextBox
            // 
            this.vozrastJivotnogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "VozrastJivotnogo", true));
            this.vozrastJivotnogoTextBox.Location = new System.Drawing.Point(166, 232);
            this.vozrastJivotnogoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.vozrastJivotnogoTextBox.Name = "vozrastJivotnogoTextBox";
            this.vozrastJivotnogoTextBox.ReadOnly = true;
            this.vozrastJivotnogoTextBox.Size = new System.Drawing.Size(164, 26);
            this.vozrastJivotnogoTextBox.TabIndex = 26;
            // 
            // vidJivotnogoTextBox
            // 
            this.vidJivotnogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "VidJivotnogo", true));
            this.vidJivotnogoTextBox.Location = new System.Drawing.Point(166, 150);
            this.vidJivotnogoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.vidJivotnogoTextBox.Name = "vidJivotnogoTextBox";
            this.vidJivotnogoTextBox.ReadOnly = true;
            this.vidJivotnogoTextBox.Size = new System.Drawing.Size(164, 26);
            this.vidJivotnogoTextBox.TabIndex = 22;
            // 
            // nomerValeraTextBox
            // 
            this.nomerValeraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "NomerValera", true));
            this.nomerValeraTextBox.Location = new System.Drawing.Point(166, 110);
            this.nomerValeraTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomerValeraTextBox.Name = "nomerValeraTextBox";
            this.nomerValeraTextBox.ReadOnly = true;
            this.nomerValeraTextBox.Size = new System.Drawing.Size(164, 26);
            this.nomerValeraTextBox.TabIndex = 20;
            // 
            // klichkaJivTextBox
            // 
            this.klichkaJivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "KlichkaJiv", true));
            this.klichkaJivTextBox.Location = new System.Drawing.Point(166, 70);
            this.klichkaJivTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.klichkaJivTextBox.Name = "klichkaJivTextBox";
            this.klichkaJivTextBox.ReadOnly = true;
            this.klichkaJivTextBox.Size = new System.Drawing.Size(164, 26);
            this.klichkaJivTextBox.TabIndex = 18;
            // 
            // nomerJivTextBox
            // 
            this.nomerJivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "NomerJiv", true));
            this.nomerJivTextBox.Location = new System.Drawing.Point(166, 30);
            this.nomerJivTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomerJivTextBox.Name = "nomerJivTextBox";
            this.nomerJivTextBox.ReadOnly = true;
            this.nomerJivTextBox.Size = new System.Drawing.Size(164, 26);
            this.nomerJivTextBox.TabIndex = 16;
            // 
            // polJivotnogoTextBox
            // 
            this.polJivotnogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "PolJivotnogo", true));
            this.polJivotnogoTextBox.Location = new System.Drawing.Point(166, 192);
            this.polJivotnogoTextBox.Name = "polJivotnogoTextBox";
            this.polJivotnogoTextBox.ReadOnly = true;
            this.polJivotnogoTextBox.Size = new System.Drawing.Size(164, 26);
            this.polJivotnogoTextBox.TabIndex = 29;
            // 
            // nomerKormaTextBox
            // 
            this.nomerKormaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "NomerKorma", true));
            this.nomerKormaTextBox.Location = new System.Drawing.Point(166, 274);
            this.nomerKormaTextBox.Name = "nomerKormaTextBox";
            this.nomerKormaTextBox.ReadOnly = true;
            this.nomerKormaTextBox.Size = new System.Drawing.Size(164, 26);
            this.nomerKormaTextBox.TabIndex = 30;
            // 
            // kartochkaBolezneyBindingSource
            // 
            this.kartochkaBolezneyBindingSource.DataMember = "FK__Kartochka__Nomer__36B12243";
            this.kartochkaBolezneyBindingSource.DataSource = this.jivotnoeBindingSource;
            // 
            // rabotaSJivotnimBindingSource
            // 
            this.rabotaSJivotnimBindingSource.DataMember = "FK__RabotaSJi__Nomer__32E0915F";
            this.rabotaSJivotnimBindingSource.DataSource = this.jivotnoeBindingSource;
            // 
            // potomstvoBindingSource
            // 
            this.potomstvoBindingSource.DataMember = "FK__Potomstvo__Nomer__398D8EEE";
            this.potomstvoBindingSource.DataSource = this.jivotnoeBindingSource;
            // 
            // potomstvoBindingSource1
            // 
            this.potomstvoBindingSource1.DataMember = "FK__Potomstvo__Nomer__3A81B327";
            this.potomstvoBindingSource1.DataSource = this.jivotnoeBindingSource;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(338, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 560);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.kartochkaBolezneyDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Карточка болезней";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kartochkaBolezneyDataGridView
            // 
            this.kartochkaBolezneyDataGridView.AllowUserToAddRows = false;
            this.kartochkaBolezneyDataGridView.AllowUserToDeleteRows = false;
            this.kartochkaBolezneyDataGridView.AutoGenerateColumns = false;
            this.kartochkaBolezneyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kartochkaBolezneyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.kartochkaBolezneyDataGridView.DataSource = this.kartochkaBolezneyBindingSource;
            this.kartochkaBolezneyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kartochkaBolezneyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.kartochkaBolezneyDataGridView.Name = "kartochkaBolezneyDataGridView";
            this.kartochkaBolezneyDataGridView.ReadOnly = true;
            this.kartochkaBolezneyDataGridView.Size = new System.Drawing.Size(626, 521);
            this.kartochkaBolezneyDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomerJiv";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazvanieBolezni";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название Болезни";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataZabolevaniya";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата заболевания";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.rabotaSJivotnimDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа с животным";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rabotaSJivotnimDataGridView
            // 
            this.rabotaSJivotnimDataGridView.AllowUserToAddRows = false;
            this.rabotaSJivotnimDataGridView.AllowUserToDeleteRows = false;
            this.rabotaSJivotnimDataGridView.AutoGenerateColumns = false;
            this.rabotaSJivotnimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rabotaSJivotnimDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rabotaSJivotnimDataGridView.DataSource = this.rabotaSJivotnimBindingSource;
            this.rabotaSJivotnimDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rabotaSJivotnimDataGridView.Location = new System.Drawing.Point(3, 3);
            this.rabotaSJivotnimDataGridView.Name = "rabotaSJivotnimDataGridView";
            this.rabotaSJivotnimDataGridView.ReadOnly = true;
            this.rabotaSJivotnimDataGridView.Size = new System.Drawing.Size(626, 521);
            this.rabotaSJivotnimDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomerJiv";
            this.dataGridViewTextBoxColumn4.HeaderText = "№ животного";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NomerSotr";
            this.dataGridViewTextBoxColumn5.HeaderText = "№ сотрудника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DataNachala";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата начала работы";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.potomstvoDataGridView1);
            this.tabPage3.Controls.Add(this.potomstvoDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(632, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Потомство";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Потомки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Предки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // potomstvoDataGridView1
            // 
            this.potomstvoDataGridView1.AllowUserToAddRows = false;
            this.potomstvoDataGridView1.AllowUserToDeleteRows = false;
            this.potomstvoDataGridView1.AutoGenerateColumns = false;
            this.potomstvoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.potomstvoDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            this.potomstvoDataGridView1.DataSource = this.potomstvoBindingSource1;
            this.potomstvoDataGridView1.Location = new System.Drawing.Point(3, 298);
            this.potomstvoDataGridView1.Name = "potomstvoDataGridView1";
            this.potomstvoDataGridView1.ReadOnly = true;
            this.potomstvoDataGridView1.Size = new System.Drawing.Size(626, 220);
            this.potomstvoDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NomerDet";
            this.dataGridViewTextBoxColumn10.HeaderText = "№ потомка";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DataZabolevaniya";
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // potomstvoDataGridView
            // 
            this.potomstvoDataGridView.AllowUserToAddRows = false;
            this.potomstvoDataGridView.AllowUserToDeleteRows = false;
            this.potomstvoDataGridView.AutoGenerateColumns = false;
            this.potomstvoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.potomstvoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.potomstvoDataGridView.DataSource = this.potomstvoBindingSource;
            this.potomstvoDataGridView.Location = new System.Drawing.Point(3, 44);
            this.potomstvoDataGridView.Name = "potomstvoDataGridView";
            this.potomstvoDataGridView.ReadOnly = true;
            this.potomstvoDataGridView.Size = new System.Drawing.Size(626, 220);
            this.potomstvoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NomerJiv";
            this.dataGridViewTextBoxColumn8.HeaderText = "№ предка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DataZabolevaniya";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // ViewAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nomerKormaTextBox);
            this.Controls.Add(this.polJivotnogoTextBox);
            this.Controls.Add(nomerKormaLabel);
            this.Controls.Add(vozrastJivotnogoLabel);
            this.Controls.Add(this.vozrastJivotnogoTextBox);
            this.Controls.Add(polJivotnogoLabel);
            this.Controls.Add(vidJivotnogoLabel);
            this.Controls.Add(this.vidJivotnogoTextBox);
            this.Controls.Add(nomerValeraLabel);
            this.Controls.Add(this.nomerValeraTextBox);
            this.Controls.Add(klichkaJivLabel);
            this.Controls.Add(this.klichkaJivTextBox);
            this.Controls.Add(nomerJivLabel);
            this.Controls.Add(this.nomerJivTextBox);
            this.Controls.Add(this.jivotnoeBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ViewAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные | Смотреть";
            this.Load += new System.EventHandler(this.ViewAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingNavigator)).EndInit();
            this.jivotnoeBindingNavigator.ResumeLayout(false);
            this.jivotnoeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource jivotnoeBindingSource;
        private ZooDataSetTableAdapters.JivotnoeTableAdapter jivotnoeTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jivotnoeBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ZooDataSetTableAdapters.KartochkaBolezneyTableAdapter kartochkaBolezneyTableAdapter;
        private System.Windows.Forms.TextBox vozrastJivotnogoTextBox;
        private System.Windows.Forms.TextBox vidJivotnogoTextBox;
        private System.Windows.Forms.TextBox nomerValeraTextBox;
        private System.Windows.Forms.TextBox klichkaJivTextBox;
        private System.Windows.Forms.TextBox nomerJivTextBox;
        private System.Windows.Forms.TextBox polJivotnogoTextBox;
        private System.Windows.Forms.TextBox nomerKormaTextBox;
        private System.Windows.Forms.BindingSource kartochkaBolezneyBindingSource;
        private ZooDataSetTableAdapters.RabotaSJivotnimTableAdapter rabotaSJivotnimTableAdapter;
        private System.Windows.Forms.BindingSource rabotaSJivotnimBindingSource;
        private ZooDataSetTableAdapters.PotomstvoTableAdapter potomstvoTableAdapter;
        private System.Windows.Forms.BindingSource potomstvoBindingSource;
        private System.Windows.Forms.BindingSource potomstvoBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView kartochkaBolezneyDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView rabotaSJivotnimDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView potomstvoDataGridView;
        private System.Windows.Forms.DataGridView potomstvoDataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}