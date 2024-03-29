﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _22_Exercicio
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee (int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void RaiseSalary(double percentage)
        {
            double aumento = Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
