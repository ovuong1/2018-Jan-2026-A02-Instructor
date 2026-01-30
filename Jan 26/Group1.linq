<Query Kind="Statements">
  <Connection>
    <ID>22afda9d-35b4-4438-a6c6-ec4906c9a3ad</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>WestWind-2024</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
</Query>

Invoices
	.GroupBy(i => i.OrderDate.Value.Year)
	.Select(g => new
	{
		Year = g.Key,
		Revenue = g.Sum(i => i.Quantity * i.UnitPrice)
		
	})
	.ToList()
	.Dump();