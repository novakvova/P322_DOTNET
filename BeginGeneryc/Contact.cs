using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginGeneryc
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\t Phone: {Phone}";
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if (obj is Contact)
            {
                var contact = obj as Contact;
                return contact.Phone == this.Phone;

            }
            return false;
        }
    }
    
}
