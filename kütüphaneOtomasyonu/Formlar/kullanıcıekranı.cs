using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonu.Formlar
{
    public partial class kullanıcıekranı : Form
    {
        public kullanıcıekranı()
        {
            InitializeComponent();
        }

        private void txtadisoyadi_TextChanged(object sender, EventArgs e)
        {
            txtadisoyadi.Enabled= false;
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {
            txttel.Enabled= false;
        }

        private void txtadres_TextChanged(object sender, EventArgs e)
        {
            txtadres.Enabled= false;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            txtemail.Enabled= false;
        }
    }
}
