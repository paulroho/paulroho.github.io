---
title: Appium Cross-Platform Mobile Test Automation for the Masses
titleappendix: Andreas Lüdeke
tags: [Mobile App Europe 2014, Testing, Mobile, Cross-Platform, WebDriver]
prehead: Mobile App Europe 2014 Notes
subtitle: >
  Notes on a [workshop](http://mobileappeurope.com/talks/appium-cross-platform-mobile-test-automation-masses/) by Andreas Lüdeke (TestObject) 
---

# [Appium](http://appium.io/) Concepts
* Cross platform (Android, iOS, Firefox OS)
* Multiple languages
* For native hybrid and web apps
* Based on JSON Webdriver Protocol
* Needs no app modification
* Large community, founded by Sauce Labs

Webdriver - Appium Server
* Android: UIAutomation controller or Selendroid
* iOS: Instrumentation Library

## Setup
* node.js

Hint: [Genymotion](http://www.genymotion.com/) Android emulator

* [Page Object Pattern](http://martinfowler.com/bliki/PageObject.html)

## Scaling Appium Tests
* Selenium Grid
* TestObjects
* SauceLabs
* ...