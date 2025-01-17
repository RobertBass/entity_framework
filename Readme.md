# Entity Framework Core

## Create a new project
```bash
# Create a new project in the current directory
dotnet new web
```

## Add Entity Framework Core and Utils
```bash
# Add Entity Framework Core
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

## Install PostgreSQL

### Install PostgreSQL on Windows

1. Download the installer from [here](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads)
2. Run the installer and follow the instructions
3. Open the PostgreSQL command line tool by searching for it in the Start menu
4. Create a new user by running the following command:

```bash
createuser -P -s -e username
```

### Install PostgreSQL on Linux

1. Install PostgreSQL by running the following command:

```bash
sudo apt-get install postgresql
```

2. Create a new user by running the following command:

```bash
sudo -u postgres createuser -P -s -e username
```

4. Exit the PostgreSQL command line tool by pressing Ctrl + D


## Install dotnet-ef

1. Install dotnet-ef by running the following command:

```bash
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.1

```

2. Verify the installation by running the following command:

```bash
dotnet ef --version
```

3. Create a new migration by running the following command:

```bash
dotnet ef migrations add InitialCreate --context TaskContext
```

4. Apply the migration by running the following command:

```bash
dotnet ef database update
```

5. Run the application by running the following command:

```bash
dotnet run
```


# Some useful commands for PostgreSQL prompt

## Create a new database
```bash
createdb -U username DatabaseName
```

## Create a new user
```bash
createuser -P -s -e username
```

## Create a new table
```bash
CREATE TABLE Categories (
    CategoryId UUID PRIMARY KEY,
    Name VARCHAR(150) NOT NULL,
    Description VARCHAR(500)
);
```
## Command Prompt of PostgreSQL
```bash
psql -U username -d DatabaseName
```

## Create a new column
```bash
ALTER TABLE Categories ADD COLUMN Description VARCHAR(500);
```

## Delete a column
```bash
ALTER TABLE Categories DROP COLUMN Description;
```

## Delete a table
```bash
DROP TABLE Categories;
```

## Delete a database
```bash
dropdb -U username DatabaseName
```

## Delete a user
```bash
dropuser -U username username
```

## List all databases
```bash
\l
```

## List all tables
```bash
\dt
```

## List all columns
```bash
\d Categories
```

## List only the column names
```bash
SELECT column_name 
FROM information_schema.columns 
WHERE table_schema = 'public' 
AND table_name = 'Name_of_the_table';
```

## List all rows
```bash
SELECT * FROM Categories;
```

## Insert a row
```bash
INSERT INTO Categories (Name, Description) VALUES ('Category Name', 'Category Description');
```

## Update a row
```bash
UPDATE Categories SET Name = 'New Category Name' WHERE CategoryId = '00000000-0000-0000-0000-000000000000';
```

## Delete a row
```bash
DELETE FROM Categories WHERE CategoryId = '00000000-0000-0000-0000-000000000000';
```
