namespace Logistic_Transport
{
    public partial class Form1 : Form
    {
        public Form1()
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
            data_table_dgv.Rows[ Informations.table_informations.rows ].HeaderCell.Value = "Total";
            data_table_dgv.Rows[ Informations.table_informations.rows ].ReadOnly = true;

            // Set the names of the columns
            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
                data_table_dgv.Columns[i].Name = "D" + i.ToString();
            data_table_dgv.Columns[ Informations.table_informations.columns ].Name = "Total";
            data_table_dgv.Columns[ Informations.table_informations.columns ].ReadOnly = true;

        }

        // Fill the data table with random data
        // Requires no argument
        // returns nothing
        private void random_fill_data_table()
        {
            Random random = new Random();

            Int32 production_total = 0;

            // Generate the random numbers
            // Calculate the production total
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
            {
                Int32 sub_total = 0;
                for ( Int32 j = 0; j < Informations.table_informations.columns; j++ )
                {
                    Int32 random_value = random.Next( 1, 101 );
                    sub_total += random_value;
                    data_table_dgv[ j, i ].Value = random_value;
                }
                data_table_dgv[ Informations.table_informations.columns, i ].Value = sub_total;

                // Calculate the production final total
                production_total += sub_total;
            }

            Int32 requests_total = 0;

            // Calculate the requests total
            for ( Int32 i = 0; i < Informations.table_informations.columns; i++ )
            {
                Int32 sub_total = 0;
                for ( Int32 j = 0; j < Informations.table_informations.rows; j++ )
                {
                    sub_total += Int32.Parse( data_table_dgv[i, j].Value.ToString() );
                }
                data_table_dgv[ i, Informations.table_informations.rows ].Value = sub_total;

                requests_total += sub_total;
            }
            data_table_dgv[ Informations.table_informations.rows, Informations.table_informations.columns ].Value = requests_total;

            if ( production_total !=  requests_total )
                MessageBox.Show( "Error" );
        }

        // Check that the data inserted in the table are correct
        // Requires no argument
        // Returns true or false wether the data where correct or not
        private void check_table()
        {}

        private void input_check( object sender, DataGridViewEditingControlShowingEventArgs e )
        {
            e.Control.KeyPress -= new KeyPressEventHandler( key_pressed );

            TextBox cell = e.Control as TextBox;

            if ( cell != null )
                cell.KeyPress += new KeyPressEventHandler( key_pressed );
            check_sum(data_table_dgv.CurrentCell.RowIndex, data_table_dgv.CurrentCell.ColumnIndex);
        }

        private void key_pressed( object sender, KeyPressEventArgs e )
        {
            // !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            if ( !char.IsNumber( e.KeyChar ) )
                e.Handled = true;
        }

        // Check that the rows and columns totals are correct
        private void check_sum( Int32 row, Int32 column )
        {
            Int32 total = 0;

            // Change the requests total
            for ( Int32 i = 0; i < Informations.table_informations.rows; i++ )
                total += Int32.Parse( data_table_dgv[ column, i ].Value.ToString() );
            
            data_table_dgv[ column, Informations.table_informations.rows ].Value = total;

            total = 0;

            // Change the production total
            for (Int32 i = 0; i < Informations.table_informations.columns; i++)
                total += Int32.Parse(data_table_dgv[i, row].Value.ToString());

            data_table_dgv[Informations.table_informations.columns, row].Value = total;
        }
    }
}