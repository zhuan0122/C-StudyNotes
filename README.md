# C-StudyNotes
Notes for learning C#
<<<<<<< HEAD

SV:
local develop branch var skapade först i lokal med command: git branch develop 
vi kan jobba direkt i lokal develop branch och sen git merge to local main branch och sen git push from lokal main till remote main. 
men om vi vill att göra main oberoende från develop och vi bara sckicka pull request när vi frågar merge ändring som vi har lagt till i remote develop branch (som också kallas remote sub-branch jämför med remote main branch) in enda repository. 

En: 
namely we have created local develop branch först then we push it to remote using **git push -u --set-upstream origin develop**
origin is the alias name for all remote repository irrespective of main or sub -branches. 
-u means tracking the diff between local and remote branches. 

EN:
I created an new branch locally called task1_name when I checked out in local develop branch. 1. git checkout develop 2. git branch task1_name
then push the local task1_name branch to remote and the remote mapping branch task1_name is created automatically by follwing command 
git push -u --set-upstream origin task1_name 

this origin task1_name is another subbranch same as origin/develop versus origin main. 
so this task1_name is not sync with origin develop. It only has contents as main has. could I say it is created from main? even I created locally after I checked out in develop local branch. ??

>>>>>>> task1_name

