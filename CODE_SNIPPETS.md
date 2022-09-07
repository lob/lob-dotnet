# Code Snippets

## Addresses Api

### Retrieve
```bash
curl https://api.lob.com/v1/addresses/adr_fa85158b26c3eb7c \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
AddressesApi api = new AddressesApi(config);

try {
  Address response = api.get("adr_fa85158b26c3eb7c");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/addresses/adr_43769b47aed248c2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
AddressesApi api = new AddressesApi(config);

try {
  AddressDeletion response = api.delete("adr_43769b47aed248c2");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/addresses \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Harry - Office" \
  -d "name=Harry Zhang" \
  -d "company=Lob" \
  -d "email=harry@lob.com" \
  -d "phone=5555555555" \
  -d "address_line1=210 King St" \
  -d "address_line2=# 6100" \
  -d "address_city=San Francisco" \
  -d "address_state=CA" \
  -d "address_zip=94107" \
  -d "address_country=US" \
```

```csharp
AddressesApi api = new AddressesApi(config);

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
  Address result = api.create(addressEditable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/addresses?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
AddressesApi api = new AddressesApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
try {
  AddressList response = api.list(
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









































## Postcards Api

### Retrieve
```bash
curl https://api.lob.com/v1/postcards/psc_5c002b86ce47537a \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
PostcardsApi api = new PostcardsApi(config);

try {
  Postcard response = api.get("psc_5c002b86ce47537a");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/postcards/psc_5c002b86ce47537a" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
PostcardsApi api = new PostcardsApi(config);

try {
  PostcardDeletion response = api.delete("psc_5c002b86ce47537a");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/postcards \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Demo Postcard job" \
  -d "from=adr_210a8d4b0b76d77b" \
  --data-urlencode "front=<html style='padding: 1in; font-size: 50;'>Front HTML for {{name}}</html>" \
  --data-urlencode "back=<html style='padding: 1in; font-size: 20;'>Back HTML for {{name}}</html>" \
  -d "to[name]=Harry Zhang" \
  -d "to[address_line1]=210 King St" \
  -d "to[address_line2]=# 6100" \
  -d "to[address_city]=San Francisco" \
  -d "to[address_state]=CA" \
  -d "to[address_zip]=94107" \
  -d "merge_variables[name]=Harry" \
```

```csharp
Dictionary<string, string> mergeVariables = new Dictionary<string, string>();
mergeVariables.Add("name", "Harry");

PostcardsApi api = new PostcardsApi(config);

AddressEditable to = new AddressEditable(
  "210 King St",  // addressLine1
  "# 6100",  // addressLine2
  "San Francisco",  // addressCity
  "CA",  // addressState
  "94107",  // addressZip
  CountryExtended.US,  // addressCounty
  null,  // description
  "Harry Zhang" // name
);

PostcardEditable postcardEditable = new PostcardEditable(
  to.ToJson(),  // to
  "adr_249af768103d2810",  // from
  default(PostcardSize),  // size
  "Demo Postcard Job",  // description
  null,  // metadata
  default(MailType),  // mailType
  mergeVariables,  // mergeVariables
  default(DateTime),  // sendDate
  "<html style='padding: 1in; font-size: 20;'>Back HTML for {{name}}</html>",  // front
  "<html style='padding: 1in; font-size: 20;'>Back HTML for {{name}}</html>" // back
);

try {
  Postcard result = api.create(postcardEditable, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/postcards?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
PostcardsApi api = new PostcardsApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
Dictionary<String, String> sendDate = new Dictionary<String, String>();
sendDate.Add("lt", DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
SortBy3 sortBy = new SortBy3(SortBy3.DateCreatedEnum.Asc);
List<PostcardSize> sizeArray = new List<PostcardSize>();
sizeArray.Add(PostcardSize._4x6);
try {
  PostcardList response = api.list(
    2, // limit
    null, // before
    null, // after
    includeList, // include
    dateCreated, // dateCreated
    metadata, // metadata
    sizeArray, // size
    true, // scheduled
    sendDate, // sendDate
    MailType.FirstClass, // mailType
    sortBy // sortBy
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## SelfMailers Api

### Retrieve
```bash
curl https://api.lob.com/v1/self_mailers/sfm_8ffbe811dea49dcf \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
SelfMailersApi api = new SelfMailersApi(config);

try {
  SelfMailer response = api.get("sfm_8ffbe811dea49dcf");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/self_mailers/sfm_8ffbe811dea49dcf" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
SelfMailersApi api = new SelfMailersApi(config);

try {
  SelfMailerDeletion response = api.delete("sfm_8ffbe811dea49dcf");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/self_mailers \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Demo Self Mailer job" \
  -d "from=adr_210a8d4b0b76d77b" \
  --data-urlencode "inside=<html style='padding: 1in; font-size: 50;'>Inside HTML for {{name}}</html>" \
  --data-urlencode "outside=<html style='padding: 1in; font-size: 20;'>Outside HTML for {{name}}</html>" \
  -d "to[name]=Harry Zhang" \
  -d "to[address_line1]=210 King St" \
  -d "to[address_line2]=# 6100" \
  -d "to[address_city]=San Francisco" \
  -d "to[address_state]=CA" \
  -d "to[address_zip]=94107" \
  -d "merge_variables[name]=Harry" \
```

```csharp
Dictionary<string, string> mergeVariables = new Dictionary<string, string>();
mergeVariables.Add("name", "Harry");

SelfMailersApi api = new SelfMailersApi(config);

AddressEditable to = new AddressEditable(
  "210 King St",  // addressLine1
  "# 6100",  // addressLine2
  "San Francisco",  // addressCity
  "CA",  // addressState
  "94107",  // addressZip
  default(CountryExtended),  // addressCounty
  null,  // description
  "Harry Zhang" // name
);

SelfMailerEditable selfMailerEditable = new SelfMailerEditable(
  to.ToJson(),  // to
  "adr_249af768103d2810",  // from
  default(SelfMailerSize),  // size
  "Demo Self Mailer Job",  // description
  default(Dictionary<string, string>),  // metadata
  default(MailType),  // mailType
  mergeVariables,  // mergeVariables
  default(DateTime),  // sendDate
  "<html style='padding: 1in; font-size: 50;'>Inside HTML for {{name}}</html>",  // inside
  "<html style='padding: 1in; font-size: 20;'>Outside HTML for {{name}}</html>" // outside
);

try {
  SelfMailer result = api.create(selfMailerEditable, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/self_mailers?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
SelfMailersApi api = new SelfMailersApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
Dictionary<String, String> sendDate = new Dictionary<String, String>();
sendDate.Add("lt", DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
SortBy3 sortBy = new SortBy3(SortBy3.DateCreatedEnum.Asc);
try {
  SelfMailerList response = api.list(
    2, // limit
    null, // before
    null, // after
    includeList, // include
    dateCreated, // dateCreated
    metadata, // metadata
    null, // size
    true, // scheduled
    sendDate, // sendDate
    MailType.FirstClass, // mailType
    sortBy // sortBy
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## Letters Api

### Retrieve
```bash
curl https://api.lob.com/v1/letters/ltr_4868c3b754655f90 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
LettersApi api = new LettersApi(config);

try {
  Letter response = api.get("ltr_4868c3b754655f90");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/letters/ltr_4868c3b754655f90" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
LettersApi api = new LettersApi(config);

try {
  LetterDeletion response = api.cancel("ltr_4868c3b754655f90");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/letters \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Demo Letter" \
  -d "from=adr_210a8d4b0b76d77b" \
  --data-urlencode "file=<html style='padding-top: 3in; margin: .5in;'>HTML Letter for {{name}}</html>" \
  -d "color=true" \
  -d "to[name]=Harry Zhang" \
  -d "to[address_line1]=210 King St" \
  -d "to[address_line2]=# 6100" \
  -d "to[address_city]=San Francisco" \
  -d "to[address_state]=CA" \
  -d "to[address_zip]=94107" \
  -d "merge_variables[name]=Harry" \
  -d "cards[]=card_c51ae96f5cebf3e"
```

```csharp
Dictionary<string, string> mergeVariables = new Dictionary<string, string>();
mergeVariables.Add("name", "Harry");

LettersApi api = new LettersApi(config);

AddressEditable to = new AddressEditable(
  "210 King St",  // addressLine1
  "# 6100",  // addressLine2
  "San Francisco",  // addressCity
  "CA",  // addressState
  "94107",  // addressZip
  default(CountryExtended),  // addressCounty
  null,  // description
  "Harry Zhang" // name
);

List<String> cards = new List<String>();
cards.Add("card_c51ae96f5cebf3e");

LetterEditable letterEditable = new LetterEditable(
  "Demo Letter",  // description
  default(Dictionary<string, string>),  // metadata
  default(MailType),  // mailType
  mergeVariables,  // mergeVariables
  default(DateTime),  // sendDate
  true,  // color
  true,  // doubleSided
  LetterEditable.AddressPlacementEnum.TopFirstPage,  // addressPlacement
  default(Object),  // returnEnvelope
  default(int?),  // perforatedPage
  default(LetterEditableCustomEnvelope),  // customEnvelope
  to.ToJson(),  // to
  "adr_249af768103d2810",  // from
  "<html style='padding-top: 3in; margin: .5in;'>HTML Letter for {{name}}</html>",  // file
  default(LetterEditable.ExtraServiceEnum?),  // extraService
  cards // cards
);

try {
  Letter result = api.create(letterEditable, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/letters?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
LettersApi api = new LettersApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
Dictionary<String, String> sendDate = new Dictionary<String, String>();
sendDate.Add("lt", DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
SortBy3 sortBy = new SortBy3(SortBy3.DateCreatedEnum.Asc);
try {
  LetterList response = api.list(
    2, // limit
    null, // before
    null, // after
    includeList, // include
    dateCreated, // dateCreated
    metadata, // metadata
    true, // color
    true, // scheduled
    sendDate, // sendDate
    MailType.FirstClass, // mailType
    sortBy // sortBy
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## Checks Api

### Retrieve
```bash
curl https://api.lob.com/v1/checks/chk_534f10783683daa0 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
ChecksApi api = new ChecksApi(config);

try {
  Check response = api.get("chk_534f10783683daa0");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/checks/chk_534f10783683daa0" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
ChecksApi api = new ChecksApi(config);

try {
  CheckDeletion response = api.cancel("chk_534f10783683daa0");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/checks \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Demo Check" \
  -d "bank_account=bank_8cad8df5354d33f" \
  -d "amount=22.5" \
  -d "memo=rent" \
  --data-urlencode "logo=https://s3-us-west-2.amazonaws.com/public.lob.com/assets/check_logo.png" \
  --data-urlencode "check_bottom=<h1 style='padding-top:4in;'>Demo Check for {{name}}</h1>" \
  -d "from=adr_210a8d4b0b76d77b" \
  -d "to[name]=Harry Zhang" \
  -d "to[address_line1]=210 King St" \
  -d "to[address_line2]=# 6100" \
  -d "to[address_city]=San Francisco" \
  -d "to[address_state]=CA" \
  -d "to[address_zip]=94107" \
  -d "merge_variables[name]=Harry" \
```

```csharp
Dictionary<string, string> mergeVariables = new Dictionary<string, string>();
mergeVariables.Add("name", "Harry");

ChecksApi api = new ChecksApi(config);

AddressEditable to = new AddressEditable(
  "210 King St",  // addressLine1
  "# 6100",  // addressLine2
  "San Francisco",  // addressCity
  "CA",  // addressState
  "94107",  // addressZip
  default(CountryExtended),  // addressCounty
  "",  // description
  "Harry Zhang" // name
);

CheckEditable checkEditable = new CheckEditable(
  "adr_249af768103d2810",  // from
  to.ToJson(),  // to
  "bank_8cad8df5354d33f",  // bank_account
  22.5f,  // amount
  "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/check_logo.png",  // logo
  "<h1 style='padding-top:4in;'>Demo Check for {{name}}</h1>",  // checkBottom
  default(string),  // attachment
  "Demo Check",  // description
  default(Dictionary<string, string>),  // metadata
  mergeVariables,  // mergeVariables
  default(DateTime),  // sendDate
  CheckEditable.MailTypeEnum.UspsFirstClass,  // mailType
  "rent" // memo
);

try {
  Check result = api.create(checkEditable, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/checks?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
ChecksApi api = new ChecksApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
Dictionary<String, String> sendDate = new Dictionary<String, String>();
sendDate.Add("lt", DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
SortBy3 sortBy = new SortBy3(SortBy3.DateCreatedEnum.Asc);
try {
  CheckList response = api.list(
    2, // limit
    null, // before
    null, // after
    includeList, // include
    dateCreated, // dateCreated
    metadata, // metadata
    true, // scheduled
    sendDate, // sendDate
    MailType.FirstClass, // mailType
    sortBy // sortBy
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## BankAccounts Api

### Retrieve
```bash
curl https://api.lob.com/v1/bank_accounts/bank_8cad8df5354d33f \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
BankAccountsApi api = new BankAccountsApi(config);

try {
  BankAccount response = api.get("bank_8cad8df5354d33f");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/bank_accounts/bank_3e64d9904356b20" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
BankAccountsApi api = new BankAccountsApi(config);

try {
  BankAccountDeletion response = api.delete("bank_3e64d9904356b20");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/bank_accounts?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
BankAccountsApi api = new BankAccountsApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
try {
  BankAccountList response = api.list(
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



### Verify
```bash
curl https://api.lob.com/v1/bank_accounts/bank_dfceb4a2a05b57e/verify \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \ 
  -d "amounts[]=25" \ 
  -d "amounts[]=63" \ 
```

```csharp
List<int> amounts = new List<int>();
amounts.Add(25);
amounts.Add(63);

verify verification = new verify(amounts);

BankAccountsApi api = new BankAccountsApi(config);

try {
  BankAccount verified_account = api.verify("bank_dfceb4a2a05b57e", verification);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/bank_accounts \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Test Bank Account" \
  -d "routing_number=322271627" \
  -d "account_number=123456789" \
  -d "signatory=John Doe" \
  -d "account_type=company" \
```

```csharp
BankAccountsApi api = new BankAccountsApi(config);

BankAccountWritable bankAccountWritable = new BankAccountWritable(
  "Test Bank Account",  // description
  "322271627",  // routingNumber
  "123456789",  // accountNumber
  BankTypeEnum.Company,  // accountType
  "John Doe" // signatory
);

try {
  BankAccount result = api.create(bankAccountWritable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



## Templates Api

### Retrieve
```bash
curl https://api.lob.com/v1/templates/tmpl_c94e83ca2cd5121 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
TemplatesApi api = new TemplatesApi(config);

try {
  Template response = api.get("tmpl_c94e83ca2cd5121");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/templates/tmpl_df934eeda694203" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
TemplatesApi api = new TemplatesApi(config);

try {
  TemplateDeletion response = api.delete("tmpl_df934eeda694203");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/templates?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
TemplatesApi api = new TemplatesApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, String> metadata = new Dictionary<String, String>();
metadata.Add("name", "Harry");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
try {
  TemplateList response = api.list(
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



### Update
```bash
curl https://api.lob.com/v1/templates/tmpl_c94e83ca2cd5121 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Updated description" \
  -d "published_version=vrsn_362184d96d9b0c9"
```

```csharp
TemplatesApi api = new TemplatesApi(config);
update update = new update("update template", "vrsn_362184d96d9b0c9");

try {
  api.update("tmpl_c94e83ca2cd5121", update);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/templates \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Test Template" \
  --data-urlencode "html=<html>HTML for {{name}}</html>" \
```

```csharp
TemplatesApi api = new TemplatesApi(config);

TemplateWritable templateWritable = new TemplateWritable(
  "Test Template",  // description
  "<html>HTML for {{name}}</html>" // html
);

try {
  Template result = api.create(templateWritable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



## TemplateVersions Api

### Retrieve
```bash
curl https://api.lob.com/v1/templates/tmpl_c94e83ca2cd5121/versions/vrsn_534e339882d2282 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
TemplateVersionsApi api = new TemplateVersionsApi(config);

try {
  TemplateVersion response = api.get("tmpl_c94e83ca2cd5121", "vrsn_534e339882d2282");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/templates/tmpl_4aa14648113e45b/versions/vrsn_534e339882d2282" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
TemplateVersionsApi api = new TemplateVersionsApi(config);

try {
  TemplateVersionDeletion response = api.delete("tmpl_4aa14648113e45b", "vrsn_534e339882d2282");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/templates/tmpl_dadaaf7b76c9f25/versions?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
TemplateVersionsApi api = new TemplateVersionsApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
try {
  TemplateVersionList response = api.list(
    "tmpl_dadaaf7b76c9f25", // tmplId
    2, // limit
    null, // before
    null, // after
    includeList, // include
    dateCreated // dateCreated
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



### Update
```bash
curl https://api.lob.com/v1/templates/tmpl_c94e83ca2cd5121/versions/vrsn_534e339882d2282 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Updated description"
```

```csharp
TemplateVersionsApi api = new TemplateVersionsApi(config);
TemplateVersionUpdatable update = new TemplateVersionUpdatable("update template", EngineHtml.Handlebars);

try {
  api.update("tmpl_c94e83ca2cd5121", "vrsn_534e339882d2282", update);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/templates/tmpl_4aa14648113e45b/versions \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Second Version" \
  --data-urlencode "html=<html>Second HTML for {{name}}</html>" \
```

```csharp
TemplateVersionsApi api = new TemplateVersionsApi(config);

TemplateVersionWritable templateVersionWritable = new TemplateVersionWritable(
  "Second Version",  // description
  "<html>Second HTML for {{name}}</html>" // html
);

try {
  TemplateVersion result = api.create("tmpl_4aa14648113e45b", templateVersionWritable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



## BillingGroups Api

### Retrieve
```bash
curl https://api.lob.com/v1/billing_groups/bg_4bb02b527a72667d0 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
BillingGroupsApi api = new BillingGroupsApi(config);

try {
  BillingGroup response = api.get("bg_4bb02b527a72667d0");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/billing_groups \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Usage group used for the Marketing Department's resource sends" \
  -d "name=Marketing Department" \
```

```csharp
BillingGroupsApi api = new BillingGroupsApi(config);

BillingGroupEditable billingGroupEditable = new BillingGroupEditable(
  "Usage group used for the Marketing Department's resource sends",  // description
  "Marketing Department" // name
);

try {
  BillingGroup result = api.create(billingGroupEditable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```
### Update
```bash
curl https://api.lob.com/v1/billing_groups/bg_759954f540a1bfdb5 \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=demo replacement" \
```

```csharp
BillingGroupsApi api = new BillingGroupsApi(config);
BillingGroupEditable update = new BillingGroupEditable("Usage group used for the Marketing Dept resource sends", "Marketing Dept");

try {
  BillingGroup response = api.update("bg_759954f540a1bfdb5", update);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### List
```bash
curl -X GET "https://api.lob.com/v1/billing_groups?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
BillingGroupsApi api = new BillingGroupsApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
Dictionary<String, DateTime> dateCreated = new Dictionary<String, DateTime>();
DateTime dateCreatedDate = DateTime.Today.AddMonths(-1);
dateCreated.Add("lt", dateCreatedDate);
Dictionary<String, String> dateModified = new Dictionary<String, String>();
dateModified.Add("lt", DateTime.Today.AddMonths(-1).ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz"));
SortByDateModified sortBy = new SortByDateModified(null, SortByDateModified.DateModifiedEnum.Asc);
try {
  BillingGroupList response = api.list(
    2, // limit
    1, // offset
    includeList, // include
    dateCreated, // dateCreated
    dateModified, // dateModified
    sortBy // sortBy
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## Cards Api

### Retrieve
```bash
curl https://api.lob.com/v1/cards/card_7a6d73c5c8457fc \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
CardsApi api = new CardsApi(config);

try {
  Card response = api.get("card_7a6d73c5c8457fc");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### Delete
```bash
curl -X DELETE "https://api.lob.com/v1/cards/card_6afffd19045076c" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
CardsApi api = new CardsApi(config);

try {
  CardDeletion response = api.delete("card_6afffd19045076c");
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```




### Create
```bash
curl https://api.lob.com/v1/cards \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "front=https://s3-us-west-2.amazonaws.com/public.lob.com/assets/card_horizontal.pdf" \
  -d "back=https://s3-us-west-2.amazonaws.com/public.lob.com/assets/card_horizontal.pdf" \
  -d "size=2.125x3.375" \
  -d "description=Test Card" \
```

```csharp
CardsApi api = new CardsApi(config);

CardEditable cardEditable = new CardEditable(
  "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/card_horizontal.pdf",  // front
  "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/card_horizontal.pdf",  // back
  CardEditable.SizeEnum._2125x3375,  // size
  "Test Card" // description
);

try {
  Card result = api.create(cardEditable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```






### List
```bash
curl -X GET "https://api.lob.com/v1/cards?limit=2" \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
CardsApi api = new CardsApi(config);
List<string> includeList = new List<string>();
includeList.Add("total_count");
try {
  CardList response = api.list(
    2, // limit
    null, // before
    null, // after
    includeList // include
  );
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



### Update
```bash
curl -X POST https://api.lob.com/v1/cards/card_6afffd19045076c \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "description=Awesome card" \
  -d "auto_reorder=true"
```

```csharp
CardsApi api = new CardsApi(config);
CardUpdatable update = new CardUpdatable("Awesome card", true, 15000);

try {
  api.update("card_6afffd19045076c", update);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



## CardOrders Api

### Retrieve
```bash
curl https://api.lob.com/v1/cards/card_6afffd19045076c/orders/ \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc:
```

```csharp
CardOrdersApi api = new CardOrdersApi(config);

try {
  CardOrderList response = api.get("card_6afffd19045076c", 2, 1);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```



### Create
```bash
curl https://api.lob.com/v1/cards/card_6afffd19045076c/orders \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "quantity=10000" \
```

```csharp
CardOrdersApi api = new CardOrdersApi(config);

CardOrderEditable cardOrderEditable = new CardOrderEditable(
  10000 // quantity
);

try {
  CardOrder result = api.create("card_6afffd19045076c", cardOrderEditable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## ZipLookups Api

### ZipLookup
```bash
curl https://api.lob.com/v1/us_zip_lookups \
  -u test_0dc8d51e0acffcb1880e0f19c79b2f5b0cc: \
  -d "zip_code=94107"
```

```csharp
ZipEditable zipEditable = new ZipEditable("94107");

ZipLookupsApi api = new ZipLookupsApi(config);

try {
  Zip response = api.ZipLookup(zipEditable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## Reverse Geocode Lookups Api

### Reverse Geocode Lookup
```bash
curl https://api.lob.com/v1/us_reverse_geocode_lookups \
  -u <YOUR_LIVE_API_KEY>: \
  -d "latitude=37.777456" \
  -d "longitude=-122.393039" \
```

```csharp
ReverseGeocodeLookupsApi api = new ReverseGeocodeLookupsApi(config);

Location location = new Location(
  37.777456f, 
  -122.393039f
);

try {
  api.ReverseGeocodeLookup(location, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## USAutoCompletions Api

### Autocomplete
```bash
curl https://api.lob.com/v1/us_autocompletions \
  -u <YOUR_LIVE_API_KEY>: \
  -d "address_prefix=185 B" \
  -d "city=San Francisco" \
  -d "state=CA" \
  -d "zip_code=94017" \
```

```csharp
UsAutocompletionsApi api = new UsAutocompletionsApi(config);
UsAutocompletionsWritable autoCompletionWritable = new UsAutocompletionsWritable(
  "185 B",  // address_prefix 
  "San Francisco",  // city 
  "CA",  // state 
  "94017" // zip_code 
);

try {
  UsAutocompletions usAutocompletion = api.UsAutocompletion(autoCompletionWritable);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## UsVerifications Api

### Bulk Verify
```bash
curl https://api.lob.com/v1/bulk/us_verifications \
  -u <YOUR LIVE API KEY>: \
  --header 'Content-Type: application/x-www-form-urlencoded' \
  --data-urlencode 'addresses[0][primary_line]=210 King Street' \
  --data-urlencode 'addresses[0][city]=San Francisco' \
  --data-urlencode 'addresses[0][state]=CA' \
  --data-urlencode 'addresses[0][zip_code]=94017' \
  --data-urlencode 'addresses[1][primary_line]=185 BERRY ST STE 6600' \
  --data-urlencode 'addresses[1][city]=SAN FRANCISCO' \
  --data-urlencode 'addresses[1][state]=CA' \
  --data-urlencode 'addresses[1][zip_code]=94017' \
```

```csharp
List<MultipleComponents> addresses = new List<MultipleComponents>();
MultipleComponents bulkAddress0 = new MultipleComponents(
  null,  // recipient 
  "210 King Street",  // primaryLine 
  null,  // secondaryLine 
  null,  // urbanization 
  "San Francisco",  // city 
  "CA",  // state 
  "94017" // zipCode 
);
addresses.Add(bulkAddress0);

MultipleComponents bulkAddress1 = new MultipleComponents(
  null,  // recipient 
  "185 BERRY ST STE 6600",  // primaryLine 
  null,  // secondaryLine 
  null,  // urbanization 
  "San Francisco",  // city 
  "CA",  // state 
  "94017" // zipCode 
);
addresses.Add(bulkAddress1);

MultipleComponentsList bulkVerify = new MultipleComponentsList(addresses);

UsVerificationsApi api = new UsVerificationsApi(config);
try {
  UsVerifications bulkVerifyResponse = api.BulkUsVerifications(bulkVerify, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### Single Verify
```bash
curl https://api.lob.com/v1/us_verifications \
  -u <YOUR_LIVE_API_KEY>: \
  -d "primary_line=210 King Street" \
  -d "city=San Francisco" \
  -d "state=CA" \
  -d "zip_code=94017" \
```

```csharp
UsVerificationsWritable singleVerify = new UsVerificationsWritable(
  null, 
  null, 
  "210 King Street", 
  null, 
  null, 
  "San Francisco", 
  "CA", 
  "94017"
);

UsVerificationsApi api = new UsVerificationsApi(config);

try {
  api.UsVerification(singleVerify, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## IntlAutocompletion Api

### IntlAutocompletion
```bash
curl https://api.lob.com/v1/intl_autocompletions \
  -u <YOUR_LIVE_API_KEY>: \
  -d "address_prefix=340 Wat" \
  -d "city=Summerside" \
  -d "state=Prince Edward Island" \
  -d "zip_code=C1N 1C4" \
  -d "country=CA" \
```

```csharp
IntlAutocompletionsApi api = new IntlAutocompletionsApi(config);

IntlAutocompletionsWritable autocompletionData = new IntlAutocompletionsWritable(
  "340 Wat", 
  "Summerside", 
  "Prince Edward Island", 
  "C1N 1C4", 
  CountryExtended.CA
);

try {
  IntlAutocompletions autocompletedAddresses = api.IntlAutocompletion(autocompletionData);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

## IntlVerifications Api

### Single Verify
```bash
curl https://api.lob.com/v1/intl_verifications \
  -u <YOUR_LIVE_API_KEY>: \
  -d "primary_line=370 Water St" \
  -d "city=Summerside" \
  -d "state=Prince Edward Island" \
  -d "postal_code=C1N 1C4" \
  -d "country=CA" \
```

```csharp
IntlVerificationWritable singleVerify = new IntlVerificationWritable(
  null, 
  "370 Water St", 
  null, 
  "Summerside", 
  "Prince Edward Island", 
  "C1N 1C4", 
  CountryExtended.CA
);

IntlVerificationsApi api = new IntlVerificationsApi(config);

try {
  api.IntlVerification(singleVerify, null);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

### Bulk Verify
```bash
curl https://api.lob.com/v1/bulk/intl_verifications \
  -u <YOUR LIVE API KEY>: \
  --header 'Content-Type: application/x-www-form-urlencoded' \
  --data-urlencode 'addresses[0][primary_line]=35 Tower Hill' \
  --data-urlencode 'addresses[0][city]=London' \
  --data-urlencode 'addresses[0][postal_code]=EC3N 4DR' \
  --data-urlencode 'addresses[0][country]=GB' \
  --data-urlencode 'addresses[1][primary_line]=370 Water St' \
  --data-urlencode 'addresses[1][city]=Summerside' \
  --data-urlencode 'addresses[1][state]=Prince Edward Island' \
  --data-urlencode 'addresses[1][postal_code]=C1N 1C4' \
  --data-urlencode 'addresses[1][country]=CA' \
```

```csharp
List<MultipleComponentsIntl> addresses = new List<MultipleComponentsIntl>();
MultipleComponentsIntl bulkAddress0 = new MultipleComponentsIntl(
  null,  // recipient 
  "35 Tower Hill",  // primaryLine 
  null,  // secondaryLine 
  "London",  // city 
  null,  // state 
  "EC3N 4DR",  // postalCode 
  CountryExtended.GB // country 
);
addresses.Add(bulkAddress0);

MultipleComponentsIntl bulkAddress1 = new MultipleComponentsIntl(
  null,  // recipient 
  "370 Water St",  // primaryLine 
  null,  // secondaryLine 
  "Summerside",  // city 
  "Prince Edward Island",  // state 
  "C1N 1C4",  // postalCode 
  CountryExtended.CA // country 
);
addresses.Add(bulkAddress1);

IntlVerificationsPayload bulkVerify = new IntlVerificationsPayload(addresses);

IntlVerificationsApi api = new IntlVerificationsApi(config);
try {
  IntlVerifications bulkVerifyResponse = api.BulkIntlVerifications(bulkVerify);
} catch (ApiException e) {
  Console.WriteLine(e.ToString());
}
```

