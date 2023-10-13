using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCApplication_1.Models;

namespace MVCApplication_1.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MVCApplication_1.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
