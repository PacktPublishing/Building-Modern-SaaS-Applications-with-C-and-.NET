# Building-Modern-SaaS-Applications-with-C-and-.NET
Building Modern SaaS Applications with C# and .NET, published by Packt


## How to use these examples

This repository is split into folders showing the expected code at the end of each chapter.

The examples in the book make use of devcontainers to run the developer environment inside a container. If you want to take this approach, you must make sure that the `.devcontainer` folder is in the root folder that is opened with Visual Studio Code. To open Chapter 2 for example, simply enter:

`cd Chapter-2`

`code .`

This will allow you to run the examples from chapter 2 when in the Docker environment.

### Running with Visual Studio Community Edition
In addition to running the code through Docker using devcontainers with Visual Studio Code, it is also possible to use the full version of Visual Studio. A solution file has been included in every folder that can be opened using Visual Studio.

Please note that the supplied database connection strings assume that they are running against a database in a Docker container. If using Visual Studio, it is required to modify the connections strings to connect to your local database of choice.
