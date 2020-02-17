FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build-env
EXPOSE 3000
WORKDIR /app


# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim
WORKDIR /app
COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS=http://localhost:3000
ENTRYPOINT ["dotnet", "dotnetdocker.dll"]