
namespace Zoo.Forms {
    partial class EditCorm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCorm));
            System.Windows.Forms.Label nomerKormaLabel;
            System.Windows.Forms.Label nazvanieKormaLabel;
            System.Windows.Forms.Label postavwikLabel;
            System.Windows.Forms.Label cenaLabel;
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kormBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomerKormaTextBox = new System.Windows.Forms.TextBox();
            this.nazvanieKormaTextBox = new System.Windows.Forms.TextBox();
            this.postavwikTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            nomerKormaLabel = new System.Windows.Forms.Label();
            nazvanieKormaLabel = new System.Windows.Forms.Label();
            postavwikLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingNavigator)).BeginInit();
            this.kormBindingNavigator.SuspendLayout();
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
            this.tableAdapterManager.JivotnoeTableAdapter = null;
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = null;
            this.tableAdapterManager.KormTableAdapter = this.kormTableAdapter;
            this.tableAdapterManager.PotomstvoTableAdapter = null;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kormBindingNavigator
            // 
            this.kormBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kormBindingNavigator.BindingSource = this.kormBindingSource;
            this.kormBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kormBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kormBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kormBindingNavigatorSaveItem});
            this.kormBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kormBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kormBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kormBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kormBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kormBindingNavigator.Name = "kormBindingNavigator";
            this.kormBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kormBindingNavigator.Size = new System.Drawing.Size(380, 25);
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
            // kormBindingNavigatorSaveItem
            // 
            this.kormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kormBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kormBindingNavigatorSaveItem.Image")));
            this.kormBindingNavigatorSaveItem.Name = "kormBindingNavigatorSaveItem";
            this.kormBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kormBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kormBindingNavigatorSaveItem.Click += new System.EventHandler(this.kormBindingNavigatorSaveItem_Click);
            // 
            // nomerKormaLabel
            // 
            nomerKormaLabel.AutoSize = true;
            nomerKormaLabel.Location = new System.Drawing.Point(46, 34);
            nomerKormaLabel.Name = "nomerKormaLabel";
            nomerKormaLabel.Size = new System.Drawing.Size(69, 20);
            nomerKormaLabel.TabIndex = 1;
            nomerKormaLabel.Text = "Номер:";
            // 
            // nomerKormaTextBox
            // 
            this.nomerKormaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "NomerKorma", true));
            this.nomerKormaTextBox.Location = new System.Drawing.Point(121, 28);
            this.nomerKormaTextBox.Name = "nomerKormaTextBox";
            this.nomerKormaTextBox.Size = new System.Drawing.Size(100, 26);
            this.nomerKormaTextBox.TabIndex = 2;
            // 
            // nazvanieKormaLabel
            // 
            nazvanieKormaLabel.AutoSize = true;
            nazvanieKormaLabel.Location = new System.Drawing.Point(19, 66);
            nazvanieKormaLabel.Name = "nazvanieKormaLabel";
            nazvanieKormaLabel.Size = new System.Drawing.Size(96, 20);
            nazvanieKormaLabel.TabIndex = 3;
            nazvanieKormaLabel.Text = "Название:";
            // 
            // nazvanieKormaTextBox
            // 
            this.nazvanieKormaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "NazvanieKorma", true));
            this.nazvanieKormaTextBox.Location = new System.Drawing.Point(121, 60);
            this.nazvanieKormaTextBox.Name = "nazvanieKormaTextBox";
            this.nazvanieKormaTextBox.Size = new System.Drawing.Size(194, 26);
            this.nazvanieKormaTextBox.TabIndex = 4;
            // 
            // postavwikLabel
            // 
            postavwikLabel.AutoSize = true;
            postavwikLabel.Location = new System.Drawing.Point(6, 98);
            postavwikLabel.Name = "postavwikLabel";
            postavwikLabel.Size = new System.Drawing.Size(109, 20);
            postavwikLabel.TabIndex = 5;
            postavwikLabel.Text = "Поставщик:";
            // 
            // postavwikTextBox
            // 
            this.postavwikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "Postavwik", true));
            this.postavwikTextBox.Location = new System.Drawing.Point(121, 92);
            this.postavwikTextBox.Name = "postavwikTextBox";
            this.postavwikTextBox.Size = new System.Drawing.Size(194, 26);
            this.postavwikTextBox.TabIndex = 6;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(58, 130);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(57, 20);
            cenaLabel.TabIndex = 7;
            cenaLabel.Text = "Цена:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(121, 124);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(100, 26);
            this.cenaTextBox.TabIndex = 8;
            // 
            // EditCorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 187);
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
            this.Name = "EditCorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корм | Редактировать";
            this.Load += new System.EventHandler(this.EditCorm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingNavigator)).EndInit();
            this.kormBindingNavigator.ResumeLayout(false);
            this.kormBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource kormBindingSource;
        private ZooDataSetTableAdapters.KormTableAdapter kormTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kormBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kormBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomerKormaTextBox;
        private System.Windows.Forms.TextBox nazvanieKormaTextBox;
        private System.Windows.Forms.TextBox postavwikTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
    }
}