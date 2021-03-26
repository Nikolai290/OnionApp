using OnionApp.Domain.Core.DbEntities;

namespace OnionApp.Dto.Employee {
    public class PromocodeDto {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Preference { get; set; }
        public string Description { get; set; }

        public PromocodeDto (Promocode promocode) {
            Id = promocode.Id;
            Code = promocode.Code;
            Preference = promocode.Preference.Name;
            Description = promocode.Description;
        }
    }
}
