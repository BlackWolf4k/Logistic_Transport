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
            for ( int i = 0; i < Informations.table_informations.rows; i++ )
                data_table_dgv.Rows[i].HeaderCell.Value = "UP" + i.ToString();
            data_table_dgv.Rows[Informations.table_informations.rows].HeaderCell.Value = "Total";

            // Set the names of the columns
            for ( int i = 0; i < Informations.table_informations.columns; i++ )
                data_table_dgv.Columns[i].Name = "D" + i.ToString();
            data_table_dgv.Columns[ Informations.table_informations.columns ].Name = "Total";

        }

        // Fill the data table with random data
        // Requires no argument
        // returns nothing
        private void random_fill_data_table()
        {}

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

            check_sum();
        }

        private void key_pressed( object sender, KeyPressEventArgs e )
        {
            // !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            if ( !char.IsNumber( e.KeyChar ) )
                e.Handled = true;
        }

        // Check that the rows and columns totals are correct
        private void check_sum()
        {}
    }
}