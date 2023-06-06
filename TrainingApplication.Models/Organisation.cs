using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApplication.Models
{
    public class Organisation
    {
        public string OrgName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
