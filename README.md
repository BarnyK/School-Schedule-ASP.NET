# School-Schedule-ASP.NET
School Schedule GUI implemeneted in ASP.NET. Made for University course

The project was not meant to persist the data on the server but in json files provided by the user so the data should be imported/exported on every server startup/shutdown
## How to run

### 1. Conteneraized

New way of running this project. It was added on top mostly for ease of use. 
This way will produce and AntiForgery exception because of lack of https certificate.

Build Docker image:

`docker build -t egui-project:latest .`

Run built image:

`docker run -p 80:80 egui-project:latest`

### 2. Not-contenerized

Run `dotnet run` in `EguiProject2` directory.
