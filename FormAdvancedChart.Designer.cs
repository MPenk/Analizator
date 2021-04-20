namespace Analizator
{
    partial class FormAdvancedChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvancedChart));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.chartFromData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblChartSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tblSettingAverage = new System.Windows.Forms.TableLayoutPanel();
            this.cboxAverage = new System.Windows.Forms.CheckBox();
            this.cboAverage = new System.Windows.Forms.ComboBox();
            this.tblSettingData = new System.Windows.Forms.TableLayoutPanel();
            this.cboxData = new System.Windows.Forms.CheckBox();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboxDataLine = new System.Windows.Forms.CheckBox();
            this.lblDataLine = new System.Windows.Forms.Label();
            this.tblSettingYInterval = new System.Windows.Forms.TableLayoutPanel();
            this.tblYIntervalAuto = new System.Windows.Forms.TableLayoutPanel();
            this.lblYIntervalText1 = new System.Windows.Forms.Label();
            this.cboxYInterval = new System.Windows.Forms.CheckBox();
            this.tblYIntervalValue = new System.Windows.Forms.TableLayoutPanel();
            this.lblYIntervalValueText = new System.Windows.Forms.Label();
            this.tboxYInterval = new System.Windows.Forms.TextBox();
            this.lblYIntervalERROR = new System.Windows.Forms.Label();
            this.tblSettingsYMin = new System.Windows.Forms.TableLayoutPanel();
            this.tblYMinText = new System.Windows.Forms.TableLayoutPanel();
            this.lblYMinText = new System.Windows.Forms.Label();
            this.tblYMinValue = new System.Windows.Forms.TableLayoutPanel();
            this.lblYMinValueText = new System.Windows.Forms.Label();
            this.tboxYMinValue = new System.Windows.Forms.TextBox();
            this.lblYMinERROR = new System.Windows.Forms.Label();
            this.tblImportToImg = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveToImg = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFromData)).BeginInit();
            this.tblChartSettings.SuspendLayout();
            this.tblSettingAverage.SuspendLayout();
            this.tblSettingData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblSettingYInterval.SuspendLayout();
            this.tblYIntervalAuto.SuspendLayout();
            this.tblYIntervalValue.SuspendLayout();
            this.tblSettingsYMin.SuspendLayout();
            this.tblYMinText.SuspendLayout();
            this.tblYMinValue.SuspendLayout();
            this.tblImportToImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.99763F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00237F));
            this.tblMain.Controls.Add(this.chartFromData, 0, 0);
            this.tblMain.Controls.Add(this.tblChartSettings, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(874, 640);
            this.tblMain.TabIndex = 0;
            // 
            // chartFromData
            // 
            this.chartFromData.BackColor = System.Drawing.Color.Transparent;
            this.chartFromData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFromData.Location = new System.Drawing.Point(3, 3);
            this.chartFromData.Name = "chartFromData";
            this.chartFromData.Size = new System.Drawing.Size(701, 614);
            this.chartFromData.TabIndex = 0;
            this.chartFromData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartFromData_MouseMove);
            // 
            // tblChartSettings
            // 
            this.tblChartSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblChartSettings.ColumnCount = 1;
            this.tblChartSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblChartSettings.Controls.Add(this.tblSettingAverage, 0, 1);
            this.tblChartSettings.Controls.Add(this.tblSettingData, 0, 0);
            this.tblChartSettings.Controls.Add(this.tblSettingYInterval, 0, 2);
            this.tblChartSettings.Controls.Add(this.tblSettingsYMin, 0, 3);
            this.tblChartSettings.Controls.Add(this.tblImportToImg, 0, 4);
            this.tblChartSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChartSettings.Location = new System.Drawing.Point(710, 3);
            this.tblChartSettings.MinimumSize = new System.Drawing.Size(50, 100);
            this.tblChartSettings.Name = "tblChartSettings";
            this.tblChartSettings.RowCount = 6;
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChartSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChartSettings.Size = new System.Drawing.Size(161, 614);
            this.tblChartSettings.TabIndex = 1;
            // 
            // tblSettingAverage
            // 
            this.tblSettingAverage.AutoSize = true;
            this.tblSettingAverage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblSettingAverage.ColumnCount = 1;
            this.tblSettingAverage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingAverage.Controls.Add(this.cboxAverage, 0, 0);
            this.tblSettingAverage.Controls.Add(this.cboAverage, 0, 1);
            this.tblSettingAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettingAverage.Location = new System.Drawing.Point(4, 81);
            this.tblSettingAverage.Name = "tblSettingAverage";
            this.tblSettingAverage.RowCount = 2;
            this.tblSettingAverage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettingAverage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingAverage.Size = new System.Drawing.Size(155, 44);
            this.tblSettingAverage.TabIndex = 3;
            // 
            // cboxAverage
            // 
            this.cboxAverage.AutoSize = true;
            this.cboxAverage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxAverage.Checked = true;
            this.cboxAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAverage.Location = new System.Drawing.Point(0, 0);
            this.cboxAverage.Margin = new System.Windows.Forms.Padding(0);
            this.cboxAverage.Name = "cboxAverage";
            this.cboxAverage.Size = new System.Drawing.Size(155, 17);
            this.cboxAverage.TabIndex = 2;
            this.cboxAverage.Text = "Średnia";
            this.cboxAverage.UseVisualStyleBackColor = true;
            this.cboxAverage.CheckedChanged += new System.EventHandler(this.cbox_CheckedChanged);
            // 
            // cboAverage
            // 
            this.cboAverage.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboAverage.FormattingEnabled = true;
            this.cboAverage.Location = new System.Drawing.Point(31, 20);
            this.cboAverage.Name = "cboAverage";
            this.cboAverage.Size = new System.Drawing.Size(121, 21);
            this.cboAverage.TabIndex = 3;
            this.cboAverage.SelectionChangeCommitted += new System.EventHandler(this.cbo_SelectionChangeCommitted);
            // 
            // tblSettingData
            // 
            this.tblSettingData.AutoSize = true;
            this.tblSettingData.ColumnCount = 1;
            this.tblSettingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSettingData.Controls.Add(this.cboxData, 0, 0);
            this.tblSettingData.Controls.Add(this.cboData, 0, 1);
            this.tblSettingData.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblSettingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettingData.Location = new System.Drawing.Point(4, 4);
            this.tblSettingData.Name = "tblSettingData";
            this.tblSettingData.RowCount = 3;
            this.tblSettingData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSettingData.Size = new System.Drawing.Size(155, 70);
            this.tblSettingData.TabIndex = 4;
            this.tblSettingData.Paint += new System.Windows.Forms.PaintEventHandler(this.tblSettingData_Paint);
            // 
            // cboxData
            // 
            this.cboxData.AutoSize = true;
            this.cboxData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxData.Checked = true;
            this.cboxData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxData.Location = new System.Drawing.Point(3, 3);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(149, 17);
            this.cboxData.TabIndex = 0;
            this.cboxData.Text = "Dane";
            this.cboxData.UseVisualStyleBackColor = true;
            this.cboxData.CheckedChanged += new System.EventHandler(this.cbox_CheckedChanged);
            // 
            // cboData
            // 
            this.cboData.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboData.FormattingEnabled = true;
            this.cboData.Location = new System.Drawing.Point(31, 26);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(121, 21);
            this.cboData.TabIndex = 1;
            this.cboData.SelectionChangeCommitted += new System.EventHandler(this.cbo_SelectionChangeCommitted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cboxDataLine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDataLine, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 14);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // cboxDataLine
            // 
            this.cboxDataLine.AutoSize = true;
            this.cboxDataLine.Checked = true;
            this.cboxDataLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxDataLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboxDataLine.Location = new System.Drawing.Point(134, 0);
            this.cboxDataLine.Margin = new System.Windows.Forms.Padding(0);
            this.cboxDataLine.Name = "cboxDataLine";
            this.cboxDataLine.Size = new System.Drawing.Size(15, 14);
            this.cboxDataLine.TabIndex = 0;
            this.cboxDataLine.UseVisualStyleBackColor = true;
            this.cboxDataLine.CheckedChanged += new System.EventHandler(this.cboxDataLine_CheckedChanged);
            // 
            // lblDataLine
            // 
            this.lblDataLine.AutoSize = true;
            this.lblDataLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDataLine.Location = new System.Drawing.Point(3, 0);
            this.lblDataLine.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDataLine.Name = "lblDataLine";
            this.lblDataLine.Size = new System.Drawing.Size(80, 14);
            this.lblDataLine.TabIndex = 1;
            this.lblDataLine.Text = "Połączone linią";
            // 
            // tblSettingYInterval
            // 
            this.tblSettingYInterval.AutoSize = true;
            this.tblSettingYInterval.ColumnCount = 1;
            this.tblSettingYInterval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingYInterval.Controls.Add(this.tblYIntervalAuto, 0, 0);
            this.tblSettingYInterval.Controls.Add(this.tblYIntervalValue, 0, 1);
            this.tblSettingYInterval.Controls.Add(this.lblYIntervalERROR, 0, 2);
            this.tblSettingYInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettingYInterval.Location = new System.Drawing.Point(4, 132);
            this.tblSettingYInterval.Name = "tblSettingYInterval";
            this.tblSettingYInterval.RowCount = 3;
            this.tblSettingYInterval.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingYInterval.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettingYInterval.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettingYInterval.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSettingYInterval.Size = new System.Drawing.Size(155, 71);
            this.tblSettingYInterval.TabIndex = 5;
            // 
            // tblYIntervalAuto
            // 
            this.tblYIntervalAuto.AutoSize = true;
            this.tblYIntervalAuto.ColumnCount = 2;
            this.tblYIntervalAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblYIntervalAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYIntervalAuto.Controls.Add(this.lblYIntervalText1, 0, 0);
            this.tblYIntervalAuto.Controls.Add(this.cboxYInterval, 1, 0);
            this.tblYIntervalAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblYIntervalAuto.Location = new System.Drawing.Point(3, 3);
            this.tblYIntervalAuto.Name = "tblYIntervalAuto";
            this.tblYIntervalAuto.RowCount = 1;
            this.tblYIntervalAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYIntervalAuto.Size = new System.Drawing.Size(149, 20);
            this.tblYIntervalAuto.TabIndex = 0;
            // 
            // lblYIntervalText1
            // 
            this.lblYIntervalText1.AutoSize = true;
            this.lblYIntervalText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYIntervalText1.Location = new System.Drawing.Point(3, 0);
            this.lblYIntervalText1.Name = "lblYIntervalText1";
            this.lblYIntervalText1.Size = new System.Drawing.Size(105, 20);
            this.lblYIntervalText1.TabIndex = 0;
            this.lblYIntervalText1.Text = "Auto przedziałka OY";
            this.lblYIntervalText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxYInterval
            // 
            this.cboxYInterval.AutoSize = true;
            this.cboxYInterval.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxYInterval.Checked = true;
            this.cboxYInterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxYInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxYInterval.Location = new System.Drawing.Point(114, 3);
            this.cboxYInterval.Name = "cboxYInterval";
            this.cboxYInterval.Size = new System.Drawing.Size(32, 14);
            this.cboxYInterval.TabIndex = 1;
            this.cboxYInterval.UseVisualStyleBackColor = true;
            this.cboxYInterval.CheckedChanged += new System.EventHandler(this.cboxYInterval_CheckedChanged);
            // 
            // tblYIntervalValue
            // 
            this.tblYIntervalValue.AutoSize = true;
            this.tblYIntervalValue.ColumnCount = 2;
            this.tblYIntervalValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYIntervalValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblYIntervalValue.Controls.Add(this.lblYIntervalValueText, 0, 0);
            this.tblYIntervalValue.Controls.Add(this.tboxYInterval, 1, 0);
            this.tblYIntervalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblYIntervalValue.Location = new System.Drawing.Point(3, 29);
            this.tblYIntervalValue.Name = "tblYIntervalValue";
            this.tblYIntervalValue.RowCount = 1;
            this.tblYIntervalValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYIntervalValue.Size = new System.Drawing.Size(149, 26);
            this.tblYIntervalValue.TabIndex = 1;
            // 
            // lblYIntervalValueText
            // 
            this.lblYIntervalValueText.AutoSize = true;
            this.lblYIntervalValueText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYIntervalValueText.Location = new System.Drawing.Point(3, 0);
            this.lblYIntervalValueText.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblYIntervalValueText.Name = "lblYIntervalValueText";
            this.lblYIntervalValueText.Size = new System.Drawing.Size(50, 26);
            this.lblYIntervalValueText.TabIndex = 0;
            this.lblYIntervalValueText.Text = "Wartość:";
            this.lblYIntervalValueText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxYInterval
            // 
            this.tboxYInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxYInterval.Enabled = false;
            this.tboxYInterval.Location = new System.Drawing.Point(56, 3);
            this.tboxYInterval.Name = "tboxYInterval";
            this.tboxYInterval.Size = new System.Drawing.Size(90, 20);
            this.tboxYInterval.TabIndex = 2;
            this.tboxYInterval.WordWrap = false;
            this.tboxYInterval.TextChanged += new System.EventHandler(this.tboxYInterval_TextChanged);
            // 
            // lblYIntervalERROR
            // 
            this.lblYIntervalERROR.AutoSize = true;
            this.lblYIntervalERROR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYIntervalERROR.ForeColor = System.Drawing.Color.Red;
            this.lblYIntervalERROR.Location = new System.Drawing.Point(3, 58);
            this.lblYIntervalERROR.Name = "lblYIntervalERROR";
            this.lblYIntervalERROR.Size = new System.Drawing.Size(149, 13);
            this.lblYIntervalERROR.TabIndex = 2;
            this.lblYIntervalERROR.Text = "Błędna wartość";
            this.lblYIntervalERROR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblYIntervalERROR.Visible = false;
            // 
            // tblSettingsYMin
            // 
            this.tblSettingsYMin.AutoSize = true;
            this.tblSettingsYMin.ColumnCount = 1;
            this.tblSettingsYMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingsYMin.Controls.Add(this.tblYMinText, 0, 0);
            this.tblSettingsYMin.Controls.Add(this.tblYMinValue, 0, 1);
            this.tblSettingsYMin.Controls.Add(this.lblYMinERROR, 0, 2);
            this.tblSettingsYMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSettingsYMin.Location = new System.Drawing.Point(4, 210);
            this.tblSettingsYMin.Name = "tblSettingsYMin";
            this.tblSettingsYMin.RowCount = 3;
            this.tblSettingsYMin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSettingsYMin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettingsYMin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSettingsYMin.Size = new System.Drawing.Size(155, 64);
            this.tblSettingsYMin.TabIndex = 6;
            // 
            // tblYMinText
            // 
            this.tblYMinText.AutoSize = true;
            this.tblYMinText.ColumnCount = 1;
            this.tblYMinText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYMinText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblYMinText.Controls.Add(this.lblYMinText, 0, 0);
            this.tblYMinText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblYMinText.Location = new System.Drawing.Point(3, 3);
            this.tblYMinText.Name = "tblYMinText";
            this.tblYMinText.RowCount = 1;
            this.tblYMinText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYMinText.Size = new System.Drawing.Size(149, 13);
            this.tblYMinText.TabIndex = 0;
            // 
            // lblYMinText
            // 
            this.lblYMinText.AutoSize = true;
            this.lblYMinText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYMinText.Location = new System.Drawing.Point(3, 0);
            this.lblYMinText.Name = "lblYMinText";
            this.lblYMinText.Size = new System.Drawing.Size(143, 13);
            this.lblYMinText.TabIndex = 0;
            this.lblYMinText.Text = "Minimalna wartość OY";
            this.lblYMinText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblYMinValue
            // 
            this.tblYMinValue.AutoSize = true;
            this.tblYMinValue.ColumnCount = 2;
            this.tblYMinValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYMinValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblYMinValue.Controls.Add(this.lblYMinValueText, 0, 0);
            this.tblYMinValue.Controls.Add(this.tboxYMinValue, 1, 0);
            this.tblYMinValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblYMinValue.Location = new System.Drawing.Point(3, 22);
            this.tblYMinValue.Name = "tblYMinValue";
            this.tblYMinValue.RowCount = 1;
            this.tblYMinValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblYMinValue.Size = new System.Drawing.Size(149, 26);
            this.tblYMinValue.TabIndex = 1;
            // 
            // lblYMinValueText
            // 
            this.lblYMinValueText.AutoSize = true;
            this.lblYMinValueText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYMinValueText.Location = new System.Drawing.Point(3, 0);
            this.lblYMinValueText.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblYMinValueText.Name = "lblYMinValueText";
            this.lblYMinValueText.Size = new System.Drawing.Size(50, 26);
            this.lblYMinValueText.TabIndex = 0;
            this.lblYMinValueText.Text = "Wartość:";
            this.lblYMinValueText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxYMinValue
            // 
            this.tboxYMinValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxYMinValue.Location = new System.Drawing.Point(56, 3);
            this.tboxYMinValue.Name = "tboxYMinValue";
            this.tboxYMinValue.Size = new System.Drawing.Size(90, 20);
            this.tboxYMinValue.TabIndex = 2;
            this.tboxYMinValue.Text = "1";
            this.tboxYMinValue.WordWrap = false;
            this.tboxYMinValue.TextChanged += new System.EventHandler(this.tboxYMinValue_TextChanged);
            // 
            // lblYMinERROR
            // 
            this.lblYMinERROR.AutoSize = true;
            this.lblYMinERROR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYMinERROR.ForeColor = System.Drawing.Color.Red;
            this.lblYMinERROR.Location = new System.Drawing.Point(3, 51);
            this.lblYMinERROR.Name = "lblYMinERROR";
            this.lblYMinERROR.Size = new System.Drawing.Size(149, 13);
            this.lblYMinERROR.TabIndex = 2;
            this.lblYMinERROR.Text = "Błędna wartość";
            this.lblYMinERROR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblYMinERROR.Visible = false;
            // 
            // tblImportToImg
            // 
            this.tblImportToImg.ColumnCount = 1;
            this.tblImportToImg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblImportToImg.Controls.Add(this.btnSaveToImg, 0, 0);
            this.tblImportToImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblImportToImg.Location = new System.Drawing.Point(4, 281);
            this.tblImportToImg.Name = "tblImportToImg";
            this.tblImportToImg.RowCount = 1;
            this.tblImportToImg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblImportToImg.Size = new System.Drawing.Size(155, 50);
            this.tblImportToImg.TabIndex = 7;
            // 
            // btnSaveToImg
            // 
            this.btnSaveToImg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveToImg.Location = new System.Drawing.Point(3, 3);
            this.btnSaveToImg.Name = "btnSaveToImg";
            this.btnSaveToImg.Size = new System.Drawing.Size(149, 23);
            this.btnSaveToImg.TabIndex = 8;
            this.btnSaveToImg.Text = "Zapisz";
            this.btnSaveToImg.UseVisualStyleBackColor = true;
            this.btnSaveToImg.Click += new System.EventHandler(this.btnSaveToImg_Click);
            // 
            // FormAdvancedChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 640);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdvancedChart";
            this.Text = "Zaawansowany wykres";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFromData)).EndInit();
            this.tblChartSettings.ResumeLayout(false);
            this.tblChartSettings.PerformLayout();
            this.tblSettingAverage.ResumeLayout(false);
            this.tblSettingAverage.PerformLayout();
            this.tblSettingData.ResumeLayout(false);
            this.tblSettingData.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblSettingYInterval.ResumeLayout(false);
            this.tblSettingYInterval.PerformLayout();
            this.tblYIntervalAuto.ResumeLayout(false);
            this.tblYIntervalAuto.PerformLayout();
            this.tblYIntervalValue.ResumeLayout(false);
            this.tblYIntervalValue.PerformLayout();
            this.tblSettingsYMin.ResumeLayout(false);
            this.tblSettingsYMin.PerformLayout();
            this.tblYMinText.ResumeLayout(false);
            this.tblYMinText.PerformLayout();
            this.tblYMinValue.ResumeLayout(false);
            this.tblYMinValue.PerformLayout();
            this.tblImportToImg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFromData;
        private System.Windows.Forms.TableLayoutPanel tblChartSettings;
        private System.Windows.Forms.CheckBox cboxAverage;
        private System.Windows.Forms.TableLayoutPanel tblSettingAverage;
        private System.Windows.Forms.ComboBox cboAverage;
        private System.Windows.Forms.TableLayoutPanel tblSettingData;
        private System.Windows.Forms.CheckBox cboxData;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.TableLayoutPanel tblSettingYInterval;
        private System.Windows.Forms.TableLayoutPanel tblYIntervalValue;
        private System.Windows.Forms.Label lblYIntervalValueText;
        private System.Windows.Forms.TableLayoutPanel tblYIntervalAuto;
        private System.Windows.Forms.Label lblYIntervalText1;
        private System.Windows.Forms.CheckBox cboxYInterval;
        private System.Windows.Forms.TextBox tboxYInterval;
        private System.Windows.Forms.Label lblYIntervalERROR;
        private System.Windows.Forms.TableLayoutPanel tblSettingsYMin;
        private System.Windows.Forms.TableLayoutPanel tblYMinText;
        private System.Windows.Forms.Label lblYMinText;
        private System.Windows.Forms.TableLayoutPanel tblYMinValue;
        private System.Windows.Forms.Label lblYMinValueText;
        private System.Windows.Forms.TextBox tboxYMinValue;
        private System.Windows.Forms.Label lblYMinERROR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cboxDataLine;
        private System.Windows.Forms.Label lblDataLine;
        private System.Windows.Forms.TableLayoutPanel tblImportToImg;
        private System.Windows.Forms.Button btnSaveToImg;
    }
}