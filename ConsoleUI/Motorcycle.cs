using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInheritance
{
    /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
           */
    public class Motorcycle : Vehicle
    {
       

        public Motorcycle()
        {
            Make = "Harley-Davidson";
            Model = "Road King";
            Year = 2021;
            HasSideCart = true;
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is now driving forward");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Morotcyle has overriden virtual to drive forward");
        }
    }
}
