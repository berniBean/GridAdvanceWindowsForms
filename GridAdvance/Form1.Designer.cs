
namespace GridAdvance
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rank = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Occupation = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Jobs = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Salary = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.Rate = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.DateTime = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FilterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Occupation,
            this.Jobs,
            this.Salary,
            this.Rate,
            this.DateTime});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "Rank";
            this.Rank.FilteringEnabled = false;
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Occupation
            // 
            this.Occupation.DataPropertyName = "Occupation";
            this.Occupation.FilteringEnabled = false;
            this.Occupation.HeaderText = "Occupation";
            this.Occupation.Name = "Occupation";
            this.Occupation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Jobs
            // 
            this.Jobs.DataPropertyName = "Jobs";
            this.Jobs.FilteringEnabled = false;
            this.Jobs.HeaderText = "Jobs";
            this.Jobs.Name = "Jobs";
            this.Jobs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.FilteringEnabled = false;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.FilteringEnabled = false;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.FilteringEnabled = false;
            this.DateTime.HeaderText = "DateTime";
            this.DateTime.Name = "DateTime";
            this.DateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(GridAdvance.Person);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterStatusLabel,
            this.ShowAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FilterStatusLabel
            // 
            this.FilterStatusLabel.Name = "FilterStatusLabel";
            this.FilterStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.FilterStatusLabel.Visible = false;
            // 
            // ShowAllLabel
            // 
            this.ShowAllLabel.IsLink = true;
            this.ShowAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAllLabel.Name = "ShowAllLabel";
            this.ShowAllLabel.Size = new System.Drawing.Size(53, 17);
            this.ShowAllLabel.Text = "Show &All";
            this.ShowAllLabel.Click += new System.EventHandler(this.ShowAllLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FilterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAllLabel;
        private System.Windows.Forms.BindingSource personBindingSource;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Rank;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Occupation;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Jobs;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Salary;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn Rate;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn DateTime;
    }
}

