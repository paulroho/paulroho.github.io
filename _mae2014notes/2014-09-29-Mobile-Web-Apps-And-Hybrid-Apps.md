---
title: Mobile Web Apps and Hybrid Apps – from Zero to Hero
titleappendix: Martin Naumann
tags: [Mobile App Europe 2014, Mobile Apps, Hybrid Apps, Mobile Web, ionic]
subtitle: >
  Notes on a [workshop](http://mobileappeurope.com/talks/mobile-web-apps-and-hybrid-apps-from-zero-to-hero-2/ "Mobile Web Apps and Hybrid Apps – from Zero to Hero")
  by Martin Naumann (Centralway Headquarters AG)
  at the [Mobile App Europe 2014](http://mobileappeurope.com/).
---

Building a MobileWebApp with [ionic](http://ionicframework.com/) and [Apache Cordova](http://cordova.apache.org/) and [PhoneGap](http://phonegap.com/) build.

1. Update nodejs

    On Windows: just install the latest msi

1. Install cordova

        npm install -g cordova

3. Install ionic framework

        npm install -g ionic

4. Seed a new ionic project

        ionic start <myProject> tabs

5. Let ionic serve the project (from the projects folder)

        ionic serve

6. Push it to GitHub

7. Check it in [http://build.phonegap.com](http://build.phonegap.com)
    1. pull it from GitHub repository
    2. Provide a name
    3. Click "Ready to build"

8. Scan the build output with a QR-code scanner


##Miscellaneous
9. (With Chrome on Android) Debug on the device
    * In Google Chrome: [chrome://inspect](chrome://inspect), choose device
    * Changes in the code (e.g. Dom Inspector) immediately reflect on phone

* Alternative for jQuery on mobiles: [jqlite](https://code.google.com/p/jqlite/ "jqlite")

