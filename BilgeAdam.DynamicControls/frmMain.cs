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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            Width = 640;
            for(var i = 0; i < 8; i++)
            {
                var btn = new Button
                {
                    Width = 50,
                    Height = 50,
                    Top = 100,
                    Left = 25 + (i * 75),
                    Text = rnd.Next(1, 100).ToString(),
                    Tag = "btc"
                };
                btn.Click += NumberSelection;
                Controls.Add(btn);
            }
        }

        private void NumberSelection(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            var number = int.Parse(btn.Text);
            var isEven = number % 2 == 0;
            if (isEven)
            {
                btn.Enabled = false;
            }
            else
            {
                btn.Dispose();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            for(var i = 0; i < Controls.Count; i++)
            {
                var ctrl = Controls[i];
                if(ctrl.Tag == null)
                {
                    continue;
                }
                if (ctrl.Tag.ToString() == "btc")
                {
                    ctrl.Click -= NumberSelection;
                    ctrl.Dispose();
                    i--;
                }
            }
            frmMain_Load(null, null);
            //Controls.Clear();
            //Controls.Add(btnRefresh);
            //frmMain_Load(null, null);
        }
    }
}
