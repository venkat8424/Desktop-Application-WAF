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
    public partial class ResourceForms : Form
    {
        public ResourceForms(Forms forms)
        {
            InitializeComponent();
            linkLabel1.Text = forms.graduateForms[0].formName;
            linkLabel1.Tag = forms.graduateForms[0].href;

            linkLabel2.Text = forms.graduateForms[1].formName;
            linkLabel2.Tag = forms.graduateForms[1].href;

            linkLabel3.Text = forms.graduateForms[2].formName;
            linkLabel3.Tag = forms.graduateForms[2].href;

            linkLabel4.Text = forms.graduateForms[3].formName;
            linkLabel4.Tag = forms.graduateForms[3].href;

            linkLabel5.Text = forms.graduateForms[5].formName;
            linkLabel5.Tag = forms.graduateForms[5].href;

            linkLabel6.Text = forms.graduateForms[6].formName;
            linkLabel6.Tag = forms.graduateForms[6].href;

            linkLabel7.Text = forms.undergraduateForms[0].formName;
            linkLabel7.Tag = forms.undergraduateForms[0].href;

        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            ll.LinkVisited = true;
            Process.Start("www.ist.rit.edu/" + ll.Tag.ToString());
        }
    }
}
