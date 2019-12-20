using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Tests
{
    class LoginTests
    {

        [Test]
        public void verifylogin()
        {
            helpers ObjHelpers = new helpers();
            Login ObjLoginpage = new Login();

            ObjHelpers.AppLaunch();
            ObjLoginpage.EnterUsername();
            ObjLoginpage.Enterpassword();
            ObjLoginpage.ClickOkButton();
          bool teststatus =  ObjLoginpage.VerifySuccessmessage();

            if (teststatus == true)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }



        }
    }
}
