using Corys.Nuget.Helper.Demo.Models;

namespace Corys.Nuget.Helper.Demo;
    public class HelperMethods
    {
        public HelperMethods()
        {
        }
        public string GetPersonDetailsWelcomer(int id, string name, int age, string occupation)
        {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException($"Occupatation cannot be empty or white space!");
        if (age < 18 || age > 80) throw new ArgumentException($"age is invalid, you cannot be younger to 18 to work here or over 85 as you should be retired");
        if (id < 100 || id > 999) throw new ArgumentException($"id is invalid, personale Id's start from 100 and cannot be greater than 999");
        if (string.IsNullOrEmpty(occupation)) throw new ArgumentException($"Occupatation cannot be empty or white space!");

        var personBuilder = new PersonModel(id, name, age, occupation);

        return $"Welcome {personBuilder.Name} our records show you are {personBuilder.Age} years old. and that you work here as a {personBuilder.Occupation}, your new Id is Id:{personBuilder.Id} so welcome to the team!";
        }
    }
