using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class CoopForm : Form
    {
        public CoopForm(CoopEnrollment coop)
        {
            InitializeComponent();

            lbl_title.Text = coop.title;

            lbl_subTitle1.Text = coop.enrollmentInformationContent[0].title;
            string[] lines = Regex.Split(coop.enrollmentInformationContent[0].description, "\\. ");
            string content = "";
            for(int i=0; i<lines.Length-1; i++)
            {
                content += lines[i] + Environment.NewLine;
            }
            content += lines[lines.Length - 1];
            lbl_subDesc1.Text = content;

            lbl_subTitle2.Text = coop.enrollmentInformationContent[1].title;
            lbl_subDesc2.Text = coop.enrollmentInformationContent[1].description;

            lbl_subTitle3.Text = coop.enrollmentInformationContent[2].title;
            lbl_subDesc3.Text = coop.enrollmentInformationContent[2].description;

            lbl_subTitle4.Text = coop.enrollmentInformationContent[3].title;
            lbl_subDesc4.Text = coop.enrollmentInformationContent[3].description;
        }
    }
}
