FROM dotnet/framework/sdk:latest AS build-env
WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

# Build runtime image
FROM dotnet/framework/aspnet:latest
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "SmartSkypeBot.dll"]
