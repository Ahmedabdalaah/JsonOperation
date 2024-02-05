using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JsonOperation
{
    internal class EmpOperations : IOperations
    {

        public void DeleteEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            using StreamReader reader = new("Employee.json");
            var json = reader.ReadToEnd();
            List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(json);
            Console.WriteLine(emp);
            /*    another way /////////////////////////////////////////
            String s;
            try
            {
                StreamReader str = new StreamReader("Employee.json");
                s = str.ReadLine();
                while (s != null)
                {
                    string[] data = s.Split("{");
                    foreach (string item in data)
                    {
                        Console.WriteLine("Employee : " + item);
                        s = str.ReadLine();
                    }
                }
                str.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
        }

        public void SerarchEmployee(int id)
    {
        try
        {
            var jsonStr = File.ReadAllText("Employee.json");
            var employee = JsonConvert.DeserializeObject<List<Employee>>(jsonStr);
            var selectedEmployee = employee.Where(x => x.Id.Equals(id));
            Console.WriteLine(selectedEmployee);
        }


        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void UpdateEmployee(int Id, string address)
    {
        throw new NotImplementedException();
    }

    public void AddEmployee(int Id, string fname, string lname, string address, string email, int phone)
    {
            try
            {
                var employee = new Employee()
                {
                    Id = Id,
                    FirstName = fname,
                    LastName = lname,
                    Address = address,
                    Email = email,
                    Phone = phone
                };
                string json = JsonConvert.SerializeObject(value: employee);
                File.AppendAllText("Employee.json", json +"\n");
                Console.WriteLine("success : A new Employee is added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
}
}