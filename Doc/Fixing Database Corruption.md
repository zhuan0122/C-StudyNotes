There is a recurring bug where results of a Deep Copy is comitted without the component being comitted. This causes sporadic crashes in some parts of the code where we expect the Component field for an Allocation Element to not be null.
To detect such errors in the database, use the following SQL query:

``` SQL 
SELECT aea.Id, aeeb.Workspace, aeeb.CommittedBy, aeeb.CommitTimestamp FROM AllocationElementAnchors as aea
inner join EntityBase as aeeb on aeeb.[Key] = aea.[Key]
inner join ComponentAnchors as ca on aea.ComponentKey = ca.[Key]
inner join EntityBase as caeb on ca.[Key] = caeb.[Key]
where caeb.IsInWorkspace = 1 and aeeb.IsInWorkspace = 0
```

If the result from this query is not empty, this means that the data is "corrupted" by this bug.

Fixing this problem can be done one of two ways. Either commit the components, or uncommit the allocation elements with their allocation element ports.
Uncommiting the allocation elements is most easily done by uncommitting the entire commit. 

Uncommiting the commit can then be done with the following statement:

``` SQL
UPDATE eb
SET eb.IsInWorkspace = 1
FROM EntityBase as eb
WHERE EXISTS
 (
    SELECT 1 FROM AllocationElementAnchors as aea
    inner join EntityBase as aeeb on aeeb.[Key] = aea.[Key]
    inner join ComponentAnchors as ca on aea.ComponentKey = ca.[Key]
    inner join EntityBase as caeb on ca.[Key] = caeb.[Key]
    where caeb.IsInWorkspace = 1 and aeeb.IsInWorkspace = 0
        and aeeb.Workspace = eb.Workspace 
        and aeeb.CommittedBy = eb.CommittedBy
        and aeeb.CommitTimestamp = eb.CommitTimestamp
)
```

This will uncommit all versions and anchors that were part of a commit that corrupted the database this way.