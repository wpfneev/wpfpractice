using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace DataAccess
{
    public class ExampleValidation : IDataErrorInfo
    {
        public string Error => string.Empty;
        public string this[string columnName] {

            get
            {
                if (columnName == "Name")
                {
                    // Validate property and return a string if there is an error
                    if (string.IsNullOrEmpty(Name))
                        return "Name is Required";
                }

                if(columnName == "Age") {
                    if (string.IsNullOrEmpty(Convert.ToString(Age)))
                        return "Age is Required";
                }

                if(columnName == "Description")
                {
                    if (string.IsNullOrEmpty(Description))
                        return "Description is Required";
                }

                // If there's no error, null gets returned
                return null;
            }
        }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
