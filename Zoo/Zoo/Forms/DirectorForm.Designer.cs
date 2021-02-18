namespace Zoo.Forms
{
    partial class DirectorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.животныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zooDataSet = new Zoo.ZooDataSet();
            this.jivotnoeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jivotnoeTableAdapter = new Zoo.ZooDataSetTableAdapters.JivotnoeTableAdapter();
            this.tableAdapterManager = new Zoo.ZooDataSetTableAdapters.TableAdapterManager();
            this.sotrudnikTableAdapter = new Zoo.ZooDataSetTableAdapters.SotrudnikTableAdapter();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(703, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.животныеToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // животныеToolStripMenuItem
            // 
            this.животныеToolStripMenuItem.Name = "животныеToolStripMenuItem";
            this.животныеToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.животныеToolStripMenuItem.Text = "Животные";
            this.животныеToolStripMenuItem.Click += new System.EventHandler(this.животныеToolStripMenuItem_Click);
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
            this.tableAdapterManager.KormTableAdapter = null;
            this.tableAdapterManager.PotomstvoTableAdapter = null;
            this.tableAdapterManager.RabotaSJivotnimTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = this.sotrudnikTableAdapter;
            this.tableAdapterManager.UpdateOrder = Zoo.ZooDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.zooDataSet;
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 412);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zooDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jivotnoeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem животныеToolStripMenuItem;
        private ZooDataSet zooDataSet;
        private System.Windows.Forms.BindingSource jivotnoeBindingSource;
        private ZooDataSetTableAdapters.JivotnoeTableAdapter jivotnoeTableAdapter;
        private ZooDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ZooDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}