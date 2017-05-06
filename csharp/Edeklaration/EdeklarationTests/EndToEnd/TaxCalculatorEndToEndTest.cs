using System.IO;
using Crisp.Tdd.EdeklarationTests.EndToEnd.Util;
using NUnit.Framework;

namespace Crisp.Tdd.EdeklarationTests.EndToEnd
{
    [TestFixture]
    public class TaxCalculatorEndToEndTest
    {
        // NOTE! This method works if you run the test in the EdeklarationTests\bin\Debug directory.
        // It won't run correctly from Visual Studio or another directory, and is included
        // for inspirational purposes.
        private string GetTestedExe()
        {
            return Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                "EdeklarationConsole\\bin\\Debug\\EdeklarationConsole.exe");
        }

        [Test]
        public void NoIncomeNoTax()
        {
            var executor = new SimpleOsCommandExecutor(GetTestedExe(), "0 Stockholm");
            executor.Run();
            Assert.AreEqual("Final tax: 0,00 kr", executor.Stdout[0]);
        }

        [Test]
        public void IsTestedBinaryPresent()
        {
            Assert.IsTrue(File.Exists(GetTestedExe()));
        }
    }
}