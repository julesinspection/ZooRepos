
namespace Zoo.Forms {
    partial class EditBolezni {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBolezni));
            System.Windows.Forms.Label nomerJivLabel;
            System.Windows.Forms.Label nazvanieBolezniLabel;
            System.Windows.Forms.Label dataZabolevaniyaLabel;
            this.zooDataSet = new Zoo.ZooDataSet();
            this.kartochkaBolezneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartochkaBolezneyTableAdapter = new Zoo.ZooDataSetTableAdapters.KartochkaBolezneyTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.kartochkaBolezneyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kartochkaBolezneyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomerJivComboBox = new System.Windows.Forms.ComboBox();
            this.nazvanieBolezniTextBox = new System.Windows.Forms.TextBox();
            this.dataZabolevaniyaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jivotnoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jivotnoeTableAdapter = new Zoo.ZooDataSetTableAdapters.JivotnoeTableAdapter();
            nomerJivLabel = new System.Windows.Forms.Label();
            nazvanieBolezniLabel = new System.Windows.Forms.Label();
            dataZabolevaniyaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyBindingNavigator)).BeginInit();
            this.kartochkaBolezneyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zooDataSet
            // 
            this.zooDataSet.DataSetName = "ZooDataSet";
            this.zooDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartochkaBolezneyBindingSource
            // 
            this.kartochkaBolezneyBindingSource.DataMember = "KartochkaBolezney";
            this.kartochkaBolezneyBindingSource.DataSource = this.zooDataSet;
            // 
            // kartochkaBolezneyTableAdapter
            // 
            this.kartochkaBolezneyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JivotnoeTableAdapter = this.jivotnoeTableAdapter;
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = this.kartochkaBolezneyTableAdapter;
            this.tableAdapterManager.KormTableAdapter = null;
            this.tableAdapterManager.PotomstvoTableAdapter = null;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kartochkaBolezneyBindingNavigator
            // 
            this.kartochkaBolezneyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kartochkaBolezneyBindingNavigator.BindingSource = this.kartochkaBolezneyBindingSource;
            this.kartochkaBolezneyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kartochkaBolezneyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kartochkaBolezneyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kartochkaBolezneyBindingNavigatorSaveItem});
            this.kartochkaBolezneyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kartochkaBolezneyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kartochkaBolezneyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kartochkaBolezneyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kartochkaBolezneyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kartochkaBolezneyBindingNavigator.Name = "kartochkaBolezneyBindingNavigator";
            this.kartochkaBolezneyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kartochkaBolezneyBindingNavigator.Size = new System.Drawing.Size(480, 25);
            this.kartochkaBolezneyBindingNavigator.TabIndex = 0;
            this.kartochkaBolezneyBindingNavigator.Text = "bindingNavigator1";
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
            // kartochkaBolezneyBindingNavigatorSaveItem
            // 
            this.kartochkaBolezneyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kartochkaBolezneyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kartochkaBolezneyBindingNavigatorSaveItem.Image")));
            this.kartochkaBolezneyBindingNavigatorSaveItem.Name = "kartochkaBolezneyBindingNavigatorSaveItem";
            this.kartochkaBolezneyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kartochkaBolezneyBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kartochkaBolezneyBindingNavigatorSaveItem.Click += new System.EventHandler(this.kartochkaBolezneyBindingNavigatorSaveItem_Click);
            // 
            // nomerJivLabel
            // 
            nomerJivLabel.AutoSize = true;
            nomerJivLabel.Location = new System.Drawing.Point(16, 36);
            nomerJivLabel.Name = "nomerJivLabel";
            nomerJivLabel.Size = new System.Drawing.Size(164, 20);
            nomerJivLabel.TabIndex = 1;
            nomerJivLabel.Text = "Номер животного:";
            // 
            // nomerJivComboBox
            // 
            this.nomerJivComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kartochkaBolezneyBindingSource, "NomerJiv", true));
            this.nomerJivComboBox.DataSource = this.jivotnoeBindingSource;
            this.nomerJivComboBox.DisplayMember = "NomerJiv";
            this.nomerJivComboBox.FormattingEnabled = true;
            this.nomerJivComboBox.Location = new System.Drawing.Point(186, 28);
            this.nomerJivComboBox.Name = "nomerJivComboBox";
            this.nomerJivComboBox.Size = new System.Drawing.Size(121, 28);
            this.nomerJivComboBox.TabIndex = 2;
            // 
            // nazvanieBolezniLabel
            // 
            nazvanieBolezniLabel.AutoSize = true;
            nazvanieBolezniLabel.Location = new System.Drawing.Point(9, 68);
            nazvanieBolezniLabel.Name = "nazvanieBolezniLabel";
            nazvanieBolezniLabel.Size = new System.Drawing.Size(171, 20);
            nazvanieBolezniLabel.TabIndex = 3;
            nazvanieBolezniLabel.Text = "Название болезни:";
            // 
            // nazvanieBolezniTextBox
            // 
            this.nazvanieBolezniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kartochkaBolezneyBindingSource, "NazvanieBolezni", true));
            this.nazvanieBolezniTextBox.Location = new System.Drawing.Point(186, 62);
            this.nazvanieBolezniTextBox.Name = "nazvanieBolezniTextBox";
            this.nazvanieBolezniTextBox.Size = new System.Drawing.Size(282, 26);
            this.nazvanieBolezniTextBox.TabIndex = 4;
            // 
            // dataZabolevaniyaLabel
            // 
            dataZabolevaniyaLabel.AutoSize = true;
            dataZabolevaniyaLabel.Location = new System.Drawing.Point(8, 100);
            dataZabolevaniyaLabel.Name = "dataZabolevaniyaLabel";
            dataZabolevaniyaLabel.Size = new System.Drawing.Size(172, 20);
            dataZabolevaniyaLabel.TabIndex = 5;
            dataZabolevaniyaLabel.Text = "Дата заболевания:";
            // 
            // dataZabolevaniyaDateTimePicker
            // 
            this.dataZabolevaniyaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kartochkaBolezneyBindingSource, "DataZabolevaniya", true));
            this.dataZabolevaniyaDateTimePicker.Location = new System.Drawing.Point(186, 94);
            this.dataZabolevaniyaDateTimePicker.Name = "dataZabolevaniyaDateTimePicker";
            this.dataZabolevaniyaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dataZabolevaniyaDateTimePicker.TabIndex = 6;
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
            // EditBolezni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 156);
            this.Controls.Add(dataZabolevaniyaLabel);
            this.Controls.Add(this.dataZabolevaniyaDateTimePicker);
            this.Controls.Add(nazvanieBolezniLabel);
            this.Controls.Add(this.nazvanieBolezniTextBox);
            this.Controls.Add(nomerJivLabel);
            this.Controls.Add(this.nomerJivComboBox);
            this.Controls.Add(this.kartochkaBolezneyBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "EditBolezni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные | Болезни | Редактировать";
            this.Load += new System.EventHandler(this.EditBolezni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartochkaBolezneyBindingNavigator)).EndInit();
            this.kartochkaBolezneyBindingNavigator.ResumeLayout(false);
            this.kartochkaBolezneyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource kartochkaBolezneyBindingSource;
        private ZooDataSetTableAdapters.KartochkaBolezneyTableAdapter kartochkaBolezneyTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kartochkaBolezneyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kartochkaBolezneyBindingNavigatorSaveItem;
        private ZooDataSetTableAdapters.JivotnoeTableAdapter jivotnoeTableAdapter;
        private System.Windows.Forms.ComboBox nomerJivComboBox;
        private System.Windows.Forms.TextBox nazvanieBolezniTextBox;
        private System.Windows.Forms.DateTimePicker dataZabolevaniyaDateTimePicker;
        private System.Windows.Forms.BindingSource jivotnoeBindingSource;
    }
}