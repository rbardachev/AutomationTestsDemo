using OpenQA.Selenium;

using UnitTestProject.PageObjects;


namespace UnitTestProject.PageObjects
{
   public class BanerNavigation : BasePage
    {
        
        public BanerNavigation(IWebDriver driver) : base(driver)
        {
        }

        // Baner locators
        protected IWebElement ContactUsLink => Driver.FindElement(By.XPath("//*[@id='contact-link']"));
        protected IWebElement SignInLink => Driver.FindElement(By.XPath("//*[@class='login']"));

        // Baner actions
        public ContactUsPage GoToContactUsPage()
        {
            ContactUsLink.Click();
            return new ContactUsPage(Driver);
        }

        public SignInPage GoToSignInPage()
        {
            SignInLink.Click();
            return new SignInPage(Driver);
        }


    }
}
