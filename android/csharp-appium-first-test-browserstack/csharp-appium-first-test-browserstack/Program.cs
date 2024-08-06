using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using OpenQA.Selenium.Appium.Interactions;
using static HarmonyLib.Code;
using System.Xml.Linq;
//using OpenQA.Selenium.Appium.MobileBy
namespace csharp_appium_first_test_browserstack
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
      browserstackOptions.Add("userName", "<username>");
      browserstackOptions.Add("accessKey", "<accessKey>");
      browserstackOptions.Add("appiumVersion", "2.6.0");
      browserstackOptions.Add("buildName", "TapClickAction");
      browserstackOptions.Add("interactiveDebugging", "true");
      browserstackOptions.Add("geoLocation", "US");
      AppiumOptions caps = new AppiumOptions();
      caps.AddAdditionalAppiumOption("bstack:options", browserstackOptions);
      caps.PlatformName = "android";
      caps.PlatformVersion = "12.0";
      caps.DeviceName = "Samsung Galaxy S22 Ultra";
      caps.App = "bs://22d05e18ee1fce3f531802a7f28490e8dc550cb0";
      AppiumDriver driver = new AndroidDriver(
          new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
      Thread.Sleep(10000);
      var element= driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text='Log in with your DraftKings account']"));
      var actions = new Actions(driver);
      // Perform the click action
      actions.MoveToElement(element).Click().Perform();
      Thread.Sleep(5000);
      driver.Quit();
    }
  }
}
