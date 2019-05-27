FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine3.9 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine3.9 AS build
WORKDIR /src
COPY ["micro-service.csproj", ""]
RUN dotnet restore "micro-service.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "micro-service.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "micro-service.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "micro-service.dll"]