---
title: Offline Architectures for Mobile Apps
titleappendix: Christian Poecher
tags: [Mobile App Europe 2014, Mobile Apps, Offline, Architecture]
prehead: Mobile App Europe 2014 Notes
subtitle: >
  Notes on a [session](http://mobileappeurope.com/talks/offline-architectures-mobile-apps/ "Offline Architectures for Mobile Apps")
  by Christian Poecher (QuinScape GmbH) 
  at the [Mobile App Europe 2014](http://mobileappeurope.com/).
---

* We live in a disconnected world
* Offline is simply a fact of life
* if you are mobile, you will be offline.
* Alex Feyerke: initiative [http://offlinefirst.org/](http://offlinefirst.org/)

Offline not considered as a failure, but just a property you have to deal with

##Kinds of offline
* Offline Maps
* async
* google docs
* business apps

##Content
* Plain Text
* JSON-Objects
* Files
* Diagrams
* Relational Data

##Sync Mechanism
* Asynchronous synchronization
    * real-time UI updates (not good for lists)
    * non-blocking
* Synchronous synchronization
    * delayed UI updates
    * blocking

##Storage and Availability
* Real time synchronization
* Lazy fetching
* eager fetching

##Transfer
* Full transfer
* Timestmamp transfer
* Mathematical transfer

##Conflict resolution
* Client (or Server) wins
* Automatic merge
* Manual merge

##Solutions
* Before - custom made development in project
* Today - efficient and enterprise-quality framework usage -> pick one

##[Hoodie](http://hood.ie/)
* Personal Sync-framework
* JavaScript
* Web and iOS

##[Share.JS](http://sharejs.org/)
* Library for Operational transform
* Base for real-time synchronization, CSCW
* Eventual consistency

##[Kony Sync](http://www.kony.com/products/development/sync)
* Complete data-sync platform
* server-based runtime
* cross-platform native or HTML5-UI generation client library for all channels (iOS, Android, Windows, BlackBerry, HTML5)
* Alternative: MobileFabric to consume offline-services through SDKs (iOS, Android, PhoneGap)
