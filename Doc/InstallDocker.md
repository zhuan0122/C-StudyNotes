**Install docker**

* Open Control Panel
* System and Security
* Programs (List on left side)
* Turn Windows Features On or Off
* Enable Hyper-V (restart required)

* Follow instructions on Scania-Wiki (Docker For Windows 10)
  * Download Docker Desktop App
  * Install  (Use Windows Container)
  * Note! Start *Computer Management* as CLA
  * To change proxi settings (Start Docker settings in System Tray)
* Clone gitlab project with script that builds the docker image   (EPID/CI_CD_Scripts)
* Look in SesammTool2-folder and look at Readme
* In PowerShell cd to folder with Dockerfile that you have updated
* build and push docker mage according to instructions in Readme


**Building a new container**  
We are currently using a docker container during our CI build and test process. This section will provide instructions on how to create a new such a container, if the current container has to be replaced for some reason.

A new image can be created from a *Dockerfile*. The Dockerfile that we are currently using is located in the EPID CI/CD scripts project and can be found [here](https://gitlab.scania.com/EPID/CI_CD_Scripts/blob/master/docker/Dockerfile). In the Dockerfile we define settings and dependencies for our new image. Once you are satisfied with the contents of the image, you can create an image using the following command:  
 `docker build -t $container-name -m 2GB`  

 This will create a new docker image locally. Once you have tested everything, you can push the docker image to our Gitlab container registry by using the following command:  
 `docker push $container-name -m 2GB`  
 Make sure to update the *gitlab-ci.yml* file with the new image name once the image has been pushed.


 **Cleaning docker containers on Gitlab runner**

 Sometimes there may be problems on the Gitlab runner. This can often be solved by adding the following commands to the setup stage of the gitlab-ci.yaml file.  
 `docker container kill $(docker ps -q)`  
 `docker system prune -af`  
 This will remove all unused images and containers, not just dangling ones. In order to perform this cleanup, replace the docker system prune command in the cleanup stage in the .gitlab-ci.yml file with the two commands from above. Then proceed to push the updated .gitlab-ci.yml file to a new branch. This will force the runner to delete containers. Once the job has finished running, the runner will be cleaned up and the branch may be deleted.


 Further instructions for building containers can be found in the [EPID CI/CD scripts project](https://gitlab.scania.com/EPID/CI_CD_Scripts).
