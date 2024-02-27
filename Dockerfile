FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FishingStats/FishingStats.csproj", "FishingStats/"]
RUN dotnet restore "FishingStats/FishingStats.csproj"
COPY . .
WORKDIR "/src/FishingStats"
RUN dotnet build "FishingStats.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FishingStats.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FishingStats.dll"]
