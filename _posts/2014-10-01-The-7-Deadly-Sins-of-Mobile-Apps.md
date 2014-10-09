---
layout: blogdraft
title: The Seven Deadly Sins of Mobile Apps
tags: [Mobile App Europe 2014, Mobile Apps]
---

Mobile App Europe 2014 Notes
Keynote: The 7 Deadly Sins of Mobile Apps
===
Notes on a [session](http://mobileappeurope.com/talks/7-deadly-sins-mobile-apps/ "Keynote: The 7 Deadly Sins of Mobile Apps")
by Jonathan Kohl (Kohl Concepts Inc.) 
at the [Mobile App Europe 2014](http://mobileappeurope.com/).

---

Author of "Tap Into Mobile Application Testing", 
upcoming: "Tap Into Mobile Application Design"

* Bad mobile experience is bad customer service
* You will lose money due to poor customer service
* Your brand and image will suffer

#Deleteable Offences
* Don't give people reasons to delete your app
* We live and die by the app store ratings

#Rantable Offences
* Social Media: #fail
* If your app fails people, they will unleash their fury on social media
* It can be very difficult to restore your brand after bad publicity

#Sin 1: Lust
App leaves you feeling unfulfilled and wanting more

##Lust remedies
* Not competing with other invoices app, but with angry birds (50% of time spent on games?)
* Designers: use mobile features
* Programmers: Solve a real problem, create great error handling
* Testers: test for reliability and usability

#Sin 2: Gluttony
* App uses far too many device resources
** Doesn't fit well on smaller screens
** Your device slows down and heats up
** Your battery goes dead quickly

##Gluttony Remedies
* Designers: design for smaller screens follow guidelines
* Developers: optimize resource usage during development
* Testers: find out the scenarios are really used

#Sin 3: Greed
* App uses as much of your network resources as possible
** App is slow and unreliable on mobile networks
** App crashes when changes network types
** App is inoperable when network connections aren't ideal or unavailable

##Greed Remedies
* Designers: design with network error handling in mind, assume weak or lost connections  
* Developers: use distributed computing approaches and error handling, assume slow connections, latency and dropped packets
* Testers: test transitions between network types and connection loss: WIFI, cellular, etc.

#Sin 4: Sloth
* The app takes too long to do anything useful
** It is slow to launch and slow to respond to gestures and inputs
** It gets in the way of problem solving particularly in high stress situations
** It causes you to feel frustrated. This app is wasting previous time.

##Sloth Remedies
* Designers: Remember that devices that have limited power and resources so don't get carried away with features - Use minimalist design start simple, remove, remove, remove!   
* Developers: Monitor and optimize performance during development - wathc for memory leaks too much processing, chatty network connections
* Testers: performance test, use real devices, under devices on slower networks

#Sin 5: Wrath
App doesn't play well with others
* Application settings override device defaults and causes unexpected behavior
* Overrides other app settings, causing them to malfunction
* App demands focus, no matter what you are doing

##Wrath Remedies
* Designers: Research custom settings and device defaults, and problems that can occur when they conflict   
* Developers: be careful with custom controls and be aware of other apps and services running on devices
* Testers: try different user scenarios interoperating with other app actions, device settings and operations

#Sin 6: Envy
The app is a copycat. Users would prefer to use existing apps instead.
* It is too similar to other apps , and gets rejected from application stores.
* After the researching and installing the app, it is too similar to others I already use, so I delete it.
* I can't find your app in a sea of similar go to a competitor

##Envy Remedies
* Designers: design the application with differentiation in mind
* Developers: e creative with mobile development features to provide a unique user experience.
* Testers: research apps in the marketplace and provide early feedback to designers and test the requirements - "What problem does it solve that others do not?"

#Sin 7: Pride
The app is difficult to users and expectes users to adapt to it.
* People get frustrated while trying to complete simple tasks
* The app requires too many inputs and gestures to get anything done
* People are subjected to pain - eye strain the fingers

If mom doesn't care, no one will

##Pride Remedies
* Designers: use empathic design - take the user, their context and emotions into account
* Developers: follow framework development guidelines and UX practices
* Testers: Test user experiences using human-interface guidelines, and use real-world scenarios and tests.

#Don't tempt others
Keep personal data private and secure
* Designers: model designs to prevent privacy breaches
* Developers: use secure protocols and storage tools
* Testers: ensure data is private - use testing and any security tools you can leverage

#Repent of Your Sins!
Alternatively:
* Exploit human weaknesses in your app to create positive experiences.
* Give users what they want and need 