---
layout: blogdraft
title: Workshop Selenium, Selendroid and ios-driver Mobile and Web Automation Using One API and One Infrastructure (Michael Palotas)
tags: [Mobile App Europe 2014, Mobile Apps, Selenium, WebDriver, Test Automation]
---

Mobile App Europe 2014 Notes

Workshop Selenium, Selendroid and ios-driver: Mobile and Web Automation Using One API and One Infrastructure
===
Notes on a [workshop](http://mobileappeurope.com/talks/selenium-selendroid-and-ios-driver-mobile-and-web-automation-using-one-api-and-one-infrastructure/ "Workshop Selenium, Selendroid and ios-driver: Mobile and Web Automation Using One API and One Infrastructure")
by Michael Palotas (Gridfusion, eBay)
at the [Mobile App Europe 2014](http://mobileappeurope.com/).

---
End-to-end-test over different devices (desktop - mobile - tablet)
Ability to directly access an API or a database

Selenium webdriver is becoming a W3C standard -> Every browser will support Selenium: [http://www.w3.org/TR/webdriver](http://www.w3.org/TR/webdriver)

Selenium Grid - scale tests to several nodes (different OS/browser) 

##Webdriver Protocol
AKA "JSON wire protocol"
Client with bindings to several languages (C#, Java, Ruby, Python, ...)
JSON Wire Protocol
Server to be downloaded for each browser (except FireFox - in standard Selenium JAR)

Selendroid and iOS-Driver for the mobile browsers

nuget Package for .NET:

    install-package Selenium.WebDriver
    install-package Selenium.WebDriver.ChromeDriver
    install-package Selenium.WebDriver.IEDriver

Example:

    [TestMethod]
    public void BrowsingWithLocalDriver()
    {
        using (var driver = new FirefoxDriver())
        {
            driver.Url = "http://paulroho.com";
            driver.Title.Should().Contain("PaulRoho.com");
        }
    }


##Remote web driver 

    install-package Selenium.RC

##Selenium Grid
* Environment Management & Control
* Scaling
* Parallel execution of tests (eBay tests if sequentially executed would take 6 days to complete)
* Reduction of execution times
* Crossover tests (web, mobile)
* Sits between my world (Dev, CI, ...) and machines with difference browsers (linux, windows, OSX, ...)
* Nodes registers with selenium grid hub with capabilities (os version, browsers, versions)
* Tests are sent to grid hub along with desired capabilities

-

1. Download the Selenium server from [Selenium Download Page](http://www.seleniumhq.org/download/).
2. Startup the hub

    java -jar selenium-server-standalone-2.41.0.jar -role hub

[http://localhost:4444/grid/console](http://localhost:4444/grid/console)

    java -jar selenium-server-standalone-2.41.0.jar -role wd -hub http://localhost:4444/grid/register

Now the grid can be targeted by using the RemoteWebDriver:

    [TestMethod]
    public void BrowsingUsingSeleniumGrid()
    {
        var capability = DesiredCapabilities.Firefox();
        using (var driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capability))
        {
            driver.Url = "http://paulroho.com";
            driver.Title.Should().Contain("PaulRoho.com");
        }
    }


##Reporting

    reporter.log("This is additional info");

##Mobile Automation Requirements
* Reuse of the existing Selenium infrastructure for the web
* Implementation of the Selnium protocol
* The application under test should not need to be modified
* Support for emulators/simulators as well as real deveices
* Parallel execution of tests in a Selenium Grid
* Management of multiple applications, versions, language
* Support for runtime instpection for the app
* Hybrid app support
* No jailbreaking of device required

* [http://ios-driver.github.io/ios-driver/](http://ios-driver.github.io/ios-driver/)
* [http://selendroid.io/](http://selendroid.io/)

##Setup for selendroid:

    DesiredCapabilitis.android()
    capability.setCapability(SelendroidCapabilities.EMULATOR,true);
    ...

Possible to define the desired locale in the capabilities

Possible to inspect the native app's Dom.