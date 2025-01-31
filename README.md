# StardewValleyCalculator

## Introduction
A web based calcualtor, written in C#, with stardew valley based paramaters. 

## Architecture Overview

```mermaid
architecture-beta
    group context(internet)[Context Diagram]
    service database(database)[Database] in context
    service user(internet)[User] in context
    service stardew(server)[Stardew Calculator] in context

    user:R --> L:stardew
    database:L <--> R:stardew
```

```mermaid
architecture-beta
    group application(disk)[Application]
    service controller(internet)[Controller] in application
    service model(disk)[Model] in application
    service view(cloud)[View] in application
    junction junctionLeft in application
    junction junctionRight in application


    controller:R <-- L:junctionLeft
    controller:L <-- R:junctionRight
    model:T <-- B:junctionLeft
    view:T <-- B:junctionRight
```

## How to Use

You can run `make help` in the terminal to see the following useful commands for this project.
``` console
build                          Build a docker image
dev                            Run the project in watch mode, any file changes will be reflected at runtime
docker-run                     Run the latest build of the docker image
help                           Display this help
http                           Run the project in http mode
https                          Run the project in https mode
tests                          Run all the tests
```


### Prerequisites

TODO: Explain which steps and dependencies are required to run and build the project (e.g., pip install -r requirements.txt)

### Build

TODO: Explain how the whole project can be build.

### Test

TODO: Explain how unit- or integreation tests can be executed.

### Run

TODO: Explain how to run the project (client, server etc.).

## License

TODO: Add license and copyright notice.