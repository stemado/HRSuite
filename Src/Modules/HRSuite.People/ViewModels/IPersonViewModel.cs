using System;
using HRSuite.Infrastructure;

namespace HRSuite.People
{
    public interface IPersonViewModel : IViewModel
    {
        void CreatePerson(string firstName, string lastName);
    }
}
