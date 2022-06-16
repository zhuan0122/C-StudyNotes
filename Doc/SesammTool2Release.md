1.	**Create release branch**  
  Select CI/CD -> Pipelines and run manual staging step for last commit in develop branch. The script performs the following:    
  *  Creates a new release branch updated version number
  *  Updates changelog with version number and commit comments 
  *  Creates staging click once deployment

2.	**Run smoketests (read smoketests.md)**

3. **Open solution from release branch**  
Change visual studio configuration to **“Release”** and **“Any CPU”**.

4.	**Prepare the Release Notes**  
Edit SesammTool2/Resources/ChangeLog.txt file.  

5.	**Database changes**  
If there are any database changes, the scripts to perform the database updates will  be found in the folder `Release/[ReleaseName]/Scripts`.  
Take a backup of the database and then run the scripts.

6.	**Do some smoke tests (not the same as in SmokeTests.doc)**  
Do a rebuild of SesammTool 2 in **“Release”** and **“Any CPU”**.    
  * Check that correct data base server and instance is used
  * Check that the changelog is correct

7.	**Publish SesammTool 2**    
Right click SesammTool2 , click Properties -> Publish. 
  * Make sure again that Visual Studio Configuration is set to “Release”.
  * Make sure that the minimum application version number  is updated, click Updates… 
   Verify “Publish version” and click **Publish Now**. 
  * Verify that Sesamm Tool 2 starts from your local computer.
  * Verify that Sesamm Tool 2 starts from a conference room.


8.	**If there are changes in your local release branch, Push them to GitLab**    
  * Commit local changes to release-branch
  * Push Changes in release branch to GitLab
  
9.  **If you are going to do a write release it is time to do that now**
  * Merge from read-read branch to write-release branch (should normally only be ChangeNotes, but could also be other small fixes from read-release-branch)
  * Perform step 3, 5, 6, 7 and 8 for the write release

10.	**Finalize release**  
  Select CI/CD -> Pipelines and run finalize release step for last commit in release branch. The script performs the following:    

* Creates two merge requests to master and develop  
* Tags master branch with format v{Version}. 
Example:  v0.0.0.40  

11. **Approve and accept merge request in Gitlab (Delete Source branch but do not squash commits).**

12. **Delete the release branch**


