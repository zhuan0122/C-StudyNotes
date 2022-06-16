# Fundamental git commands
This document contains a list of the most fundamental commands used while working with git on the command line. 
#### Repositories
Create a new empty git repository in the current directory  
<code>git init</code>

Clone a remote repository to the current directory  
<code>git clone [url-to-repo]</code>

#### Branches
Create a new branch  
<code>git branch [branch-name]</code>

Switch to another branch/tag/commit  
<code>git checkout [branch-name/tag/commit-hash]</code>

Switch to another branch from remote (useful for code review)  
<code>git checkout --track [origin/branch-name]</code>

Create a new branch and switch to it  
<code>git checkout -b [branch-name]</code>

Delete a branch  
<code>git branch -d [branch-name]</code>

#### Inspect
View file status  
<code>git status</code>

View commit history  
<code>git log</code>

View commit history for a specific contributor  
<code>git log --author="Erik Comstedt"</code>

Show the difference between two files  
<code>git diff [/path/to/file1] [/path/to/file2]</code>

#### Commit and push
Add a file to staging  
<code>git add [/path/to/file]</code>

Remove a file from staging  
<code>git rm [/path/to/file]</code>

Creates a commit with all staged files  
<code>git commit -m [commit-message]</code>

Push all outgoing commits to a branch  
<code>git push [origin] [branch-name]</code>

Push all outgoing commits to a branch and sets upstream  
<code>git push -u [remote/branch-name]</code>

#### Sync and merge
Fetch all history from remote branch  
<code>git fetch [remote/branch-name]</code>

Reapply commits *on top* of another branch  
<code>git rebase [branch-name]</code>

Merge branch *into* current branch  
<code>git merge [branch-name]</code>

Fetch all history from remote branch and merge into current branch  
<code>git pull [branch-name]</code>

#### Oops, I messed up..
Undo all commits performed after the specified commit  
<code>git reset [commit-hash]</code>

Revert local repository back to an earlier point in history (will discard any changes)  
<code>git reset --hard [commit-hash]</code>

#### Show or configure git settings
Show global .gitconfig  
<code>git config --list --global</code>

Show system .gitconfig  
<code>git config --list --system</code>

Show local .gitconfig  
<code>git config --list --local</code>

Edit global .gitconfig  
<code>git config --edit --global</code>

Edit system .gitconfig  
<code>git config --edit --system</code>

Edit local .gitconfig  
<code>git config --edit --local</code>
