using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //Arrange
          var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

            //Act
          var result = book.GetStatistics();


            //Assert 
           Assert.Equal(85.6, result.Average, 1);
           Assert.Equal(90.5, result.High, 1);
           Assert.Equal(77.3, result.Low, 1);
        Assert.Equal('B', result.Letter);
        }
    }
}
