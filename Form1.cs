
namespace habana_sample
{
    public partial class Inventory_Management_System : Form
    {
        public Inventory_Management_System()
        {
            InitializeComponent();

            // Connect the Form Load event
            this.Load += Inventory_Management_System_Load;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private void button13_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Retry;
            }
        }

        private void Inventory_Management_System_Load(object? sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                "P001", "Keyboard", "Accessories",
                "Piece", "15", "850.00", "Available"
            );

            dataGridView1.Rows.Add(
                "P002", "Mouse", "Accessories",
                "Piece", "20", "450.00", "Available"
            );

            dataGridView1.Rows.Add(
                "P003", "Monitor", "Electronics",
                "Piece", "5", "5500.00", "Low Stock"
            );

            dataGridView1.Rows.Add("P001", "Keyboard", "Accessories", "Piece", "15", "850.00", "Available");
            dataGridView1.Rows.Add("P002", "Mouse", "Accessories", "Piece", "20", "450.00", "Available");
            dataGridView1.Rows.Add("P003", "Monitor", "Electronics", "Piece", "5", "5500.00", "Low Stock");
            dataGridView1.Rows.Add("P004", "Printer", "Electronics", "Piece", "8", "4200.00", "Available");
            dataGridView1.Rows.Add("P005", "USB Flash Drive", "Storage", "Piece", "30", "350.00", "Available");
            dataGridView1.Rows.Add("P006", "External Hard Drive", "Storage", "Piece", "4", "2800.00", "Low Stock");
            dataGridView1.Rows.Add("P007", "Laptop", "Electronics", "Piece", "10", "35000.00", "Available");
            dataGridView1.Rows.Add("P008", "Headphones", "Accessories", "Piece", "12", "750.00", "Available");
            dataGridView1.Rows.Add("P009", "Webcam", "Electronics", "Piece", "3", "1200.00", "Low Stock");
            dataGridView1.Rows.Add("P010", "HDMI Cable", "Accessories", "Piece", "25", "250.00", "Available");
            dataGridView1.Rows.Add("P011", "Power Supply", "Computer Parts", "Piece", "7", "1800.00", "Available");
            dataGridView1.Rows.Add("P012", "RAM 8GB", "Computer Parts", "Piece", "2", "1500.00", "Low Stock");
            dataGridView1.Rows.Add("P013", "SSD 500GB", "Storage", "Piece", "9", "2200.00", "Available");
            dataGridView1.Rows.Add("P014", "Microphone", "Accessories", "Piece", "6", "950.00", "Available");
            dataGridView1.Rows.Add("P015", "Router", "Networking", "Piece", "0", "1800.00", "Out of Stock");

        }

        private void SearchProduct()
        {
            string search = textBox1.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = Convert.ToString(row.Cells[1].Value)?.ToLower() ?? "";

                row.Visible = productName.Contains(search);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
