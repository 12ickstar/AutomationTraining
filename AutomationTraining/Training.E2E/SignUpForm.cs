using Bogus;
using System;

namespace Training.E2E
{
    public class SignUpForm
    {
        public SignUpForm(Faker faker)
        {
            Gender = (Gender)faker.Random.Number(1, 2);
            Password = faker.Internet.Password(10);
            DateOfBirth = faker.Person.DateOfBirth;
            FirstName = faker.Person.FirstName;
            LastName = faker.Person.LastName;
            Company = faker.Company.CompanyName();
            Address = faker.Person.Address.Street;
            Country = (Country)faker.Random.Number(1, 7);
            State = faker.Person.Address.State;
            ZipCode = faker.Person.Address.ZipCode;
            MobileNumber = faker.Person.Phone;
        }

        public Gender Gender { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string MobileNumber { get; set; }
    }

    public enum Gender
    { 
        Mr = 1,
        Mrs = 2
    }

    public enum Country
    { 
        India = 1,
        US = 2,
        CN = 3,
        AU = 4,
        Israel = 5,
        NZ = 6,
        SG = 7
    }
}