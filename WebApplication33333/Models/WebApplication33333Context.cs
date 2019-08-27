using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication33333.Models
{
    public class WebApplication33333Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication33333Context() : base("name=WebApplication33333Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication33333.Models.Student> Students { get; set; }
    }
}
