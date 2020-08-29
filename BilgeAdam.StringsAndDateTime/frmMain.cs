using BilgeAdam.StringsAndDateTime.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.StringsAndDateTime
{
    public partial class frmMain : Form
    {
        private DateTimeHelper dtHelper;
        private StringHelper stHelper;
        public frmMain()
        {
            InitializeComponent();
            dtHelper = new DateTimeHelper();
            stHelper = new StringHelper();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDateTime();
            txtInputString.Text = "I love it when you call me senorita, I wish I could pretend I didn't need you";
            txtUpper.Text = stHelper.GetUpperCase(txtInputString.Text);
            txtLower.Text = stHelper.GetLowerCase(txtInputString.Text);
            txtReplace.Text = stHelper.ReplaceWord(txtInputString.Text, "I ", "you ");
            txtLength.Text = stHelper.GetLength(txtInputString.Text);
            txtIndex.Text = stHelper.GetIndex(txtInputString.Text, 'a');
            txtWordCount.Text = stHelper.GetWordCount(txtInputString.Text);
            txtCustomMath.Text = stHelper.GetCustomCalculation(txtCustomMath.Text);
        }

        private void SetDateTime()
        {
            txtDateStart.Text = dtHelper.GetNow();
            txtYesterday.Text = dtHelper.GetYesterday();
            txtTomorrow.Text = dtHelper.GetTomorrow();
            txtThreeMonthsLater.Text = dtHelper.GetThreeMonthsLater();
            txtLastMonth.Text = dtHelper.GetOneMonthBefore();
            txtTwoYearsLater.Text = dtHelper.GetTwoYearsLater();
            txtLastYear.Text = dtHelper.GetLastYear();
            txtUtc.Text = dtHelper.GetUtc();
            txtDayOfWeek.Text = dtHelper.GetDayOfWeek();
            txtTotalDayLife.Text = dtHelper.GetDaysDifference(new DateTime(1988, 2, 8)).ToString();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            SetDateTime();
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
            btnLive.Text = tmr.Enabled ? "Suspend" : "Live";
        }
    }
}
