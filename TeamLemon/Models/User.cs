using System;
using System.Collections.Generic;
using System.Text;

namespace TeamLemon.Models
{
    public class User : Person
    {
        Dictionary<int, Person> AllPersons = new Dictionary<int, Person>();
    }
}
