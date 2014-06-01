---
layout: blogdraft
title: Contributing to SpecFlow
draft: true
---


Contributing to SpecFlow
========================

TODO: Description of the observed odd behaviour (highlighting step arguments in feature files)



SpecFlow Sources
----------------
To get the latest version of the SpecFlow sources do the following:

1. Fork github/techtalk/specflow:

    ![Forking SpecFlow](/images/posts/ForkingSpecflow.png)
	{: .image}

	 
	 This brings you directly to your fork on your github page:

    ![Forked SpecFlow](/images/posts/ForkedSpecflow.png)	 
	{: .image}
	 
2. Clone your fork of the SpecFlow repository

	 The easiest way to accomplish this might be to use the built in support for git repositories (Visual Studio 2012 and 2013).

	 
	 First, connect to the team project:

	 ![Connecting to Team Project in Visual Studio 2013](/images/posts/ConnectToTeamProject.png)
	{: .image}

	 
	 Now you need the url of the repository to clone. That's easiest by copying it directly from the clone url textbox on the repository's site:

	 ![HTTPS clone URL on GitHub](/images/posts/GetRepoCloneUrl.PNG)
	{: .image}
	 
	 Back in Visual Studio, click the clone button, paste the url and change the local path if necessary:

	 ![Cloning a repository in Visual Studio 2013](/images/posts/CloneRepository.PNG)
	{: .image}
	 
	 
	 For a several 100MB sized repository as SpecFlow is, it's nice to have informative progress info:
	 
	 ![Progress on cloning](/images/posts/CloningInProgress.PNG)
	{: .image}
	 
    Of course you can use the git command line or your preferred UI tool such as [Git Extensions](https://github.com/gitextensions/gitextensions) or [GitHub for Windows](https://windows.github.com/) for this procedure as well.
	 