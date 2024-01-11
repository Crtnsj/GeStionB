namespace GeStionB
{
    public partial class Form1 : Form
    {
        private DrugDataAccess dataAccess = new DrugDataAccess();
        public Form1()
        {
            InitializeComponent();
            updateDataGridView();
        }


        public void updateDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.getDrugListFromDB();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                string name = selectedRow.Cells["Name"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();

                FormDetails formDetail = new FormDetails(name, description);
                formDetail.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            //dataAccess.addDrug(drug);
            int result = dataAccess.addDrugToDB(drug);
            if (result == 0)
            {
                MessageBox.Show(result.ToString());
            }
            else if (result > 0)
            {
                MessageBox.Show("Le medicament: " + this.textBox1.Text + " à bien été ajouté");
            }
            MessageBox.Show(result.ToString());
            updateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}