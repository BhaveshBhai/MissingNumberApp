using MissingNumberApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberApp.Services
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void WriteOutput(IEnumerable<int> missingNumbers)
        {
            if (!missingNumbers.Any())
                Console.WriteLine("No missing numbers.");
            else
                Console.WriteLine("Missing numbers: " + string.Join(", ", missingNumbers));
        }
    }
}
