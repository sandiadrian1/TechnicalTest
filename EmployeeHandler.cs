using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    //class yang digunakan untuk handle operasi AddData,ShowData,And Delete Data
    internal class EmployeeHandler : IOperationsEmployee
    {

        //Array List yang digunakan untuk menyimpan sekelompok objek/data
        private List<Employee> _employees = new List<Employee>();


        //method untuk menambahkan data Karyawan
        public void AddEmployee(Employee employee)
        {
            //Validasi untuk valid data null handling
            if (string.IsNullOrEmpty(employee.EmployeeID) || string.IsNullOrEmpty(employee.FullName))
            {
                throw new Exception("Maaf Id karyawan dan Nama Lengkap Tidak Boleh Kosong");
            }

            //Validasi untuk valid data duplicate data handling
            if (_employees.Exists(e => e.EmployeeID == employee.EmployeeID))
            {
                throw new Exception("Maaf ID ini sudah digunakan");
            }

            //menambahkan data jika memenuhi kondisi
            _employees.Add(employee);
        }

         //method menampilkan data karyawan
        public void ShowEmployee()
        {
            Console.WriteLine("\n \t Daftar Karyawan\n");
            Console.WriteLine($"| EmployeeID  \t|   FullName \t|    BirthDate | ");

            //Loop digunakan untuk menampilkan seluruh data karyawan
            foreach (var emp in _employees)
            {
                Console.WriteLine($"|   {emp.EmployeeID}    \t|   {emp.FullName}\t|    {emp.BirthDate:dd-MMM-yy} |");
            }
        }

        //method hapus data karyawan menggunakan parameter bedasarkan id
        public void DeleteEmployee(string employeeId)
        {
            //variabel employees yang menampung id employees
            var employees = _employees.Find(e => e.EmployeeID == employeeId);
            
            //kondisi jika id yang di input tidak sesuai dengan id yang ada di data
            if(employees == null) 
            {
                throw new Exception("Data tidak ditemukan");
            }
            else
            {
                //menghapus data employees berdasarkan id yang kita tampung
                _employees.Remove(employees);
            }
        }

    }
}
