namespace MVCcrud.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudendbEntities : DbContext
    {
        public StudendbEntities()
            : base("name=StudendbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<StudentTable> StudentTables { get; set; }
    }
}
