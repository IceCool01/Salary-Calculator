using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class CalculateLogic: Form1
    {
        private decimal _salary;
        private Label coefficient1_05, coefficient1_2, coefficient1_35;
        public decimal delaysMoney;
        public decimal absenteeism;
        private decimal forProduction = 500;
        public CalculateLogic() { }
        
        public CalculateLogic(decimal salary, Label coefficient1_05, Label coefficient1_2, Label coefficient1_35)
        {
            _salary = salary;
            this.coefficient1_05 = coefficient1_05;
            this.coefficient1_2 = coefficient1_2;
            this.coefficient1_35 = coefficient1_35;
        }

        private void OutputSalary( decimal workingDaysInMosh, decimal _overtime, decimal nalog = 0)
        {
            overtimePay = Math.Round(_salary / workingDaysInMosh / 8) * _overtime;
            coefficient1_05.Text = (_salary - forProduction - nalog + (overtimePay * (decimal)1.05)).ToString();
            coefficient1_2.Text = (_salary - forProduction - nalog + (overtimePay * (decimal)1.2)).ToString();
            coefficient1_35.Text = (_salary - forProduction - nalog + (overtimePay * (decimal)1.35)).ToString();
        }

        private decimal CalculatePremiumReduction(decimal _delays, decimal premia)
        {
            if (_delays > 1)
            {
                _delays = 1 - ((_delays - 1) / 10);
                premia = premia * _delays;
                delaysMoney = Math.Round((_salary * (decimal)0.3) - premia, 2);
            }
            else _delays = 1;
            return premia;
        }

        private decimal CalculateAbsenteeismReduction(decimal _absence, decimal premia, decimal _delays)
        {
            switch (_absence)
            {
                case 0:
                    premia = premia;
                    break;
                case 1:
                    premia = premia * (decimal)0.75;
                    absenteeism = Math.Round(((_salary * (decimal)0.3 * _delays) * (decimal)0.25), 2);
                    break;
                case 2:
                    premia = premia * (decimal)0.5;
                    absenteeism = Math.Round(((_salary * (decimal)0.3 * _delays) * (decimal)0.5), 2);
                    break;
                case 3:
                    premia = premia * 0;
                    absenteeism = Math.Round(_salary * (decimal)0.3 * _delays, 2);
                    break;
                default:
                    MessageBox.Show("Ты уволен.");
                    break;

                  
            }
            return premia;
        }
        public void CalculateSalary(decimal workingDaysInMosh, decimal _overtime, decimal _workingOnTheWeekend, decimal _delays, decimal _absence)
        {
            // ЗП делется 70/30 как оклад и премия 
            decimal oklad = _salary * (decimal)0.7;
            decimal premia = _salary * (decimal)0.3;

            // Расчет удержания зп за прогклы/пропуски
            premia = CalculatePremiumReduction(_delays, premia);

            premia = CalculateAbsenteeismReduction(_absence, premia, _delays);
            
            // Расчет зп по трем коэффицентам 

            if (_overtime > 0 && _workingOnTheWeekend > 0)
            {
                _overtime = _overtime + (_workingOnTheWeekend * 8);
                _salary = oklad + premia;
                OutputSalary(workingDaysInMosh , _overtime);
            }
            else if (_overtime == 0 && _workingOnTheWeekend == 0)
            {
                _salary = oklad + premia;
                coefficient1_05.Text = (_salary - forProduction).ToString();
                coefficient1_2.Text = (_salary - forProduction).ToString();
                coefficient1_35.Text = (_salary - forProduction).ToString();
            }
            else if (_overtime == 0 | _workingOnTheWeekend == 0)
            {
                if (_overtime == 0 && _workingOnTheWeekend > 0)
                {
                    _overtime = _overtime + (_workingOnTheWeekend * 8);
                    _salary = oklad + premia;
                    OutputSalary(workingDaysInMosh, _overtime);
                }
                if (_overtime > 0 && _workingOnTheWeekend == 0)
                {
                    _salary = oklad + premia;
                    OutputSalary(workingDaysInMosh, _overtime);
                }
            }

            else
            {
                MessageBox.Show("Ошибка введенных данных!");
            }
        }

        // Перегрузка метода с вычетом налога
        public void CalculateSalary(decimal workingDaysInMosh, decimal _overtime, decimal _workingOnTheWeekend, decimal _delays, decimal _absence, decimal officialSalary)
        {
            decimal nalog = officialSalary * (decimal)0.13;

            // ЗП делется 70/30 как оклад и премия 
            decimal oklad = _salary * (decimal)0.7;
            decimal premia = _salary * (decimal)0.3;

            // Расчет удержания зп за прогклы/пропуски
            premia = CalculatePremiumReduction(_delays, premia);

            premia = CalculateAbsenteeismReduction(_absence, premia, _delays);

            // Расчет зп по трем коэффицентам 

            if (_overtime > 0 && _workingOnTheWeekend > 0)
            {
                _overtime = _overtime + (_workingOnTheWeekend * 8);
                _salary = oklad + premia;
                OutputSalary(workingDaysInMosh, _overtime, nalog);
            }
            else if (_overtime == 0 && _workingOnTheWeekend == 0)
            {
                _salary = oklad + premia;
                coefficient1_05.Text = (_salary - forProduction - nalog).ToString();
                coefficient1_2.Text = (_salary - forProduction - nalog).ToString();
                coefficient1_35.Text = (_salary - forProduction - nalog).ToString();
            }
            else if (_overtime == 0 | _workingOnTheWeekend == 0)
            {
                if (_overtime == 0 && _workingOnTheWeekend > 0)
                {
                    _overtime = _overtime + (_workingOnTheWeekend * 8);
                    _salary = oklad + premia;
                    OutputSalary(workingDaysInMosh, _overtime, nalog);
                }
                if (_overtime > 0 && _workingOnTheWeekend == 0)
                {
                    _salary = oklad + premia;
                    OutputSalary(workingDaysInMosh, _overtime, nalog);
                }
            }

            else
            {
                MessageBox.Show("Ошибка введенных данных!");
            }
        }
    }
}
