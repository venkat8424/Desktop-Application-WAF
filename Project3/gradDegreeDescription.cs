using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class gradDegreeDescription : Form
    {
        public gradDegreeDescription(Degrees degrees, string name)
        {
            InitializeComponent();
            Graduate result = degrees.graduate.Find(x => x.degreeName.Equals(name));
            lbl_gradDegreeName.Text = result.title;
            string concentrationList = "";
            for (int i = 0; i < result.concentrations.Count - 1; i++)
            {
                concentrationList += result.concentrations[i] + Environment.NewLine;
            }
            concentrationList += result.concentrations[result.concentrations.Count - 1];
            lbl_gradConcList.Text = concentrationList;
        }
    }
}
