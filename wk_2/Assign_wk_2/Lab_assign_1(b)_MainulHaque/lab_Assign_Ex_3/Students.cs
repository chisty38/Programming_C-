using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_Assign_Ex_3
{
    class Students
    {
        public string Name { get; set; }
        public int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                    id = value;
                else
                    id = 0;
            }
        } // end property

        // constructor
        public Students( int i_d, string name)
        {
            Name = name;
            ID = i_d;
        }

        public override string ToString()
        {
            return String.Format("\nID: {0}, Name: {1}", ID, Name);
        }

    }
}
