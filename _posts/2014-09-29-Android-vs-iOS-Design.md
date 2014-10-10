---
layout: blogdraft
title: Android vs. iOS Design – the Double Effort?! (Melinda Albert)
tags: [Mobile App Europe 2014, Mobile Apps, Android, iOS, Design, Usability]
---

Mobile App Europe 2014 Notes

Android vs. iOS Design – the Double Effort?!
===
Notes on a [session](http://mobileappeurope.com/talks/android-vs-ios-design-double-effort/ "Android vs. iOS Design – the Double Effort?!")
by [Melinda Albert](www.melinde-albert.de "Melinda Albert")
at the [Mobile App Europe 2014](http://mobileappeurope.com/).

---

## Thumb size
* Height of buttons, input fields, icons
	* iOS 44pt
	* iOS: 48pt (min 32pt)

6 User Interface Differences between Android and iOS apps

## Navigation Bar
* iOS: [Navigation Bar](https://developer.apple.com/library/ios/documentation/userexperience/conceptual/mobilehig/Bars.html#//apple_ref/doc/uid/TP40006556-CH12-SW3)
	* Back button - screen title - text titled control or max 2 icons
* Android: [Action Bar](http://developer.android.com/guide/topics/ui/actionbar.html)
	* Nav icon - screen title (not centered) - action icons - menu icon
	* Ad Menu icon:
		* menu items to the current screen, not for navigation
		* There is a table for device/orientation, number of icons
		* max 5 icons: the icons not fitting go to the menu icon 

## Lists
* iOS:
	* Chevron
	* subtitles go to the right
	* no expand/collapse

* Android Lists
	* single-line, double-line, three line list
	* List items can expand/collapse
	* for more info per item: card

## Tabbar
* iOS: [Toolbar](https://developer.apple.com/library/ios/documentation/userexperience/conceptual/mobilehig/Bars.html#//apple_ref/doc/uid/TP40006556-CH12-SW4)
	* No chevron (UX problem - coming back with material design)
	* Always at the button (no interference with hardware controls)
	* max 5 buttons, can have "More" button, but consider side bar navigation for more items
	* icons, text below
	* can slide, can be translucent

* Android: [Tabs](http://developer.android.com/design/building-blocks/tabs.html)
	* Always under the app bar
	* max. 6 tabs
	* just text, no icons

## Buttons
* [iOS](https://developer.apple.com/library/iOS/documentation/userexperience/conceptual/UIKitUICatalog/UIButton.html)
	* System buttons, looks just like a link
	* Apple itself makes exceptions (e.g. AppStore)
* [Android](http://developer.android.com/guide/topics/ui/controls/button.html)
	* Floating action button
	* Rectangular Raised button
	* Flat button, looks like link -> hint: better not use within screens

## Icons
* [iOS AppIcon](https://developer.apple.com/library/iOS/documentation/userexperience/conceptual/mobilehig/AppIcons.html)
	* The business card of the application (bad example: associations that go in the web for the new icon for AirBnB)
	* Always rounded rectangle (maybe form in it)

* [Android AppIcon](http://developer.android.com/design/style/iconography.html)
	* Any outline

* AppIcon Do's
	* Clear silhouette
	* clean colors
	* platform sepcific

* AppIcons Don'ts
	* text
	* mystetrious
	* blue
	* fotos
	* blurry
	* small elements

* iOS Icons
	* Thin (2pt) outline -> inline with text thinness 
* Android Icons

## Navigation
* [iOS Navigation](https://developer.apple.com/library/ios/documentation/userexperience/conceptual/mobilehig/Navigation.html)
	* Tree Structure
	* Tabbar
	* Deck of cards
	* (Dashboard - old fashioned)
	* Mixed navigation - combine above
	* No Navigation
	* Sidebar - not a native element of iOS

* [Android Navigation](https://developer.android.com/training/design-navigation/index.html)
	* Sidebar (native in Android)
	* Tabbar
	* Stacked cards