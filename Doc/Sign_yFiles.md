License conditions for yFiles dictates that code calling yFiles either has to be obfuscated or strong name signed.
SesammTool has decided to use signed dlls to fulfill the license requirement.

Since a signed dll requires that all dlls that it depends on are also signed, the yFiles dlls has to be signed.  
For other dependencies that also has to be signed, the preferred solution is to use signed packages from nuget. For sprache there exist no signed nuget-package so there we sign that packages as part of the build process as described in the StrongNameSigner package. 

[yFiles documentation for signing](https://docs.yworks.com/yfileswpf/#/dguide/signing?mode=namespaces#top)

Following the instructions from yFiles we have obtained an updated license-file that is related to the snk-file 
found here: *.\SesammTool2\SesammTool2.snk*. 

*"Never send the snk-file to yFiles, extract the public key using *sn -p SesammTool2.snk publickey.snk* and 
send publickey.snk to yFiles."*  
This we only have to do once.

To sign the yFiles dll's we use the [StrongNameSigner](https://github.com/brutaldev/StrongNameSigner/) nuget package as suggested by yFiles. 

The same snk-file as above has to used when signing yFiles dll's.
   ###  Upgrade yFiles to the latest version:
1. Normally the technical contact for yFiles in SesammTool 2 team get an e-mail when a new version is available. The download link is included in the email and is:
https://downloads.yworks.com/sdm/customer.html
2. Login with your username and password
7. Download the latest zip-file
8. Extract and copy the dll files in lib\net40 folder to [Gitrepo]\SesammTool2\libs\yFiles
9. Rename yWorks.yFilesWPF.DevelopmentLicense.xml to yWorks.yFilesWPF.DevelopmentLicenseUseOtherLicense.xml

1. Open command prompt
2. Change directory to where strong-name signer is located (current version) *./packages\Brutal.Dev.StrongNameSigner.2.3.0\build*
3. Sign all yFiles dlls in yFiles folder:  
   ```>StrongNameSigner.Console.exe -in ..\..\..\libs\yFiles\ -k ..\..\..\SesammTool2.snk```
4. Commit the updated dll's (the unsigned backup copies should not be committed)

 
