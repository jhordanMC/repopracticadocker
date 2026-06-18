# Imagen base para build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copiar y restaurar dependencias
COPY mi-proyecto/*.csproj ./mi-proyecto/
RUN dotnet restore mi-proyecto/mi-proyecto.csproj

# Copiar todo y compilar
COPY . ./
RUN dotnet build mi-proyecto/mi-proyecto.csproj --no-restore
RUN dotnet publish mi-proyecto/mi-proyecto.csproj -c Release -o /app/publish

# Imagen final
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "mi-proyecto.dll"]