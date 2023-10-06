# Azure Data Studio

To starting using MSSQL, im gonna use this docker-compose, because i am using MAC:

```yaml
version: '3.8'
services:
  mssql:
    image: mcr.microsoft.com/azure-sql-edge
    environment:
      - ACCEPT_EULA=Y
      - SA_PASSWORD=Admin123@@
      - MSSQL_PID=Developer
    ports:
      - 1433:1433
    volumes:
      - ./data:/var/opt/mssql
```

To start the container, just run:

```bash
docker-compose up -d
```

Creating a new database

```sql
CREATE DATABASE [Alekinho]
```

Creating a new table

```sql
CREATE TABLE [dbo].[Alekinho](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    CONSTRAINT [PK_Alekinho] PRIMARY KEY CLUSTERED ([Id] ASC)
)
```

Add a column called name in table

```sql
ALTER TABLE [dbo].[Alekinho] ADD [Name] [varchar](50) NULL
```

