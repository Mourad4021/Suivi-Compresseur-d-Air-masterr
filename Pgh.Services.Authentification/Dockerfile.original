FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Pgh.Services.Authentification/Pgh.Services.Authentification.csproj", "Pgh.Services.Authentification/"]
COPY ["Pgh.Common/Pgh.Common.csproj", "Pgh.Common/"]
COPY ["Pgh.Auth.Model/Pgh.Auth.Model.csproj", "Pgh.Auth.Model/"]
COPY ["Pgh.Auth.Dal/Pgh.Auth.Dal.csproj", "Pgh.Auth.Dal/"]
RUN dotnet restore "Pgh.Services.Authentification/Pgh.Services.Authentification.csproj"
COPY . .
WORKDIR "/src/Pgh.Services.Authentification"
RUN dotnet build "Pgh.Services.Authentification.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Pgh.Services.Authentification.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Pgh.Services.Authentification.dll"]
