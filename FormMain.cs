using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;


namespace Analizator
{
    public partial class FormMain : Form
    {
       // Data data;
        SpecialChart chart;
        List<Data> listData = new List<Data>();
        List<TabPage> listPages = new List<TabPage>();
        List<ListDataGUI> listDataGUI = new List<ListDataGUI>();
        int selectedData = -1;
        int allData = -1;

        public FormMain()
        {
            
            InitializeComponent();

           
            this.MaximumSize = new System.Drawing.Size(205, 120);
            this.MinimumSize = new System.Drawing.Size(205, 120);

        }

        /// <summary>
        /// Loads all the necessary elements for new data
        /// </summary>
        private void OperationsOnNewData() {
            
            //Przygotowanie formularza
            
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.MinimumSize = new System.Drawing.Size(800, 440);
            
            //wypisywanie wyników na ekranie
            foreach (var item in listData.ElementAt(selectedData).GetFileContent())
            {
                this.listDataGUI.ElementAt(selectedData).AddLbxData(item);
            }

            //Aktualizacja wyświetlanych informacji
            RefreshResults();

            //Wyświetlenie okna
            tblUp.Visible = true;
            tabControl.Visible = true;
            chartData.Visible = true;
        }

        /// <summary>
        /// Refreshes all exist informations (without lbxData)
        /// </summary>
        private void RefreshResults() {
            Data data = listData.ElementAt(selectedData);
            //Aktualizowanie wyświtlanych informacji
            lblDataAverage.Text = data.Average().ToString();
            lblDataVariance.Text = data.Variance().ToString();
            lblDataMin.Text = data.Min().ToString();
            lblDataMax.Text = data.Max().ToString();
            listPages.ElementAt(selectedData).Text = data.GetFileName(); 
            this.chart = new SpecialChart(chartData, listData.ElementAt(selectedData));

            //Odpowiednie wypisanie ilości wyników
            if (data.GetDataLenght() == 1) this.listDataGUI.ElementAt(selectedData).Setlbl(  data.GetDataLenght().ToString() + " wynik");
            if (data.GetDataLenght() < 5 && data.GetDataLenght() > 1) this.listDataGUI.ElementAt(selectedData).Setlbl(data.GetDataLenght().ToString() + " wyniki");
            if (data.GetDataLenght() > 4) this.listDataGUI.ElementAt(selectedData).Setlbl(data.GetDataLenght().ToString() + " wyników");
            this.chart.SetNewDataToChart(data);
        }
        private Data GetData() {
            return listData.ElementAt(selectedData);
        }


        /// <summary>
        /// Open file
        /// </summary>
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            
            Data data = new Data();
            
            if (data.Exist()==true)
            {
                allData++;
                selectedData=allData;
                this.listData.Add(data);

                TabPage tabPage = new TabPage();

                tabControl.Controls.Add(tabPage);
                listPages.Add(tabPage);
                ListDataGUI guiListData = new ListDataGUI();
                this.listDataGUI.Add(guiListData);
                tabPage.Controls.Add(guiListData);

                tabPage.Location = new System.Drawing.Point(4, 22);
                tabPage.Padding = new System.Windows.Forms.Padding(3);
                tabPage.Size = new System.Drawing.Size(106, 278);
                tabPage.TabIndex = 0;   
                tabPage.UseVisualStyleBackColor = true;

                guiListData.Dock = System.Windows.Forms.DockStyle.Fill;
                guiListData.Location = new System.Drawing.Point(3, 3);
                guiListData.Size = new System.Drawing.Size(100, 272);
                guiListData.TabIndex = 0;

                tabControl.SelectedIndex = selectedData;
                OperationsOnNewData();
            }
            else if(data.Exist() == false) { 
                if (MessageBox.Show("Brak danych do odczytu", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry) btnReadFile_Click(sender, e);
            }
        }



        private void btnExport_Click(object sender, EventArgs e)
        {
            if (listData.ElementAt(selectedData).SaveFile(cboxAverage.Checked, cboxVariance.Checked, cboxMin.Checked, cboxMax.Checked)) 
            {
                 MessageBox.Show("Zapis pliku zakończony sukcesem", "Zapisano plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenAdvancedChart_Click(object sender, EventArgs e)
        {
            FormAdvancedChart formAdvancedChart = new FormAdvancedChart(listData.ElementAt(selectedData));
            formAdvancedChart.ShowDialog();
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedData = ((TabControl)sender).SelectedIndex;
            this.RefreshResults();
        }
    }
}
