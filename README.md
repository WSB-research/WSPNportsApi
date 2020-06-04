# WSBNports API/Database access

We now have a working Cosmos database storing JSON documents representing a single NPORT file. There's about 4500 NPORT files in this database currently, by my estimation there's about 16,000 on the SEC website that still need to be scraped, but it costs an arm and leg to squeeze it into the database so it's slow going. 

The Cosmos DB is partitioned by Filer CIK Number. We needed a partition for faster querying, and cross partition querying is quite difficult. If we need to make another collection with this data using a different partition, let me know. 

## OData Documentation
Here's comprehensive documentation on using OData for querying: 

`https://www.odata.org/documentation/`

## Sample Queries

This query fetches the unique/distinct Filer CIK numbers in the database: 

`https://wsbnport.azurewebsites.net/odata/nports/FilerCiks`

This query is a sample used to fetch all NPORT files for the Filer CIK 0001605941:

`https://wsbnport.azurewebsites.net/odata/nports('0001605941')?$count=true`

This query is a sample/subset of the previous query, fetching all NPORT filings for that Filer where the Series Name contains the word "GAMCO": 

`https://wsbnport.azurewebsites.net/odata/nports('0001605941')?$count=true&$filter=contains(formData/genInfo/seriesName, 'GAMCO')`

This query takes the Filer CIK 0000892538 and filters for filings where they had a holding with the name 'Dollar General Corp'

`https://wsbnport.azurewebsites.net/odata/nports('0000892538')?$count=true&$filter=formData/invstOrSecs/invstOrSecArray/any(x: x/name eq 'Dollar General Corp')`

## Schema

I will warn users; some fields can be either an object or an array of that object. 

Schema can be found here:

`https://app.quicktype.io?share=WhebQbQXzr0itDwdehz3`


