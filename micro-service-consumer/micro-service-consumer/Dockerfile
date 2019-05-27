FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine3.9 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine3.9 AS build
WORKDIR /src
COPY ["micro-service-consumer.csproj", ""]
RUN dotnet restore "micro-service-consumer.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "micro-service-consumer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "micro-service-consumer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "micro-service-consumer.dll"]