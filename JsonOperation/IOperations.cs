using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOperation
{
    internal interface IOperations
    {
        void AddEmployee(int Id, string fname, string lname, string address, string email, int phone);
        void DeleteEmployeeById(int id);
        void GetAll();
        void UpdateEmployee(int id, string address);
        void SerarchEmployee(int id); 
    }
}
