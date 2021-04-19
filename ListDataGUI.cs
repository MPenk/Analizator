using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizator
{
    public partial class ListDataGUI : UserControl
    {
        public ListDataGUI()
        {
            InitializeComponent();
        }
        public void Setlbl(string text)
        {
            lblData.Text = text;
        }
        public void AddLbxData(double data)
        {
            lbxData.Items.Add(data);
        }
    }
}
