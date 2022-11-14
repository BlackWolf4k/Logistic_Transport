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
    }
}