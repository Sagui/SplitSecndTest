using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using JQSelenium;
namespace SplitSecnd.AAT
{
  

    public class when_logging_in_purshase_page
    {
        //testing sjndjnfjfnjf 
         
        private Establish context =
            () =>
            {
                var driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("https://google.com/");
                var jqf = new JQuery(driver);
            };

        private Because of =
            () => { };

        private It should_log_in =
            () => { };
    }              
}
