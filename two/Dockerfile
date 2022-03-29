FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["two/two.csproj", "two/"]
RUN dotnet restore "two/two.csproj"
COPY . .
WORKDIR "/src/two"
RUN dotnet build "two.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "two.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "two.dll"]
