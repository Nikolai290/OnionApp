using System;
using System.Collections.Generic;
using System.Text;

namespace OnionApp.Domain.Core.DbEntities {
    public class Preference : Entity {
        public virtual string Name { get; set; }
        public IList<Customer> Customers { get; set; }
        public IList<Promocode> Promocodes { get; set; }


        public Preference() { }
    }
}
