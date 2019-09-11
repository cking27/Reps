Docker CMD
docker run --rm --name pg-reps-docker -e POSTGRES_DB=workout,POSTGRES_USER=repsadmin,POSTGRES_PASSWORD=abc123  -d -p 5432:5432 -v ~/volumes/postgres:/var/lib/postgressql/data postgres