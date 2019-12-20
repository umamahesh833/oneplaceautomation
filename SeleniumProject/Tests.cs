using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class Tests
    {
        [Test]
        public void firsttest()
        {
            //Test1
            Console.WriteLine("Executing test 1");
        }


        [Test]
        [Category("L1")]
        public void Secondtest()
        {

            Console.WriteLine("Executing test 2");
        }

        [Test]
        public void VerifyLogin()
        {

            Console.WriteLine("VerifyLogin test");
        }


    }
}
