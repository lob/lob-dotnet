# Getting Started

This guide illustrates how to use the SDK to implement the following method patterns:

- CREATE
- LIST
- GET
- DELETE
- VERIFY (BANK ACCOUNTS)
- UPDATE

## INSTALL

```
$ dotnet add package lob.dotnet
```

## IMPORT AND INITIALIZE

```csharp
using lob.dotnet;

Configuration config = new Configuration();
config.Username = "<<YOUR API KEY HERE>>"
```
You then instantiate the specific resource API that you need access to as follows:

```csharp
api = new AddressesApi(config);
```

## METHODS

This abstracts the request/response interaction out of the calling code such that you create the resource and pass it to the corresponding API in a try/catch such that any non-success is an `ApiException` that must be handled.

### CREATE METHOD

Here is a sample of the CREATE method

```csharp
AddressEditable addressEditable = new AddressEditable(
  "210 King St",  // addressLine1
  "# 6100",  // addressLine2
  "San Francisco",  // addressCity
  "CA",  // addressState
  "94107",  // addressZip
  CountryExtended.US,  // addressCountry
  "Harry - Office",  // description
  "Harry Zhang",  // name
  "Lob",  // company
  "5555555555",  // phone
  "harry@lob.com" // email
);

try {
  Address result = api.AddressCreate(addressEditable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### LIST METHOD

Here is a sample of the LIST method:

```csharp
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
try {
  AddressList response = api.AddressesList(
    2, // limit
    null, // before
    null, // after
    includeList, // include
    dateCreated, // dateCreated
    metadata // metadata
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### GET BY ID METHOD

Here is a sample of the GET method:

```csharp
try {
  Address response = api.AddressRetrieve("adr_fa85158b26c3eb7c");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### DELETE METHOD

Here is a sample of the DELETE method:

```csharp
try {
  AddressDeletion response = api.AddressDelete("adr_43769b47aed248c2");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### BANK ACCOUNT VERIFY

Here is a sample of the BANK ACCOUNT VERIFY method:

```csharp
List<int> amounts = new List<int>();
amounts.Add(25);
amounts.Add(63);

BankAccountVerify verification = new BankAccountVerify(amounts);

try {
  BankAccount verified_account = api.BankAccountVerify("bank_dfceb4a2a05b57e", verification);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### UPDATE METHOD

Here is a sample of the UPDATE method:

```csharp
TemplateUpdate update = new TemplateUpdate("update template", "vrsn_362184d96d9b0c9");

try {
  api.TemplateUpdate("tmpl_c94e83ca2cd5121", update);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```
