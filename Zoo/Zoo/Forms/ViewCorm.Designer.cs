
namespace Zoo.Forms {
    partial class ViewCorm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCorm));
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label postavwikLabel;
            System.Windows.Forms.Label nazvanieKormaLabel;
            System.Windows.Forms.Label nomerKormaLabel;
            this.zooDataSet = new Zoo.ZooDataSet();
            this.kormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kormTableAdapter = new Zoo.ZooDataSetTableAdapters.KormTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.kormBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.postavwikTextBox = new System.Windows.Forms.TextBox();
            this.nazvanieKormaTextBox = new System.Windows.Forms.TextBox();
            this.nomerKormaTextBox = new System.Windows.Forms.TextBox();
            this.jivotnoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jivotnoeTableAdapter = new Zoo.ZooDataSetTableAdapters.JivotnoeTableAdapter();
            this.jivotnoeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cenaLabel = new System.Windows.Forms.Label();
            postavwikLabel = new System.Windows.Forms.Label();
            nazvanieKormaLabel = new System.Windows.Forms.Label();
            nomerKormaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingNavigator)).BeginInit();
            this.kormBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kormBindingSource
            // 
            this.kormBindingSource.DataMember = "Korm";
            this.kormBindingSource.DataSource = this.zooDataSet;
            // 
            // kormTableAdapter
            // 
            this.kormTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JivotnoeTableAdapter = this.jivotnoeTableAdapter;
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = null;
            this.tableAdapterManager.KormTableAdapter = this.kormTableAdapter;
            this.tableAdapterManager.PotomstvoTableAdapter = null;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kormBindingNavigator
            // 
            this.kormBindingNavigator.AddNewItem = null;
            this.kormBindingNavigator.BindingSource = this.kormBindingSource;
            this.kormBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kormBindingNavigator.DeleteItem = null;
            this.kormBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.kormBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kormBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kormBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kormBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kormBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kormBindingNavigator.Name = "kormBindingNavigator";
            this.kormBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.kormBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kormBindingNavigator.Size = new System.Drawing.Size(1093, 25);
            this.kormBindingNavigator.TabIndex = 0;
            this.kormBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(81, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(58, 130);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(57, 20);
            cenaLabel.TabIndex = 15;
            cenaLabel.Text = "Цена:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(121, 124);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.ReadOnly = true;
            this.cenaTextBox.Size = new System.Drawing.Size(100, 26);
            this.cenaTextBox.TabIndex = 16;
            // 
            // postavwikLabel
            // 
            postavwikLabel.AutoSize = true;
            postavwikLabel.Location = new System.Drawing.Point(6, 98);
            postavwikLabel.Name = "postavwikLabel";
            postavwikLabel.Size = new System.Drawing.Size(109, 20);
            postavwikLabel.TabIndex = 13;
            postavwikLabel.Text = "Поставщик:";
            // 
            // postavwikTextBox
            // 
            this.postavwikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "Postavwik", true));
            this.postavwikTextBox.Location = new System.Drawing.Point(121, 92);
            this.postavwikTextBox.Name = "postavwikTextBox";
            this.postavwikTextBox.ReadOnly = true;
            this.postavwikTextBox.Size = new System.Drawing.Size(194, 26);
            this.postavwikTextBox.TabIndex = 14;
            // 
            // nazvanieKormaLabel
            // 
            nazvanieKormaLabel.AutoSize = true;
            nazvanieKormaLabel.Location = new System.Drawing.Point(19, 66);
            nazvanieKormaLabel.Name = "nazvanieKormaLabel";
            nazvanieKormaLabel.Size = new System.Drawing.Size(96, 20);
            nazvanieKormaLabel.TabIndex = 11;
            nazvanieKormaLabel.Text = "Название:";
            // 
            // nazvanieKormaTextBox
            // 
            this.nazvanieKormaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "NazvanieKorma", true));
            this.nazvanieKormaTextBox.Location = new System.Drawing.Point(121, 60);
            this.nazvanieKormaTextBox.Name = "nazvanieKormaTextBox";
            this.nazvanieKormaTextBox.ReadOnly = true;
            this.nazvanieKormaTextBox.Size = new System.Drawing.Size(194, 26);
            this.nazvanieKormaTextBox.TabIndex = 12;
            // 
            // nomerKormaLabel
            // 
            nomerKormaLabel.AutoSize = true;
            nomerKormaLabel.Location = new System.Drawing.Point(46, 34);
            nomerKormaLabel.Name = "nomerKormaLabel";
            nomerKormaLabel.Size = new System.Drawing.Size(69, 20);
            nomerKormaLabel.TabIndex = 9;
            nomerKormaLabel.Text = "Номер:";
            // 
            // nomerKormaTextBox
            // 
            this.nomerKormaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "NomerKorma", true));
            this.nomerKormaTextBox.Location = new System.Drawing.Point(121, 28);
            this.nomerKormaTextBox.Name = "nomerKormaTextBox";
            this.nomerKormaTextBox.ReadOnly = true;
            this.nomerKormaTextBox.Size = new System.Drawing.Size(100, 26);
            this.nomerKormaTextBox.TabIndex = 10;
            // 
            // jivotnoeBindingSource
            // 
            this.jivotnoeBindingSource.DataMember = "FK__Jivotnoe__NomerK__300424B4";
            this.jivotnoeBindingSource.DataSource = this.kormBindingSource;
            // 
            // jivotnoeTableAdapter
            // 
            this.jivotnoeTableAdapter.ClearBeforeFill = true;
            // 
            // jivotnoeDataGridView
            // 
            this.jivotnoeDataGridView.AutoGenerateColumns = false;
            this.jivotnoeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jivotnoeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.jivotnoeDataGridView.DataSource = this.jivotnoeBindingSource;
            this.jivotnoeDataGridView.Location = new System.Drawing.Point(321, 28);
            this.jivotnoeDataGridView.Name = "jivotnoeDataGridView";
            this.jivotnoeDataGridView.Size = new System.Drawing.Size(761, 220);
            this.jivotnoeDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomerJiv";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomerJiv";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KlichkaJiv";
            this.dataGridViewTextBoxColumn2.HeaderText = "KlichkaJiv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomerValera";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomerValera";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VidJivotnogo";
            this.dataGridViewTextBoxColumn4.HeaderText = "VidJivotnogo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PolJivotnogo";
            this.dataGridViewTextBoxColumn5.HeaderText = "PolJivotnogo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VozrastJivotnogo";
            this.dataGridViewTextBoxColumn6.HeaderText = "VozrastJivotnogo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NomerKorma";
            this.dataGridViewTextBoxColumn7.HeaderText = "NomerKorma";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ViewCorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 265);
            this.Controls.Add(this.jivotnoeDataGridView);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(postavwikLabel);
            this.Controls.Add(this.postavwikTextBox);
            this.Controls.Add(nazvanieKormaLabel);
            this.Controls.Add(this.nazvanieKormaTextBox);
            this.Controls.Add(nomerKormaLabel);
            this.Controls.Add(this.nomerKormaTextBox);
            this.Controls.Add(this.kormBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "ViewCorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корм | Смотреть";
            this.Load += new System.EventHandler(this.ViewCorm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingNavigator)).EndInit();
            this.kormBindingNavigator.ResumeLayout(false);
            this.kormBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource kormBindingSource;
        private ZooDataSetTableAdapters.KormTableAdapter kormTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kormBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ZooDataSetTableAdapters.JivotnoeTableAdapter jivotnoeTableAdapter;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox postavwikTextBox;
        private System.Windows.Forms.TextBox nazvanieKormaTextBox;
        private System.Windows.Forms.TextBox nomerKormaTextBox;
        private System.Windows.Forms.BindingSource jivotnoeBindingSource;
        private System.Windows.Forms.DataGridView jivotnoeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}