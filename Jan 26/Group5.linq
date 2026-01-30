<Query Kind="Statements">
  <Connection>
    <ID>e911c88b-78d8-48b8-9b71-c4628c7c6afb</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Contoso</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

Invoices
	.GroupBy(i => new {Country = i.Customer.Geography.RegionCountryName,
						i.DateKey.Date.Year})
	.Select(g => new
	{
		 g.Key.Country,
		g.Key.Year,
		Orders = g.Select(inv => new
		{
			OrderID = inv.InvoiceID,
			Customer = inv.Customer.FirstName + " " + inv.Customer.LastName
		})
		.OrderBy(inv => inv.OrderID)
		.ToList()
	})
	.OrderBy(g => g.Country)
	.ThenBy(g => g.Year)
	.ToList()
	.Dump();