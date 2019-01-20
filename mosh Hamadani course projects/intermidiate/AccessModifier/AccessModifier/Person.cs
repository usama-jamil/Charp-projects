using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessModifier
{
    class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
