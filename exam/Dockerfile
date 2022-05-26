FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["exam/exam.csproj", "exam/"]
RUN dotnet restore "exam/exam.csproj"
COPY . .
WORKDIR "/src/exam"
RUN dotnet build "exam.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "exam.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "exam.dll"]
