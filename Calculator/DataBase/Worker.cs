using System;
using System.Collections.Generic;

namespace Calculator.DataBase
{
    public partial class Worker
    {
        public int WorkersId { get; set; }

        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? Post { get; set; }

        public decimal? Salary { get; set; }
    }
}

