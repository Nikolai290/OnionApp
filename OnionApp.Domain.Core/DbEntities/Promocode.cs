using System.Collections.Generic;

namespace OnionApp.Domain.Core.DbEntities {
    public class Promocode : Entity {
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual Preference Preference { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual IList<Employee> Employee { get; set; }
        public virtual IList<Customer> Customers { get; set; }

        public Promocode() { }
    }
}
