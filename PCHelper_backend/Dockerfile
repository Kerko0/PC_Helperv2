#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PCHelper_backend.csproj", "PCHelper_backend/"]
RUN dotnet restore "PCHelper_backend/PCHelper_backend.csproj"
WORKDIR "/src/PCHelper_backend"
COPY . .
RUN dotnet build "PCHelper_backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PCHelper_backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PCHelper_backend.dll"]