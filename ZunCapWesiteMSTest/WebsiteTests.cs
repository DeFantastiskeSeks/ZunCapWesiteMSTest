using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZunCapWesiteMSTest
{
    [TestClass]
    public class WebsiteTests
    {
        private static readonly string DriverDirectory = "C:\\WebDrivers";
        private readonly string _url = "https://kind-river-00f606f03.3.azurestaticapps.net";
        private static IWebDriver? _driver;

        [ClassInitialize]
        public static void init(TestContext context)
        {
            //_driver = new FirefoxDriver(DriverDirectory);
            _driver = new ChromeDriver(DriverDirectory);
        }

        [ClassCleanup]
        public static void cleanup()
        {
            _driver!.Dispose();
        }

        [TestMethod]
        public void HudtypeOgResultatIsNotNullTest()
        {
            _driver!.Navigate().GoToUrl(_url);

            IWebElement submitbtn = _driver.FindElement(By.Name("submitbtn"));
            IWebElement hudtyperesult = _driver.FindElement(By.Name("hudtypeResultat"));
            IWebElement hudtype = _driver.FindElement(By.Name("hudtype"));

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.IsNotNull(hudtyperesult.Text);
            Assert.IsNotNull(hudtype.Text);
        }

        [TestMethod]
        public void Hudtype_1_Test()
        {
            _driver!.Navigate().GoToUrl(_url);

            SelectElement nuancelist = new SelectElement(_driver.FindElement(By.Name("nuance")));
            SelectElement skoldetlist = new SelectElement(_driver.FindElement(By.Name("skoldet")));
            SelectElement brunlist = new SelectElement(_driver.FindElement(By.Name("brun")));
            SelectElement hårfarvelist = new SelectElement(_driver.FindElement(By.Name("hårfarve")));
            SelectElement øjenfarvelist = new SelectElement(_driver.FindElement(By.Name("øjenfarve")));
            SelectElement fregnerlist = new SelectElement(_driver.FindElement(By.Name("fregner")));
            IWebElement submitbtn = _driver.FindElement(By.Name("submitbtn"));
            IWebElement hudtyperesult = _driver.FindElement(By.Name("hudtypeResultat"));
            IWebElement hudtype = _driver.FindElement(By.Name("hudtype"));

            nuancelist.SelectByValue("0");
            skoldetlist.SelectByValue("0");
            brunlist.SelectByValue("0");
            hårfarvelist.SelectByValue("0");
            øjenfarvelist.SelectByValue("0");
            fregnerlist.SelectByValue("0");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("0", hudtyperesult.Text);
            Assert.AreEqual("1", hudtype.Text);

            nuancelist.SelectByValue("3");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("3", hudtyperesult.Text);
            Assert.AreEqual("1", hudtype.Text);
        }

        [TestMethod]
        public void Hudtype_2_Test()
        {
            _driver!.Navigate().GoToUrl(_url);

            SelectElement nuancelist = new SelectElement(_driver.FindElement(By.Name("nuance")));
            SelectElement skoldetlist = new SelectElement(_driver.FindElement(By.Name("skoldet")));
            SelectElement brunlist = new SelectElement(_driver.FindElement(By.Name("brun")));
            SelectElement hårfarvelist = new SelectElement(_driver.FindElement(By.Name("hårfarve")));
            SelectElement øjenfarvelist = new SelectElement(_driver.FindElement(By.Name("øjenfarve")));
            SelectElement fregnerlist = new SelectElement(_driver.FindElement(By.Name("fregner")));
            IWebElement submitbtn = _driver.FindElement(By.Name("submitbtn"));
            IWebElement hudtyperesult = _driver.FindElement(By.Name("hudtypeResultat"));
            IWebElement hudtype = _driver.FindElement(By.Name("hudtype"));

            nuancelist.SelectByValue("0");
            skoldetlist.SelectByValue("2");
            brunlist.SelectByValue("2");
            hårfarvelist.SelectByValue("0");
            øjenfarvelist.SelectByValue("0");
            fregnerlist.SelectByValue("0");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("4", hudtyperesult.Text);
            Assert.AreEqual("2", hudtype.Text);

            nuancelist.SelectByValue("3");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("7", hudtyperesult.Text);
            Assert.AreEqual("2", hudtype.Text);
        }

        [TestMethod]
        public void Hudtype_3_Test()
        {
            _driver!.Navigate().GoToUrl(_url);

            SelectElement nuancelist = new SelectElement(_driver.FindElement(By.Name("nuance")));
            SelectElement skoldetlist = new SelectElement(_driver.FindElement(By.Name("skoldet")));
            SelectElement brunlist = new SelectElement(_driver.FindElement(By.Name("brun")));
            SelectElement hårfarvelist = new SelectElement(_driver.FindElement(By.Name("hårfarve")));
            SelectElement øjenfarvelist = new SelectElement(_driver.FindElement(By.Name("øjenfarve")));
            SelectElement fregnerlist = new SelectElement(_driver.FindElement(By.Name("fregner")));
            IWebElement submitbtn = _driver.FindElement(By.Name("submitbtn"));
            IWebElement hudtyperesult = _driver.FindElement(By.Name("hudtypeResultat"));
            IWebElement hudtype = _driver.FindElement(By.Name("hudtype"));

            nuancelist.SelectByValue("0");
            skoldetlist.SelectByValue("2");
            brunlist.SelectByValue("2");
            hårfarvelist.SelectByValue("2");
            øjenfarvelist.SelectByValue("2");
            fregnerlist.SelectByValue("0");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("8", hudtyperesult.Text);
            Assert.AreEqual("3", hudtype.Text);

            nuancelist.SelectByValue("3");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("11", hudtyperesult.Text);
            Assert.AreEqual("3", hudtype.Text);
        }

        [TestMethod]
        public void Hudtype_4_Test()
        {
            _driver!.Navigate().GoToUrl(_url);

            SelectElement nuancelist = new SelectElement(_driver.FindElement(By.Name("nuance")));
            SelectElement skoldetlist = new SelectElement(_driver.FindElement(By.Name("skoldet")));
            SelectElement brunlist = new SelectElement(_driver.FindElement(By.Name("brun")));
            SelectElement hårfarvelist = new SelectElement(_driver.FindElement(By.Name("hårfarve")));
            SelectElement øjenfarvelist = new SelectElement(_driver.FindElement(By.Name("øjenfarve")));
            SelectElement fregnerlist = new SelectElement(_driver.FindElement(By.Name("fregner")));
            IWebElement submitbtn = _driver.FindElement(By.Name("submitbtn"));
            IWebElement hudtyperesult = _driver.FindElement(By.Name("hudtypeResultat"));
            IWebElement hudtype = _driver.FindElement(By.Name("hudtype"));

            nuancelist.SelectByValue("0");
            skoldetlist.SelectByValue("3");
            brunlist.SelectByValue("3");
            hårfarvelist.SelectByValue("2");
            øjenfarvelist.SelectByValue("2");
            fregnerlist.SelectByValue("2");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("12", hudtyperesult.Text);
            Assert.AreEqual("4", hudtype.Text);

            nuancelist.SelectByValue("2");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("14", hudtyperesult.Text);
            Assert.AreEqual("4", hudtype.Text);
        }

        [TestMethod]
        public void Hudtype_5_Test()
        {
            _driver!.Navigate().GoToUrl(_url);

            SelectElement nuancelist = new SelectElement(_driver.FindElement(By.Name("nuance")));
            SelectElement skoldetlist = new SelectElement(_driver.FindElement(By.Name("skoldet")));
            SelectElement brunlist = new SelectElement(_driver.FindElement(By.Name("brun")));
            SelectElement hårfarvelist = new SelectElement(_driver.FindElement(By.Name("hårfarve")));
            SelectElement øjenfarvelist = new SelectElement(_driver.FindElement(By.Name("øjenfarve")));
            SelectElement fregnerlist = new SelectElement(_driver.FindElement(By.Name("fregner")));
            IWebElement submitbtn = _driver.FindElement(By.Name("submitbtn"));
            IWebElement hudtyperesult = _driver.FindElement(By.Name("hudtypeResultat"));
            IWebElement hudtype = _driver.FindElement(By.Name("hudtype"));

            nuancelist.SelectByValue("3");
            skoldetlist.SelectByValue("3");
            brunlist.SelectByValue("3");
            hårfarvelist.SelectByValue("2");
            øjenfarvelist.SelectByValue("2");
            fregnerlist.SelectByValue("2");

            submitbtn.Click();

            Console.WriteLine(hudtyperesult.Text);
            Console.WriteLine("Hudtype-" + hudtype.Text);
            Assert.AreEqual("15", hudtyperesult.Text);
            Assert.AreEqual("5", hudtype.Text);
        }

        [TestMethod]
        public void Notify_Test()
        {
            _driver.Navigate().GoToUrl("http://localhost:5173/userUV");







            WebDriverWait driverWait = new(_driver, TimeSpan.FromSeconds(10));

            _driver.SwitchTo().Alert().Accept();
            
            IAlert alert = driverWait.Until(ExpectedConditions.AlertIsPresent());
            Assert.AreEqual("Du har modtaget den anbefalede mængde UV", alert.Text);



        }
    }
}