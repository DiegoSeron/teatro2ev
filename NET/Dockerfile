FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY *.sln .
COPY API/*.csproj API/
COPY Business/*.csproj Business/
COPY Models/*.csproj Models/
COPY Data/*.csproj Data/
RUN dotnet restore Tickett.sln

COPY . .
RUN dotnet publish Tickett.sln -c Release -o API/out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/API/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "Tickett.API.dll"]