---
title: iBeacons - The Opportunity
titleappendix: Mark Mason
tags: [Mobile App Europe 2014, Mobile Apps, Internet Of Things, iBeacons]
subtitle: > 
  Notes on a [session](http://mobileappeurope.com/talks/ibeacons-opportunity/ "iBeacons: The Opportunity")
  by Mark Mason (Mubaloo)
  at the [Mobile App Europe 2014](http://mobileappeurope.com/).
---

Definition

* Beacons - blue tooth device
* iBeacons - Apple's profile to do beacons

Contextually relevant information

* from right person
* at the right place
* at the right time

[http://www.ibeacon.com/](http://www.ibeacon.com/)

##iBeacon - Technical Overview

* Low energy bluetooth (BLE) (running for days, up to 2 years, even 9 years with slow ping)
* Pings unique id
* Phone App installed: phone notifies to open the up the app
* Pings 100ms & configurable power

##iBeacon Triggers (Ranging)
* Proximity
    * immediate: 0.3m
    * near: 2m
    * far: 30m
* Entry/exit
* Time (dwell - e.g. ping after 1 minute), since last visit
* Visits
* Combinations

##UUIDs
* **UUID** - same for all beacons in all stores of a brand - *"Welcome"*
* UUID + **MajorID** - same for all beacons in one store or department - *"Welcome to the sporting goods department, checkout our special ..."*
* UUID + MajorID + **MinorID** - individual for each beacon - *A notification triggered when user gets to the golf section*  
Message to the shop employee: someone is standing in the golf department

##User centric
Just because we can doesn't mean we should do it

##Use Case Showroom
* Welcome and identify current customers & potential new customers
* Maximize salesperson utilization
* Monitor vehicle engagement & showroom layout
* Improve overall showroom experience

##Use Case Transport [Crossrail](http://www.crossrail.co.uk/)
* Driver logging and timetable accuracy (also maintenance, cleaning)
* Trigger relevant and dedicated apps
* Monitor and schedule maintenance personnel and equipment
* Monitor personnel activity (security personnel, changing routes)

##Use Case - Offices
* Room usage and availability
* Facilities/maintenance
* Hot desk availability
* Capacity planning (where to put certain things)

Position tracking - Beacons on top of WiFi based location determination

##Use Case Shopping centres
* Blue dot wayfinding, turn by tun directions an mall map
* Traffic flow analysis for retail lease rates
* Event alerts
* Profile responsive Adhells - *what does this mean?*
* Provision of customer incentives
* Car parking

##Use Case Retail
* Welcome valued customers (if they have the app installed)
* Sales-assistant assistant
* In-shop proximity marketing
* Merchandising analysis
* Payment

##Use Case Hospitality
* Automatic door entry
* In-room payment
* Hotel navigation
* Rewards
* Security

##Use Cases Events
* Blue dot wayfinding, layout
* Traffic flow analysis for outlet monitoring and queue busting
* Catering - order and pay direct from their seat
* Video playback of action from alternate view or archived video (knows where you sit - offer different position)
* A platform any team can use

##Use Case Theme Parks
* Park entry & blue dot wayfinding (GPS: has not the granularity)
* Queue busting
* Catering vouchers
* Video playback/photos of rides
* Viewing of previous photos in other queues (incentive to buy)

##Challenges
* BT is on
* Download app
* "What's in it for me?"
* Developing a seamless omni-channel experience
* A well thought through content and context strategy