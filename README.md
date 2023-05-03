# adventours

# Update database

Add-Migration <Migration name>

Update-Database -StartupProject Adventours.API -Project DataAccess -Context AdventoursContext -Args '"Data Source=SERVERNAME.database.windows.net;Initial Catalog=DATABASENAME;User ID=USERNAME;Password=XXX"'
