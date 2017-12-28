using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class LabInfoForm : Form
    {
        public LabInfoForm(TutorsAndLabInformation labInfo)
        {
            InitializeComponent();
            lbl_title.Text = labInfo.title;
            lbl_desc.Text = labInfo.description;
            link_labSchedule.Tag = labInfo.tutoringLabHoursLink;
        }

        private void link_labSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link_labSchedule.LinkVisited = true;
            Process.Start(link_labSchedule.Tag.ToString());
        }
    }
}
