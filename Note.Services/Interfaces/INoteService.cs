using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Services.Interfaces
{
    public interface INoteService
    {
        public Task AddNote(string title, string content, int userId);
        public Task Delete(int noteId);
        public Task Update(int noteId, string title, string content);
        public Task<DAL.Models.Note> GetById(int noteId);
        public Task<List<DAL.Models.Note>> GetAllNotesByUserId(int userId);
        public Task<List<DAL.Models.Note>> GetAllNotes();
    }
}
