using Calculator.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;


namespace Calculator
{

    public partial class Form1 : Form
    {
        private WorkersContext dbContext;
        private List<Label> labelsToClear;
        private UIHelper uiHelper;
        public Form1()
        {
            InitializeComponent();
            dbContext = new WorkersContext();
            labelsToClear = new List<Label> { firstName_label, lastName_label, middleName_label, post_label, coefficient1_05, coefficient1_2, coefficient1_35 };
            uiHelper = new UIHelper(labelsToClear);

            // Подписка на событие KeyPress для каждого TextBox
            workingDays.KeyPress += TextBox_KeyPress;
            overtime.KeyPress += TextBox_KeyPress;
            workingOnTheWeekend.KeyPress += TextBox_KeyPress;
            delays.KeyPress += TextBox_KeyPress;
            absence.KeyPress += TextBox_KeyPress;
        }

        decimal delaysMoney = 0;
        decimal absenteeism = 0;
        
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка на ввод цифр и клавиши Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Проверка на то, что запятая может быть введена только один раз
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public decimal _salary;
        public decimal overtimePay;

        private void worker_Click(object sender, EventArgs e, int index)
        {
            var worker = dbContext.Workers.OrderBy(w => w.WorkersId).Skip(index).FirstOrDefault();

            if (worker != null)
            {
                firstName_label.Text = worker.FirstName;
                lastName_label.Text = worker.LastName;
                middleName_label.Text = worker.MiddleName;
                post_label.Text = worker.Post;
                _salary = worker.Salary ?? 0;
            }
        }
        private void worker1_Click(object sender, EventArgs e)
        {
            
            worker_Click(sender, e, 0);
        }

        private void worker2_Click(object sender, EventArgs e)
        {
            
            worker_Click(sender, e, 1);
        }

        private void worker3_Click(object sender, EventArgs e)
        {
            
            worker_Click(sender, e, 2);
        }

        private void worker4_Click(object sender, EventArgs e)
        {
            
            worker_Click(sender, e, 3);
        }

        private void salary_Click(object sender, EventArgs e)
        {
            decimal workingDaysInMosh = Convert.ToDecimal(workingDays.Text);
            decimal _overtime = Convert.ToDecimal(overtime.Text);
            decimal _workingOnTheWeekend = Convert.ToDecimal(workingOnTheWeekend.Text);
            decimal _delays = Convert.ToDecimal(delays.Text);
            decimal _absence = Convert.ToDecimal(absence.Text);
            decimal officialSalary = 25000;

            if (officialEmployee.Checked)
            {
                
                    CalculateLogic calculateLogic = new CalculateLogic(_salary, coefficient1_05, coefficient1_2, coefficient1_35);
                    calculateLogic.CalculateSalary(workingDaysInMosh, _overtime, _workingOnTheWeekend, _delays, _absence, officialSalary);

                    delaysMoney = calculateLogic.delaysMoney;
                    absenteeism = calculateLogic.absenteeism;
                
            }
            else
            {
                    CalculateLogic calculateLogic = new CalculateLogic(_salary, coefficient1_05, coefficient1_2, coefficient1_35);
                    calculateLogic.CalculateSalary(workingDaysInMosh, _overtime, _workingOnTheWeekend, _delays, _absence);

                    delaysMoney = calculateLogic.delaysMoney;
                    absenteeism = calculateLogic.absenteeism;
                
            }


        }



        private void workingDays_TextChanged(object sender, EventArgs e)
        {


        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            uiHelper.ClearTextBoxesAndLabels(this);
        }

       

        private void officialEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void salaryDeductions_Click(object sender, EventArgs e)
        {



            SalaryDeductions salaryDeductions = new SalaryDeductions(delaysMoney, absenteeism);
            salaryDeductions.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablBd tablBd = new TablBd();
            tablBd.Show();
        }
    }
}
