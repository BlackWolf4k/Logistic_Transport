namespace Logistic_Transport
{
    public partial class Logistic_Transport : Form
    {
        public Logistic_Transport()
        {
            InitializeComponent();
        }

        Int32[] old_informations = new Int32[ 2 ];
        private List<Int32> data = new List<Int32>();

        // Create a new table
        private void new_table( object sender, EventArgs e )
        {
            // Open the dialog form for the size informations
            Informations informations = new Informations();
            informations.ShowDialog();

            // Generate the table
            make_new_table();
        }

        private void make_new_table()
        {
            // Clear the old table
            data_table_dgv.Rows.Clear();
            data_table_dgv.Columns.Clear();
            data_table_dgv.Refresh();

            // Set the informations
            data_table_dgv.RowCount = Informations.table_informations.rows + 1;
            data_table_dgv.ColumnCount = Informations.table_informations.columns + 1;

            // Check if the user asked to use random data
            if ( Informations.table_informations.random_fill == true )
            {
                // Fill the table with random data
                random_fill_data_table();
            }

            // Show the rows and columns on the top left of the screen
            rows_tb.Text = Informations.table_informations.rows.ToString();
            columns_tb.Text = Informations.table_informations.columns.ToString();

            // Make the headers of the table
            // Set the names of the rows
            data_table_dgv.RowHeadersWidth = 100;
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
                data_table_dgv.Rows[i].HeaderCell.Value = "UP" + i.ToString();
            data_table_dgv.Rows[ Informations.table_informations.rows ].HeaderCell.Value = "Request";

            // Set the names of the columns
            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
            {
                data_table_dgv.Columns[i].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                data_table_dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                data_table_dgv.Columns[i].Name = "D" + i.ToString();
            }
            data_table_dgv.Columns[ Informations.table_informations.columns ].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            data_table_dgv.Columns[ Informations.table_informations.columns ].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            data_table_dgv.Columns[ Informations.table_informations.columns ].Name = "Production";

            // Make the total readonly
            data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].ReadOnly = true;

            // Enable the run button
            run_b.Enabled = true;
        }

        // Fill the data table with random data
        // Requires no argument
        // returns nothing
        private void random_fill_data_table()
        {
            Random random = new Random();

            // Generate the random numbers
            // Calculate the production total
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
            {
                for ( Int32 j = 0; j < Informations.table_informations.columns; j++ )
                {
                    Int32 random_value = random.Next( 1, 101 );
                    data_table_dgv[ j, i ].Value = random_value;
                }
            }

            Int32 production_total = 0;
            Int32 requests_total = 0;

            // Generat ethe request total
            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
            {
                Int32 random_value = random.Next( 1, 101 );
                requests_total += random_value;
                data_table_dgv[ i, Informations.table_informations.rows ].Value = random_value;
            }

            // Generate the production total
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
            {
                if ( i == Informations.table_informations.rows - 1 )
                {
                    if ( requests_total < production_total )
                    {
                        Int32 random_value = random.Next( 1, 101 );
                        
                        // Last of production
                        data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows - 1 ].Value = random_value;
                        production_total += random_value;

                        data_table_dgv[ Informations.table_informations.columns - 1, Informations.table_informations.rows ].Value = Int32.Parse( data_table_dgv[ Informations.table_informations.columns - 1, Informations.table_informations.rows ].Value.ToString() ) + production_total - requests_total;
                    }
                    else if ( requests_total == production_total )
                    {
                        Int32 random_value = random.Next( 1, 101 );
                        data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows - 1 ].Value = random_value;

                        data_table_dgv[ Informations.table_informations.columns - 1, Informations.table_informations.rows ].Value = Int32.Parse( data_table_dgv[ Informations.table_informations.columns - 1, Informations.table_informations.rows ].Value.ToString() ) + random_value;

                        production_total += random_value;
                    }
                    else
                    {
                        data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows - 1 ].Value = requests_total - production_total;
                        production_total += requests_total - production_total;
                    }
                }
                else
                {
                    Int32 random_value = random.Next( 1, 101 );
                    production_total += random_value;
                    data_table_dgv[ Informations.table_informations.columns, i ].Value = random_value;
                }
            }

            data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = production_total;
        }

        // Ckec that only numbers are beeing inserted
        private void input_check( object sender, DataGridViewEditingControlShowingEventArgs e )
        {
            e.Control.KeyPress -= new KeyPressEventHandler( key_pressed );

            TextBox cell = e.Control as TextBox;

            if ( cell != null )
                cell.KeyPress += new KeyPressEventHandler( key_pressed );

            // check_sum( data_table_dgv.CurrentCell.RowIndex, data_table_dgv.CurrentCell.ColumnIndex );
        }

        private void key_pressed( object sender, KeyPressEventArgs e )
        {
            // !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            if ( !char.IsNumber( e.KeyChar ) && e.KeyChar != '\b' )
                e.Handled = true;
        }

        // Chck that the value inside the table are ok
        bool check_table()
        {
            bool content = true;

            if ( Informations.table_informations.rows < 2 || Informations.table_informations.columns < 2 )
                return false;

            for ( Int32 i = 0; i < Informations.table_informations.rows + 1; i++ )
                for ( Int32 j = 0; j < Informations.table_informations.columns + 1; j++ )
                {
                    if ( data_table_dgv[j, i].Value == null )
                    {
                        if ( i != Informations.table_informations.rows && j != Informations.table_informations.columns )
                            return false;
                    }
                    else
                    {
                        Int32 result = 0;
                        if ( !Int32.TryParse( data_table_dgv[ j, i ].Value.ToString(), out result ) )
                        {
                            return false;
                        }
                        if ( data_table_dgv[ j, i ].Value == "" || data_table_dgv[ j, i ].Value.ToString() == "0" )
                            content = false;
                    }
                }

            if ( content == false )
                return false;

            Int32 total = 0;
            Int32 total_b = 0;
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
            {
                total += Int32.Parse( data_table_dgv[ Informations.table_informations.columns, i ].Value.ToString() );
            }

            total_b = total;

            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
            {
                total -= Int32.Parse( data_table_dgv[ i, Informations.table_informations.rows ].Value.ToString() );
            }

            if ( total == 0 && content )
            {
                data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].Value = total_b;
                return true;
            }
            return false;
        }

        private void copy_table()
        {
            data.Clear();
            old_informations[0] = Informations.table_informations.rows;
            old_informations[1] = Informations.table_informations.columns;

            for ( int i = 0; i < Informations.table_informations.rows + 1; i++ )
                for ( int j = 0; j < Informations.table_informations.columns + 1; j++ )
                    data.Add( Int32.Parse( data_table_dgv[ j, i ].Value.ToString() ) );
        }

        private void reload_table(object sender, EventArgs e)
        {
            Informations.table_informations.rows = old_informations[0];
            Informations.table_informations.columns = old_informations[1];
            Informations.table_informations.random_fill = false;

            make_new_table();

            for ( int i = 0; i < Informations.table_informations.rows + 1; i++ )
                for ( int j = 0; j < Informations.table_informations.columns + 1; j++ )
                    data_table_dgv[ j, i ].Value = data[ i * ( old_informations[1] + 1 ) + j ];
        }

        private void run( object sender, EventArgs e )
        {
            if ( !check_table() )
            {
                MessageBox.Show( "Check the table and try again" );
            }
            else
            {
                Output output = new Output( ref data_table_dgv );
                copy_table();
                output.ShowDialog();
                last_table_b.Enabled = true;
            }
        }
    }
}