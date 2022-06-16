1. Create and open an empty migration in your local working database
   
run command: 
   add-migration ReplaceAccUnitInCanSignalVersionTable -ProjectName DataLayer –StartupProjectName DbMigration –ConnectionStringName SesammToolDev

   in my local has server localhost, database name: SesammTool2 
   

   there are many projects in ST2, we open migration on project DataLayer and DbMigration. 
   Project and startupproject name are fixed. Migration name is added by user -- descriptve name 

  ConnectionStringName is from startupproject, I changed the Catalog to be Sesammtool2 
   <add name="SesammToolDev" connectionString="data source=localhost;initial catalog=SesammTool2;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />

   The first name is not very important here as long as it is the same as Context model. since in our ST2 context constructor we have set; public SesammToolContext(string connectionString) : base(connectionString) 
   so it will accpet any name. 
  
  dataSource is server name, now I am working on localhost so it should be localhost, initial Catalog is the database name we have in our local host, mine is SesammTool2. 

2. Uppdate your current connected database in the server.
   
Run command: 
Update-Database -verbose -ConnectionStringName Production -StartUpProjectName SesammTool2 -ProjectName DataLayer

now we need to follow the app,config or connectionstring in our ST2 project, 
 <add name="Production_test" connectionString="data source=localhost;initial catalog=SesammTool2;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />

 similary the connectionstring name does not matter, any name will be accepted. I name it as Production_test. It should be Production in normal case. 
 datasource: localhost server for local working
 catalog: connected database is SesammTool2 

 
3. after run step 1 and 2, my localhost server's database SesammTool2 has got its columns unit updated. '
   all m/s2 are replaced by m/s²

4. I guess: if I need to update our production database I need to change server to SECO13424 that's it


   Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Degrees (C)','°C'");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees Celcius','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degree C','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degC','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'C','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Celsius','°C')");





*****************************
### Common errors may appear during adding-migration and update-database in EF6
***************************


1. error1: No get-package command: clean solution and rebuild or build solution. then open console again 

2. error2: Exception calling "LoadFrom" with "1" argument(s): "Could not load file or assembly 
'file:///C:\Users\HZHSXR\code\ST2\SesammTool2\packages\EntityFramework.6.4.4\tools\EntityFramework.PowerShell.Utility.dll' or one of its 
dependencies. The system cannot find the file specified."

-- Use EntityFramework6\add-migratoin ..... 

3. error 3: Could not load type 'System.Data.Entity.Infrastructure.Design.Executor+Scaffold' from assembly 'EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'.

--update-package EntityFramework (wthout version -Version:xxx set, it will update to the latest version)
I add-migration with project DataLayer so I only update pacakge in DataLayer. I did not update pacakge in any other project. keep them as same 

4. error : updte-database with build fail: DataLayer build fail: Add this tagen
/// <summary>
    /// Update Temperature unit in CansignalVersionTable
    /// </summary>

5. error: update-database: Exception calling "LoadFrom" with "1" argument(s): "Could not load file or assembly 
   -- EntityFramework6\Update-Database -verbose -ConnectionStringName Production -StartUpProjectName SesammTool2 -ProjectName DataLayer

6. ?? do I need to set DataLayer(Project name) as startup project to add-migration or any project would be okay? 
    --No, when i add-migration, I still have SesammTool2 as my satrtup project but I set DataLayer in package console 


**********
Temp:
Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Degrees (C)','°C')");   --25 
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees Celcius','°C')");  1
             Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees celcius','°C')");  3

             Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees C','°C')");  42 

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degree C','°C')");   2

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Celsius','°C')");  21



            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degC','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'C','°C')"); 

             Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'deg °C','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°Cel°Cius','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees °C','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°°C','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees °°C','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees °C','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°Cel°Cisus','°C')");

            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Grad°C','°C')");



            new: 
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'C','°C')"); 
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Celcisus','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Celcius','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Celsius','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'deg C','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degC','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degree C','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Degrees (C)','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees C','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees Celcius','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees celsius','°C')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'GradC','°C')");




acc:
 Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'm/s^2','m/s²')");
 Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'm/sÂ²','m/s²')");
 Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'm/s2','m/s²')");

 Sql("UPDATE dbo.CanSignalVersions SET Unit= 'm/s²' WHERE FullName LIKE '%RT%RelLongAcceleration'");
 Sql("UPDATE dbo.CanSignalVersions SET Unit= 'm/s²' WHERE FullName LIKE '%Track%Relative%Longitudinal%Acceleration'");


 Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'm/s2','m/s²')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'm/sÂ²','m/s²')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'm/s^2','m/s²')");
            Sql("UPDATE dbo.CanSignalVersions SET Unit= 'm/s²' WHERE FullName LIKE '%RT%RelLongAcceleration'");
            Sql("UPDATE dbo.CanSignalVersions SET Unit= 'm/s²' WHERE FullName LIKE '%Track%Relative%Longitudinal%Acceleration'");


* If you want to run your last two added migration then go back to the status before these migration with:
* 
  EntityFramework6\update-database -TargetMigration:202103171016091_SplitTables -ConnectionStringName Production -StartUpProjectName SesammTool2 -ProjectName DataLayer

  then EF will run down() in these added migration tables on your database if you put down method as empty.then nothing is reverted. 
  then you could change your current these two added migration tables in upp method if you need or find some changes are needed
  then run this command: it will apply two changed added migration since the target migration methioned above

  EntityFramework6\update-database -verbose -ConnectionStringName Production -StartUpProjectName SesammTool2 -ProjectName DataLayer

  then it will rerun all up methods in the afterwards migrations since the target one. 

  * but usually if we find we want to patch some bugs we just open a new migration and do the changes and synchorize the down methods. 

* if you get failed to restore backup then open SQL configuration 2019 and restart the sql sever there then go back to restore backup again
it will work .
if you failed to connect to WMI 2019 provider then follow this fixing: https://www.sqlnethub.com/blog/how-to-resolve-cannot-connect-to-wmi-provider-sql-server-configuration-manager/


namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Backup Unit column before changing it
    /// </summary>
    public partial class ReplaceTempUnitInCanSignalVersionTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees celsius','°C')"
                 + "WHERE FullName Like '%Cab Temperature%'");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees Celcius','°C')"
                 + "WHERE FullName Like '%FuelPumpTemp%'");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Degrees (C)','°C')"
                 + "WHERE FullName IN " +
                 "('Low Beam Temp', 'Low Beam Left Temp', 'High Beam Or Motorway Temp', 'DRL and Position Temp', " +
                 "'Direction Indicator Temp', 'Control Unit Temp', 'ADB Temp')");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degrees C','°C')" +
                    "WHERE " +
                    "(FullName LIKE '%ambient%Temp%' OR FullName LIKE '%Cab%Coolant%Temp%' " +
                    "OR FullName LIKE '%Cab%Evaporator%Temp%' OR FullName LIKE '%Coolant%Temperature%Heater%'" +
                    "OR FullName LIKE '%Current%Temperature%' OR FullName LIKE '%Delivered%Temperature%' " +
                    "OR FullName LIKE '%EC%Trnstr%Temp%' OR FullName LIKE '%Electric%machine%Heat%Exchanger%Temp%'" +
                    "OR FullName LIKE '%EmHeatEx2CoolantTemp%' OR FullName LIKE '%Inverter%Coolant%Temp%' OR FullName LIKE '%Mgu%BusBar%Temp%'" +
                    "OR FullName LIKE '%Mgu%Temp%' OR FullName LIKE '%HeaterTemperature%' OR FullName LIKE '%PCB%Temperature%Heater%'" +
                    " OR FullName LIKE '%Pre%Departure%Temp%' OR FullName LIKE '%Requested Temperature%')");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'degree C','°C')"
                 + "WHERE FullName Like '%Outdoor%Temp%'");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, 'Celsius','°C')"
                 + "WHERE " +
                 "FullName Like '%BatteryCoolingInletTemp%' OR FullName LIKE '%Chipset%Temperature%'" +
                 " OR FullName LIKE '%CoolPump%Temp%' OR FullName LIKE '%Display%Temperature%' " +
                 "OR FullName LIKE '%PCB%Temperature%' OR FullName LIKE '%Cab%Temperature 1%' " +
                 "OR FullName LIKE '%Subjective%Cab%Temperature%' OR FullName LIKE '%MPUmotorTemperature%'" +
                 "OR AnchorKey IN (73287,73291, 73346,83949, 83953, 83957,93370, 93379, 93383 )");
        }
        
        public override void Down()
        {
            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°C','degrees celsius')"
                  + "WHERE FullName Like '%Cab Temperature%'");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°C','degrees Celcius')"
                 + "WHERE FullName Like '%FuelPumpTemp%'");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°C','Degrees (C)')"
                 + "WHERE FullName IN " +
                 "('Low Beam Temp', 'Low Beam Left Temp', 'High Beam Or Motorway Temp', " +
                 "'DRL and Position Temp', 'Direction Indicator Temp', 'Control Unit Temp', 'ADB Temp')");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°C','degrees C')" +
                   "WHERE " +
                   "(FullName LIKE '%ambient%Temp%' OR FullName LIKE '%Cab%Coolant%Temp%' " +
                   "OR FullName LIKE '%Cab%Evaporator%Temp%' OR FullName LIKE '%Coolant%Temperature%Heater%'" +
                   "OR FullName LIKE '%Current%Temperature%' OR FullName LIKE '%Delivered%Temperature%' " +
                   "OR FullName LIKE '%EC%Trnstr%Temp%' OR FullName LIKE '%Electric%machine%Heat%Exchanger%Temp%'" +
                   "OR FullName LIKE '%EmHeatEx2CoolantTemp%' OR FullName LIKE '%Inverter%Coolant%Temp%' OR FullName LIKE '%Mgu%BusBar%Temp%'" +
                   "OR FullName LIKE '%Mgu%Temp%' OR FullName LIKE '%HeaterTemperature%' OR FullName LIKE '%PCB%Temperature%Heater%'" +
                   " OR FullName LIKE '%Pre%Departure%Temp%' OR FullName LIKE '%Requested Temperature%')");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°C','degree C')"
                 + "WHERE FullName Like '%Outdoor%Temp%'");

            Sql(@"UPDATE dbo.CanSignalVersions SET Unit =REPLACE(Unit, '°C','Celsius')"
                 + "WHERE " +
                 "FullName Like '%BatteryCoolingInletTemp%' OR FullName LIKE '%Chipset%Temperature%'" +
                 " OR FullName LIKE '%CoolPump%Temp%' OR FullName LIKE '%Display%Temperature%' " +
                 "OR FullName LIKE '%PCB%Temperature%' OR FullName LIKE '%Cab%Temperature 1%' " +
                 "OR FullName LIKE '%Subjective%Cab%Temperature%' OR FullName LIKE '%MPUmotorTemperature%'" +
                 "OR AnchorKey IN (73287,73291, 73346,83949, 83953, 83957,93370, 93379, 93383 )");
        }
    }
}


Sql("dbo.CanSignalVersions SET Unit = '°C' WHERE Unit = Celcisus ");
            Sql("dbo.CanSignalVersions SET Unit = '°C' WHERE Unit = Celcius ");
            Sql("dbo.CanSignalVersions SET Unit = '°C' WHERE Unit = Celsius ");
            Sql("dbo.CanSignalVersions SET Unit = °C WHERE Unit LIKE '%deg%C%' ");
            Sql("dbo.CanSignalVersions SET Unit = °C WHERE Unit = GradC ");
            Sql("dbo.CanSignalVersions SET Unit = °C WHERE Unit LIKE '%Deg%(C)%' ");

             Sql("dbo.CanSignalVersions SET Unit='°C' WHERE (Unit='C' OR Unit='Celcisus' " +
                "OR Unit='Celcius' OR Unit='Celsius' OR Unit LIKE '%deg%C%' OR Unit='GradC' " +
                "OR Unit LIKE '%Deg%(C)%' ) ");


                 Sql(@"UPDATE dbo.CanSignalVersions SET Unit= '°C' WHERE ( FullName LIKE '%Temp%' AND Unit='C')");
            Sql(@"UPDATE dbo.CanSignalVersions SET Unit= '°C' WHERE (FullName LIKE '%Temp% AND Unit LIKE 'Cel%i%us%')");
            Sql(@"UPDATE dbo.CanSignalVersions SET Unit= '°C' WHERE ( Unit LIKE '%deg%C%' OR Unit = 'GradC') ");
        }


        EntityFramework6\Update-Database -TargetMigration:202103171016091_SplitTables -ConnectionStringName Production -StartUpProjectName SesammTool2 -ProjectName DataLayer