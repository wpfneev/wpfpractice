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
            this.AddNewEmployee = new RelayCommand(() => MessageBox.Show("The add button has been clicked, functionality needs to be implemented"));
            PopulateStaticData();
        }

        public ICommand AddNewEmployee { get; set; }

        public Employee ItemSelected
        {
            get { return itemSelected; }
            set
            {
                itemSelected = value;
                MessageBox.Show(string.Format("The Selected Employee {0}{1} ", itemSelected.FirstName, itemSelected.LastName));
            }
        }

        private void PopulateStaticData()
        {
            for(int index = 0; index < 1000; index++)
            {
                this.Employees.Add(new Employee("John " + index, "Doe " + index, index));
            }
        }
    }
}
