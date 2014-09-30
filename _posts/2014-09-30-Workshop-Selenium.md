MAE2013, Day2 - Workshop Selenium, Selendroid and ios-driver: Mobile and Web Automation Using One API and One Infrastructure (Part 1) 
===
by Michael Palotas

---
End-to-end-test over different devices (desktop - mobile - tablet)
Ability to directly access an API or a database

Selenium webdriver is becoming a W3C standard -> Every browser will support Selenium: [http://www.w3.org/TR/webdriver](http://www.w3.org/TR/webdriver)

Selenium Grid - scale tests to several nodes (different OS/browser) 

#Webdriver Protocol
AKA "JSON wire protocol"
Client with bindings to several languages (C#, Java, Ruby, Python, ...)
JSON Wire Protocol
Server to be downloaded for each browser (except FireFox - in standard Selenium JAR)

Selendroid and iOS-Driver for the mobile browsers

nuget Package for .NET:
    install-package Selenium.WebDriver

