FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Cvr.Dev.Client/Cvr.Dev.Client.csproj", "Cvr.Dev.Client/"]
RUN dotnet restore "Cvr.Dev.Client/Cvr.Dev.Client.csproj"
COPY . .
WORKDIR "/src/Cvr.Dev.Client"
RUN dotnet build "Cvr.Dev.Client.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Cvr.Dev.Client.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cvr.Dev.Client.dll"]
