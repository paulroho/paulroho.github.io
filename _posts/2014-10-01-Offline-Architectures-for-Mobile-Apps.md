MAE2014, Day 3 - Offline Architectures for Mobile Apps
===
by Christian Poecher (QuinScape GmbH) 

---

* We live in a disconnected world
* Offline is simply a fact of life
* if you are mobile, you will be offline.
* Alex Feyerke, [http://offlinefirst.org/](http://offlinefirst.org/)

Offline not considered as a failure, but just a property you have to deal with

#Kinds of offline
* Offline Maps
* async
* google docs
* business apps

#Content
* Plain Text
* JSON-Objects
* Files
* Diagrams
* Relational Data

#Sync Mechanism
* Asynchronous synchronization
** real-time UI updates (not good for lists)
** non-blocking
* Synchronous synchronization
** delayed UI updates
** blocking

#Storage and Availability
* Real time synchronization
* Lazy fetching
* eager fetching

#Transfer
* Full transfer
* Timestmamp transfer
* Mathematical transfer

#Conflict resolution
* Client (or Server) wins
* Automatic merge
* Manual merge

#Solutions
* Before - custom made development in project
* Today - efficient and enterprise-quality framework usage -> pick one

#Hood.ie
* Personal Sync-framework
* JavaScript
* Web and iOS

#Share.JS
* Library for Operational transform
* Base for real-time synchronization, CSCW
* Eventual consistency

#Kony Sync
* Complete data-sync platform
* server-based runtime
* cross-platform native or HTML5-UI generation client library for all channels (iOS, Android, Windows, BlackBerry, HTML5)
* Alternative: MobileFabric to consume offline-services through SDKs (iOS, Android, PhoneGap)
* 