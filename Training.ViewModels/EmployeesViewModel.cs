using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Traning.Core;

namespace Training.ViewModels
{
    public class EmployeesViewModel
    {
        private Employee itemSelected;
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeesViewModel() { 

            Employees = new ObservableCollection<Employee>();
            this.AddNewEmployee = new RelayCommand((parameter) =>
            {
                this.Employees.Add(new Employee(this.FirstName, this.LastName, int.Parse(this.Age)));
                MessageBox.Show("Employee Added!");
            });
            PopulateStaticData();
        }

        public ICommand AddNewEmployee { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Age { get; set; }

        public Employee ItemSelected
        {
            get { return itemSelected; }
            set
            {
                itemSelected = value;
                //MessageBox.Show(string.Format("The Selected Employee {0}{1} ", itemSelected.FirstName, itemSelected.LastName));
            }
        }

        private void PopulateStaticData()
        {
            for(int index = 0; index < 10; index++)
            {
                this.Employees.Add(new Employee("John " + index, "Doe " + index, index));
            }
        }
    }
}
