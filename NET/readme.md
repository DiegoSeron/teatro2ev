# Readme

## Setup local environment (API+DB)
`docker-compose up --build --force-recreate -d`

## Setup database
Connect to database and run manually the script of init-db.sql
(PRO OPTIONs:
- https://stackoverflow.com/questions/69941444/how-to-have-docker-compose-init-a-sql-server-database)
- https://www.softwaredeveloper.blog/initialize-mssql-in-docker-container

## Save database
docker commit & docker push


## Migration
`dotnet tool install --global dotnet-ef --version 6.*`
`dotnet ef migrations add InitialCreate -p ./Data/Tickett.Data.csproj -s ./API/Tickett.API.csproj`
`dotnet ef database update  -p ./Data/Tickett.Data.csproj -s ./API/Tickett.API.csproj`
`dotnet ef database drop  -p ./Data/Tickett.Data.csproj -s ./API/Tickett.API.csproj`


## Idea a aplicar para los asientos
`nuestras salas tienen asientos fijos, en el momento que hace el get pinta un array con los asientos en localStorage y cuando seleccionas los asientos`
`modificas el estado del asiento en ese array y lo envias a vue, Despues guardas en una tabla reservas el id de la obra y un array<int> con los numeros`
`de los asientos seleccionados.`