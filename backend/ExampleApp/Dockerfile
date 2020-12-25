FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app/

COPY bin/Release/net5.0/publish/ .
COPY bin/Release/frontend/build/ frontend-build/.

ENTRYPOINT ["dotnet", "ExampleApp.dll"]
