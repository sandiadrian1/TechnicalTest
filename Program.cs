using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat objek inisialisasi handle karyawan
            EmployeeHandler handle = new EmployeeHandler();

            //hardcore data karyawan
            //membuat objek baru yang langsung dimasukkan kedalam parameter
            try
            {
            handle.AddEmployee(new Employee("1001", "Adit", new DateTime(1954,8,17)));
            handle.AddEmployee(new Employee("1002", "Anton", new DateTime(1954,8,18)));
            handle.AddEmployee(new Employee("1003", "Amir", new DateTime(1954,8,19)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ ex.Message);
            }

            //Menampilkan data karyawan
            handle.ShowEmployee();

            //menghapus data karyawan berdasarkan ID
            handle.DeleteEmployee("1001");

            //Menampilkan data karyawan
            handle.ShowEmployee();

           /* //menambahkan data ketika nama kosong
            handle.AddEmployee(new Employee("1004", "", new DateTime(2004, 7, 15)));*/

            //menambahkan data yang sama
            handle.AddEmployee(new Employee("1002", "Sandi", new DateTime(2000, 8, 17)));

                   
        }
    }
}
