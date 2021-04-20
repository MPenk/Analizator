using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Analizator
{

    public partial class FormAdvancedChart : Form
    {
        Data data;
        SpecialChart chart;
        ToolTip toolTip = new ToolTip();
        List<SettingsSeries> listSettings = new List<SettingsSeries>();
        Point prevMousePoint;

        public FormAdvancedChart(Data data)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(900, 350);
            CreateListSettings();
            CreateColorsList();

            this.data = data;
            this.chart = new SpecialChart(chartFromData, this.data, true);

            // Tworzenie list rozwijanych 
            foreach (var item in listSettings)
            {
                item.cbo.ValueMember = "color";
                item.cbo.DisplayMember = "PL";
                item.cbo.DataSource = item.ColorList;
                item.cbo.SelectedValue = item.color;
            }

            // Ustawienie wartości minimalnej w textbox
            tboxYMinValue.Text = chart.GetYMin().ToString();
            lblYMinERROR.Visible = false;
        }

        /// <summary>
        /// Change color serie after change in combobox.
        /// </summary>
        private void cbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Colors obj = ((ComboBox)sender).SelectedItem as Colors;
            if (obj != null)
            {
                if (((ComboBox)sender).Name == "cboData") chart.ChangeColor("dataPoint", obj.color);
                chart.ChangeColor(((ComboBox)sender).Name.Remove(0, 3).ToLower(), obj.color);
            }
        }

        /// <summary>
        /// Change visibility after change in checkbox.
        /// </summary>
        private void cbox_CheckedChanged(object sender, EventArgs e)
        {
            turnOffSeries((CheckBox)sender);
        }
        /// <summary>
        /// Create list of SettingsSeries
        /// </summary>
        private void CreateListSettings()
        {
            listSettings.Add(new SettingsSeries { name = SettingsSeries.settingName.data, cbo = cboData, cbox = cboxData, cbox2 = cboxDataLine, color = Color.Red, ColorList = CreateColorsList() });
            listSettings.Add(new SettingsSeries { name = SettingsSeries.settingName.average, cbo = cboAverage, cbox = cboxAverage, color = Color.Green, ColorList = CreateColorsList() });
        }


        /// <summary>
        /// Create list of Colors
        /// </summary>
        private List<Colors> CreateColorsList()
        {
            List<Colors> list = new List<Colors>();
            list.Add(new Colors { id = 0, PL = "Zielony", color = Color.Green });
            list.Add(new Colors { id = 1, PL = "Czerwony", color = Color.Red });
            list.Add(new Colors { id = 2, PL = "Szary", color = Color.Gray });
            list.Add(new Colors { id = 3, PL = "Pomarańczowy", color = Color.DarkOrange });
            list.Add(new Colors { id = 4, PL = "Ciemny szaro-niebieski", color = Color.DarkSlateBlue });
            list.Add(new Colors { PL = "Fioletowy", color = Color.DarkMagenta });
            list.Add(new Colors { PL = "Morski zielony", color = Color.DarkSeaGreen });
            list.Add(new Colors { PL = "Jasny niebieski", color = Color.DarkTurquoise });
            return list;
        }


        /// <summary>
        /// Change visibility 
        /// </summary>
        private void turnOffSeries(CheckBox obj)
        {

            SettingsSeries sender = listSettings.Find(cbox => cbox.cbox == obj);
            if (sender.cbox2 != null)
            {
                sender.cbox2.Enabled = (sender.cbox.Checked == true) ? true : false;
                sender.cbox2.Checked = true;
            }
            if (sender.name.ToString() == "data")
                chart.Visible(sender.name.ToString() + "Point", sender.cbox.Checked);
            chart.Visible(sender.name.ToString(), sender.cbox.Checked);
            sender.cbo.Enabled = (sender.cbox.Checked == true) ? true : false;

        }

        private void tboxYInterval_TextChanged(object sender, EventArgs e)
        {
            SetYInterval(((TextBox)sender).Text);
        }

        private void SetYInterval(string value)
        {
            double y = 0;
            if (double.TryParse(value, out y))
            {
                lblYIntervalERROR.Visible = false;
                chart.SetYInterval(y);
            }
            else if (value != "") lblYIntervalERROR.Visible = true;
        }

        private void cboxYInterval_CheckedChanged(object sender, EventArgs e)
        {
            tboxYInterval.Enabled = (((CheckBox)sender).Checked == true) ? false : true;
            if (((CheckBox)sender).Checked == true)
            {
                tboxYInterval.Enabled = false;
                chart.SetYInterval(0);
            }
            else
            {
                tboxYInterval.Enabled = true;
                SetYInterval(tboxYInterval.Text);
            }
        }

        private void tboxYMinValue_TextChanged(object sender, EventArgs e)
        {
            double y = 0;
            if (double.TryParse(((TextBox)sender).Text, out y))
            {
                if (chart.GetYMax() > y)
                {
                    lblYMinERROR.Visible = false;
                    chart.SetYMin(y);
                }
                else
                {
                    lblYMinERROR.Visible = true;
                    lblYMinERROR.Text = "Za duża wartość";
                }
            }
            else if (((TextBox)sender).Text != "")
            {
                lblYMinERROR.Visible = true;
                lblYMinERROR.Text = "Błędna wartość";
            }
        }

        private void chartFromData_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (Math.Abs(pos.X - this.prevMousePoint.X) < 6 && Math.Abs(pos.Y - this.prevMousePoint.Y) < 6) return;

            toolTip.RemoveAll();
            var results = chart.GetHitTest(pos.X, pos.Y);
            this.prevMousePoint = pos;
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        double X = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        double Y = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        if (Math.Abs(pos.X - X) < 7 && Math.Abs(pos.Y - Y) < 7)
                        {
                            toolTip.Show("Y=" + prop.YValues[0], chart.GetChart(), pos.X + 5, pos.Y - 17);
                        }
                    }
                }
            }
        }

        private void tblSettingData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboxDataLine_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox obj = (CheckBox)sender;
            SettingsSeries setting = listSettings.Find(cbox2 => cbox2.cbox2 == obj);
            chart.Visible(setting.name.ToString(), setting.cbox2.Checked);
            chart.IsVisibleInLegend(setting.name.ToString() + "Point", !setting.cbox2.Checked);
        }

        private void btnSaveToImg_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                try
                {
                    saveFileDialog.FileName = System.IO.Path.GetFileNameWithoutExtension(data.GetFilePath())+".png";
                    saveFileDialog.Filter = "Pliki txt (*.png) | *.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                    {


                        chart.SaveToImg(saveFileDialog.FileName);

                        // Wczytywanie pliku do Stream

                    }
                    else
                    {
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd zapisu pliku\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }



    class SettingsSeries
    {
        public enum settingName
        {
            data,
            average
        }
        public settingName name { get; set; }
        public CheckBox cbox { get; set; }
        public CheckBox cbox2 { get; set; }
        public ComboBox cbo { get; set; }
        public Color color { get; set; }
        public List<Colors> ColorList { get; set; }
    }
    class Colors
    {
        public int id { get; set; }
        public string PL { get; set; }
        public Color color { get; set; }

    }


}
