## Manual migration


### 1. Obtaining a ST1 backup
1. Open SQL management studio and connect to **SESOCO3142**.
2. Right click the database in the list. Select **Tasks -> Back up..**.
3. Save the backup to **C:\Share\dbbackup**.
4. Open file explorer and navigate to **\\sesoco3142\dbbackup**.
5. **Move** the backup file to your local drive.
6. **Disconnect** from **SESOCO3142** in SQL management studio and **connect** to **localhost**.
7. If you already have SESAMMDB on localhost, you may want to delete it.
8. Right-click the databases folder and select **restore**. Select the backup file that you just moved as source.

### 2. Setting up an empty ST2 database
1. Download this [file](\\\sesoco3268\dbbackup\empty_database.bak) (it is a backup for an empty ST2 database) Located at \\\sesoco3268\dbbackup\empty_database.bak.
2. **Restore** the file. Name the database **SesammTool2_migration**.

## 3. Starting the migration
1. Verify that you have one database called *SESAMMDB* and one database called *SesammTool2_migration* on **localhost**.
2. Start visual studio and open up the SesammTool2 solution.
3. In the solution explorer, right-click on the **dbmigration** project and select *Set as Startup Project*. The project is located in the Tools folder.
4. Open the file Utils_Old/DefaultValues.cs.
5. Replace **"sesoco3268"** with **"localhost"** on line 14. Save the file.
6. Start the project by pressing ctrl+F5. A dialogue should appear. (Do not run the migration with the debugger attached. This will make everything take five times as long.)
7. Verify that SourceDb.Server and DestinationDb.Server is set to **localhost**. Also verify that SourceDb.DbInst is set to **SESAMMDB** and that DestinationDb.DbInst is set to **SesammTool2_migration**.
8. Press start migration.

## 4. Moving data to AlphaReadOnly
1. Once the migration has finished. Open up SQL management studio once more. Right click the database **SesammTool2_migration** and select **Tasks -> Export Data-Tier Application**.
2. Select the default settings, save the **.bacpak file** somewhere on your local drive.
3. **Disconnect** from **localhost** and **connect** to **sesoco3268**.
4. Right click databases, select **Import Data-Tier Application**. Select the **.bacpack file**, give the database the name  **SesammTool2_migration** and click continue.
5. Log in to **Jenkins** and select the job **MigartionLastStepOnly**.
6. Select **Build with parameters** from the left side menu.
7. Set **SesammTool2_migration** as *StagingDatabaseName*. Leave everything else as default. Click build.
