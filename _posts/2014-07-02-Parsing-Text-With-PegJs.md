---
layout: blogdraft
title: Parsing Text With Peg.js
---

# Parsing Text With Peg.js

Today start documenting my journey towards parsing text in JavaScript. 

I will do this over several posts, right at the time something new happens. So it should kind of real-time.

## Motivation

At my day-job I am working as a consultant. From Monday to Thursday I am at the customer's site. Every Friday there is "Office Day" at our employer's office. That's when I have the opportunity to see most of my colleagues, talk to them, discuss ideas, chat about this and that, have meetings and internal trainings.

For the most part that is fun to do, but for me ...

**Every Friday starts with a draining task**

In the first minutes at the office on a lovely Friday, I take the notes regarding the work from the previous days and enter them into our beloved time tracking system. As it might not surprise you: There is a somewhat patchy relation to that system.

Here's a makeover of the main part of the entry form: 

![Sketch of a time tracking entry form](/images/posts/PegJs/TimeTrackingEntryForm.png)
{: .image}  
(Wireframe stencils courtesy of [www.paulhibbitts.com/wireframe-stencils-for-powerpoint.html](www.paulhibbitts.com/wireframe-stencils-for-powerpoint.html "Hibbitts Design"))

So, nothing surprisingly. Just the _n_th incarnation of the same as seen in zillions systems like this around the globe.

While working at the customer, I take my time tracking notes in some kind of plain-text format. On entering the data into our time tracker, I then stupidly have to mark parts of the input and copy paste it into the corresponding field of the application:

![Marked Time Data](/images/posts/PegJs/MarkedTimeData.png)
{: .image}

Technically speaking, we perform a **parse** task to identify the different parts of our notes. We then extract those parts and move it's contents into the target system. Mechanical and draining.

**But wait - these are the thing computers were made for!**

So why not automate this stuff?

Even when working at the company's office, I would prefer editing my whole time tracking data as a single text over humping around in some more or less intuitive and usable form with several distinct fields.

Here is some sample tracking text as I note it done while working at the customer (changed some critical parts to not disclose proprietary information):

    08:30-11:45 [C_3.4.2] PERSY: AD-sync concept update
    11:45-12:15 Lunch
    12:15-12:30 [C_3.4.2] PERSY: AD-sync documentation
    12:30-12:45 [C_3.4.2] LEX: Issues staging epox
    12:45-13:15 [C_3.4.2] PERSY: AD-sync documentation
    13:15-14:30 [C_3.4.2] LEX: Issues staging epox
    14:30-15:00 [C_3.4.2] PERSY: AD-Sync
    15:00-16:00 [C_3.4.2] PERSY: Presentation AD-sync @tech jour fixe
    16:00-16:30 [C_3.4.2] PERSY: AD-sync
    16:30-18:00 [P_3.4.1.1] LePrCMS: source transfer
    
Pseudo grammar:

    <from>-<to> [<workitemid>] <text>

Playground: [http://peg.arcanis.fr/](http://peg.arcanis.fr/ "PEG.js - Grammar Editor by Maël Nison").

First version of the grammar that seems to work so far: 

    start
    = (line)*
    
    line
    = (time TO time SPACE (workitemidtag SPACE)? anytext)? EOL
    
    time
    = digit digit ":" digit digit
    
    digit
    = [0-9]
    
    workitemidtag
    = LBRACKET workitemid RBRACKET
    
    workitemid
    = [a-zA-Z0-9\.\_]+
    
    anytext
    = (ascii / umlaut / interpunct / SPACE)+
    
    ascii
    = [a-zA-Z0-9]
    
    umlaut
    = [\xC4\xE4\xDC\xFC\xD6\xF6]
    
    interpunct
    = [:()#-_!]
    
    EOL = "\n"
    TO = "-"
    SPACE = " "
    LBRACKET = "["
    RBRACKET = "]"
    
Output:

![Screenshot of the Grammar Editor](/images/posts/PegJs/ScreenshotGrammarEditor.png)
{: .image}

You can find that version of the grammar here to play with: [http://peg.arcanis.fr/pNz2g/1/](http://peg.arcanis.fr/pNz2g/1/ "First version of the grammar").
