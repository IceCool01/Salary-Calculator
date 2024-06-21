using Calculator.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
     public partial class TablBd : Form
    {
        private WorkersContext dbContext;

        public TablBd()
        {
            InitializeComponent();
            dbContext = new WorkersContext();
            
        }

        private void TablBd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var workers = dbContext.Workers.ToList();
            dataGridView1.DataSource = workers;
        }

        private void SaveData()
        {
            dbContext.SaveChanges();
        }


        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var worker = dataGridView1.Rows[e.RowIndex].DataBoundItem as Worker;
                if (worker != null)
                {
                    dbContext.Entry(worker).State = EntityState.Modified;
                }
            }
        }
    }
}
