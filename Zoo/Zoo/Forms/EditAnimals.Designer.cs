
namespace Zoo.Forms {
    partial class EditAnimals {
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
            System.Windows.Forms.Label nomerJivLabel;
            System.Windows.Forms.Label klichkaJivLabel;
            System.Windows.Forms.Label nomerValeraLabel;
            System.Windows.Forms.Label vidJivotnogoLabel;
            System.Windows.Forms.Label polJivotnogoLabel;
            System.Windows.Forms.Label vozrastJivotnogoLabel;
            System.Windows.Forms.Label nomerKormaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAnimals));
            this.zooDataSet = new Zoo.ZooDataSet();
            this.jivotnoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jivotnoeTableAdapter = new Zoo.ZooDataSetTableAdapters.JivotnoeTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.kormTableAdapter = new Zoo.ZooDataSetTableAdapters.KormTableAdapter();
            this.jivotnoeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jivotnoeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomerJivTextBox = new System.Windows.Forms.TextBox();
            this.klichkaJivTextBox = new System.Windows.Forms.TextBox();
            this.nomerValeraTextBox = new System.Windows.Forms.TextBox();
            this.vidJivotnogoTextBox = new System.Windows.Forms.TextBox();
            this.polJivotnogoComboBox = new System.Windows.Forms.ComboBox();
            this.vozrastJivotnogoTextBox = new System.Windows.Forms.TextBox();
            this.nomerKormaComboBox = new System.Windows.Forms.ComboBox();
            this.kormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomerJivLabel = new System.Windows.Forms.Label();
            klichkaJivLabel = new System.Windows.Forms.Label();
            nomerValeraLabel = new System.Windows.Forms.Label();
            vidJivotnogoLabel = new System.Windows.Forms.Label();
            polJivotnogoLabel = new System.Windows.Forms.Label();
            vozrastJivotnogoLabel = new System.Windows.Forms.Label();
            nomerKormaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingNavigator)).BeginInit();
            this.jivotnoeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomerJivLabel
            // 
            nomerJivLabel.AutoSize = true;
            nomerJivLabel.Location = new System.Drawing.Point(104, 36);
            nomerJivLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerJivLabel.Name = "nomerJivLabel";
            nomerJivLabel.Size = new System.Drawing.Size(69, 20);
            nomerJivLabel.TabIndex = 1;
            nomerJivLabel.Text = "Номер:";
            // 
            // klichkaJivLabel
            // 
            klichkaJivLabel.AutoSize = true;
            klichkaJivLabel.Location = new System.Drawing.Point(98, 76);
            klichkaJivLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            klichkaJivLabel.Name = "klichkaJivLabel";
            klichkaJivLabel.Size = new System.Drawing.Size(75, 20);
            klichkaJivLabel.TabIndex = 3;
            klichkaJivLabel.Text = "Кличка:";
            // 
            // nomerValeraLabel
            // 
            nomerValeraLabel.AutoSize = true;
            nomerValeraLabel.Location = new System.Drawing.Point(28, 116);
            nomerValeraLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerValeraLabel.Name = "nomerValeraLabel";
            nomerValeraLabel.Size = new System.Drawing.Size(145, 20);
            nomerValeraLabel.TabIndex = 5;
            nomerValeraLabel.Text = "Номер вальера:";
            // 
            // vidJivotnogoLabel
            // 
            vidJivotnogoLabel.AutoSize = true;
            vidJivotnogoLabel.Location = new System.Drawing.Point(125, 156);
            vidJivotnogoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vidJivotnogoLabel.Name = "vidJivotnogoLabel";
            vidJivotnogoLabel.Size = new System.Drawing.Size(48, 20);
            vidJivotnogoLabel.TabIndex = 7;
            vidJivotnogoLabel.Text = "Вид:";
            // 
            // polJivotnogoLabel
            // 
            polJivotnogoLabel.AutoSize = true;
            polJivotnogoLabel.Location = new System.Drawing.Point(125, 198);
            polJivotnogoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            polJivotnogoLabel.Name = "polJivotnogoLabel";
            polJivotnogoLabel.Size = new System.Drawing.Size(48, 20);
            polJivotnogoLabel.TabIndex = 9;
            polJivotnogoLabel.Text = "Пол:";
            // 
            // vozrastJivotnogoLabel
            // 
            vozrastJivotnogoLabel.AutoSize = true;
            vozrastJivotnogoLabel.Location = new System.Drawing.Point(89, 238);
            vozrastJivotnogoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vozrastJivotnogoLabel.Name = "vozrastJivotnogoLabel";
            vozrastJivotnogoLabel.Size = new System.Drawing.Size(84, 20);
            vozrastJivotnogoLabel.TabIndex = 11;
            vozrastJivotnogoLabel.Text = "Возраст:";
            // 
            // nomerKormaLabel
            // 
            nomerKormaLabel.AutoSize = true;
            nomerKormaLabel.Location = new System.Drawing.Point(48, 280);
            nomerKormaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nomerKormaLabel.Name = "nomerKormaLabel";
            nomerKormaLabel.Size = new System.Drawing.Size(125, 20);
            nomerKormaLabel.TabIndex = 13;
            nomerKormaLabel.Text = "Номер корма:";
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
            this.tableAdapterManager.KartochkaBolezneyTableAdapter = null;
            this.tableAdapterManager.KormTableAdapter = this.kormTableAdapter;
            this.tableAdapterManager.PotomstvoTableAdapter = null;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kormTableAdapter
            // 
            this.kormTableAdapter.ClearBeforeFill = true;
            // 
            // jivotnoeBindingNavigator
            // 
            this.jivotnoeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jivotnoeBindingNavigator.BindingSource = this.jivotnoeBindingSource;
            this.jivotnoeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jivotnoeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jivotnoeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jivotnoeBindingNavigatorSaveItem});
            this.jivotnoeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jivotnoeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jivotnoeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jivotnoeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jivotnoeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jivotnoeBindingNavigator.Name = "jivotnoeBindingNavigator";
            this.jivotnoeBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.jivotnoeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jivotnoeBindingNavigator.Size = new System.Drawing.Size(584, 25);
            this.jivotnoeBindingNavigator.TabIndex = 0;
            this.jivotnoeBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // jivotnoeBindingNavigatorSaveItem
            // 
            this.jivotnoeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jivotnoeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jivotnoeBindingNavigatorSaveItem.Image")));
            this.jivotnoeBindingNavigatorSaveItem.Name = "jivotnoeBindingNavigatorSaveItem";
            this.jivotnoeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jivotnoeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.jivotnoeBindingNavigatorSaveItem.Click += new System.EventHandler(this.jivotnoeBindingNavigatorSaveItem_Click);
            // 
            // nomerJivTextBox
            // 
            this.nomerJivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "NomerJiv", true));
            this.nomerJivTextBox.Location = new System.Drawing.Point(183, 30);
            this.nomerJivTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomerJivTextBox.Name = "nomerJivTextBox";
            this.nomerJivTextBox.Size = new System.Drawing.Size(164, 26);
            this.nomerJivTextBox.TabIndex = 2;
            // 
            // klichkaJivTextBox
            // 
            this.klichkaJivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "KlichkaJiv", true));
            this.klichkaJivTextBox.Location = new System.Drawing.Point(183, 70);
            this.klichkaJivTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.klichkaJivTextBox.Name = "klichkaJivTextBox";
            this.klichkaJivTextBox.Size = new System.Drawing.Size(164, 26);
            this.klichkaJivTextBox.TabIndex = 4;
            // 
            // nomerValeraTextBox
            // 
            this.nomerValeraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "NomerValera", true));
            this.nomerValeraTextBox.Location = new System.Drawing.Point(183, 110);
            this.nomerValeraTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomerValeraTextBox.Name = "nomerValeraTextBox";
            this.nomerValeraTextBox.Size = new System.Drawing.Size(164, 26);
            this.nomerValeraTextBox.TabIndex = 6;
            // 
            // vidJivotnogoTextBox
            // 
            this.vidJivotnogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "VidJivotnogo", true));
            this.vidJivotnogoTextBox.Location = new System.Drawing.Point(183, 150);
            this.vidJivotnogoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.vidJivotnogoTextBox.Name = "vidJivotnogoTextBox";
            this.vidJivotnogoTextBox.Size = new System.Drawing.Size(164, 26);
            this.vidJivotnogoTextBox.TabIndex = 8;
            // 
            // polJivotnogoComboBox
            // 
            this.polJivotnogoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "PolJivotnogo", true));
            this.polJivotnogoComboBox.FormattingEnabled = true;
            this.polJivotnogoComboBox.Items.AddRange(new object[] {
            "самец",
            "самка"});
            this.polJivotnogoComboBox.Location = new System.Drawing.Point(183, 190);
            this.polJivotnogoComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.polJivotnogoComboBox.Name = "polJivotnogoComboBox";
            this.polJivotnogoComboBox.Size = new System.Drawing.Size(199, 28);
            this.polJivotnogoComboBox.TabIndex = 10;
            // 
            // vozrastJivotnogoTextBox
            // 
            this.vozrastJivotnogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "VozrastJivotnogo", true));
            this.vozrastJivotnogoTextBox.Location = new System.Drawing.Point(183, 232);
            this.vozrastJivotnogoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.vozrastJivotnogoTextBox.Name = "vozrastJivotnogoTextBox";
            this.vozrastJivotnogoTextBox.Size = new System.Drawing.Size(164, 26);
            this.vozrastJivotnogoTextBox.TabIndex = 12;
            // 
            // nomerKormaComboBox
            // 
            this.nomerKormaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jivotnoeBindingSource, "NomerKorma", true));
            this.nomerKormaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jivotnoeBindingSource, "NomerKorma", true));
            this.nomerKormaComboBox.DataSource = this.kormBindingSource;
            this.nomerKormaComboBox.DisplayMember = "NomerKorma";
            this.nomerKormaComboBox.FormattingEnabled = true;
            this.nomerKormaComboBox.Location = new System.Drawing.Point(183, 272);
            this.nomerKormaComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomerKormaComboBox.Name = "nomerKormaComboBox";
            this.nomerKormaComboBox.Size = new System.Drawing.Size(199, 28);
            this.nomerKormaComboBox.TabIndex = 14;
            this.nomerKormaComboBox.ValueMember = "NomerKorma";
            // 
            // kormBindingSource
            // 
            this.kormBindingSource.DataMember = "Korm";
            this.kormBindingSource.DataSource = this.zooDataSet;
            // 
            // EditAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(nomerKormaLabel);
            this.Controls.Add(this.nomerKormaComboBox);
            this.Controls.Add(vozrastJivotnogoLabel);
            this.Controls.Add(this.vozrastJivotnogoTextBox);
            this.Controls.Add(polJivotnogoLabel);
            this.Controls.Add(this.polJivotnogoComboBox);
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
            this.Name = "EditAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные | Редактировать";
            this.Load += new System.EventHandler(this.EditAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingNavigator)).EndInit();
            this.jivotnoeBindingNavigator.ResumeLayout(false);
            this.jivotnoeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource jivotnoeBindingSource;
        private ZooDataSetTableAdapters.JivotnoeTableAdapter jivotnoeTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jivotnoeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jivotnoeBindingNavigatorSaveItem;
        private ZooDataSetTableAdapters.KormTableAdapter kormTableAdapter;
        private System.Windows.Forms.TextBox nomerJivTextBox;
        private System.Windows.Forms.TextBox klichkaJivTextBox;
        private System.Windows.Forms.TextBox nomerValeraTextBox;
        private System.Windows.Forms.TextBox vidJivotnogoTextBox;
        private System.Windows.Forms.ComboBox polJivotnogoComboBox;
        private System.Windows.Forms.TextBox vozrastJivotnogoTextBox;
        private System.Windows.Forms.ComboBox nomerKormaComboBox;
        private System.Windows.Forms.BindingSource kormBindingSource;
    }
}