# Install Git for SesammTool

### Goal
At the end of this guide you will have installed Git-related tools needed to develop SesammTool2 using Git as source code repository. You have also created a local Git-clone of the SesammTool2-repository.

The following tools  and accounts will be installed:
1.	Create Gitlab account.
2.	Git for Windows (Git SCM for Windows).
3. Tortoise Git (Windows Shell Interface to Git, not mandatory but recommended)
4. GitStashExtension for Visual Studio (brings support for GitStash in TeamExplorer).

The steps have been tried on Windows 7, Windows 10 and Visual Studio 2017.
### Installation Steps

#### Create Gitlab account
* Go to gitlab.scania.com
* Start Authenticator app on your phone. 
* Click “+” and select “Annat”
* Scan the QR code
* Use the pin-code in the app and enter at gitlab login on computer
* Save the restore codes in a safe place
* Make sure that you are a member of the EPID group (ask another member of EPID)

#### Install git for windows
* Download and install latest git from Windows from https://gitforwindows.org/
* Use default values when installing

#### Install Tortois Git
* Download Installer for TortoiseGit 64 bit
https://tortoisegit.org/download/
* Start installation and use default values. The “Git.exe Path” should be automatically filled in if “git for Windows” was installed successfully in the section above.

#### Install VisualStudio.GitStashExtension in Visual Studio
* From Visual Studio go to “Tools | Extension And Updates”.
* Search and install VisualStudio.GitStashExtension for Visual Studio.
* Restart Visual Studio to finalize installation.

### Create Local Git Clone
Create Access Token to be able to Create the Git Clone.
* Navigate to gitlab.scania.com
* Log in
* Goto “logged in User” and select Settings
* Select “Access Token” in list to the left
* Create Personal Access Token with api-Scope. Never need to expire. You could give it any name (ex. “SesammTool2”).
* Use your user-Id and created token to login  when Creating the local Git-clone
* Create your local work folder (ex. c:\GitWork)
* Right-click on folder and select “TortoiseGit | Settings”
* In Network set Proxy-address: proxyseso.scania.com and Port: 8080
* Right-click on folder and select Git Clone…
* In Scania GitLab select Projects|SesammTool2
* Copy URL to Clipboard. Use Url in Git-Clone dialog

Now you should have a folder with a local Git Clone of SesammTool2 
How to use Git for SesammTool2 will be described elsewhere…
