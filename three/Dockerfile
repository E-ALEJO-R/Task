FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["three/three.csproj", "three/"]
RUN dotnet restore "three/three.csproj"
COPY . .
WORKDIR "/src/three"
RUN dotnet build "three.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "three.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "three.dll"]
