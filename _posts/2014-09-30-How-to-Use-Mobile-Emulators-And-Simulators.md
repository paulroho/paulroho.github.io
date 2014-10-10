---
layout: blog
title: How to Use Mobile Emulators and Simulators to Test the Mobile Diversity (Stefan Gwihs & Philipp Strelka)
tags: [Mobile App Europe 2014, Mobile Apps]
---

Mobile App Europe 2014 Notes

How to Use Mobile Emulators and Simulators to Test the Mobile Diversity
===
Notes on a [session](http://mobileappeurope.com/talks/use-mobile-emulators-simulators-test-mobile-diversity/ "How to Use Mobile Emulators and Simulators to Test the Mobile Diversity")
by Stefan Gwihs & Philipp Strelka (Anecon)
at the [Mobile App Europe 2014](http://mobileappeurope.com/).

---

##Challenges
* Usability
* Network
* Tool
* Security
* Release Cycles
* Diversity
* Fragmentation

*How to handle these challenges*

* Risk-based device selection (example: important for a game)
* Emulators & Simulators
* Multi-layer test (example: important for an in-house CRM)

##Risk-based device selection
* Experience
* Statistics
* Boundary Cases
* Exclusions

##Multi-Layer Testing
* Testing pyramid - compared to food pyramid
* Multi-Layer architecture - choose the right layer for each test, not any layer must be skipped, especially not the UI-level, most of the severe bugs appeared on all devices, so can be found by testing on e.g. the service layer

##Emulators and Simulators

Unfortunately, the speakers could not provide any useful information about alternative emulators or how to speed up the slow emulator performance especially on Android. But they mentioned a tool to simulate real network traffic:
* [WANem](http://wanem.sourceforge.net/) - simulate network behavior for mobile testing

###Cons
* Slow
* Not 100% accurate
* No UX
* Hard to install
* System depended
* Update handling

###Pros
* Cheap
* Flexible
* Accurate
* Accessible
* Configurable

