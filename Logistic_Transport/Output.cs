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
        DataGridView data_dgv;
        DataGridView backup_dgv;
        public Output( ref DataGridView data_table_dgv )
        {
            InitializeComponent();
            this.data_dgv = data_table_dgv;
            backup_dgv = data_dgv;
        }

        private void initialize_table()
        {
            output_lv.Clear();
            output_lv.View = View.Details;
            output_lv.Columns.Add( "Output", 391 );
            /*output_lv.Columns.Add( "Producer", 100 );
            output_lv.Columns.Add( "Consumer", 100 );
            output_lv.Columns.Add( "Total", 191 );*/
        }

        private void run_nord_west( object sender, EventArgs e )
        {
            initialize_table();
            output_lv.Items.Add( new ListViewItem( "Nord - West Method" ) );

            // Final cost
            Int32 cost = 0;

            // Run the nord west method
            while ( Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) > 0 )
            {
                if ( Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() ) > Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() ) )
                {
                    data_dgv[ Informations.table_informations.columns, 0 ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() ) - Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    // Remove the column
                    data_dgv.Columns.RemoveAt( 0 );

                    // Decrease maximum column
                    Informations.table_informations.columns -= 1;
                }
                else if ( Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() ) < Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() ) )
                {
                    data_dgv[ 0, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() );

                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() );

                    // Remove the row
                    data_dgv.Rows.RemoveAt( 0 );

                    // Decrease maximum row
                    Informations.table_informations.rows -= 1;
                }
                else
                {
                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    // Remove both the row and the column
                    data_dgv.Columns.RemoveAt( 0 );
                    data_dgv.Rows.RemoveAt( 0 );

                    // Decrease maximum row and columns
                    Informations.table_informations.columns -= 1;
                    Informations.table_informations.rows -= 1;
                }

                // Update the cost
                cost += Int32.Parse( data_dgv[ 0, 0 ].Value.ToString() ) * Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );
            }
        }

        private void run_minimum_prices( object sender, EventArgs e )
        {
            initialize_table();
            output_lv.Items.Add( new ListViewItem( "Minimum Costs Method" ) );
        }
    }
}
