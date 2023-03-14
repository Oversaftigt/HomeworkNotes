namespace HomeworkNotes
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tb_notes = new System.Windows.Forms.RichTextBox();
            this.tb_teacher = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.forms2Dato = new System.Windows.Forms.Label();
            this.forms2Lærer = new System.Windows.Forms.Label();
            this.forms2Emne = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.button_saveNotes = new System.Windows.Forms.Button();
            this.lb_notesEditForm = new System.Windows.Forms.Label();
            this.lb_importantNotesEditForm = new System.Windows.Forms.Label();
            this.rtb_importantNotesEditForm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_notes
            // 
            this.tb_notes.Location = new System.Drawing.Point(12, 268);
            this.tb_notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.Size = new System.Drawing.Size(372, 145);
            this.tb_notes.TabIndex = 0;
            this.tb_notes.Text = "";
            // 
            // tb_teacher
            // 
            this.tb_teacher.Location = new System.Drawing.Point(91, 126);
            this.tb_teacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_teacher.Name = "tb_teacher";
            this.tb_teacher.Size = new System.Drawing.Size(215, 22);
            this.tb_teacher.TabIndex = 2;
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(91, 187);
            this.tb_subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(215, 22);
            this.tb_subject.TabIndex = 3;
            // 
            // forms2Dato
            // 
            this.forms2Dato.AutoSize = true;
            this.forms2Dato.Location = new System.Drawing.Point(12, 69);
            this.forms2Dato.Name = "forms2Dato";
            this.forms2Dato.Size = new System.Drawing.Size(39, 16);
            this.forms2Dato.TabIndex = 4;
            this.forms2Dato.Text = "Dato:";
            // 
            // forms2Lærer
            // 
            this.forms2Lærer.AutoSize = true;
            this.forms2Lærer.Location = new System.Drawing.Point(12, 130);
            this.forms2Lærer.Name = "forms2Lærer";
            this.forms2Lærer.Size = new System.Drawing.Size(46, 16);
            this.forms2Lærer.TabIndex = 5;
            this.forms2Lærer.Text = "Lærer:";
            // 
            // forms2Emne
            // 
            this.forms2Emne.AutoSize = true;
            this.forms2Emne.Location = new System.Drawing.Point(12, 190);
            this.forms2Emne.Name = "forms2Emne";
            this.forms2Emne.Size = new System.Drawing.Size(45, 16);
            this.forms2Emne.TabIndex = 6;
            this.forms2Emne.Text = "Emne:";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(91, 63);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 22);
            this.dtp_date.TabIndex = 8;
            // 
            // button_saveNotes
            // 
            this.button_saveNotes.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saveNotes.Location = new System.Drawing.Point(13, 419);
            this.button_saveNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_saveNotes.Name = "button_saveNotes";
            this.button_saveNotes.Size = new System.Drawing.Size(143, 112);
            this.button_saveNotes.TabIndex = 9;
            this.button_saveNotes.Text = "Gem og luk";
            this.button_saveNotes.UseVisualStyleBackColor = true;
            this.button_saveNotes.Click += new System.EventHandler(this.button_saveNotes_Click);
            // 
            // lb_notesEditForm
            // 
            this.lb_notesEditForm.AutoSize = true;
            this.lb_notesEditForm.Location = new System.Drawing.Point(14, 242);
            this.lb_notesEditForm.Name = "lb_notesEditForm";
            this.lb_notesEditForm.Size = new System.Drawing.Size(40, 16);
            this.lb_notesEditForm.TabIndex = 10;
            this.lb_notesEditForm.Text = "Noter";
            // 
            // lb_importantNotesEditForm
            // 
            this.lb_importantNotesEditForm.AutoSize = true;
            this.lb_importantNotesEditForm.Location = new System.Drawing.Point(392, 242);
            this.lb_importantNotesEditForm.Name = "lb_importantNotesEditForm";
            this.lb_importantNotesEditForm.Size = new System.Drawing.Size(85, 16);
            this.lb_importantNotesEditForm.TabIndex = 11;
            this.lb_importantNotesEditForm.Text = "Vigtige Noter";
            this.lb_importantNotesEditForm.Click += new System.EventHandler(this.label2_Click);
            // 
            // rtb_importantNotesEditForm
            // 
            this.rtb_importantNotesEditForm.Location = new System.Drawing.Point(395, 268);
            this.rtb_importantNotesEditForm.Name = "rtb_importantNotesEditForm";
            this.rtb_importantNotesEditForm.Size = new System.Drawing.Size(198, 145);
            this.rtb_importantNotesEditForm.TabIndex = 12;
            this.rtb_importantNotesEditForm.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(887, 544);
            this.Controls.Add(this.rtb_importantNotesEditForm);
            this.Controls.Add(this.lb_importantNotesEditForm);
            this.Controls.Add(this.lb_notesEditForm);
            this.Controls.Add(this.button_saveNotes);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.forms2Emne);
            this.Controls.Add(this.forms2Lærer);
            this.Controls.Add(this.forms2Dato);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.tb_teacher);
            this.Controls.Add(this.tb_notes);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_notes;
        private System.Windows.Forms.TextBox tb_teacher;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label forms2Dato;
        private System.Windows.Forms.Label forms2Lærer;
        private System.Windows.Forms.Label forms2Emne;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button button_saveNotes;
        private System.Windows.Forms.Label lb_notesEditForm;
        private System.Windows.Forms.Label lb_importantNotesEditForm;
        private System.Windows.Forms.RichTextBox rtb_importantNotesEditForm;
    }
}