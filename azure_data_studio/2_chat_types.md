# nchar vs Char vs Varchar vs Nvarchar

## Char

Fixed-size string data. n defines the string size in bytes and must be a value from 1 through 8,000. For single-byte encoding character sets such as Latin, the storage size is n bytes and the number of characters that can be stored is also n. For multibyte encoding character sets, the storage size is still n bytes but the number of characters that can be stored may be smaller than n. The ISO synonym for char is character.

- Fixed length
- Maximum size of 8,000 characters
- When the data is shorter than the defined length, blank characters are appended to the right of the data
- When the data is longer than the defined length, SQL Server will generate an error message

## Varchar

- Variable length
- Maximum size of 8,000 characters
- When the data is shorter than the defined length, blank characters are appended to the right of the data
- When the data is longer than the defined length, SQL Server will truncate the extra characters


## NChar

Fixed-size string data. n defines the string size in byte-pairs, and must be a value from 1 through 4,000. 
The storage size is two times n bytes. For UCS-2 encoding, the storage size is two times n bytes and the number of characters that can be stored is also n. 

For UTF-16 encoding, the storage size is still two times n bytes, but the number of characters that can be stored may be smaller than n because Supplementary Characters use two byte-pairs (also called surrogate-pair). The ISO synonyms for nchar are national char and national character.

- Fixed length
- Maximum size of 4,000 characters
- When the data is shorter than the defined length, blank characters are appended to the right of the data
- When the data is longer than the defined length, SQL Server will generate an error message

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

# Important

A common misconception is to think that with char(n) and varchar(n), the n defines the number of characters. However, in char(n) and varchar(n), the n defines the string length in bytes (0 to 8,000). n never defines numbers of characters that can be stored. This is similar to the definition of nchar(n) and nvarchar(n).

# References

https://learn.microsoft.com/pt-br/sql/t-sql/data-types/nchar-and-nvarchar-transact-sql?view=sql-server-ver16

https://learn.microsoft.com/en-us/sql/t-sql/data-types/char-and-varchar-transact-sql?view=sql-server-ver16