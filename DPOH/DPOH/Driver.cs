// <copyright file="Driver.cs" company="engi">
// The driver for the whole project.  Runs the DatabaseAccess methods.
// </copyright>
namespace DPOH
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Main driver, executes the various DatabaseAccess methods.
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Main method of driver.  Drives the DatabaseAccess class
        /// </summary>
        /// <param name="args">args are not used.</param>
        public static void Main(string[] args)
        {
            Tuple<long, double> temp = DatabaseAccess.RowCountAndExecutionTime(false); // non-indexed table
            Console.WriteLine("Non-indexed row count: " + temp.Item1 + " and execution time: " + temp.Item2 + "ms");

            temp = DatabaseAccess.RowCountAndExecutionTime(true); // indexed table
            Console.WriteLine("Indexed row count: " + temp.Item1 + " and execution time: " + temp.Item2 + "ms");

            Console.WriteLine("\n\nThe non-indexed execution plan is:\n\n" + DatabaseAccess.GetSelectQueryPlan(false));

            Console.WriteLine("\n\nThe indexed execution plan is:\n\n" + DatabaseAccess.GetSelectQueryPlan(true));

            Console.ReadLine();
        }
    }
}
