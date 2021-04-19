namespace Analizator
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.tblUp = new System.Windows.Forms.TableLayoutPanel();
            this.tblResults = new System.Windows.Forms.TableLayoutPanel();
            this.tblResultsExport = new System.Windows.Forms.TableLayoutPanel();
            this.cboxMax = new System.Windows.Forms.CheckBox();
            this.cboxMin = new System.Windows.Forms.CheckBox();
            this.cboxVariance = new System.Windows.Forms.CheckBox();
            this.cboxAverage = new System.Windows.Forms.CheckBox();
            this.tblResultsData = new System.Windows.Forms.TableLayoutPanel();
            this.lblDataMax = new System.Windows.Forms.Label();
            this.lblDataMin = new System.Windows.Forms.Label();
            this.lblDataVariance = new System.Windows.Forms.Label();
            this.lblDataAverage = new System.Windows.Forms.Label();
            this.tblResultsInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfoAverage = new System.Windows.Forms.Label();
            this.lblInfoVariance = new System.Windows.Forms.Label();
            this.lblInfoMin = new System.Windows.Forms.Label();
            this.lblInfoMax = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnOpenAdvancedChart = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tblMain.SuspendLayout();
            this.tblUp.SuspendLayout();
            this.tblResults.SuspendLayout();
            this.tblResultsExport.SuspendLayout();
            this.tblResultsData.SuspendLayout();
            this.tblResultsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.btnReadFile, 0, 0);
            this.tblMain.Controls.Add(this.tblUp, 1, 0);
            this.tblMain.Controls.Add(this.chartData, 1, 1);
            this.tblMain.Controls.Add(this.tabControl, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(897, 492);
            this.tblMain.TabIndex = 5;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadFile.Location = new System.Drawing.Point(40, 34);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(40, 34, 40, 34);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(170, 43);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Otwórz plik";
            this.btnReadFile.UseMnemonic = false;
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // tblUp
            // 
            this.tblUp.AutoSize = true;
            this.tblUp.ColumnCount = 3;
            this.tblUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUp.Controls.Add(this.tblResults, 0, 0);
            this.tblUp.Controls.Add(this.btnExport, 1, 0);
            this.tblUp.Controls.Add(this.btnOpenAdvancedChart, 2, 0);
            this.tblUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUp.Location = new System.Drawing.Point(250, 0);
            this.tblUp.Margin = new System.Windows.Forms.Padding(0);
            this.tblUp.Name = "tblUp";
            this.tblUp.RowCount = 1;
            this.tblUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUp.Size = new System.Drawing.Size(647, 111);
            this.tblUp.TabIndex = 4;
            this.tblUp.Visible = false;
            // 
            // tblResults
            // 
            this.tblResults.AutoSize = true;
            this.tblResults.ColumnCount = 3;
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblResults.Controls.Add(this.tblResultsExport, 2, 0);
            this.tblResults.Controls.Add(this.tblResultsData, 1, 0);
            this.tblResults.Controls.Add(this.tblResultsInfo, 0, 0);
            this.tblResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResults.Location = new System.Drawing.Point(0, 0);
            this.tblResults.Margin = new System.Windows.Forms.Padding(0);
            this.tblResults.MaximumSize = new System.Drawing.Size(933, 0);
            this.tblResults.Name = "tblResults";
            this.tblResults.RowCount = 1;
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResults.Size = new System.Drawing.Size(252, 111);
            this.tblResults.TabIndex = 3;
            // 
            // tblResultsExport
            // 
            this.tblResultsExport.AutoSize = true;
            this.tblResultsExport.ColumnCount = 1;
            this.tblResultsExport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResultsExport.Controls.Add(this.cboxMax, 0, 3);
            this.tblResultsExport.Controls.Add(this.cboxMin, 0, 2);
            this.tblResultsExport.Controls.Add(this.cboxVariance, 0, 1);
            this.tblResultsExport.Controls.Add(this.cboxAverage, 0, 0);
            this.tblResultsExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResultsExport.Location = new System.Drawing.Point(225, 0);
            this.tblResultsExport.Margin = new System.Windows.Forms.Padding(0);
            this.tblResultsExport.Name = "tblResultsExport";
            this.tblResultsExport.RowCount = 4;
            this.tblResultsExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResultsExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResultsExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResultsExport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResultsExport.Size = new System.Drawing.Size(27, 111);
            this.tblResultsExport.TabIndex = 5;
            // 
            // cboxMax
            // 
            this.cboxMax.AutoSize = true;
            this.cboxMax.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxMax.Checked = true;
            this.cboxMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxMax.Location = new System.Drawing.Point(0, 81);
            this.cboxMax.Margin = new System.Windows.Forms.Padding(0);
            this.cboxMax.Name = "cboxMax";
            this.cboxMax.Size = new System.Drawing.Size(27, 30);
            this.cboxMax.TabIndex = 5;
            this.cboxMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxMax.UseVisualStyleBackColor = true;
            // 
            // cboxMin
            // 
            this.cboxMin.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxMin.Checked = true;
            this.cboxMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxMin.Location = new System.Drawing.Point(0, 54);
            this.cboxMin.Margin = new System.Windows.Forms.Padding(0);
            this.cboxMin.Name = "cboxMin";
            this.cboxMin.Size = new System.Drawing.Size(27, 27);
            this.cboxMin.TabIndex = 2;
            this.cboxMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxMin.UseVisualStyleBackColor = true;
            // 
            // cboxVariance
            // 
            this.cboxVariance.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxVariance.Checked = true;
            this.cboxVariance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxVariance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxVariance.Location = new System.Drawing.Point(0, 27);
            this.cboxVariance.Margin = new System.Windows.Forms.Padding(0);
            this.cboxVariance.Name = "cboxVariance";
            this.cboxVariance.Size = new System.Drawing.Size(27, 27);
            this.cboxVariance.TabIndex = 1;
            this.cboxVariance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxVariance.UseVisualStyleBackColor = true;
            // 
            // cboxAverage
            // 
            this.cboxAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxAverage.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxAverage.Checked = true;
            this.cboxAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAverage.Location = new System.Drawing.Point(0, 0);
            this.cboxAverage.Margin = new System.Windows.Forms.Padding(0);
            this.cboxAverage.Name = "cboxAverage";
            this.cboxAverage.Size = new System.Drawing.Size(27, 27);
            this.cboxAverage.TabIndex = 0;
            this.cboxAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxAverage.UseVisualStyleBackColor = true;
            // 
            // tblResultsData
            // 
            this.tblResultsData.AutoSize = true;
            this.tblResultsData.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblResultsData.ColumnCount = 1;
            this.tblResultsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResultsData.Controls.Add(this.lblDataMax, 0, 3);
            this.tblResultsData.Controls.Add(this.lblDataMin, 0, 2);
            this.tblResultsData.Controls.Add(this.lblDataVariance, 0, 1);
            this.tblResultsData.Controls.Add(this.lblDataAverage, 0, 0);
            this.tblResultsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResultsData.Location = new System.Drawing.Point(213, 0);
            this.tblResultsData.Margin = new System.Windows.Forms.Padding(0);
            this.tblResultsData.Name = "tblResultsData";
            this.tblResultsData.RowCount = 4;
            this.tblResultsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsData.Size = new System.Drawing.Size(12, 111);
            this.tblResultsData.TabIndex = 5;
            // 
            // lblDataMax
            // 
            this.lblDataMax.AutoSize = true;
            this.lblDataMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataMax.Location = new System.Drawing.Point(6, 83);
            this.lblDataMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataMax.Name = "lblDataMax";
            this.lblDataMax.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblDataMax.Size = new System.Drawing.Size(1, 26);
            this.lblDataMax.TabIndex = 9;
            this.lblDataMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataMin
            // 
            this.lblDataMin.AutoSize = true;
            this.lblDataMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataMin.Location = new System.Drawing.Point(6, 56);
            this.lblDataMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataMin.Name = "lblDataMin";
            this.lblDataMin.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblDataMin.Size = new System.Drawing.Size(1, 25);
            this.lblDataMin.TabIndex = 8;
            this.lblDataMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataVariance
            // 
            this.lblDataVariance.AutoSize = true;
            this.lblDataVariance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataVariance.Location = new System.Drawing.Point(6, 29);
            this.lblDataVariance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataVariance.Name = "lblDataVariance";
            this.lblDataVariance.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblDataVariance.Size = new System.Drawing.Size(1, 25);
            this.lblDataVariance.TabIndex = 7;
            this.lblDataVariance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataAverage
            // 
            this.lblDataAverage.AutoSize = true;
            this.lblDataAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataAverage.Location = new System.Drawing.Point(6, 2);
            this.lblDataAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAverage.Name = "lblDataAverage";
            this.lblDataAverage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblDataAverage.Size = new System.Drawing.Size(1, 25);
            this.lblDataAverage.TabIndex = 6;
            this.lblDataAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblResultsInfo
            // 
            this.tblResultsInfo.AutoSize = true;
            this.tblResultsInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblResultsInfo.ColumnCount = 1;
            this.tblResultsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblResultsInfo.Controls.Add(this.lblInfoAverage, 0, 0);
            this.tblResultsInfo.Controls.Add(this.lblInfoVariance, 0, 1);
            this.tblResultsInfo.Controls.Add(this.lblInfoMin, 0, 2);
            this.tblResultsInfo.Controls.Add(this.lblInfoMax, 0, 3);
            this.tblResultsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblResultsInfo.Location = new System.Drawing.Point(0, 0);
            this.tblResultsInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tblResultsInfo.Name = "tblResultsInfo";
            this.tblResultsInfo.RowCount = 4;
            this.tblResultsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblResultsInfo.Size = new System.Drawing.Size(213, 111);
            this.tblResultsInfo.TabIndex = 5;
            // 
            // lblInfoAverage
            // 
            this.lblInfoAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoAverage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoAverage.Location = new System.Drawing.Point(6, 2);
            this.lblInfoAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoAverage.Name = "lblInfoAverage";
            this.lblInfoAverage.Size = new System.Drawing.Size(201, 25);
            this.lblInfoAverage.TabIndex = 2;
            this.lblInfoAverage.Text = "Średnia wartość wynosi:";
            this.lblInfoAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoVariance
            // 
            this.lblInfoVariance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoVariance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoVariance.Location = new System.Drawing.Point(6, 29);
            this.lblInfoVariance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoVariance.Name = "lblInfoVariance";
            this.lblInfoVariance.Size = new System.Drawing.Size(201, 25);
            this.lblInfoVariance.TabIndex = 3;
            this.lblInfoVariance.Text = "Wariancja wynosi:";
            this.lblInfoVariance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoMin
            // 
            this.lblInfoMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoMin.Location = new System.Drawing.Point(6, 56);
            this.lblInfoMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoMin.Name = "lblInfoMin";
            this.lblInfoMin.Size = new System.Drawing.Size(201, 25);
            this.lblInfoMin.TabIndex = 4;
            this.lblInfoMin.Text = "Minimalna wartość wynosi:";
            this.lblInfoMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoMax
            // 
            this.lblInfoMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfoMax.Location = new System.Drawing.Point(6, 83);
            this.lblInfoMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoMax.Name = "lblInfoMax";
            this.lblInfoMax.Size = new System.Drawing.Size(201, 26);
            this.lblInfoMax.TabIndex = 5;
            this.lblInfoMax.Text = "Maksymalna wartość wynosi:";
            this.lblInfoMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(255, 25);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 61);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Eksportuj";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnOpenAdvancedChart
            // 
            this.btnOpenAdvancedChart.AutoSize = true;
            this.btnOpenAdvancedChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenAdvancedChart.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenAdvancedChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenAdvancedChart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenAdvancedChart.Location = new System.Drawing.Point(349, 4);
            this.btnOpenAdvancedChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenAdvancedChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpenAdvancedChart.Name = "btnOpenAdvancedChart";
            this.btnOpenAdvancedChart.Size = new System.Drawing.Size(294, 103);
            this.btnOpenAdvancedChart.TabIndex = 5;
            this.btnOpenAdvancedChart.Text = "Otwórz zaawansowany wykres";
            this.btnOpenAdvancedChart.UseVisualStyleBackColor = false;
            this.btnOpenAdvancedChart.Click += new System.EventHandler(this.btnOpenAdvancedChart_Click);
            // 
            // chartData
            // 
            this.chartData.BackColor = System.Drawing.Color.Transparent;
            this.chartData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartData.Location = new System.Drawing.Point(254, 115);
            this.chartData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartData.Name = "chartData";
            this.chartData.Size = new System.Drawing.Size(639, 374);
            this.chartData.TabIndex = 5;
            this.chartData.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(4, 115);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(242, 374);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 492);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(234, 137);
            this.Name = "FormMain";
            this.Text = "Analizator";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblUp.ResumeLayout(false);
            this.tblUp.PerformLayout();
            this.tblResults.ResumeLayout(false);
            this.tblResults.PerformLayout();
            this.tblResultsExport.ResumeLayout(false);
            this.tblResultsExport.PerformLayout();
            this.tblResultsData.ResumeLayout(false);
            this.tblResultsData.PerformLayout();
            this.tblResultsInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TableLayoutPanel tblUp;
        private System.Windows.Forms.TableLayoutPanel tblResults;
        private System.Windows.Forms.TableLayoutPanel tblResultsExport;
        private System.Windows.Forms.CheckBox cboxMax;
        private System.Windows.Forms.CheckBox cboxMin;
        private System.Windows.Forms.CheckBox cboxVariance;
        private System.Windows.Forms.CheckBox cboxAverage;
        private System.Windows.Forms.TableLayoutPanel tblResultsData;
        private System.Windows.Forms.Label lblDataMax;
        private System.Windows.Forms.Label lblDataMin;
        private System.Windows.Forms.Label lblDataVariance;
        private System.Windows.Forms.Label lblDataAverage;
        private System.Windows.Forms.TableLayoutPanel tblResultsInfo;
        private System.Windows.Forms.Label lblInfoAverage;
        private System.Windows.Forms.Label lblInfoVariance;
        private System.Windows.Forms.Label lblInfoMin;
        private System.Windows.Forms.Label lblInfoMax;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnOpenAdvancedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.TabControl tabControl;
    }
}

