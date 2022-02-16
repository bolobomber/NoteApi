using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        public async Task Delete(int noteId)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Models.Note note)
        {
            throw new NotImplementedException();
        }

        public async Task<Models.Note> GetById(int noteId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Models.Note>> GetAllNotesByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Models.Note>> GetAllNotes()
        {
            throw new NotImplementedException();
        }
    }
}
