// Myrna Fierro
// COSC 2330 001
// Group Project Ex.1
// Date:  04/05/2016

// Group Project One:  Restaurant 

// Purpose:  
//  - Request input for number of tables 
//  - Assign a table 
//  - Assign number of people for a table
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFierroGroupProject_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Restaurant Project! ");
            SetTableSize someTableInfo = new SetTableSize();

            someTableInfo.AssignNumberOfTables();

            someTableInfo.AssignTableNumber();

            someTableInfo.AssignNumberOfSeatsToTable(assignTableNumber);

            Console.ReadKey();
            
        }


        public static int assignTableNumber { get; set; }
    }
}
