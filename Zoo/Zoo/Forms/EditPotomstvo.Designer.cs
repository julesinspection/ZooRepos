﻿
namespace Zoo.Forms {
    partial class EditPotomstvo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPotomstvo));
            System.Windows.Forms.Label nomerDetLabel;
            System.Windows.Forms.Label nomerJivLabel;
            System.Windows.Forms.Label dataZabolevaniyaLabel;
            this.zooDataSet = new Zoo.ZooDataSet();
            this.potomstvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potomstvoTableAdapter = new Zoo.ZooDataSetTableAdapters.PotomstvoTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.potomstvoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.potomstvoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomerDetTextBox = new System.Windows.Forms.TextBox();
            this.nomerJivComboBox = new System.Windows.Forms.ComboBox();
            this.dataZabolevaniyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            nomerDetLabel = new System.Windows.Forms.Label();
            nomerJivLabel = new System.Windows.Forms.Label();
            dataZabolevaniyaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingNavigator)).BeginInit();
            this.potomstvoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potomstvoBindingSource
            // 
            this.potomstvoBindingSource.DataMember = "Potomstvo";
            this.potomstvoBindingSource.DataSource = this.zooDataSet;
            // 
            // potomstvoTableAdapter
            // 
            this.potomstvoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JivotnoeTableAdapter = null;
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = null;
            this.tableAdapterManager.KormTableAdapter = null;
            this.tableAdapterManager.PotomstvoTableAdapter = this.potomstvoTableAdapter;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // potomstvoBindingNavigator
            // 
            this.potomstvoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.potomstvoBindingNavigator.BindingSource = this.potomstvoBindingSource;
            this.potomstvoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.potomstvoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.potomstvoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.potomstvoBindingNavigatorSaveItem});
            this.potomstvoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.potomstvoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.potomstvoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.potomstvoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.potomstvoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.potomstvoBindingNavigator.Name = "potomstvoBindingNavigator";
            this.potomstvoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.potomstvoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.potomstvoBindingNavigator.Size = new System.Drawing.Size(488, 25);
            this.potomstvoBindingNavigator.TabIndex = 0;
            this.potomstvoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // potomstvoBindingNavigatorSaveItem
            // 
            this.potomstvoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.potomstvoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("potomstvoBindingNavigatorSaveItem.Image")));
            this.potomstvoBindingNavigatorSaveItem.Name = "potomstvoBindingNavigatorSaveItem";
            this.potomstvoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.potomstvoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.potomstvoBindingNavigatorSaveItem.Click += new System.EventHandler(this.potomstvoBindingNavigatorSaveItem_Click);
            // 
            // nomerDetLabel
            // 
            nomerDetLabel.AutoSize = true;
            nomerDetLabel.Location = new System.Drawing.Point(19, 34);
            nomerDetLabel.Name = "nomerDetLabel";
            nomerDetLabel.Size = new System.Drawing.Size(145, 20);
            nomerDetLabel.TabIndex = 1;
            nomerDetLabel.Text = "Номер потомка:";
            // 
            // nomerDetTextBox
            // 
            this.nomerDetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potomstvoBindingSource, "NomerDet", true));
            this.nomerDetTextBox.Location = new System.Drawing.Point(170, 28);
            this.nomerDetTextBox.Name = "nomerDetTextBox";
            this.nomerDetTextBox.Size = new System.Drawing.Size(100, 26);
            this.nomerDetTextBox.TabIndex = 2;
            // 
            // nomerJivLabel
            // 
            nomerJivLabel.AutoSize = true;
            nomerJivLabel.Location = new System.Drawing.Point(7, 68);
            nomerJivLabel.Name = "nomerJivLabel";
            nomerJivLabel.Size = new System.Drawing.Size(157, 20);
            nomerJivLabel.TabIndex = 3;
            nomerJivLabel.Text = "Номер родителя:";
            // 
            // nomerJivComboBox
            // 
            this.nomerJivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.potomstvoBindingSource, "NomerJiv", true));
            this.nomerJivComboBox.FormattingEnabled = true;
            this.nomerJivComboBox.Location = new System.Drawing.Point(170, 60);
            this.nomerJivComboBox.Name = "nomerJivComboBox";
            this.nomerJivComboBox.Size = new System.Drawing.Size(121, 28);
            this.nomerJivComboBox.TabIndex = 4;
            // 
            // dataZabolevaniyaLabel
            // 
            dataZabolevaniyaLabel.AutoSize = true;
            dataZabolevaniyaLabel.Location = new System.Drawing.Point(17, 100);
            dataZabolevaniyaLabel.Name = "dataZabolevaniyaLabel";
            dataZabolevaniyaLabel.Size = new System.Drawing.Size(147, 20);
            dataZabolevaniyaLabel.TabIndex = 5;
            dataZabolevaniyaLabel.Text = "Дата Рождения:";
            // 
            // dataZabolevaniyaDateTimePicker
            // 
            this.dataZabolevaniyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.potomstvoBindingSource, "DataZabolevaniya", true));
            this.dataZabolevaniyaDateTimePicker.Location = new System.Drawing.Point(170, 94);
            this.dataZabolevaniyaDateTimePicker.Name = "dataZabolevaniyaDateTimePicker";
            this.dataZabolevaniyaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataZabolevaniyaDateTimePicker.TabIndex = 6;
            // 
            // EditPotomstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 152);
            this.Controls.Add(dataZabolevaniyaLabel);
            this.Controls.Add(this.dataZabolevaniyaDateTimePicker);
            this.Controls.Add(nomerJivLabel);
            this.Controls.Add(this.nomerJivComboBox);
            this.Controls.Add(nomerDetLabel);
            this.Controls.Add(this.nomerDetTextBox);
            this.Controls.Add(this.potomstvoBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "EditPotomstvo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные | Потомство | Редактировать";
            this.Load += new System.EventHandler(this.EditPotomstvo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potomstvoBindingNavigator)).EndInit();
            this.potomstvoBindingNavigator.ResumeLayout(false);
            this.potomstvoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource potomstvoBindingSource;
        private ZooDataSetTableAdapters.PotomstvoTableAdapter potomstvoTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator potomstvoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton potomstvoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomerDetTextBox;
        private System.Windows.Forms.ComboBox nomerJivComboBox;
        private System.Windows.Forms.DateTimePicker dataZabolevaniyaDateTimePicker;
    }
}