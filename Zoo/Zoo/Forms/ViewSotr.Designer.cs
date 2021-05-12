
namespace Zoo.Forms {
    partial class ViewSotr {
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
            System.Windows.Forms.Label stajLabel;
            System.Windows.Forms.Label vozrastLabel;
            System.Windows.Forms.Label polLabel;
            System.Windows.Forms.Label doljnostLabel;
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label nomerSotrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSotr));
            this.zooDataSet = new Zoo.ZooDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new Zoo.ZooDataSetTableAdapters.SotrudnikTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.rabotaSJivotnimTableAdapter = new Zoo.ZooDataSetTableAdapters.RabotaSJivotnimTableAdapter();
            this.sotrudnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nomerSotrTextBox = new System.Windows.Forms.TextBox();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            this.doljnostTextBox = new System.Windows.Forms.TextBox();
            this.polTextBox = new System.Windows.Forms.TextBox();
            this.vozrastTextBox = new System.Windows.Forms.TextBox();
            this.stajTextBox = new System.Windows.Forms.TextBox();
            this.rabotaSJivotnimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabotaSJivotnimDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stajLabel = new System.Windows.Forms.Label();
            vozrastLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            doljnostLabel = new System.Windows.Forms.Label();
            fIOLabel = new System.Windows.Forms.Label();
            nomerSotrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingNavigator)).BeginInit();
            this.sotrudnikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stajLabel
            // 
            stajLabel.AutoSize = true;
            stajLabel.Location = new System.Drawing.Point(126, 216);
            stajLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            stajLabel.Name = "stajLabel";
            stajLabel.Size = new System.Drawing.Size(58, 20);
            stajLabel.TabIndex = 18;
            stajLabel.Text = "Стаж:";
            // 
            // vozrastLabel
            // 
            vozrastLabel.AutoSize = true;
            vozrastLabel.Location = new System.Drawing.Point(100, 180);
            vozrastLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vozrastLabel.Name = "vozrastLabel";
            vozrastLabel.Size = new System.Drawing.Size(84, 20);
            vozrastLabel.TabIndex = 17;
            vozrastLabel.Text = "Возраст:";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(136, 144);
            polLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(48, 20);
            polLabel.TabIndex = 16;
            polLabel.Text = "Пол:";
            // 
            // doljnostLabel
            // 
            doljnostLabel.AutoSize = true;
            doljnostLabel.Location = new System.Drawing.Point(75, 108);
            doljnostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            doljnostLabel.Name = "doljnostLabel";
            doljnostLabel.Size = new System.Drawing.Size(109, 20);
            doljnostLabel.TabIndex = 15;
            doljnostLabel.Text = "Должность:";
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(129, 72);
            fIOLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(55, 20);
            fIOLabel.TabIndex = 14;
            fIOLabel.Text = "ФИО:";
            // 
            // nomerSotrLabel
            // 
            nomerSotrLabel.AutoSize = true;
            nomerSotrLabel.Location = new System.Drawing.Point(12, 36);
            nomerSotrLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerSotrLabel.Name = "nomerSotrLabel";
            nomerSotrLabel.Size = new System.Drawing.Size(172, 20);
            nomerSotrLabel.TabIndex = 13;
            nomerSotrLabel.Text = "Номер сотрудника:";
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.zooDataSet;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JivotnoeTableAdapter = null;
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = null;
            this.tableAdapterManager.KormTableAdapter = null;
            this.tableAdapterManager.PotomstvoTableAdapter = null;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = this.rabotaSJivotnimTableAdapter;
            this.tableAdapterManager.SotrudnikTableAdapter = this.sotrudnikTableAdapter;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rabotaSJivotnimTableAdapter
            // 
            this.rabotaSJivotnimTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikBindingNavigator
            // 
            this.sotrudnikBindingNavigator.AddNewItem = null;
            this.sotrudnikBindingNavigator.BindingSource = this.sotrudnikBindingSource;
            this.sotrudnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sotrudnikBindingNavigator.DeleteItem = null;
            this.sotrudnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.sotrudnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sotrudnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sotrudnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sotrudnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sotrudnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sotrudnikBindingNavigator.Name = "sotrudnikBindingNavigator";
            this.sotrudnikBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.sotrudnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sotrudnikBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.sotrudnikBindingNavigator.TabIndex = 0;
            this.sotrudnikBindingNavigator.Text = "bindingNavigator1";
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
            // nomerSotrTextBox
            // 
            this.nomerSotrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "NomerSotr", true));
            this.nomerSotrTextBox.Location = new System.Drawing.Point(194, 30);
            this.nomerSotrTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomerSotrTextBox.Name = "nomerSotrTextBox";
            this.nomerSotrTextBox.ReadOnly = true;
            this.nomerSotrTextBox.Size = new System.Drawing.Size(164, 26);
            this.nomerSotrTextBox.TabIndex = 2;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(194, 66);
            this.fIOTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.ReadOnly = true;
            this.fIOTextBox.Size = new System.Drawing.Size(164, 26);
            this.fIOTextBox.TabIndex = 4;
            // 
            // doljnostTextBox
            // 
            this.doljnostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Doljnost", true));
            this.doljnostTextBox.Location = new System.Drawing.Point(194, 102);
            this.doljnostTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.doljnostTextBox.Name = "doljnostTextBox";
            this.doljnostTextBox.ReadOnly = true;
            this.doljnostTextBox.Size = new System.Drawing.Size(164, 26);
            this.doljnostTextBox.TabIndex = 6;
            // 
            // polTextBox
            // 
            this.polTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Pol", true));
            this.polTextBox.Location = new System.Drawing.Point(194, 138);
            this.polTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.polTextBox.Name = "polTextBox";
            this.polTextBox.ReadOnly = true;
            this.polTextBox.Size = new System.Drawing.Size(164, 26);
            this.polTextBox.TabIndex = 8;
            // 
            // vozrastTextBox
            // 
            this.vozrastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Vozrast", true));
            this.vozrastTextBox.Location = new System.Drawing.Point(194, 174);
            this.vozrastTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.vozrastTextBox.Name = "vozrastTextBox";
            this.vozrastTextBox.ReadOnly = true;
            this.vozrastTextBox.Size = new System.Drawing.Size(164, 26);
            this.vozrastTextBox.TabIndex = 10;
            // 
            // stajTextBox
            // 
            this.stajTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudnikBindingSource, "Staj", true));
            this.stajTextBox.Location = new System.Drawing.Point(194, 210);
            this.stajTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.stajTextBox.Name = "stajTextBox";
            this.stajTextBox.ReadOnly = true;
            this.stajTextBox.Size = new System.Drawing.Size(164, 26);
            this.stajTextBox.TabIndex = 12;
            // 
            // rabotaSJivotnimBindingSource
            // 
            this.rabotaSJivotnimBindingSource.DataMember = "FK__RabotaSJi__Nomer__33D4B598";
            this.rabotaSJivotnimBindingSource.DataSource = this.sotrudnikBindingSource;
            // 
            // rabotaSJivotnimDataGridView
            // 
            this.rabotaSJivotnimDataGridView.AllowUserToAddRows = false;
            this.rabotaSJivotnimDataGridView.AllowUserToDeleteRows = false;
            this.rabotaSJivotnimDataGridView.AutoGenerateColumns = false;
            this.rabotaSJivotnimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rabotaSJivotnimDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.rabotaSJivotnimDataGridView.DataSource = this.rabotaSJivotnimBindingSource;
            this.rabotaSJivotnimDataGridView.Location = new System.Drawing.Point(366, 28);
            this.rabotaSJivotnimDataGridView.Name = "rabotaSJivotnimDataGridView";
            this.rabotaSJivotnimDataGridView.ReadOnly = true;
            this.rabotaSJivotnimDataGridView.Size = new System.Drawing.Size(606, 208);
            this.rabotaSJivotnimDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomerJiv";
            this.dataGridViewTextBoxColumn1.HeaderText = "№ животного";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNachala";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала работы";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // ViewSotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.rabotaSJivotnimDataGridView);
            this.Controls.Add(stajLabel);
            this.Controls.Add(vozrastLabel);
            this.Controls.Add(polLabel);
            this.Controls.Add(doljnostLabel);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(nomerSotrLabel);
            this.Controls.Add(this.stajTextBox);
            this.Controls.Add(this.vozrastTextBox);
            this.Controls.Add(this.polTextBox);
            this.Controls.Add(this.doljnostTextBox);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.nomerSotrTextBox);
            this.Controls.Add(this.sotrudnikBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ViewSotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники | Смотреть";
            this.Load += new System.EventHandler(this.ViewSotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingNavigator)).EndInit();
            this.sotrudnikBindingNavigator.ResumeLayout(false);
            this.sotrudnikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabotaSJivotnimDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ZooDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sotrudnikBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox nomerSotrTextBox;
        private System.Windows.Forms.TextBox fIOTextBox;
        private System.Windows.Forms.TextBox doljnostTextBox;
        private System.Windows.Forms.TextBox polTextBox;
        private System.Windows.Forms.TextBox vozrastTextBox;
        private System.Windows.Forms.TextBox stajTextBox;
        private ZooDataSetTableAdapters.RabotaSJivotnimTableAdapter rabotaSJivotnimTableAdapter;
        private System.Windows.Forms.BindingSource rabotaSJivotnimBindingSource;
        private System.Windows.Forms.DataGridView rabotaSJivotnimDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}