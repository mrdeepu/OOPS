using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class OCP
    {
        public void InvokeOcp()
        {
            //List<PersonModel> people = new List<PersonModel>
            //{
            //    new PersonModel {FirstName = "Deepu", LastName = "R" },
            //    new PersonModel {FirstName = "Dakshin", LastName = "Deepu" },
            //    new PersonModel {FirstName = "Dhanya", LastName = "KL" }
            //};

            List<IApplicantModel> people = new List<IApplicantModel>
            {
                new PersonModel {FirstName = "Deepu", LastName = "R" },
                new ManagerModel {FirstName = "Dakshin", LastName = "Deepu" },
                new PersonModel {FirstName = "Dhanya", LastName = "KL" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            //Accounts accounts = new Accounts();

            foreach (var person in people)
            {
                //employees.Add(accounts.Create(person));
                employees.Add(person.AccountsProcessor.Create(person));

            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} " +
                                  $"{employee.LastName} : " +
                                  $"{employee.EmailAddress} , " +
                                  $"IsManage : {employee.IsManager} , " +
                                  $"IsExecutive : {employee.IsExecutive}");
            }
            Console.ReadLine();
        }
    }
}
