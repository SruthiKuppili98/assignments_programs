namespace MyApp.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<int> AdressId { get; set; }
    
        public virtual Address Address { get; set; }
    }
}