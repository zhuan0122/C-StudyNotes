# Git Workflow
We use the GitFlow workflow, as described [here][atlassian-gitflow]
 (along with some other useful guides).

The overall flow is:

1. A develop branch is created from master
2. A release branch is created from develop
3. Feature branches are created from develop
4. When a feature is complete it is merged into the develop branch
5. When the release branch is done it is merged into develop and master
6. If an issue in master is detected a hotfix branch is created from master
Once the hotfix is complete it is merged to both develop and master

A graphical overview of this can be found [here][gitflow-visual].


## Starting a new task

1. Create a [new branch] in GitLab. Choose develop as source branch.
2. Create a [merge request] and select your new branch as source. If develop is not set as target, switch to develop as target branch.
3. Fix the merge request title if necessary, and add "WIP:" in front by clicking the link beneath the Title field.
4. (optional): Add a description of the task (often the description from the Jira ticket).
5. Submit the merge request.
6. From Visual Studio, do a fetch from the repository, then switch to the newly created branch.
7. Start working on the new task.

## Working with a task

While working with a task it is not uncommon to make several commits. These are made locally and later pushed to the central repository.
As long as the commit has not been pushed, it is possible to amend a previous commit to keep the history cleaner.
This is done by either using the "amend precious commit" option under the action dropdown for the Changes tab in Team Explorer in Visual Studio, or by using the ``--amend`` switch for the command line. This changes the previous commit to include the current changes, which is also why it shouldn't be used (or at least used with care) on already pushed commits.  
Separating the task into several commits will make reviewing easier, especially if each commit contain a logically separated part of the task.

While working it could also be a good idea to keep up to date with the latest changes from the develop branch.
This can be done by either merging or rebasing. Code-wise the results of these should be the same, but the history and the merge process will differ.

Merging will create a new commit in the current branch with two parents,
the head of each branch. When merging, Git will report on any conflicts between the
parent commits, and once those are resolved the commit will be created.  
To make it clearer in GitLab it is also recommended to do a push before and after
each merge. This is because GitLab creates distinct versions in the
merge-request for each push. This makes it easier for the reviewer to ignore changes
that are merged from develop and therefore already has been reviewed.

Rebasing, on the other hand, will rewrite the history so that the first commit of the branch has the head of the target branch as a parent. The main difference for the user is that potential conflicts are reported and has to be fixed separately for each commit in the branch being rebased.

Note that because rebasing rewrites the history, it has the potential to do damage if used carelessly.

The recommended approach is to rebase if the code has not yet been pushed, or if you're merging changes from the same branch you're currently in (i.e. changes from someone else working on the same task), and merge otherwise.
This provides a middle ground between the cleaner history provided by rebasing and the safety and "truth" provided by the merge approach. This can be set as default in the settings in Team Explorer.
The name of the setting is "Rebase local branch when pulling" and should be set to "Preserve" to keep any local merge history during rebase.


## Finishing a task

1. Make sure your branch is up to date with the target branch.
   - This can be done by merging the target branch into the source branch.
2. Push the changes to the repository
3. Mark the Merge request as no longer being "WIP:" by removing the text. If you didn't [create a Merge Request][merge request] earlier, do so now.
4. (optional) Add specific reviewers for the Merge Request.
5. Select the "Remove branch after merge request is accepted" option.
6. Save the merge request.

## Reviewing a Merge Request

The changes in a Merge Request can be viewed through GitLab or by checking out the branch through Git.

Gitlab lets you see the changes both as a whole and separated by commits. You can also add comments on specific lines of code, as well as more general comments.
Each comment will start a discussion, which will track the particular piece of code it relates to and mark if it changes. All discussions should be marked as resolved before approving or merging the request.

Testing the code is as simple as checking out the branch to be merged and running it. The tests will already have been run by gitlab, and the results are available.

The build/test results are shown through the Pipeline section of the merge request. This is separated into several parts, the most important ones are the ```build``` and ```test``` steps.
Clicking on any step of the pipeline shows the console log for that step, allowing you to see why a build failed, or which tests didn't pass.
The test results are also available in xml format, as artifacts from the ```collectresults``` step. We might in the future set up a service to provide a test result overview similar to what is provided by Jenkins.

When you're happy with the changes included in the merge request, simply click the approve button. Then, if you want to merge the request into the develop branch, click the Merge button.
The changes will then be merged into the target branch, unless the source branch is no longer up to date with the target.

Make sure that the "Remove branch on merge" is checked, unless there is a specific reason to keep the branch alive.

## List of fundamental git commands
[List of git commands][git-commands]

## Useful resources

[Pro Git (ebook)](https://git-scm.com/book/en/v2)  
[Atlassian Git tutorial](https://www.atlassian.com/git/tutorials)  
[Think like a Git](http://think-like-a-git.net/)  


[atlassian-gitflow]: https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow
[gitflow-visual]: https://nvie.com/files/Git-branching-model.pdf
[new branch]: https://gitlab.scania.com/EPID/SesammTool2/merge_requests/new
[merge request]: https://gitlab.scania.com/EPID/SesammTool2/merge_requests/new
[git-commands]: https://gitlab.scania.com/EPID/SesammTool2/tree/develop/Doc/GitCommands.md
