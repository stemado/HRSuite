using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HRSuite.Business;

namespace HRSuite.Infrastructure
{
    public interface IPersonRepository
    {
        int SavePerson(Person person);
    }
}