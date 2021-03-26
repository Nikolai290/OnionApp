using System.Collections.Generic;

namespace OnionApp.Domain.Core.DbEntities {
    public class Employee : Entity {
        public virtual string Name { get; set; }
        public virtual Role Role { get; set; }
        public virtual IList<Promocode> Promocodes { get; set; }

        // Needs for Nhibernate
        public Employee() { }
    }
}
