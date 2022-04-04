# C-StudyNotes
Notes for learning C#

SV:
local develop branch var skapade först i lokal med command: git branch develop 
vi kan jobba direkt i lokal develop branch och sen git merge to local main branch och sen git push from lokal main till remote main. 
men om vi vill att göra main oberoende från develop och vi bara sckicka pull request när vi frågar merge ändring som vi har lagt till i remote develop branch (som också kallas remote sub-branch jämför med remote main branch) in enda repository. 

En: 
namely we have created local develop branch först then we push it to remote using **git push -u --set-upstream origin develop**
origin is the alias name for all remote repository irrespective of main or sub -branches. 
-u means tracking the diff between local and remote branches. 

