# PowerSesamm Documentation

## Generate help documentation

We use a tool for generating help text for the powershell cmdlets in PowerSesamm.  
The tool is XmlDoc2CmdletDoc (https://github.com/red-gate/XmlDoc2CmdletDoc).  

The tool can be found in the following path ./Tools/XmlDoc2CmdletDoc (Relative to the root of the PowerSesamm project)  

### To generate new documentation:
Make sure that the project has the setting that generates an Xml-file from the summary comments.

Open a powershell prompt and change directory to the XmlDoc2CmdletDoc folder.

Execute the following command:
.\XmlDoc2CmdletDoc.exe "path to the powersesamm assembly"

A new PowerSesamm.dll-Help.xml file should now have been generated in the same folder as the assembly.
Copy that file to the root folder of PowerSesamm (Remember to check it out in perforce otherwise it won't show up as changed.)

## Commands:

All commands have the following parameters to enable it to target a specific databases:
* Server - The server to save the changes to.
* Database - The database on the server to save the changes to.
* Refresh - Refresh data from database.

Currently not possible to switch database without also including -Refresh if a specific database
has been selected already.

### Sync-ChangeRequests
This command syncs change requests from Jira to SesammTool.

The parameters are the following:
* CutOff - The date from which to search for change reqeusts (Checks updated date in Jira.)
* Username - Used by Jenkins to set the user with which to login to Jira with. If left blank the user will be prompted for credentials.
* Password - Same as previous.
* Projects - Defines the projects in which CRs should be searched for. Default is SSCR.

The command will run for a while and then when all the change requests have been loaded and processed it will save the changes to the database.

This command should be run after each new migration to ensure that there are change requests available for selection when editing entities.

### Sync-OasFpc
This command syncs fpc codes for user functions, use cases and scenarios from OAS.

The parameters are the following:
* Preview - Displays how many entities will be changed but does not commit the changes.

The command will update the field OasFpc on each instance if it has changed since the last sync.
This will then be saved to the database if the preview flag is not set.


