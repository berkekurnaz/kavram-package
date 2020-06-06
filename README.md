
# Kavram
Kavram is a simple state management package for .net core apps. You can store your data in one place and use it wherever you want with Kavram. Kavram uses a singleton design pattern and it is open source.
> **Nuget :** https://www.nuget.org/packages/Kavram <br/>

> **Tutorial (English) :** Coming Soon...

> **Tutorial (Turkish) :** Coming Soon...
> 
## Installation

- Download this package to your project.
```bash
Install-Package Kavram -Version 1.0.0
```

## Examples
[Example-1 : .Net Core Console App with Kavram](https://github.com/berkekurnaz/kavram-package/tree/master/Kavram.TestConsole) <br/>
[Example-2 : .Net Core Mvc App with Kavram](https://github.com/berkekurnaz/kavram-package/tree/master/Kavram.TestWeb)

## How to use this package ?
-  This sample code contains almost all examples.
```csharp

            // Create new storage
            var kavram = KavramObject.Create();

            // We save string variable with Kavram
            String name = "Berke";
            kavram.Update("name", name);

            // We get a variable with Kavram
            var newName = kavram.Get("name");
            Console.WriteLine(newName);

            // We save list variable with Kavram
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            kavram.Update("numberList", numberList);

            // We get a list with Kavram
            IList collection = (IList)kavram.Get("numberList");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            // You can check the key
            bool check = kavram.IsKeyContains("name");

            // You can delete all data
            kavram.ClearAllData();

            // You can get a count of datas
            int count = kavram.GetKeysCount();

```

## Functions List
- object Get(String key)
- bool Update(String key, object data)
- bool Delete(String key)
- bool ClearAllData()
- List<string> GetAllKeys()
- int GetKeysCount()
- bool IsKeyContains(String key)

## Contact
> Developer: Berke Kurnaz

> Mail Address: contact@berkekurnaz.com <br/>
> Mail Address: kurnaz.berke1907@gmail.com

> Github: https://github.com/berkekurnaz