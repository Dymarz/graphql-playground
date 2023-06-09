FROM mcr.microsoft.com/dotnet/sdk:7.0 as build

WORKDIR /app

COPY . .

RUN dotnet build .

RUN dotnet publish -o publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0	

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT [ "dotnet", "graphql-playground.dll" ]