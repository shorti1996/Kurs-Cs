using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public class MapObject
    {
        internal class NoPositionDefinedException : Exception
        {
            public NoPositionDefinedException() : base() { }
            public NoPositionDefinedException(string message) : base(message) { }
            public NoPositionDefinedException(string message, Exception exception) : base(message, exception) { }
        }

        private string name;
        private bool destroyable;
        private bool passThrough;
        private bool deadly;
        private int x;
        private int y;
        private Panel correspondingPanel;

        private Panel panel;
        private Map map;
        private Form form;

        /*public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void MapObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("A property has changed: " + e.PropertyName);
        }*/


        #region Encapsulated fields
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool Destroyable
        {
            get { return destroyable; }
            set { destroyable = value; }
        }

        public bool PassThrough
        {
            get { return passThrough; }
            set { passThrough = value; }
        }

        public bool Deadly
        {
            get { return deadly; }
            set { deadly = value; }
        }

        public Panel CorrespondingPanel
        {
            get
            {
                return correspondingPanel;
            }

            set
            {
                correspondingPanel = value;
            }
        }

        public Panel Panel
        {
            get
            {
                return panel;
            }

            set
            {
                panel = value;
            }
        }

        public Map Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public Form Form
        {
            get
            {
                return form;
            }

            set
            {
                form = value;
            }
        }
        #endregion

        public MapObject()
        {
            NoPositionDefinedException exception
                = new NoPositionDefinedException("No position defined. Cannot create MapObject");
            throw exception;
        }

        public MapObject(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public MapObject(int x, int y, ref Map map, ref Form form, ref Panel panel)
        {
            this.x = x;
            this.y = y;
            this.Map = map;
            this.Form = form;
            this.Panel = panel;
        }

    }
}
