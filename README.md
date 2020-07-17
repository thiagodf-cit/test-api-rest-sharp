[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://www.gitpod.io/#https://github.com/thiagodf-cit/test-api-rest-sharp/)

## Project Test API - RestShap C# .Net Core.

[![made-with-gitpod](https://img.shields.io/badge/Made%20with-Gitpod-1f425f.svg)](https://gitpod.io/)
[![License: MIT](https://img.shields.io/badge/License-MIT-1f425f.svg)](https://github.com/thiagodf-cit/test-api-rest-sharp/blob/master/LICENSE)
[![GitHub stars](https://img.shields.io/github/stars/thiagodf-cit/test-api-rest-sharp?style=social&label=Star)](https://github.com/thiagodf-cit/test-api-rest-sharp/)

## Start

```
** Paste the path to the file. ex => /user/folder/Test.Api.Correios.csproj
```

```
  (Bash)
  > mkdir Test-Api-Rest-Sharp
  > cd Test-Api-Rest-Sharp/
  > dotnet new console --name Test.Api.Correios --output Test.Api.Correios
  
  (Open VsCode In Terminal)
  > dotnet new sln
  > dotnet "sln" "**/Test-Api-Rest-Sharp.sln" "add" "**/Test.Api.Correios.csproj"
  > dotnet restore
  > dotnet build Test-Api-Rest-Sharp.sln
  
  NuGet:
  > cd Test.Api.Correios/
  
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "FluentAssertions" "-v" "2.4.1"
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "Microsoft.NETCore.App" "-v" "2.2.8"
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "Microsoft.NET.Test.Sdk" "-v" "16.6.1"
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "RestSharp" "-v" "106.11.5-alpha.0.2"
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "xunit" "-v" "2.4.1"
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "xunit.runner.visualstudio" "-v" "2.4.2"
  > dotnet "add" "**/Test.Api.Correios.csproj" "package" "xunit.runner.console" "-v" "2.4.2"
  
```