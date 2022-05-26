FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["defensaPersistencia/defensaPersistencia.csproj", "defensaPersistencia/"]
RUN dotnet restore "defensaPersistencia/defensaPersistencia.csproj"
COPY . .
WORKDIR "/src/defensaPersistencia"
RUN dotnet build "defensaPersistencia.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "defensaPersistencia.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "defensaPersistencia.dll"]
