---
title: Mobile Apps and the Role of Load Testing (Peter Varhol)
tags: [Mobile App Europe 2014, Mobile Apps, Testing, Load Testing]
---

Mobile App Europe 2014 Notes

Mobile Apps and the Role of Load Testing
===
Notes on a [session](http://mobileappeurope.com/talks/mobile-apps-role-load-testing/ "Mobile Apps and the Role of Load Testing")
by Peter Varhol (Aras Corporation)
at the [Mobile App Europe 2014](http://mobileappeurope.com/).

---

##Why Load Test Mobile Apps?
* Load testing the backend infrastructure (the app itself has just a single user)
* Can the server handle the expected number of users?

##Expections
* Performane/response time time
* Expected number of users is a serviced with acceptable performance
* The application stresses approximately evenly across tiers and components
* The application fails gracefully
* App and backend infrastructure serves a variety of business cases (normal use, seasonal high use, new product or marketing initiatives)

##Business Issues in Mobile Load Testing
* The market moves too fast
* We don't know how the app is going to be used
* If a public app, we don't know how many people will use it

=> So we have to make some market and use assumptions

##Technical Issues in Mobile Load Testing
* The devices are all different

##Ways to Load Test Mobile Apps
* Synthetic test scripts
* RUM - Real User Monitoring
* Crowdsouring
* Recorded user sessions

##Expected Results of Load Testing
* Can the server handle the expected number of users?
* What does the response curve look like as uses are added?
* At what point does the application fail?
* Where is the application stressed?

##Preparing to Load Test
* Develop user personas
* Determine device characteristics
* Derive activities from personas

##Developing Personas
* Power/Standard/Casual
* Domestic/International users
* By age
* What ever makes sense for the application

##For each persona determine
* Frequency of visits
* Actions on each visit

##Making Use of the User Persona
* What percentage of each
* Have to guess
* Try different balanaces
* Compare response time and load measures

##SLA
* E.g. "in 98% of the time we react within 500ms"

##Corrective Actions
* More Servers
* Hardware accelarator (Caching)
* Bugs
* Too much traffic (data not needed)

Showed [JMeter](http://jmeter.apache.org/ "JMeter")
