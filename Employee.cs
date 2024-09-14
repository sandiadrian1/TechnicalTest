using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    internal class Employee
    {
        //properti yang digunakan untuk menyimpan id karyawan
        public string EmployeeID { get; set; }
        //properti yang digunakan untuk menyimpan full name karyawan
        public string FullName { get; set; }

        //properti yang digunakan untuk menyimpan tanggal lahir karyawan
        public DateTime BirthDate { get; set; }


        //constructor untuk menginisialisasi objek
        public Employee(string employeeID, string fullName, DateTime birthDate)
        {
            EmployeeID = employeeID; //inisalisasi EmployeeID dengan parameter
            FullName = fullName; //inisialisasi FullName dengan parameter
            BirthDate = birthDate; // inisialisasi BirthDate dengan parameter
        }

       
    }
}
