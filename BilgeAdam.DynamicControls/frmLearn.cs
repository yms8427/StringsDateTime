using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.DynamicControls
{
    public partial class frmLearn : Form
    {
        public frmLearn()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var b = new Button
            {
                Text = "Custom Button",
                Height = 30,
                Width = 125,
                Tag = "grp",
                Top = 100,
                Left = 200,
            };
            b.Click += CustomClick1;
            b.Click += CustomClick2;
            Controls.Add(b);
        }

        private void CustomClick1(object sender, EventArgs e)
        {
            (sender as Button).Click -= CustomClick1;
            MessageBox.Show("1");
        }

        private void CustomClick2(object sender, EventArgs e)
        {
            (sender as Button).Click -= CustomClick2;
            MessageBox.Show("2");
        }
    }
}
