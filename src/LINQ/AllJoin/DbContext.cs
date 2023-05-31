﻿using System.Collections.Generic;
using AllJoin.Entities;

namespace AllJoin
{
    public class DbContext
    {
        public IEnumerable<Employee> Staff { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Bank> Banks { get; set; }

        public DbContext()
        {
            Departments = new[]
            {
                new Department {Id = 1, Name = "Кухня"},
                new Department {Id = 2, Name = "Бар"},
                new Department {Id = 3, Name = "Администрация"}
            };

            Banks = new[]
            {
                new Bank {Id = 1, Name = "Гоп-Стоп"},
                new Bank {Id = 2, Name = "Вшивый"},
                new Bank {Id = 3, Name = "Пока не лопнул"}
            };

            Staff = new[]
            {
                new Employee {Id = 1, Name = "Маша", DepartmentId = 1},
                new Employee {Id = 2, Name = "Петя", DepartmentId = 2},
                new Employee {Id = 3, Name = "Коля", BankId = 1}, 
                new Employee {Id = 4, Name = "Света", DepartmentId = 2, BankId = 2},
                new Employee {Id = 5, Name = "Ваня"}
            };
        }
    }
}
