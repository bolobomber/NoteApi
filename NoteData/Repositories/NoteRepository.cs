using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Note.DAL.Interface.Repositories;
using Note.DAL.Models;

namespace Note.DAL.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly NoteContext context;
        public NoteRepository(NoteContext context)
        {
            this.context = context;
        }


        public async Task Add(Models.Note note)
        {
            await context.AddAsync(note);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int noteId)
        { 
            context.Remove( await context.Notes.FirstOrDefaultAsync(x => x.Id == noteId));
            await context.SaveChangesAsync();
        }

        public async Task Update(Models.Note note)
        {
            throw new NotImplementedException();
        }

        public async Task<Models.Note> GetById(int noteId)
        {
            return await context.Notes.FirstOrDefaultAsync(x => x.Id == noteId);
        }

        public async Task<List<Models.Note>> GetAllNotesByUserId(int userId)
        {
            return await context.Notes.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<List<Models.Note>> GetAllNotes()
        {
            return await context.Notes.ToListAsync();
        }
    }
}
