﻿

namespace APIstudentsecurity.Models
{
    using System.Data.Entity;

    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIstudentsecurity.Models.Student> Students { get; set; }
    }
}