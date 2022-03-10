#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["WappaMobile.ChallengeDev.WebApi/WappaMobile.ChallengeDev.WebApi.csproj", "WappaMobile.ChallengeDev.WebApi/"]
COPY ["WappaMobile.ChallengeDev.Models/WappaMobile.ChallengeDev.Models.csproj", "WappaMobile.ChallengeDev.Models/"]
COPY ["WappaMobile.ChallengeDev/WappaMobile.ChallengeDev.csproj", "WappaMobile.ChallengeDev/"]
COPY ["WappaMobile.ChallengeDev.GoogleMaps/WappaMobile.ChallengeDev.GoogleMaps.csproj", "WappaMobile.ChallengeDev.GoogleMaps/"]
COPY ["WappaMobile.ChallengeDev.Data.InMemory/WappaMobile.ChallengeDev.Data.InMemory.csproj", "WappaMobile.ChallengeDev.Data.InMemory/"]
RUN dotnet restore "WappaMobile.ChallengeDev.WebApi/WappaMobile.ChallengeDev.WebApi.csproj"
COPY . .
WORKDIR "/src/WappaMobile.ChallengeDev.WebApi"
RUN dotnet build "WappaMobile.ChallengeDev.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WappaMobile.ChallengeDev.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WappaMobile.ChallengeDev.WebApi.dll"]