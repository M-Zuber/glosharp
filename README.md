# Glosharp

A C# SDK for working with Gitkraken Glo Boards

**Master Branch Status**

[![Build status](https://ci.appveyor.com/api/projects/status/079vxniq63ema0h6/branch/master?svg=true)](https://ci.appveyor.com/project/wdhodges/glosharp/branch/master)


**Develop Branch**

[![Build status](https://ci.appveyor.com/api/projects/status/079vxniq63ema0h6?svg=true)](https://ci.appveyor.com/project/wdhodges/glosharp/branch/develop)

# Getting Started

The prefered method for installation is NuGet. 

```
dotnet add package Glosharp
```

There are a couple ways that you can set your Personal Access Token. You can set it in the Environment variable named `GlosharpToken` or you can store it in the `config.json` file. 

```powershell
$env:GlosharpToken=your_personal_token
```
or
```bash
cp config-example.json config.json
```

It has not been set up yet to do OAuth, as OAuth may not be in for sometime. 
