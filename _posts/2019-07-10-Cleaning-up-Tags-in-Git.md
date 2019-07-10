# Cleaning up Tags in git

Tags are similar to branches as pointers to a specific commit. The difference is that during its lifetime a branch can (and typically will) point to different commits, while a tag remains pointing to one specific commit.

## Warning
Tag names can be used in several places where branch names can be used, e.g. to checkout a specific commit:
    $ git checkout {branch|tag-name}

Mind the order here. In case there is a branch with the same name as a tag, the branch will be used:
    $ git checkout BRANCH_OR_TAG
    warning: refname 'BRANCH_OR_TAG' is ambiguous.
    Previous HEAD position was b948af82c Commit to be tagged
    Switched to branch 'BRANCH_OR_TAG'

To avoid surprises either check up-front that there is no equally named branch, or be explicit about it, e.g. by qualifying the tag:
    $ git checkout refs/tags/BRANCH_OR_TAG
    Note: checking out 'refs/tags/BRANCH_OR_TAG'.

    You are in 'detached HEAD' state. You can look around, make experimental
    changes and commit them, and you can discard any commits you make in this
    state without impacting any branches by performing another checkout.

    If you want to create a new branch to retain commits you create, you may
    do so (now or later) by using -b with the checkout command again. Example:

      git checkout -b <new-branch-name>

    HEAD is now at b948af82c Commit to be tagged



## Listing Tags

List all local tags:
    $ git tag

List all tags on a remote:
    $ git ls-remote --tags

Or if you have multiple remotes:
    $ git ls-remote {origin-name} --tags


## Deleting Tags

Delete a local tag:
    $ git tag -d {tag-name}

Delete a tag on a remote:
    $ git push --delete {tag-name}