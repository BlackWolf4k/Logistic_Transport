using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistic_Transport
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
            main();
        }

        private void main()
        {
            string[] row = { "Metodo Nord - Ovest", "" };
            ListViewItem item = new ListViewItem( row );
            output_lv.Items.Add( item );
        }
    }
}
