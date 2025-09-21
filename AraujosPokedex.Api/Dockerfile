FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AraujosPokedex.Api/AraujosPokedex.Api.csproj", "AraujosPokedex.Api/"]
COPY ["AraujosPokedex.Domain/AraujosPokedex.Domain.csproj", "AraujosPokedex.Domain/"]
COPY ["AraujosPokedex.Domain/AraujosPokedex.Database.csproj", "AraujosPokedex.Database/"]
RUN dotnet restore "AraujosPokedex.Api/AraujosPokedex.Api.csproj"
COPY . .
WORKDIR "/src/AraujosPokedex.Api"
RUN dotnet build "./AraujosPokedex.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AraujosPokedex.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AraujosPokedex.Api.dll"]
