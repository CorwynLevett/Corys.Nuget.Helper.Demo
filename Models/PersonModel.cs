namespace Corys.Nuget.Helper.Demo.Models;
internal class PersonModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Occupation { get; set; }

        public PersonModel(int id, string name, int age, string occupation)
        {
            Id = id;
            Name = name;
            Age = age;
            Occupation = occupation;
        }
    }
