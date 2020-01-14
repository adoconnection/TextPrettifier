dotnet build -c Release
dotnet test -c Release 
dotnet pack -c Release -o artifacts TextPrettifier\TextPrettifier.csproj 
dotnet nuget push artifacts\TextPrettifier.2020.01.nupkg --source https://www.nuget.org/api/v2/package