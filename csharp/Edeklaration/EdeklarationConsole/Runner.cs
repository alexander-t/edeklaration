using System;
using System.Globalization;
using System.Threading;

namespace Crisp.Tdd.Edeklaration
{
    /**
     * If you keep this class and project as is, there's no need to adjust the end-to-end test.
     */
    public class Runner
    {
        private static void Main(string[] args)
        {
            // To avoid locale issues. Feel free to change.
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("sv-SE");
            Console.Out.WriteLine("Final tax: {0:C2}", Double.Parse(args[0]));
        }
    }
}
