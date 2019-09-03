---
title: Upgrade Work Item Types for AzureDevOps Server/TFS to Support Pull Requests

tags: [Developer Workflow, Pull Requests, AzureDevOps]
---

Recently my client upgraded from TFS 2017 (on-premise) to AzureDevOps Server. Besides the new UI everything seemed to work fine. Just as I wanted to complete a pull request, I faced the following error message:

![Error message on attempting to complete the pull request](/images/posts/AzureDevOpsUpgradeWorkItemTemplates/ErrorMessage.PNG)
{: .image}

By googling I found a proper [question on StackOverflow](https://stackoverflow.com/questions/50935155/tfs-cannot-complete-product-backlog-item-because-there-is-no-transition-from-co) with a [helpful answer](https://stackoverflow.com/a/50941616/571213) and a supplementing comment on the implementation.

To make things easier, these are the full steps to overcome this issue. All credit goes to the authors of the question, the answer and the comment.


## 1. Export the Work Item Type Definition(s) to File(s)

    witadmin exportwitd /collection:https://tfs.mycompany.com/DefaultCollection /p:MyProject /n:"Product Backlog Item" /f:"C:\Temp\pbi.xml"
    witadmin exportwitd /collection:https://tfs.mycompany.com/DefaultCollection /p:MyProject /n:"Bug"                  /f:"C:\Temp\bug.xml"

Each invocation should end with this message:

    Operation complete.

The easiest way to get a handle to that tool is to run it from a Visual Studio Developer Command Prompt.

Remark: Although on the [Microsoft Docs-Page regard the witadmin cli tool](https://docs.microsoft.com/en-us/azure/devops/reference/witadmin/witadmin-import-export-manage-wits?view=tfs-2018) it is mentioned that the version of the tool has to match the version of TFS or AzureDevOps Server, it worked for me using the witadmin.exe from Visual Studio 2015 (path `C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\witadmin.exe`) in conjunction with AzureDevOps Server 2019.


## 2. Enter Up the Missing Transition Actions

* Locate all nodes transiting to 'Done' (XPath `/witd:WITD/WORKITEMTYPE/WORKFLOW/TRANSITIONS/TRANSITION[@to="Done"]`):

![A transition to 'Done' without actions in a work item type definition](/images/posts/AzureDevOpsUpgradeWorkItemTemplates/witp_before.PNG)
{: .image}

* Add an action to the transition:

    <ACTIONS>
        <ACTION value="microsoft.vsts.actions.checkin"/>  
    </ACTIONS>

![A transition to 'Done' with an action defined](/images/posts/AzureDevOpsUpgradeWorkItemTemplates/witp_after.PNG)
{: .image}


## 3. Import the changed Work Item Type Definition(s)

    witadmin importwitd /collection:https://tfs.mycompany.com/DefaultCollection /p:MyProject /f:"C:\Temp\pbi.xml"
    witadmin importwitd /collection:https://tfs.mycompany.com/DefaultCollection /p:MyProject /f:"C:\Temp\bug.xml"

Each invocation should conclude with

    The work item type import has completed.

Done:

![No more error message on attempting to complete the pull request](/images/posts/AzureDevOpsUpgradeWorkItemTemplates/NoMoreErrorMessage.PNG)
{: .image}
