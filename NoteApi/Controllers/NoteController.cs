using Microsoft.AspNetCore.Mvc;
using Note.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {   
        private readonly INoteService noteService;

        public NoteController(INoteService noteService)
        {
            this.noteService = noteService;
        }

        [HttpGet]
        public async Task<Note.DAL.Models.Note> GetNoteById(int id)
        {
            return await noteService.GetById(id);
        }

        [HttpPost]
        public async Task<IActionResult> AddNote(string title, string content, int userId)
        {
            await noteService.AddNote(title, content, userId);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteNote(int id)
        {
            await noteService.Delete(id);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("AllNotes")]
        public async Task<List<Note.DAL.Models.Note>> GetAllNotes()
        {
            return await noteService.GetAllNotes();
        }

        [HttpGet("AllNotesByUserId")]
        public async Task<List<Note.DAL.Models.Note>> GetAllNotesByUserId(int id)
        {
            return await noteService.GetAllNotesByUserId(id);
        }


    }
}
