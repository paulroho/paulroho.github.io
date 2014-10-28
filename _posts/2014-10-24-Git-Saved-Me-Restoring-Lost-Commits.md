---
layout: blogdraft
title: Git Saved Me - Restoring Lost Commits
tags: [git]
---

#Git Saved Me - Restoring Lost Commits

Today I lost several commits to a local git repository that were not pushed to the remote by that time. As you might understand, this made me feel very unpleasant. It was hard work that I lost by just a few clicks.

In this post I will show you in some detail how I came into that situation and how I managed to finally recover these not-so lost commits.

## GitExtensions
Regarding [git](http://git-scm.com/) I can do the very basics on the command line. But for my day-to-day work, I mainly use [GitExtensions](https://github.com/gitextensions/gitextensions). This tool provides me with a nice user interface for all the git operations I do and many more things I am not ready to check out at my current knowledge of git.

![GitExtension's Main Window](/images/posts/GitRecoverLostCommits/00_GitExt.PNG)
{: .image}

On a very basic view, GitExtensions gives me a nice graphical representation of the branches and merges, shows the files in the commit along with the changes made for each file. A host of menu items give access to a lot more functions out of git's vast feature-set. Shortcuts make it convenient to perform the most commonly used tasks.

That's all more than fine. 

### Branching, Merging And GitExtensions
As I have had some hard times dealing with branches in GitExtensions, I must say that this part of the user interface feels not so well thought out to me. Sometimes it can be even disturbing. Especially when merging, I find it is not clear which branch is to be merged into what branch.

But just *checking out* a branch seemed obvious to me. Until recently.

## Some Background

I was working on a repository with the local master branch being several commits ahead of the associated remote:

![The repository as it was before the incident](/images/posts/GitRecoverLostCommits/01_SituationBefore_GitExt.PNG)
{: .image}

For those not familiar with GitExtensions, red icons ![A local branch in GitExtensions](/images/posts/GitRecoverLostCommits/branch_master_GitExt.png) show local branches. Green icons ![A remote branch in GitExtensions](/images/posts/GitRecoverLostCommits/branch_originmaster_GitExt.png) are used for remote branches. Note that the local master branch is using a bold font signaling that this branch is currently checked out. The remote branch origin/master is using a non-bold font because it is behind the local master.

The icon ![A label in GitExtensions](/images/posts/GitRecoverLostCommits/label_GitExt.png) depicts just a label I applied to tackle down some version.

Having arrived in that state I realized that I needed an older version of a file. To be exact, I needed the version that was on the remote master (origin/master). So I thought it would be easy to just checkout the commit, grab that version of the desired file and go back to where I was in my local master branch.

**And so the tragedy started.**

## How I Messed Up My Repository

I selected the commit, and chose "Checkout branch" from the context menu:

![Checkout context menu](/images/posts/GitRecoverLostCommits/02_CheckoutOriginMasterMenu_GitExt.png)
{: .image}

Then there was this dialog, saying I could checkout origin/master:

![Checkout dialog in GitExtensions](/images/posts/GitRecoverLostCommits/03_CheckoutOriginMasterDialog_GitExt.PNG)
{: .image}

This seemed all too logical, since I wanted to have the state as it was on the remote master. But unfortunately, I did not inspect the options selected below:

![Annotated checkout dialog in GitExtensions](/images/posts/GitRecoverLostCommits/03_CheckoutOriginMasterDialog_GitExtAnnotated.PNG)
{: .image}

Would I have read this thoughtfully, I would have saved myself. It clearly says, what this option does: it **resets my current master branch**. That was not what I wanted, but I did not know that at that time - and clicked ok.

### The Nasty Surprise

To my big surprise, I ended up with this shocking image:

![All local commits seem to be lost](/images/posts/GitRecoverLostCommits/04_LostCommits_GitExt.PNG)
{: .image}

All the commits that my local master was ahead of the remote master were gone!

![OMG!](/images/posts/GitRecoverLostCommits/terrified.png)
{: .image}

##The Cure
In this desperate situation, I fortunately found a post named [restoring lost commits](http://gitready.com/advanced/2009/01/17/restoring-lost-commits.html) on [Nick Quaranto](https://twitter.com/qrush)'s awesome [git ready](http://gitready.com/) site.

With the help of this concise and clear post, I managed to get back my lost commits in a matter of minutes. Most of that time was due to making safety copies and double-checking everything I did.

The post basically shows how to get back commits that have already been marked for garbage collection, but might not be actually removed from the repository's internal data structures.

Here are the steps following Nick's post for my special situation:

###1. Make A Backup Copy

Since I have managed to mess up my repository in a second, I wanted to make sure, that I would not ultimately destroy all my hopes by another mistake.

Although git might seem magical at times, it is completely filesystem based. A simple copy/paste backup of the whole working directory (along with the .git folder) is fine for a quick safety net.

###2. List The No More Assigned Objects In The Repository

First I needed to see if git still knows my vanished commits. For that matter there is git's ````fsck```` command:  

    git fsck --lost-found

In my current case this is what came out:

![The lost commits in git's internal data structure](/images/posts/GitRecoverLostCommits/05_GitFsck_GitBash.PNG)
{: .image}

So I was a bit relieved. There seemed to be a good chance to really recover my lost work. 

###3. Merge The Lost Commits Back Into The Current Branch

The next step was bringing back the lost commits to the current branch. From Nick's post it was not super clear to me, if I would have to do it commit by commit, or if it would be possible to get back all commits at once. Since I had my backup copy, I could experiment without fear.

I just assumed, that it would work for multiple commits. I grabbed the last commits sha ````4c27c662cc617...```` and tried the merge with it:

    git merge 4c27

(Isn't it nice that you can type just enough letters to make sure that the sha-1 is unambiguous? Actually, even just ````4c```` would have been sufficiently distinctive).

And now the real magic happened:

![Git merges the lost commits back to the current branch](/images/posts/GitRecoverLostCommits/06_GitMerge_GitBash.PNG)
{: .image}

Refreshing the view in GitExtensions made me really happy:

![Recovered commits](/images/posts/GitRecoverLostCommits/07_SituationAfter_GitExt.png)
{: .image}


All my believed to be lost commits were back in business.

![Happy again!](/images/posts/GitRecoverLostCommits/happy.png)
{: .image}

###4. Push It, Baby, Push It!

Now that I could successfully reanimate my sick repository, I wanted to make sure to not happen this again by pushing to the remote branch.

![After pushing the recovered commits](/images/posts/GitRecoverLostCommits/08_AfterPush_GitExt.png)
{: .image}

Now I really feel safe. Because no matter what idiocy I might do next with my local repo, the remote repo has all the good stuff in place.