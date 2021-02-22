FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["./src/API/BEDF.API/BEDF.API.csproj", "src/API/BEDF.API/"]
COPY ["./src/data/BEDF.Data/BEDF.Data.csproj", "src/data/BEDF.Data/"]
COPY ["./src/domain/BEDF.Domain/BEDF.Domain.csproj", "src/domain/BEDF.Domain/"]
COPY ["./src/services/BEDF.Services/BEDF.Services.csproj", "src/services/BEDF.Services/"]

RUN dotnet restore "src/API/BEDF.API/BEDF.API.csproj"
COPY . .
WORKDIR "src/API/BEDF.API"
RUN dotnet build "BEDF.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BEDF.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "BEDF.API.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet "BEDF.API.dll"



