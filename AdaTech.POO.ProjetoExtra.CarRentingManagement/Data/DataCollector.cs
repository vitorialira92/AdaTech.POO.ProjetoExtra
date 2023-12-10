using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement.Enums;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement.model;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement.Enums;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Data
{
    internal static class DataCollector
    {
        private static StreamReader reader;

        public static void GetAllVehicles()
        {
            string file = @"Data\Files\Vehicles.txt";
            reader = new StreamReader(file);

            string headerLine = reader.ReadLine(); 

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(',');

                Vehicle vehicle = new Vehicle
                    (
                        decimal.Parse(values[0]),
                        (CarBrand)int.Parse(values[1]),
                        values[2],
                        int.Parse(values[3]),
                        int.Parse(values[4]),
                        values[5],
                        (CarType)int.Parse(values[6]),
                        (CarStatus)int.Parse(values[7]),
                        double.Parse(values[8]),
                        double.Parse(values[9])
                        

                    );
                

                VehiclesManagement.AddVehicle(vehicle);
            }
        }

        public static void GetAllEmployees()
        {
            
            string file = @"Data\Files\Employees.txt";
            reader = new StreamReader(file);

            string headerLine = reader.ReadLine();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                //id,CPF,name,phoneNumber,email,street,city,brazilState,postalCode,password,department,position,salary
                Employee employee = new Employee
                    (   decimal.Parse(values[0]),
                        values[1],
                        values[2],
                        values[3],
                        values[4],
                        new Address(
                            values[5],
                            values[6],
                            (BrazilStates)int.Parse(values[7]),
                            values[8]
                            ),
                        values[9], "system",
                        (Department)int.Parse(values[10]),
                        values[11],
                        decimal.Parse(values[12]));


                EmployeesManagement.AddEmployee(employee);
            }
        }

        public static void GetAllManagers()
        {
            string file = @"Data\Files\Managers.txt";
            reader = new StreamReader(file);

            string headerLine = reader.ReadLine();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] values = line.Split(',');
                //bonus,id,CPF,name,phoneNumber,email,street,city,brazilState,postalCode,password,department,position,salary

                Manager manager = new Manager
                    (   decimal.Parse(values[0]),
                        decimal.Parse(values[1]),
                        values[2],
                        values[3],
                        values[4],
                        values[5],
                        new Address(
                            values[6],
                            values[7],
                            (BrazilStates)int.Parse(values[8]),
                            values[9]
                            ),
                        values[10], "system",
                        (Department)int.Parse(values[11]),
                        values[12],
                        decimal.Parse(values[13]));


                EmployeesManagement.AddManager(manager);
            }
        }

        internal static void GetAllRentals()
        {
            throw new NotImplementedException();
        }
    }
}
