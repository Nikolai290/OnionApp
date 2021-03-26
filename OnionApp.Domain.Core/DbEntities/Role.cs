using System.Collections.Generic;

namespace OnionApp.Domain.Core.DbEntities {
    public class Role : Entity {
        public virtual string Name { get; set; }
        public IList<Employee> Employees { get; set; }

        // Needs for Nhibernate
        public Role() { } 
    }
}
