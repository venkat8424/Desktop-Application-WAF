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
    public partial class AdvisingForm : Form
    {
        IstMinorAdvising minorAdv;
        public AdvisingForm(StudentServices advising)
        {
            InitializeComponent();
            lbl_acadAdvisorsTitle.Text = advising.academicAdvisors.title;
            lbl_acadAdvisorsDesc.Text = advising.academicAdvisors.description;
            lbl_advisor1.Text = advising.professonalAdvisors.advisorInformation[0].name;
            lbl_dept1.Text = advising.professonalAdvisors.advisorInformation[0].department;
            lbl_email1.Text = advising.professonalAdvisors.advisorInformation[0].email;
            lbl_advisor2.Text = advising.professonalAdvisors.advisorInformation[1].name;
            lbl_dept2.Text = advising.professonalAdvisors.advisorInformation[1].department;
            lbl_email2.Text = advising.professonalAdvisors.advisorInformation[1].email;
            lbl_advisor3.Text = advising.professonalAdvisors.advisorInformation[2].name;
            lbl_dept3.Text = advising.professonalAdvisors.advisorInformation[2].department;
            lbl_email3.Text = advising.professonalAdvisors.advisorInformation[2].email;
            lbl_facAdvisorsTitle.Text = advising.facultyAdvisors.title;
            lbl_facAdvDesc.Text = advising.facultyAdvisors.description;
            faqLink.Tag = advising.academicAdvisors.faq.contentHref;

            minorAdv = advising.istMinorAdvising;

        }

        private void lbl_minorAdv_Click(object sender, EventArgs e)
        {
            MinorAdvisors madv = new MinorAdvisors(minorAdv);
            madv.ShowDialog();
        }

        private void faqLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            faqLink.LinkVisited = true;
            Process.Start(faqLink.Tag.ToString());
        }
    }
}
