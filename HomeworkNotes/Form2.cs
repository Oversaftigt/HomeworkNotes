using HomeworkNotes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkNotes
{
    public partial class Form2 : Form
    {
        public Notes MyNote;
        public Form2(Notes myNote)
        {
            InitializeComponent();
            MyNote = myNote;

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            ShowNotes();
        }

        private void ShowNotes()
        {
            dtp_date.Text = MyNote.lectureDate.ToString("dd" + ". " + "MMMM yyyy");
            tb_teacher.Text = MyNote.teachersName;
            tb_subject.Text = MyNote.subject;
            tb_notes.Text = MyNote.notes;
            rtb_importantNotesEditForm.Text = MyNote.importantNotes;
        }

        private void SaveNotes()
        {
            MyNote.lectureDate = dtp_date.Value.Date;
            MyNote.teachersName = tb_teacher.Text;
            MyNote.subject = tb_subject.Text;
            MyNote.notes = tb_notes.Text;
            MyNote.importantNotes = rtb_importantNotesEditForm.Text;

            this.Close();
        }

        private void button_saveNotes_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
