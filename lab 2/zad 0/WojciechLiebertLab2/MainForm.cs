using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WojciechLiebertLab2
{
    public partial class FormWojciechLiebert : Form
    {
        Note currentNote = new Note();
        Student currentStudent = new Student();
        bool editClicked = false;
        bool editNotesClicked = false;
        List<Note> emptyList = new List<Note>(); //for resetint
        List<Note> noteList = new List<Note>();
        List<Student> studentList = new List<Student>();
        int tempIndexOfOldStudentInStudentList = -1; //field used in buttonEdit_Click
        int tempOldStudentIndex = -1; //field used in buttonEdit_Click
         //whether student is currently edited or not

        public FormWojciechLiebert()
        {
            InitializeComponent();
        }

        private void FormWojciechLiebert_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Adds a new student to studentList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("studentList.GetEnumerator()= " + studentList.GetEnumerator().ToString());
            Debug.WriteLine("noteList.GetEnumerator()= " + noteList.GetEnumerator().ToString());
            Student student = new Student();
            ReadStudentData(student);
            int index;
            index = studentList.IndexOf(student);
            if (index != -1)
            {
                Debug.WriteLine("Cannot create student with already existing index number");
                return;
            }
            studentList.Add(student);
            RefreshDataGridViewStudents();
            Debug.WriteLine(student.GetHashCode() + " added");
        }

        /// <summary>
        /// Adds a new note to noteList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNotes_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotes.DataSource == null) return;
            if (dataGridViewStudents.SelectedRows.Count == 0) return;
            Note note = new Note();
            ReadNoteData(note);
            noteList.Add(note);
            Debug.WriteLine("note.GetHashCode= " + note.GetHashCode());
            Debug.WriteLine("dataGridViewNotes.Rows.Count= " + dataGridViewNotes.Rows.Count);
            RefreshDataGridViewNotes(currentStudent);
        }

        /// <summary>
        /// Deletes note from notesList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                student = GetStudentFromSelectedRow();
                Debug.WriteLine(student.Index);
                //Debug purposes
                foreach (Student s in studentList)
                {
                    Debug.WriteLine("> " + s.Equals(student));
                }
                studentList.Remove(student);
                RefreshDataGridViewStudents();
            }
        }

        /// <summary>
        /// Deletes a note from selected row in dataGridViewNotes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteNotes_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotes.SelectedRows.Count != 0)
            {
                Note note = new Note();
                note = (Note)dataGridViewNotes.SelectedRows[0].DataBoundItem;
                noteList.Remove(note);
                RefreshDataGridViewNotes(currentStudent);
            }
        }

        /// <summary>
        /// Edit student feature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            Student oldStudent = new Student();
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                //state-based solution
                if (editClicked == false)
                {
                    editClicked = true;
                    //disable controls so user cannot mess up with them
                    dataGridViewStudents.Enabled = false;
                    groupBoxNotes.Enabled = false;
                    //change button text so user can see what's happening
                    buttonEdit.Text = "Zapisz";
                    Debug.WriteLine("editClicked= " + editClicked);
                    //fill oldStudent with data from selected row
                    oldStudent = GetStudentFromSelectedRow();
                    //fill textboxes with data user will edit
                    FillStudentTextBoxes(oldStudent);
                    //set to further usage- uverwrite the same student in studentList
                    tempIndexOfOldStudentInStudentList = studentList.IndexOf(oldStudent);
                    Debug.WriteLine("oldStudent.Index= " + oldStudent.Index);
                    //sets current student (temp-like container)
                    currentStudent.NotesList = oldStudent.NotesList;
                    //to check if student already existed but should be overwritten anyways
                    tempOldStudentIndex = oldStudent.Index;
                }
                else
                {
                    //reenable controls
                    editClicked = false;
                    dataGridViewStudents.Enabled = true;
                    groupBoxNotes.Enabled = true;
                    buttonEdit.Text = "Edytuj";
                    Debug.WriteLine("editClicked= " + editClicked);
                    //if (oldStudent was on the list)
                    if (tempIndexOfOldStudentInStudentList != -1)
                    {
                        newStudent.Name = textBoxName.Text;
                        Debug.WriteLine("newStudent.Name= " + newStudent.Name);
                        newStudent.Surname = textBoxSurname.Text;
                        int indexTemp = 0;
                        Int32.TryParse(textBoxIndex.Text, out indexTemp);
                        newStudent.Index = indexTemp;
                        Debug.WriteLine("newStudent.Index= " + newStudent.Index);
                        Debug.WriteLine("tempOldStudentIndex= " + tempOldStudentIndex);
                        newStudent.NotesList = currentStudent.NotesList;
                        //change index numbers in noteList of student
                        foreach (Note note in newStudent.NotesList)
                        {
                            note.Index = newStudent.Index;
                        }
                        //if (newStudent is not present on the list or this is the same student but with changed fields)
                        if (studentList.IndexOf(newStudent) == -1 || tempOldStudentIndex == newStudent.Index)
                        {
                            studentList[tempIndexOfOldStudentInStudentList] = newStudent;
                            Debug.WriteLine("studentList[tempIndexOfOldStudentInStudentList].GetHashCode()= " + studentList[tempIndexOfOldStudentInStudentList].GetHashCode());
                            RefreshDataGridViewNotes(newStudent);
                            RefreshDataGridViewStudents();
                            tempIndexOfOldStudentInStudentList = -1;
                            tempOldStudentIndex = -1;
                        }
                        else
                        {
                            Debug.WriteLine("Student already exists");
                            RefreshDataGridViewNotes(newStudent);
                            RefreshDataGridViewStudents();
                            tempIndexOfOldStudentInStudentList = -1;
                            tempOldStudentIndex = -1;
                        }
                    }
                    RefreshDataGridViewStudents();
                }
            }
        }

        private void buttonEditNotes_Click(object sender, EventArgs e)
        {
            Note oldNote = new Note();
            Note newNote = new Note();
            if (dataGridViewNotes.SelectedRows.Count == 0) return;
            //state-based solution
            if (editNotesClicked == false)
            {
                //self-explainatory variables and methods
                editNotesClicked = true;
                groupBoxStudents.Enabled = false;
                oldNote = GetNoteFromSelectedRow();
                currentNote = oldNote;
                FillNoteTextBoxes(oldNote);
                buttonEditNotes.Text = "Zapisz";
            }
            else
            {
                //get note data from textboxes and refresh DataGridViewNotes
                editNotesClicked = false;
                groupBoxStudents.Enabled = true;
                newNote = currentNote;
                DateTime date;
                DateTime.TryParse(textBoxDate.Text, out date);
                newNote.Date = date;
                double mark;
                double.TryParse(textBoxNotes.Text, out mark);
                newNote.Mark = mark;
                newNote.Subject = textBoxSubject.Text;
                buttonEditNotes.Text = "Edytuj";
                RefreshDataGridViewNotes(currentStudent);
            }
        }

        private void CellClickNotes(object sender, DataGridViewCellEventArgs e)
        {
            GetNoteFromSelectedRow();
        }

        private void CellClickStudents(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataGridViewNotes();
        }

        /// <summary>
        /// Fills textboxes in groupBoxNotes with currently selected row in dataGridViewNotes
        /// </summary>
        private void FillNoteTextBoxes(Note note)
        {
            if (dataGridViewNotes.SelectedRows.Count != 0)
            {
                textBoxDate.Text = note.Date.ToString();
                textBoxSubject.Text = note.Subject;
                textBoxNotes.Text = note.Mark.ToString();
                textBoxIndexNotes.Text = note.Index.ToString();
            }
        }

        /// <summary>
        /// Fills textboxes in groupBoxStudents with currently selected row in dataGridViewStudents
        /// </summary>
        private void FillStudentTextBoxes(Student student)
        {
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                textBoxName.Text = student.Name;
                textBoxSurname.Text = student.Surname;
                textBoxIndex.Text = student.Index.ToString();
            }
        }

        private Note GetNoteFromSelectedRow(Note note)
        {
            if (dataGridViewNotes.SelectedRows.Count != 0)
            {
                note = (Note)dataGridViewNotes.SelectedRows[0].DataBoundItem;
            }

            return note;
        }

        private Note GetNoteFromSelectedRow()
        {
            Note note = new Note();
            if (dataGridViewNotes.SelectedRows.Count != 0)
            {
                note = (Note)dataGridViewNotes.SelectedRows[0].DataBoundItem;
                FillNoteTextBoxes(note);
            }

            return note;
        }

        /// <summary>
        /// Pobiera ze studentList dane istniejacego studenta
        /// </summary>
        /// <param name="student"></param>
        private void GetStudentData(Student student)
        {
            int id = studentList.IndexOf(student);
            Debug.WriteLine("id= " + id);
            if (id == -1)
            {
                Debug.WriteLine("No such student");
                return;
            }
            student.NotesList = studentList[id].NotesList;
            student.Name = studentList[id].Name;
            student.Surname = studentList[id].Surname;
        }

        private Student GetStudentFromSelectedRow()
        {
            Student student = new Student();
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                student = (Student)dataGridViewStudents.SelectedRows[0].DataBoundItem;
                FillStudentTextBoxes(student);
            }

            return student;
        }
        /// <summary>
        /// Loads data for dataGridViewNotes if possible
        /// </summary>
        private void LoadDataGridViewNotes()
        {
            try
            {
                currentStudent = GetStudentFromSelectedRow();
                noteList = currentStudent.NotesList;
                RefreshDataGridViewNotes(currentStudent);
                tempIndexOfOldStudentInStudentList = currentStudent.Index;
                //currentStudent = student;
                textBoxIndexNotes.Text = currentStudent.Index.ToString();
            }
            catch (Exception)
            {

                Debug.WriteLine("Couldn't load notes for this student");
            }
        }

        /// <summary>
        /// Pobiera dane z textBoxów oceny
        /// </summary>
        /// <param name="note"></param>
        private void ReadNoteData(Note note)
        {
            DateTime date = new DateTime();
            DateTime.TryParse(textBoxDate.Text, out date);
            Debug.WriteLine("date= " + date);
            note.Date = date;
            double mark;
            Double.TryParse(textBoxNotes.Text, out mark);
            note.Mark = mark;
            note.Subject = textBoxSubject.Text;
            int index;
            Int32.TryParse(textBoxIndexNotes.Text, out index);
            note.Index = index;
        }

        /// <summary>
        /// Pobiera dane z textBoxów Studenta
        /// </summary>
        /// <param name="student"></param>
        private void ReadStudentData(Student student)
        {
            student.Name = textBoxName.Text;
            student.Surname = textBoxSurname.Text;
            int index;
            Int32.TryParse(textBoxIndex.Text, out index);
            student.Index = index;
        }
        /// <summary>
        /// Refreshes dataGridViewNotes for specified student or resets to null
        /// </summary>
        private void RefreshDataGridViewNotes(Student student)
        {
            dataGridViewNotes.DataSource = null;
            dataGridViewNotes.DataSource = student.NotesList;
            Debug.WriteLine("dataGridViewNotes refreshed, dataGridViewNotes.Rows.Count= " + dataGridViewNotes.Rows.Count);
        }

        private void RefreshDataGridViewNotes()
        {
            dataGridViewNotes.Refresh();
            dataGridViewNotes.DataSource = null;
        }

        /// <summary>
        /// Odświeża DataGridViewStudents
        /// </summary>
        private void RefreshDataGridViewStudents()
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = studentList;
        }

        private void RowHeaderMouseClickStudents(object sender, EventArgs e)
        {
            LoadDataGridViewNotes();
        }
    }
}
