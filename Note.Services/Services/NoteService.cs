using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Note.DAL.Interface.Repositories;
using Note.Services.Interfaces;
using Note.Services.Validators;

namespace Note.Services.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository noteRepository;
        private readonly NoteValidator noteValidator;

        public NoteService(INoteRepository noteRepository, NoteValidator noteValidator)
        {
            this.noteRepository = noteRepository;
            this.noteValidator = noteValidator;
        }
        public async Task AddNote(string title, string content, int userId)
        {
            var note = new DAL.Models.Note()
            {
                Title = title,
                Content = content,
                UserId = userId
            };
            await noteValidator.ValidateAndThrowAsync(note);
            await noteRepository.Add(note);
        }

        public async Task Delete(int noteId)
        {
            await noteRepository.Delete(noteId);
        }

        public async Task Update(int noteId, string title, string content)
        {
            var allNotes = await noteRepository.GetAllNotes();
            var note = allNotes.FirstOrDefault(x => x.Id == noteId);

            note.Title = title;
            note.Content = content;

            await noteValidator.ValidateAndThrowAsync(note);
            await noteRepository.Update(note);
        }


        public async Task<DAL.Models.Note> GetById(int noteId)
        {
           return await noteRepository.GetById(noteId);
        }
       

        public async Task<List<DAL.Models.Note>> GetAllNotesByUserId(int userId)
        {
            return await noteRepository.GetAllNotesByUserId(userId);
        }

        public async Task<List<DAL.Models.Note>> GetAllNotes()
        {
            return await noteRepository.GetAllNotes();
        }
    }
}
