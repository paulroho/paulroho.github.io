---
title: Engineering Wunderlist for Android
titleappendix: César Valiente
tags: [Mobile App Europe 2014, Mobile Apps, Architecture, Android]
subtitle: >
  Notes on a [session](http://mobileappeurope.com/talks/engineering-wunderlist-android/ "Engineering Wunderlist for Android")
  by César Valiente (6Wunderkinder GmbH)
  at the [Mobile App Europe 2014](http://mobileappeurope.com/).
---

César showed off the architecture of the [Wunderlist App for Android](https://play.google.com/store/apps/details?id=com.wunderkinder.wunderlistandroid "Wunderlist App in the Google Play Store") for [Wunderlist](https://www.wunderlist.com/). 

While some amount was standard ingredients, there were some interesting aspects:

## API
* Websocket - main way of communication (support for instant notifications)
* REST - mainly as fallback for Websockets

## Android Layer
* Event Bus for asynchronous communication