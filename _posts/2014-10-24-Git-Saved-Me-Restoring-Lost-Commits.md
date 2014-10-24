---
layout: blogdraft
title: Git Saved Me - Restoring Lost Commits
tags: [git]
---

Today I lost several commits to a local git repository that were not pushed to the remote by that time. As you might understand, this made me feel very unpleasant. It was really hard work that I lost by just a few clicks.

In this post I will show you in some detail how I came into that situation and how I managed to finally recover these not-so lost commits.

## GitExtensions
Despite a few half-hearted attempts to familiarize myself with my Mac and its OS X, I still am  a Windows-guy. Regarding git I know the basics in the command line, but for my day-to-day work with this awesome tool, I mainly use the great [GitExtensions](https://github.com/gitextensions/gitextensions). This tool provides me with a nice user interface for all the git operations I do and many more I am not ready to check out at my current knowledge of git.

![GitExtension's Main Window](/images/posts/GitRecoverLostCommits/00_GitExt.PNG)
{: .image}

### Branches And GitExtensions
As I have had some hard times dealing with branches in GitExtensions, I must say that this part of the user interface feels not so well thought out to me. Sometimes it can be even disturbing.

Especially when merging, I find it is not clear which branch is to be merged into what branch.

But checking out seemed obvious to me. Until recently.

## Synopsis

The local master branch was several commits ahead of the associated remote:

![The repository as it was before the incident](/images/posts/GitRecoverLostCommits/01_SituationBefore_GitExt.PNG)

Then I realized that I needed the version from a file as it was on the remote master (origin/master). So I thought it would be easy to just checkout the commit, grab that version of the desired file and go back to where I was in my local master branch. And here the tragic started.

I selected the commit, and chose "Checkout branch" from the context menu:

![Checkout context menu](/images/posts/GitRecoverLostCommits/02_CheckoutOriginMasterMenu_GitExt.png)

Then there was this dialog, saying I could checkout origin/master:

![Checkout dialog in GitExtensions](/images/posts/GitRecoverLostCommits/03_CheckoutOriginMasterDialog_GitExt.PNG)

This seemed all too logical, since I wanted to have the state as it was on the remote master. But unfortunately, I did not inspect the options selected below:

![Annotated checkout dialog in GitExtensions](/images/posts/GitRecoverLostCommits/03_CheckoutOriginMasterDialog_GitExtAnnotated.PNG)

Would I have read this thoughtfully, I would have saved myself. It clearly says, what this option does: it resets my current master branch. That was not what I wanted, but I clicked ok.

So I ended up with this sad situation:

![All local commits seem to be lost](/images/posts/GitRecoverLostCommits/04_LostCommits_GitExt.PNG)

In this desperate situation I found the following post on [Nick Quaranto](https://twitter.com/qrush)'s awesome [git ready](http://gitready.com/) project:  
[restoring lost commits](http://gitready.com/advanced/2009/01/17/restoring-lost-commits.html)

With the help of this concise and clear post, I managed to get back my lost commits in a matter of minutes (most of this time due to making safety copies and fearing to hit the final enter).

Here are the steps:
