#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["S3WebApp/S3WebApp.csproj", "S3WebApp/"]
RUN dotnet restore "S3WebApp/S3WebApp.csproj"
COPY . .
WORKDIR "/src/S3WebApp"
RUN dotnet build "S3WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "S3WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "S3WebApp.dll"]