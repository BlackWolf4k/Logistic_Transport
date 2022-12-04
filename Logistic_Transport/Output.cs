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

        private void reload_table()
        {}

        private void disable_changings()
        {
            // Disable the possibility to make changes
            run_nord_west_b.Enabled = false;
            run_minimum_prices_b.Enabled = false;
            step_by_step_cb.Enabled = false;
        }

        private void enable_changings()
        {
            // Enable the possibility to make changes
            run_nord_west_b.Enabled = true;
            run_minimum_prices_b.Enabled = true;
            step_by_step_cb.Enabled = true;
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
                // Store the cost of the cell
                Int32 cell_cost = Int32.Parse( data_dgv[ 0, 0 ].Value.ToString() );
                Int32 production = 0;

                if ( Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() ) > Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() ) )
                {
                    data_dgv[ Informations.table_informations.columns, 0 ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() ) - Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    production = Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

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

                    production = Int32.Parse( data_dgv[ Informations.table_informations.columns, 0 ].Value.ToString() );

                    // Remove the row
                    data_dgv.Rows.RemoveAt( 0 );

                    // Decrease maximum row
                    Informations.table_informations.rows -= 1;
                }
                else
                {
                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    production = Int32.Parse( data_dgv[ 0, Informations.table_informations.rows ].Value.ToString() );

                    // Remove both the row and the column
                    data_dgv.Columns.RemoveAt( 0 );
                    data_dgv.Rows.RemoveAt( 0 );

                    // Decrease maximum row and columns
                    Informations.table_informations.columns -= 1;
                    Informations.table_informations.rows -= 1;
                }

                // Update the cost
                cost += cell_cost * production;

                if ( step_by_step_cb.Checked )
                {
                    Task task = Task.Delay(1000);
                    task.Wait();
                }
            }
            output_lv.Items.Add( new ListViewItem( cost.ToString() ) );

            reload_table();
        }

        private void run_minimum_prices( object sender, EventArgs e )
        {
            disable_changings();

            initialize_table();
            output_lv.Items.Add( new ListViewItem( "Minimum Costs Method" ) );

            // Final cost
            Int32 cost = 0;

            Int32 min_row = 0;
            Int32 min_column = 0;

            while ( Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) > 0 )
            {
                // Get the minimum
                get_minimum( ref min_row, ref min_column );

                Int32 cell_cost = Int32.Parse( data_dgv[ min_column, min_row ].Value.ToString() );
                Int32 production = 0;

                if ( Int32.Parse( data_dgv[ Informations.table_informations.columns, min_row ].Value.ToString() ) > Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() ) )
                {
                    data_dgv[ Informations.table_informations.columns, min_row ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, min_row ].Value.ToString() ) - Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() );

                    production = Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() );

                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() );

                    // Remove the column
                    data_dgv.Columns.RemoveAt( min_column );

                    // Decrease maximum column
                    Informations.table_informations.columns -= 1;
                }
                else if ( Int32.Parse( data_dgv[ Informations.table_informations.columns, min_row ].Value.ToString() ) < Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() ) )
                {
                    data_dgv[ min_column, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ Informations.table_informations.columns, min_row ].Value.ToString() );

                    production = Int32.Parse( data_dgv[ Informations.table_informations.columns, min_row ].Value.ToString() );

                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ Informations.table_informations.columns, min_row ].Value.ToString() );

                    // Remove the row
                    data_dgv.Rows.RemoveAt( min_row );

                    // Decrease maximum row
                    Informations.table_informations.rows -= 1;
                }
                else
                {
                    // Change total
                    data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = Int32.Parse( data_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value.ToString() ) - Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() );

                    production = Int32.Parse( data_dgv[ min_column, Informations.table_informations.rows ].Value.ToString() );

                    // Remove both the row and the column
                    data_dgv.Columns.RemoveAt( min_column );
                    data_dgv.Rows.RemoveAt( min_row );

                    // Decrease maximum row and columns
                    Informations.table_informations.columns -= 1;
                    Informations.table_informations.rows -= 1;
                }

                MessageBox.Show("");

                // Update the cost
                cost += cell_cost * production;
            }
            output_lv.Items.Add( new ListViewItem( cost.ToString() ) );

            reload_table();
        }

        private void get_minimum( ref Int32 min_row, ref Int32 min_column )
        {
            Int32 min = Int32.Parse( data_dgv[ 0, 0 ].Value.ToString() );
            min_row = 0;
            min_column = 0;

            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
                for ( Int32 j = 0; j < Informations.table_informations.rows; j++ )
                    if ( Int32.Parse( data_dgv[ i, j ].Value.ToString() ) < min )
                    {
                        min = Int32.Parse( data_dgv[ i, j ].Value.ToString() );
                        min_row = j;
                        min_column = i;
                    }
        }
    }
}
