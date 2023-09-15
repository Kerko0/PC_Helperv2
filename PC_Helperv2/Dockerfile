#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PC_Helperv2.csproj", "PCHelper_frontend/"]
RUN dotnet restore "PCHelper_frontend/PC_Helperv2.csproj"
WORKDIR "/src/PCHelper_frontend"
COPY . .
RUN dotnet build "PC_Helperv2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PC_Helperv2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80