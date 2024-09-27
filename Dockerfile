# https://hub.docker.com/_/microsoft-dotnet

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["webApi/webApi.csproj", "webApi/"]
COPY ["DAL/DAL.csproj", "DAL/"]
COPY ["Services/Services.csproj", "Services/"]
RUN dotnet restore "webApi/webApi.csproj"
COPY . .

WORKDIR  "/src/webApi"
RUN dotnet build "webApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "webApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webApi.dll"]