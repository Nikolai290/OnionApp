namespace OnionApp.Domain.Core.DbEntities {
    public abstract class Entity {
        public virtual int Id { get; set; }
        public virtual bool IsDeleted { get; set; }

        public void Delete(bool delete) => IsDeleted = delete;

    }
}
