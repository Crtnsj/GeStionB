using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeStionB.Ordonnances
{
    public partial class ViewOrdonnances : Form
    {
        OrdonnancesDataAccess dataAccess = new OrdonnancesDataAccess(); 
        public ViewOrdonnances()
        {
            InitializeComponent();
            updateDataGridView();
            this.Activated += ViewOrdonnances_Activated;
        }

        private void ViewOrdonnances_Activated(object sender, EventArgs e)
        {
            updateDataGridView();
        }


       

        public void updateDataGridView()
        {
            this.gridOrdonnance.DataSource = null;
            this.gridOrdonnance.DataSource = dataAccess.GetOrdonnancesListFromDB();
        }
    }
}
