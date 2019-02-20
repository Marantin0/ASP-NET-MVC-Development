using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTesting
{
    public class SolObject
    {
        public SolObject()
        {
            fName = "George";
            sName = "Michael";
        }

        public SolObject(string fiName, string suName)
        {
            fName = fiName;
            sName = suName;

        }

        string fName = "Insert First Name";
        string sName = "Insert Surname";

        public string FirstName()
        {
            return fName;
        }

        public string Surname()
        {
            return sName;
        }
    }
}
