using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyVersionConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2000, 1, 1)                    // baseline is 01/01/2000
                .AddDays(Convert.ToDouble(txtBuild.Text))               // build is number of days after baseline
                .AddSeconds(Convert.ToDouble(txtRevision.Text) * 2);    // revision is half the number of seconds into the day

            txtResult.Text = $"{date:dddd, dd.MM.yyyy} - {date:HH:mm:ss}";
        }
    }
}
