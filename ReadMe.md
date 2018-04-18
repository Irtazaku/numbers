# Prerequisites:
- MySQL


# GraphQL Server

- runs at port 3000
- Frontend will be communicating with this server.
- Apollo is used to feed data to graphQL which get data from Http services of springboot server


# API Server

- runs at port 54274
- Used to provide data from database to Apollo.
- internally use Jooq to communicate with database.
