using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WojciechLiebertLab2
{
    class Note
    {
        int index;
        double mark; //cannot name it "value" because of clarity issues
        String subject;
        DateTime date;
        [System.ComponentModel.DisplayName("Nr indeksu")]
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        [System.ComponentModel.DisplayName("Data")]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        [System.ComponentModel.DisplayName("Przedmiot")]
        public String Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        [System.ComponentModel.DisplayName("Ocena")]
        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
    }
}
