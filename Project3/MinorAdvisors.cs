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
    public partial class MinorAdvisors : Form
    {
        public MinorAdvisors(IstMinorAdvising minorAdv)
        {
            InitializeComponent();

            lbl_title.Text = minorAdv.title;

            lbl_prof1.Text = minorAdv.minorAdvisorInformation[0].advisor;
            lbl_email1.Text = minorAdv.minorAdvisorInformation[0].email;
            lbl_dept1.Text = minorAdv.minorAdvisorInformation[0].title;

            lbl_prof2.Text = minorAdv.minorAdvisorInformation[1].advisor;
            lbl_email2.Text = minorAdv.minorAdvisorInformation[1].email;
            lbl_dept2.Text =minorAdv.minorAdvisorInformation[1].title;

            lbl_prof3.Text = minorAdv.minorAdvisorInformation[2].advisor;
            lbl_email3.Text = minorAdv.minorAdvisorInformation[2].email;
            lbl_dept3.Text = minorAdv.minorAdvisorInformation[2].title;

            lbl_prof4.Text = minorAdv.minorAdvisorInformation[3].advisor;
            lbl_email4.Text = minorAdv.minorAdvisorInformation[3].email;
            lbl_dept4.Text = minorAdv.minorAdvisorInformation[3].title;

            lbl_prof5.Text= minorAdv.minorAdvisorInformation[4].advisor;
            lbl_email5.Text = minorAdv.minorAdvisorInformation[4].email;
            lbl_dept5.Text = minorAdv.minorAdvisorInformation[4].title;

            lbl_prof6.Text = minorAdv.minorAdvisorInformation[5].advisor;
            lbl_email6.Text = minorAdv.minorAdvisorInformation[5].email;
            lbl_dept6.Text = minorAdv.minorAdvisorInformation[5].title;

            lbl_prof7.Text = minorAdv.minorAdvisorInformation[6].advisor;
            lbl_email7.Text = minorAdv.minorAdvisorInformation[6].email;
            lbl_dept7.Text = minorAdv.minorAdvisorInformation[6].title;

            lbl_prof8.Text = minorAdv.minorAdvisorInformation[7].advisor;
            lbl_email8.Text = minorAdv.minorAdvisorInformation[7].email;
            lbl_dept8.Text = minorAdv.minorAdvisorInformation[7].title;
        }
    }
}
