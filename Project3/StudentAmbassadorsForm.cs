using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class StudentAmbassadorsForm : Form
    {
        public StudentAmbassadorsForm(StudentAmbassadors stuAmb)
        {
            InitializeComponent();
            lbl_title.Text = stuAmb.title;

            lbl_subTitle1.Text = stuAmb.subSectionContent[0].title;
            lbl_subDesc1.Text = stuAmb.subSectionContent[0].description;

            lbl_subTitle2.Text = stuAmb.subSectionContent[1].title;
            lbl_subDesc2.Text = stuAmb.subSectionContent[1].description;

            lbl_subTitle3.Text = stuAmb.subSectionContent[2].title;
            string[] lines = Regex.Split(stuAmb.subSectionContent[2].description, "\\. ");
            string content = "";
            for(int i=0; i<lines.Length-1; i++)
            {
                content += lines[i] + Environment.NewLine;
            }
            content += lines[lines.Length - 1];
            lbl_subDesc3.Text = content;

            lbl_subTitle4.Text = stuAmb.subSectionContent[3].title;
            lines = Regex.Split(stuAmb.subSectionContent[3].description, "\\. ");
            content = "";
            for (int i = 0; i < lines.Length - 1; i++)
            {
                content += lines[i] + Environment.NewLine;
            }
            content += lines[lines.Length - 1];
            lbl_subDesc4.Text = content;

            lbl_subTitle5.Text = stuAmb.subSectionContent[4].title;
            lbl_subDesc5.Text = stuAmb.subSectionContent[4].description;

            lbl_subTitle6.Text = stuAmb.subSectionContent[5].title;
            lbl_subDesc6.Text = stuAmb.subSectionContent[5].description;

            lbl_application.Text = stuAmb.subSectionContent[6].description;
            applicationFormLink.Tag = stuAmb.applicationFormLink;

            lbl_note.Text = stuAmb.note;
        }

        private void applicationFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            applicationFormLink.LinkVisited = true;
            Process.Start(applicationFormLink.Tag.ToString());
        }
    }
}
