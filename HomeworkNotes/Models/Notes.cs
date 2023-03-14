using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNotes.Models
{
    public class Notes
    {
        public DateTime lectureDate { get; set; }
        public string teachersName { get; set; }
        public string subject { get; set; }
        public string notes { get; set; }
        public string importantNotes { get; set; }
        public Notes(string teachersName, string subject)
        {
            this.lectureDate = DateTime.Today;
            this.teachersName = teachersName;
            this.subject = subject;
            this.notes = "";
            this.importantNotes = "";
        }


    }
}
