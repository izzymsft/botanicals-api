
### Creating a Docker Image for the Botanicals REST API Application

```shell

# Login to the Container Registry (Docker Hub)
docker login

# This command builds the Docker image locally
docker build -t izzymsft/botanicalsapi:3.1 .

# hostPort:containerPort
# This command runs the docker container on port 80
# Can be reached as http://localhost/api/botanicals
# The Swagger Page can be reached via http://localhost/swagger/index.html
docker run -d -p 80:5000 --name botanicals izzymsft/botanicalsapi:3.1

# Get list of running containers to see the container id
docker ps

# Kill Container
docker kill {containerId}

# Removing the stopped container from the list of dead containers
docker rm botanicals

```

### Build and run the sample with Docker for Linux containers

https://docs.microsoft.com/en-us/dotnet/core/docker/building-net-docker-images#build-and-run-the-sample-with-docker-for-linux-containers


### Build and run the sample with Docker for Windows containers

https://docs.microsoft.com/en-us/dotnet/core/docker/building-net-docker-images#build-and-run-the-sample-with-docker-for-windows-containers

### Docker Images for .NET CORE 2.2

https://docs.docker.com/engine/examples/dotnetcore/

https://docs.microsoft.com/en-us/dotnet/core/docker/building-net-docker-images
