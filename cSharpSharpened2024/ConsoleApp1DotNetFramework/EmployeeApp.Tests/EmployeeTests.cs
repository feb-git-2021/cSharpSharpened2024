using EmployeeApp.HR;
using System;
using Xunit;

namespace EmployeeApp.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NoOfHours()
        {
            //Arrange
            Employee employee = new Employee("David", "Smith", "david@zensar.com", new DateTime(1992, 1, 20), 3, EmployeeType.Developer);
            int numberOfHours = 3;

            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours,employee.NoOfHrsWorked);
        }


        [Fact]
        public void PerformWork_Adds_DefaultNoOfHours_IfNoValueSpecified()
        {
            //Arrange
            Employee employee = new Employee("David", "Smith", "david@zensar.com", new DateTime(1992, 1, 20), 3, EmployeeType.Developer);
           

            //Act
            employee.PerformWork();

            //Assert
            Assert.Equal(0, employee.NoOfHrsWorked);


        }
    }
}