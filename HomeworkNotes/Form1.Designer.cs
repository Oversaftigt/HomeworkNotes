namespace HomeworkNotes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_teacher = new System.Windows.Forms.Label();
            this.lb_subject = new System.Windows.Forms.Label();
            this.MyNotes = new System.Windows.Forms.Label();
            this.tb_notes = new System.Windows.Forms.RichTextBox();
            this.button_changeNotes = new System.Windows.Forms.Button();
            this.rtb_importantNotes = new System.Windows.Forms.RichTextBox();
            this.lb_notes = new System.Windows.Forms.Label();
            this.lb_importantNotes = new System.Windows.Forms.Label();
            this.dgv_noter = new System.Windows.Forms.DataGridView();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dtp_filter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resetFilter = new System.Windows.Forms.Button();
            this.lectureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(39, 90);
            this.lb_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(33, 13);
            this.lb_date.TabIndex = 2;
            this.lb_date.Text = "Dato:";
            // 
            // lb_teacher
            // 
            this.lb_teacher.AutoSize = true;
            this.lb_teacher.Location = new System.Drawing.Point(36, 134);
            this.lb_teacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_teacher.Name = "lb_teacher";
            this.lb_teacher.Size = new System.Drawing.Size(38, 13);
            this.lb_teacher.TabIndex = 3;
            this.lb_teacher.Text = "Lærer:";
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Location = new System.Drawing.Point(36, 183);
            this.lb_subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(40, 13);
            this.lb_subject.TabIndex = 4;
            this.lb_subject.Text = "Emne: ";
            // 
            // MyNotes
            // 
            this.MyNotes.AutoSize = true;
            this.MyNotes.BackColor = System.Drawing.SystemColors.Control;
            this.MyNotes.Font = new System.Drawing.Font("Microsoft JhengHei", 15.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyNotes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MyNotes.Location = new System.Drawing.Point(33, 16);
            this.MyNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyNotes.Name = "MyNotes";
            this.MyNotes.Size = new System.Drawing.Size(125, 27);
            this.MyNotes.TabIndex = 5;
            this.MyNotes.Text = "Mine Noter";
            // 
            // tb_notes
            // 
            this.tb_notes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_notes.Location = new System.Drawing.Point(37, 262);
            this.tb_notes.Margin = new System.Windows.Forms.Padding(4);
            this.tb_notes.Name = "tb_notes";
            this.tb_notes.ReadOnly = true;
            this.tb_notes.Size = new System.Drawing.Size(475, 186);
            this.tb_notes.TabIndex = 7;
            this.tb_notes.Text = "";
            // 
            // button_changeNotes
            // 
            this.button_changeNotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_changeNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_changeNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changeNotes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_changeNotes.Image = ((System.Drawing.Image)(resources.GetObject("button_changeNotes.Image")));
            this.button_changeNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_changeNotes.Location = new System.Drawing.Point(37, 460);
            this.button_changeNotes.Margin = new System.Windows.Forms.Padding(4);
            this.button_changeNotes.Name = "button_changeNotes";
            this.button_changeNotes.Size = new System.Drawing.Size(686, 123);
            this.button_changeNotes.TabIndex = 8;
            this.button_changeNotes.Text = "Rediger noter";
            this.button_changeNotes.UseVisualStyleBackColor = false;
            this.button_changeNotes.Click += new System.EventHandler(this.button_changeNotes_Click);
            // 
            // rtb_importantNotes
            // 
            this.rtb_importantNotes.Location = new System.Drawing.Point(520, 262);
            this.rtb_importantNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_importantNotes.Name = "rtb_importantNotes";
            this.rtb_importantNotes.ReadOnly = true;
            this.rtb_importantNotes.Size = new System.Drawing.Size(203, 186);
            this.rtb_importantNotes.TabIndex = 9;
            this.rtb_importantNotes.Text = "";
            // 
            // lb_notes
            // 
            this.lb_notes.AutoSize = true;
            this.lb_notes.Location = new System.Drawing.Point(39, 235);
            this.lb_notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_notes.Name = "lb_notes";
            this.lb_notes.Size = new System.Drawing.Size(36, 13);
            this.lb_notes.TabIndex = 10;
            this.lb_notes.Text = "Noter:";
            this.lb_notes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_importantNotes
            // 
            this.lb_importantNotes.AutoSize = true;
            this.lb_importantNotes.Location = new System.Drawing.Point(517, 235);
            this.lb_importantNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_importantNotes.Name = "lb_importantNotes";
            this.lb_importantNotes.Size = new System.Drawing.Size(71, 13);
            this.lb_importantNotes.TabIndex = 11;
            this.lb_importantNotes.Text = "Vigtige Noter:";
            // 
            // dgv_noter
            // 
            this.dgv_noter.AutoGenerateColumns = false;
            this.dgv_noter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_noter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureDateDataGridViewTextBoxColumn,
            this.teachersNameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dgv_noter.DataSource = this.notesBindingSource;
            this.dgv_noter.Location = new System.Drawing.Point(733, 16);
            this.dgv_noter.Name = "dgv_noter";
            this.dgv_noter.RowHeadersWidth = 51;
            this.dgv_noter.RowTemplate.Height = 24;
            this.dgv_noter.Size = new System.Drawing.Size(409, 440);
            this.dgv_noter.TabIndex = 12;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(953, 519);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(87, 48);
            this.btn_filter.TabIndex = 13;
            this.btn_filter.Text = "Filtre";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dtp_filter
            // 
            this.dtp_filter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_filter.Location = new System.Drawing.Point(747, 545);
            this.dtp_filter.Name = "dtp_filter";
            this.dtp_filter.Size = new System.Drawing.Size(200, 19);
            this.dtp_filter.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtre noter efter dato her:";
            // 
            // btn_resetFilter
            // 
            this.btn_resetFilter.Location = new System.Drawing.Point(1047, 519);
            this.btn_resetFilter.Name = "btn_resetFilter";
            this.btn_resetFilter.Size = new System.Drawing.Size(95, 45);
            this.btn_resetFilter.TabIndex = 16;
            this.btn_resetFilter.Text = "Reset";
            this.btn_resetFilter.UseVisualStyleBackColor = true;
            this.btn_resetFilter.Click += new System.EventHandler(this.btn_resetFilter_Click);
            // 
            // lectureDateDataGridViewTextBoxColumn
            // 
            this.lectureDateDataGridViewTextBoxColumn.DataPropertyName = "lectureDate";
            this.lectureDateDataGridViewTextBoxColumn.HeaderText = "Dato";
            this.lectureDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureDateDataGridViewTextBoxColumn.Name = "lectureDateDataGridViewTextBoxColumn";
            this.lectureDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // teachersNameDataGridViewTextBoxColumn
            // 
            this.teachersNameDataGridViewTextBoxColumn.DataPropertyName = "teachersName";
            this.teachersNameDataGridViewTextBoxColumn.HeaderText = "Lærer";
            this.teachersNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teachersNameDataGridViewTextBoxColumn.Name = "teachersNameDataGridViewTextBoxColumn";
            this.teachersNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Emne";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesBindingSource
            // 
            this.notesBindingSource.DataSource = typeof(HomeworkNotes.Models.Notes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 598);
            this.Controls.Add(this.btn_resetFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dgv_noter);
            this.Controls.Add(this.lb_importantNotes);
            this.Controls.Add(this.lb_notes);
            this.Controls.Add(this.rtb_importantNotes);
            this.Controls.Add(this.button_changeNotes);
            this.Controls.Add(this.tb_notes);
            this.Controls.Add(this.MyNotes);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.lb_teacher);
            this.Controls.Add(this.lb_date);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_teacher;
        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.Label MyNotes;
        private System.Windows.Forms.RichTextBox tb_notes;
        private System.Windows.Forms.Button button_changeNotes;
        private System.Windows.Forms.RichTextBox rtb_importantNotes;
        private System.Windows.Forms.Label lb_notes;
        private System.Windows.Forms.Label lb_importantNotes;
        private System.Windows.Forms.DataGridView dgv_noter;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker dtp_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetFilter;
    }
}

