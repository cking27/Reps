# Reps

Simple Rest API with Postgres backend.  Postgres DB is in Docker.  Cake builds code and Docker.
Front End- React.js

** Helpful commands (FrontEnd )**.

cd front/repsfront/

# To Run
./npm start

** Helpful commands (Backend)**.

# To Build
./build.ps1[sh]

# To Run
 .\build.ps1 -Target Run
 ./build.sh --target=Run

 # To start docker


# Docker 1
docker run --rm --name pg-reps-docker -e POSTGRES_DB=workout,POSTGRES_USER=repsadmin,POSTGRES_PASSWORD=abc123  -d -p 5432:5432 -v ~/volumes/postgres:/var/lib/postgressql/data postgres

# Reps API
/build.sh --target=RepsApi-Run
/build.sh --target=RepsApi-Run

#Links

## Docker .Net Models
https://medium.com/@agavatar/webapi-with-net-core-and-postgres-in-visual-studio-code-8b3587d12823

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
dotnet ef migrations add MORETABLES
dotnet ef database update