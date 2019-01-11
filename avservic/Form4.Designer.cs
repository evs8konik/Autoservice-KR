namespace avservic
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.автосервисDataSet = new avservic.автосервисDataSet();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиTableAdapter = new avservic.автосервисDataSetTableAdapters.УслугиTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяВыполнениячасыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гарантиядниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автосервисDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.видработыDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.времяВыполнениячасыDataGridViewTextBoxColumn,
            this.гарантиядниDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.услугиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // автосервисDataSet
            // 
            this.автосервисDataSet.DataSetName = "автосервисDataSet";
            this.автосервисDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.автосервисDataSet;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // видработыDataGridViewTextBoxColumn
            // 
            this.видработыDataGridViewTextBoxColumn.DataPropertyName = "Вид_работы";
            this.видработыDataGridViewTextBoxColumn.HeaderText = "Вид_работы";
            this.видработыDataGridViewTextBoxColumn.Name = "видработыDataGridViewTextBoxColumn";
            this.видработыDataGridViewTextBoxColumn.Width = 160;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // времяВыполнениячасыDataGridViewTextBoxColumn
            // 
            this.времяВыполнениячасыDataGridViewTextBoxColumn.DataPropertyName = "Время выполнения(часы)";
            this.времяВыполнениячасыDataGridViewTextBoxColumn.HeaderText = "Время выполнения(часы)";
            this.времяВыполнениячасыDataGridViewTextBoxColumn.Name = "времяВыполнениячасыDataGridViewTextBoxColumn";
            // 
            // гарантиядниDataGridViewTextBoxColumn
            // 
            this.гарантиядниDataGridViewTextBoxColumn.DataPropertyName = "Гарантия(дни)";
            this.гарантиядниDataGridViewTextBoxColumn.HeaderText = "Гарантия(дни)";
            this.гарантиядниDataGridViewTextBoxColumn.Name = "гарантиядниDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::avservic.Properties.Resources.x_c7673acc;
            this.ClientSize = new System.Drawing.Size(599, 342);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Услуги автосервиса";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автосервисDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private автосервисDataSet автосервисDataSet;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private автосервисDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяВыполнениячасыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гарантиядниDataGridViewTextBoxColumn;
    }
}