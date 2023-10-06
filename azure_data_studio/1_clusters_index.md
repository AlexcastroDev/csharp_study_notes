
# Clustered Keyword

The CLUSTERED is the default means that the table will be clustered by the primary key. It refer to the way data is physically stored in the table.
When you create a clustered index on a table, all the rows in the table are stored in the order of the clustered index key. Therefore, there can be only one clustered index per table, because the data rows themselves can be sorted in only one order.

## key points about clustered indexes

- Only One Per Table: A table can have only one clustered index because the actual data rows can only be stored in one order.

- Physical Order: With a clustered index, the rows are stored on the disk in the order specified by the index key. This means that the data is physically sorted in the order of the clustered index.

- Improved Performance for Range Queries: Clustered indexes can improve the performance of queries that involve ranges of values because the data is physically stored in that order.

- Data Modification Overhead: Inserting, updating, or deleting data can be more expensive with a clustered index because when you modify a row, it may need to be physically relocated to maintain the order specified by the index.

- Primary Key Is Often Clustered: In many cases, the primary key of a table is made a clustered index. This is because it's often used for searching, and physically organizing the data in this way can provide performance benefits.

- Covering Index: A clustered index can act as a covering index for queries that use the columns in the index key. This means that all the information needed by a query is available in the index itself, so the SQL Server engine doesn't have to look up the actual data rows.

What is the difference between a clustered and a non-clustered index?

A clustered index determines the physical order of data in a table. A table can have only one clustered index. A non-clustered index is a special type of index in which the logical order of the index does not match the physical stored order of the rows on disk. The leaf nodes of a non-clustered index do not consist of the data pages. Instead, the leaf nodes contain index rows.

# Non-Clustered Keyword

A non-clustered index is a special type of index in which the logical order of the index does not match the physical stored order of the rows on disk. The leaf nodes of a non-clustered index do not consist of the data pages. Instead, the leaf nodes contain index rows.

# Index vs Clustered Index

An index and a clustered index serve similar purposes in a database, but they have key differences:

Index:

An index is a database object that improves the speed of data retrieval operations on a table at the cost of additional storage space and decreased performance on data modification operations (inserts, updates, and deletes).

An index contains a sorted list of references to the actual data rows in a table. It's like an ordered list of pointers to the records.

A table can have multiple indexes, and each index can be created on one or more columns of the table.

Indexes can be either clustered or non-clustered.

A non-clustered index does not affect the physical order of the actual data on disk. It is a separate structure that points to the data.

Clustered Index:

A clustered index is a type of index where the actual data rows are physically ordered on the disk based on the index key. This means the data is stored in the same order as the index.

A table can have only one clustered index because the physical organization of the data can only be in one order.

The clustered index key is typically used as the primary key for a table, but this is not a strict rule. Any unique key can be used.

Because the data is physically ordered based on the clustered index key, queries that use the key for searching or ranges of values can be faster.

Inserting, updating, or deleting data in a table with a clustered index can be more expensive because it may require physically reorganizing the data to maintain the order specified by the index.

In summary, while both indexes and clustered indexes serve to improve query performance, a clustered index is specific in that it physically orders the actual data on disk. A regular (non-clustered) index is a separate structure that contains pointers to the data. It's possible to have multiple non-clustered indexes on a table, but a table can only have one clustered index.

# References

https://learn.microsoft.com/en-us/sql/relational-databases/indexes/clustered-and-nonclustered-indexes-described?view=sql-server-ver16

https://learn.microsoft.com/en-us/sql/relational-databases/indexes/create-clustered-indexes?view=sql-server-ver16