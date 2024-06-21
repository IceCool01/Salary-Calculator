using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SalaryDeductions : Form
    {
        public decimal _delaysMoney;
        public decimal _absenteeism;
        public decimal forProduction = 500;

        public SalaryDeductions(decimal delaysMoney, decimal absenteeism)
        {
            InitializeComponent();
            _delaysMoney = delaysMoney;
            _absenteeism = absenteeism;

        }


        private void SalaryDeductions_Load(object sender, EventArgs e)
        {
            salaryRetentionInfo.Text = "С заработной платы удержено : " + _delaysMoney +
                " снято за опоздания , а так же " + _absenteeism + " снято за прогулы." + " И " + forProduction +
                " удерженно в фонд помощи нуждающимся сотрудникам!";
        }
    }
}
