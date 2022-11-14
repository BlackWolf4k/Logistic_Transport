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
    public partial class Informations : Form
    {
        // Structure to save and share informations about the creation of the form
        public static class table_informations
        {
            public static Int32 rows = 2;
            public static Int32 columns = 2;
            public static bool random_fill;
        };

        public Informations()
        {
            InitializeComponent();
        }

        private void create_table( object sender, EventArgs e )
        {
            // Set the values to store
            table_informations.rows = Int32.Parse( rows_nud.Value.ToString() );
            table_informations.columns = Int32.Parse( columns_nud.Value.ToString() );
            table_informations.random_fill = random_fill_cb.Checked;

            // Check that the inserted infromations are correct
            // Close this window
            this.Close();
        }
    }
}
