
using Machine.Specifications;
using OpenQA.Selenium.Firefox;
using JQSelenium;
namespace SplitSecnd.AAT
{
  

    public class when_logging_in_purshase_page
    {
       
         
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
