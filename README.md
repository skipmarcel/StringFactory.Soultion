## What Is This?

This is a project I completed using C# and ASP.net while attending Epicodus programing school. It's an exercise in Many-to-Many Relationships with Mysql databases.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "Factory".
3. Within the production directory "Factory", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USER-NAME];pwd=[YOUR-PASSWOR];"
  }
}
```

6. Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.

7. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.
