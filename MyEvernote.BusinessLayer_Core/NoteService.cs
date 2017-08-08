using System.Collections.Generic;
using System.Linq;
using MyEvernote.Common;
using MyEvernote.DataAccessLayer_Infastructure.EntityFramework;

namespace MyEvernote.BusinessLayer_Core
{
    public class NoteService
    {
        private readonly Reporsitory<Note> noteReporsitory = new Reporsitory<Note>();

        public List<Note> GetNotes()
        {
            return noteReporsitory.List();
        }
        public List<Note> GetNoteswithOrderByDesc()
        {
            return noteReporsitory.ListQueryable().OrderByDescending(p=>p.ModifiedOn).ToList();
        }
    }
}
