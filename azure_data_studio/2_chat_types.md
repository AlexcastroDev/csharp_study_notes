# Char vs Varchar vs Nvarchar

## Char

Fixed-size string data. n defines the string size in byte-pairs, and must be a value from 1 through 4,000. The storage size is two times n bytes. For UCS-2 encoding, the storage size is two times n bytes and the number of characters that can be stored is also n. For UTF-16 encoding, the storage size is still two times n bytes, but the number of characters that can be stored may be smaller than n because Supplementary Characters use two byte-pairs (also called surrogate-pair). The ISO synonyms for nchar are national char and national character.

- Fixed length
- Maximum size of 8,000 characters
- When the data is shorter than the defined length, blank characters are appended to the right of the data
- When the data is longer than the defined length, SQL Server will generate an error message

## Varchar

- Variable length
- Maximum size of 8,000 characters
- When the data is shorter than the defined length, blank characters are appended to the right of the data
- When the data is longer than the defined length, SQL Server will truncate the extra characters

## Nvarchar

- Variable length
- Maximum size of 4,000 characters
- When the data is shorter than the defined length, blank characters are appended to the right of the data
- When the data is longer than the defined length, SQL Server will truncate the extra characters

Examples of usage:

```sql
CREATE TABLE [dbo].[CharVarcharNvarchar](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [CharColumn] [char](10) NULL,
    [VarcharColumn] [varchar](10) NULL,
    [NvarcharColumn] [nvarchar](10) NULL,
 CONSTRAINT [PK_CharVarcharNvarchar] PRIMARY KEY CLUSTERED ([Id] ASC)
)
```

Example of data 

Use cases for char, varchar and nvarchar

- char: When you know the length of the data will be the same for all rows
for example: a column that stores a two-character state abbreviation for each row, 


- varchar: When you know the length of the data will vary for each row, but the maximum length is less than 8,000 characters
- nvarchar: When you know the length of the data will vary for each row, but the maximum length is less than 4,000 characters


# References

https://learn.microsoft.com/pt-br/sql/t-sql/data-types/nchar-and-nvarchar-transact-sql?view=sql-server-ver16