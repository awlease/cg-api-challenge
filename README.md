# cg-api-challenge
Currently the application can be run from Visual Studio from the Kestrel runtime or the Docker debug run.
Also, there is a shortcut in /runnable that will run a pre-built release version of the application.
Once the console is running, you can navigate to https://localhost:5001/swagger to see the available endpoints.

If I had more time, I would likely separate out the database work into a separate program layer and add a separate deployment or use Azure/AWS for the database rather than hosting it in the same container. Additionally I would likely work with the requirements owner to get a clear image of what additional items the Trainer needs in the schema, whether it be scheduling, expertise, or more.