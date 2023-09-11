FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Topology/Topology.csproj", "Topology/"]

RUN dotnet restore "Topology/Topology.csproj"
COPY . .
WORKDIR "/src/Topology"
RUN dotnet build "Topology.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Topology.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Topology.dll"]