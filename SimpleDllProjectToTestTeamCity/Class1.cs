using System;

namespace SimpleDllProjectToTestTeamCity
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int AgeInDays
        {
            get { return (DateTime.Today - BirthDate).Days;  }
        }
    }
}
