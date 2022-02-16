using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Note.DAL.Models;

namespace Note.DAL
{
    public class NoteContext : DbContext
    {
        public NoteContext()
        {
            
        }
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Models.Note> Notes { get; set; }
    }
}
