using HomeworkNotes.Models;
using HomeworkNotes.Services;
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
    public partial class Form1 : Form
    {
        public BindingList<Notes> CollectionOfNotes;
        public HomeworkServices HomeworkServices;
        public Notes MyNote;
        public Form1()
        {
            MyNote = new Notes("Per", "Database");
            HomeworkServices = new HomeworkServices();
            InitializeComponent();
            dgv_noter.DataSource = HomeworkServices.GenerateDummyData();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            ShowNotes();
        }

        private void ShowNotes()
        {
            lb_date.Text = "Dato: " + MyNote.lectureDate.ToString("dd" + ". " + "MMMM yyyy");
            lb_teacher.Text = "Lærer: " + MyNote.teachersName;
            lb_subject.Text = "Emne: " + MyNote.subject;
            tb_notes.Text = MyNote.notes;
            rtb_importantNotes.Text = MyNote.importantNotes;
        }

        private void ShowEditForm()
        {
            Form changeNotes = new Form2(MyNote);
            changeNotes.ShowDialog();
            ShowNotes();
        }

        private void button_changeNotes_Click(object sender, EventArgs e)
        {
            ShowEditForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
           dgv_noter.DataSource = HomeworkServices.FilterNotes(dtp_filter.Value.Date);
        }

        private void btn_resetFilter_Click(object sender, EventArgs e)
        {
            dgv_noter.DataSource = HomeworkServices.GenerateDummyData();
        }
    }
}
