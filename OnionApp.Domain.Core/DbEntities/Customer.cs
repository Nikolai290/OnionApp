using System;
using System.Collections.Generic;
using System.Text;

namespace OnionApp.Domain.Core.DbEntities {
    public class Customer : Entity {
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual IList<Preference> Preferences { get; set; }
        public virtual IList<Promocode> Promocodes { get; set; }
        


        public Customer() { }
    }
}
