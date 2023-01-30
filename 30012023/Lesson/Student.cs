using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student
    {
       public string FullName;
       protected byte _age=15;

       public byte Age
       {
            set
            {
                if (value >= 15)
                    _age = value;
            }
            get
            {
                return _age;
            }
       }
    }
}
