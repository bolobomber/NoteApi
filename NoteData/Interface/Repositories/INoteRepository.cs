using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.DAL.Models;

namespace Note.DAL.Interface.Repositories
{
    public interface INoteRepository
    {
        public Task Add(Models.Note note);
        public Task Delete(int noteId);
        public Task Update(Models.Note note);
        public Task<Models.Note> GetById(int noteId);
        public Task<List<Models.Note>> GetAllNotesByUserId(int userId);
        public Task<List<Models.Note>> GetAllNotes();
    }
}
