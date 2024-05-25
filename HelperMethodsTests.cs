using Corys.Nuget.Helper.Demo;
using FluentAssertions;
using System;
using Xunit;

namespace HelperUnitTests
{
    public class HelperMethodsTests
    {
        [Theory]
        [InlineData(100, "Cory", 38, "Tester")]
        [InlineData(101, "Cory", 38, "Tester")]
        [InlineData(102, "Tom", 80, "Tester")]
        [InlineData(103, "Bob", 18, "Tester")]
        [InlineData(999, "Bob", 18, "Tester")]
        [InlineData(100, "a very very veryveryveryveryveryveryveryveryveryveryveryveryveryveryvery long name", 20, "a very very veryveryveryveryveryveryveryveryveryveryveryveryveryveryvery long job title")]
        public void HappyPath_Returns_A_Good_Welcome(int id, string name, int age, string job)
        {
            //arrange
            string expected = $"Welcome {name} our records show you are {age} years old. and that you work here as a {job}, your new Id is Id:{id} so welcome to the team!";
            var helper = new HelperMethods();
            //act 
            string result = helper.GetPersonDetailsWelcomer(id, name, age, job);
            //assert
            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(101, "", 38, "Tester")]
        [InlineData(102, "Tom", 85, "")]
        [InlineData(103, "", 18, "")]
        [InlineData(104, "Tom", 17, "Developer")]
        [InlineData(105, "Tom", 86, "Developer")]
        [InlineData(1, "Tom", 20, "Developer")]
        [InlineData(99, "Tom", 20, "Developer")]
        [InlineData(50, "Tom", 20, "Developer")]
        [InlineData(1000, "Tom", 20, "Developer")]
        [InlineData(10000, "Tom", 20, "Developer")]

        public void SadPath_Exceptions_Are_Thrown(int id, string name, int age, string job)
        {
            //arrange
            string expected = $"Welcome {name} our records show you are {age} years old. and that you work here as a {job}, your new Id is Id:{id} so welcome to the team!";
            var helper = new HelperMethods();
            //act & assert
            helper.Invoking(x => x.GetPersonDetailsWelcomer(id, name, age, job)).Should().Throw<ArgumentException>();
        }
    }
}