using HomeworkNotes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNotes.Services
{
    public class HomeworkServices
    {
        public BindingList<Notes> CollectionOfNotes;

        public BindingList<Notes> GenerateDummyData()
        {
            var result = new BindingList<Notes>();

            var note1 = new Notes("Lasse", "Programmering");
            var note2 = new Notes("Per", "Database");
            var note3 = new Notes("Henrik", "Virksomhed");
            note1.lectureDate = DateTime.Today.AddDays(3);
            note2.lectureDate = DateTime.Today;
            note3.lectureDate = DateTime.Today;
            result.Add(note1);
            result.Add(note2);
            CollectionOfNotes = result;

            return result;
        }

        public BindingList<Notes> FilterNotes(DateTime date)
        {
            var result = GenerateDummyData().Where(s => s.lectureDate == date);
            var bindinglist = new BindingList<Notes>();
            
            foreach (var note in result.ToList())
            {
                bindinglist.Add(note);
            }
            return bindinglist;
        }
        //public BindingList<Notes> AddNewNote()
        //{

        //    return ;
        //}
    }
}
