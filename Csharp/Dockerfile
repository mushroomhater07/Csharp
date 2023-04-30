FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Csharp/Csharp.csproj", "Csharp/"]
RUN dotnet restore "Csharp/Csharp.csproj"
COPY . .
WORKDIR "/src/Csharp"
RUN dotnet build "Csharp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Csharp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Csharp.dll"]
