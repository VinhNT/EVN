using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVN
{
    public partial class frmAppSetting : Form
    {        
        public frmAppSetting()
        {
            InitializeComponent();
            
        }
        public void LoadSetting()
        {
        }
        public void SaveSetting()
        {
        }

        private void tbConstrast_Scroll(object sender, EventArgs e)
        {
            tbValueTooltip.Show(tbConstrast.Value.ToString(), tbConstrast);
        }

        private void frmAppSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
