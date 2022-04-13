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

I have one task1 sub branch local and origin for doing my task 
when it is done I want to merge my remote branch to develop. 
but how could I make my task branch inherits all files from develop not main? 
CONFILICTS happens since our two branches develop and task1_name all changed file README file
then we need resove the conflict then merge task1_name to develop (this is caused by not creating task1_name from develop branch not sync with it from begining then 
later we want merge task1_name to develop. conflicts. if we added change in another file that develop did not change, we could do merge without conflict )
 but usually we need our develops file to do our task1 so think about this?? 

when I check out develop branch 
and then git branch task2 there. 
ls task2 files 
I see the files are from develop 

how about main? yeah mains files like README is empty so if I git checkout main and create branch där i got the empty README file in my task3_frommain branch 
i TEST IT AGAIN with git branch task4_fromdev in develop branch checked out first then all files in task4_fromdev will inherit from develop!!!
