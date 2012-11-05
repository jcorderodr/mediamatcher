using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaMatcher.Forms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            this.Text = Program.AppTitle + this.Text;
        }
    }
}
