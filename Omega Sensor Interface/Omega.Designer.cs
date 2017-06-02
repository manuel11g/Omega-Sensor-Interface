namespace Omega_Sensor_Interface
{
    partial class Omega
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StatusTab = new System.Windows.Forms.TabPage();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.AlertsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataContainer = new Omega_Sensor_Interface.DataContainer();
            this.dataContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.StatusTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.StatusTab);
            this.tabControl1.Controls.Add(this.AlertsTab);
            this.tabControl1.Controls.Add(this.ConfigTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // StatusTab
            // 
            this.StatusTab.Controls.Add(this.dataGridView1);
            this.StatusTab.Location = new System.Drawing.Point(28, 4);
            this.StatusTab.Name = "StatusTab";
            this.StatusTab.Padding = new System.Windows.Forms.Padding(3);
            this.StatusTab.Size = new System.Drawing.Size(788, 455);
            this.StatusTab.TabIndex = 0;
            this.StatusTab.Text = "Status";
            this.StatusTab.UseVisualStyleBackColor = true;
            // 
            // ConfigTab
            // 
            this.ConfigTab.Location = new System.Drawing.Point(28, 4);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(713, 455);
            this.ConfigTab.TabIndex = 1;
            this.ConfigTab.Text = "Config";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // AlertsTab
            // 
            this.AlertsTab.Location = new System.Drawing.Point(28, 4);
            this.AlertsTab.Name = "AlertsTab";
            this.AlertsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AlertsTab.Size = new System.Drawing.Size(713, 455);
            this.AlertsTab.TabIndex = 2;
            this.AlertsTab.Text = "Alerts";
            this.AlertsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.mACDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.Temperature,
            this.Humidity});
            this.dataGridView1.DataSource = this.devicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataContainer
            // 
            this.dataContainer.DataSetName = "DataContainer";
            this.dataContainer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataContainerBindingSource
            // 
            this.dataContainerBindingSource.DataSource = this.dataContainer;
            this.dataContainerBindingSource.Position = 0;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.dataContainerBindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            // 
            // mACDataGridViewTextBoxColumn
            // 
            this.mACDataGridViewTextBoxColumn.DataPropertyName = "MAC";
            this.mACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.mACDataGridViewTextBoxColumn.Name = "mACDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature C";
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            this.Temperature.Width = 125;
            // 
            // Humidity
            // 
            this.Humidity.HeaderText = "Humidity";
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            // 
            // Omega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Omega";
            this.Text = "Omega";
            this.tabControl1.ResumeLayout(false);
            this.StatusTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StatusTab;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.TabPage AlertsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private System.Windows.Forms.BindingSource dataContainerBindingSource;
        private DataContainer dataContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
    }
}