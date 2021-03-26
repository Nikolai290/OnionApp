using System.Collections.Generic;

namespace OnionApp.Domain.Core.DbEntities {
    public class Partner : Entity {
        public string Name { get; set; }
        public IList<Promocode> Promocodes { get; set; }

        public Partner() { }
    }
}
