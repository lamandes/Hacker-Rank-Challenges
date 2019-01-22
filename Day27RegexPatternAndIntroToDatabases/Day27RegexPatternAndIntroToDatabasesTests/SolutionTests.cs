using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day27RegexPatternAndIntroToDatabases;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27RegexPatternAndIntroToDatabases.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MainTest()
        {
            //Arrange data
            string testString1 = "a abc@abc.com";
            string testString2 = "z z@gmail.com";
            string testString3 = "t test@gmail.com";
            string[] test1 = testString1.Split(' ');
            string[] test2 = testString2.Split(' ');
            string[] test3 = testString3.Split(' ');
            string[] expected = { "t", "z" };
            Solution sol = new Solution();
            //Act
            sol.insertGmail(test1[0], test1[1]);
            sol.insertGmail(test2[0], test2[1]);
            sol.insertGmail(test3[0], test3[1]);
            sol.sort();
            //Assert
            //Assert.Equals or Assert.AreEqual will fail as it compare the object reference memory
            CollectionAssert.Equals(expected, sol.getArray().ToArray());
        }
    }
}