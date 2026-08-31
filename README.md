# Start of read me file for #whatsinmycity



## SQL Server requirements** 



**Version: 2022 (16.x) or newer** 



## Creating the database 



1. In SQL MMS, click on File > Open > 00\_Create\_Database\_Schema.sql

2. Execute the query and wait until finish
3. Open Object explorer and confirm 'whatsinmycity' appears

## Connecting to the database

Make use of the database connection helper class "DatabaseHelper.cs". 
1. In app.config edit the connection String, by copying in your own local connection string
3. if using SQL Express, your connectionString will have Data Source = localhost\SQLEXPRESS

## Example for executing Database Operations in each form
```csharp
using (SqlConnection connecton = DatabaseHelper.GetConnection())
{
    connection.Open(); 

    // Database operation here

    connection.Close();
}
```



