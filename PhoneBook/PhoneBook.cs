using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Separator { get; set; }
        public PhoneBook() {

        }

        public string Validation() {
            string message = "Line " + this.Id ;

            if (this.PhoneNumber.Length != 9)
            {
                message += " phone number should be 9 digits. ";

            }
            if (this.Separator != "-" && this.Separator != ":" )
            {
                message += " separator should be `:` or `-` ";
            }
           
            return message;
            }

        public override string ToString()
        {
            return this.Name + " " + this.Surname + " " + this.Separator + " " + this.PhoneNumber;
        }

    }
}
