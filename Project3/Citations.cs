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
    public partial class Citations : Form
    {
        public Citations(List<ByInterestArea> byInterestArea, string name)
        {
            InitializeComponent();
            ByInterestArea result = byInterestArea.Find(x => x.areaName.Equals(name));
            lbl_citationsTitle.Text = "Research by Domain Area: " + result.areaName;
            List<string> citationList = result.citations;
            for(int i=0; i<citationList.Count; i++)
            {
                citationList[i] = "-" + citationList[i];
            }
            rtb_citations.Lines = citationList.ToArray();
        }

        public Citations(List<ByFaculty> byFaculty, string name)
        {
            InitializeComponent();
            ByFaculty result = byFaculty.Find(x => x.facultyName.Equals(name));
            lbl_citationsTitle.Text = result.facultyName;
            List<string> citationList = result.citations;
            for (int i = 0; i < citationList.Count; i++)
            {
                citationList[i] = "-" + citationList[i];
            }
            rtb_citations.Lines = citationList.ToArray();
        }
    }
}
