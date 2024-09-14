using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    internal interface IOperationsEmployee
    {
        void AddEmployee(Employee employee); //method AddEmployee yang di deklarasikan tanpa implementasi,implementasi nya di class yang menggunakan nya
        void ShowEmployee(); //method ShowEmployee yang di deklarasikan tanpa implementasi,implementasi nya di class yang menggunakan nya
        void DeleteEmployee(string employeeId); //method DeleteEmployee yang di deklarasikan tanpa implementasi,implementasi nya di class yang menggunakan nya
    }
}
