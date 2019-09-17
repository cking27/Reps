# Reps

Simple Rest API with Postgres backend.  Postgres DB is in Docker.  Cake builds code and Docker.

** Helpful commands**.

# To Build
./build.ps1[sh]

# To Run
 .\build.ps1 -Target Run
 ./build.sh --target=Run

 # To start docker


# Docker 1
docker run --rm --name pg-reps-docker -e POSTGRES_DB=workout,POSTGRES_USER=repsadmin,POSTGRES_PASSWORD=abc123  -d -p 5432:5432 -v ~/volumes/postgres:/var/lib/postgressql/data postgres

# Docker 1
docker run --rm --name pg-reps-docker -e POSTGRES_DB=workout,POSTGRES_USER=repsadmin,POSTGRES_PASSWORD=abc123  -d -p 5432:5432 -v ~/volumes/postgres:/var/lib/postgressql/data postgres