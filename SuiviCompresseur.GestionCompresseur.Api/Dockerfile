FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SuiviCompresseur.GestionCompresseur.Api/SuiviCompresseur.GestionCompresseur.Api.csproj", "SuiviCompresseur.GestionCompresseur.Api/"]
COPY ["SuiviCompresseur.GestionCompresseur.Data/SuiviCompresseur.GestionCompresseur.Data.csproj", "SuiviCompresseur.GestionCompresseur.Data/"]
COPY ["SuiviCompresseur.GestionCompresseur.Domain/SuiviCompresseur.GestionCompresseur.Domain.csproj", "SuiviCompresseur.GestionCompresseur.Domain/"]
COPY ["SuiviCompresseur.Domain.Core/SuiviCompresseur.Domain.Core.csproj", "SuiviCompresseur.Domain.Core/"]
COPY ["SuiviCompresseur.Infra.IoC/SuiviCompresseur.Infra.IoC.csproj", "SuiviCompresseur.Infra.IoC/"]
COPY ["SuiviCompresseur.Gestion.Responsable.Aplication/SuiviCompresseur.Gestion.Responsable.Aplication.csproj", "SuiviCompresseur.Gestion.Responsable.Aplication/"]
COPY ["SuiviCompresseur.Gestion.Responsable.Domain/SuiviCompresseur.Gestion.Responsable.Domain.csproj", "SuiviCompresseur.Gestion.Responsable.Domain/"]
COPY ["SuiviCompresseur.Gestion.Responsable.Data/SuiviCompresseur.Gestion.Responsable.Data.csproj", "SuiviCompresseur.Gestion.Responsable.Data/"]
COPY ["SuiviCompresseur.Notification.Data/SuiviCompresseur.Notification.Data.csproj", "SuiviCompresseur.Notification.Data/"]
COPY ["SuiviCompresseur.Notification.Domain/SuiviCompresseur.Notification.Domain.csproj", "SuiviCompresseur.Notification.Domain/"]
COPY ["SuiviCompresseur.GestionCompresseur.Application/SuiviCompresseur.GestionCompresseur.Application.csproj", "SuiviCompresseur.GestionCompresseur.Application/"]
COPY ["SuiviCompresseur.GestionFournisseur.Data/SuiviCompresseur.GestionFournisseur.Data.csproj", "SuiviCompresseur.GestionFournisseur.Data/"]
COPY ["SuiviCompresseur.GestionFournisseur.Domain/SuiviCompresseur.GestionFournisseur.Domain.csproj", "SuiviCompresseur.GestionFournisseur.Domain/"]
COPY ["SuiviCompresseur.GestionFournisseur.Application/SuiviCompresseur.GestionFournisseur.Application.csproj", "SuiviCompresseur.GestionFournisseur.Application/"]
COPY ["SuiviCompresseur.Infra.Bus/SuiviCompresseur.Infra.Bus.csproj", "SuiviCompresseur.Infra.Bus/"]
RUN dotnet restore "SuiviCompresseur.GestionCompresseur.Api/SuiviCompresseur.GestionCompresseur.Api.csproj"
COPY . .
WORKDIR "/src/SuiviCompresseur.GestionCompresseur.Api"
RUN dotnet build "SuiviCompresseur.GestionCompresseur.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SuiviCompresseur.GestionCompresseur.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SuiviCompresseur.GestionCompresseur.Api.dll"]
