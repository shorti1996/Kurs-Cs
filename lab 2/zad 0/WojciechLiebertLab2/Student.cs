using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WojciechLiebertLab2
{
    class Student
    {       
        String name;
        String surname;
        int index;
        List<Note> notesList = new List<Note>();

        [System.ComponentModel.DisplayName("Imię")]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [System.ComponentModel.DisplayName("Nazwisko")]
        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        [System.ComponentModel.DisplayName("Nr Indeksu")]
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        [System.ComponentModel.DisplayName("notesList")]
        public List<Note> NotesList
        {
            get { return notesList; }
            set { notesList = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student objAsStudent = obj as Student;
            if (objAsStudent == null) return false;
            else return Equals(objAsStudent);
        }

        public bool Equals(Student other)
        {
            if (other == null) return false;
            return (this.Index.Equals(other.Index));
        }

        public override int GetHashCode()
        {
            return Index;
        }
    }
}
