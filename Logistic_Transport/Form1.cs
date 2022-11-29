namespace Logistic_Transport
{
    public partial class Logistic_Transport : Form
    {
        public Logistic_Transport()
        {
            InitializeComponent();
        }

        // Create a new table
        private void new_table( object sender, EventArgs e )
        {
            // Open the dialog form for the size informations
            Informations informations = new Informations();
            informations.ShowDialog();

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
                data_table_dgv.Columns[i].Name = "D" + i.ToString();
            data_table_dgv.Columns[ Informations.table_informations.columns ].Name = "Production";

            // Make the total readonly
            data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows ].ReadOnly = true;

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
                        data_table_dgv[ Informations.table_informations.columns - 1, Informations.table_informations.rows ].Value = ( requests_total - random_value ) + random_value;
                        data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows - 1 ].Value = random_value;
                        production_total += random_value;
                    }
                    else if ( requests_total == production_total )
                    {
                        Int32 random_value = random.Next( 1, 101 );
                        data_table_dgv[ Informations.table_informations.columns - 1, Informations.table_informations.rows ].Value = random_value;
                        data_table_dgv[ Informations.table_informations.columns, Informations.table_informations.rows - 1 ].Value = random_value;
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

        private void input_check( object sender, DataGridViewEditingControlShowingEventArgs e )
        {
            e.Control.KeyPress -= new KeyPressEventHandler( key_pressed );

            TextBox cell = e.Control as TextBox;

            if ( cell != null )
                cell.KeyPress += new KeyPressEventHandler( key_pressed );

            check_sum( data_table_dgv.CurrentCell.RowIndex, data_table_dgv.CurrentCell.ColumnIndex );
        }

        private void key_pressed( object sender, KeyPressEventArgs e )
        {
            // !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            if ( !char.IsNumber( e.KeyChar ) )
                e.Handled = true;
        }

        bool check_table()
        {
            Int32 total = 0;
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
            {
                total += Int32.Parse( data_table_dgv[ Informations.table_informations.columns, i ].Value.ToString() );
            }

            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
            {
                total -= Int32.Parse( data_table_dgv[ i, Informations.table_informations.rows ].Value.ToString() );
            }

            if ( total == 0 )
                return true;
            return false;
        }

        // Check that the rows and columns totals are correct
        private void check_sum( Int32 row, Int32 column )
        {
            // MessageBox.Show("aaa");
            Int32 total = 0;

            // Change the requests total
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
                total += Int32.Parse( data_table_dgv[ column, i ].Value.ToString() );
            
            data_table_dgv[ column, Informations.table_informations.rows ].Value = total;

            total = 0;

            // Change the production total
            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
                total += Int32.Parse( data_table_dgv[i, row].Value.ToString() );

            data_table_dgv[Informations.table_informations.columns, row].Value = total;
        }

        private void run( object sender, EventArgs e )
        {
            if ( !check_table() )
            {
                MessageBox.Show( "" );
            }
            else
            {
                Output output = new Output();
                output.ShowDialog();
            }
        }
    }
}