# Estágio de Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar arquivos de projeto e restaurar dependências
COPY ["Movix.Api/Movix.Api.csproj", "Movix.Api/"]
COPY ["Movix.Application/Movix.Application.csproj", "Movix.Application/"]
COPY ["Movix.Domain/Movix.Domain.csproj", "Movix.Domain/"]
COPY ["Movix.Infrastructure/Movix.Infrastructure.csproj", "Movix.Infrastructure/"]
RUN dotnet restore "Movix.Api/Movix.Api.csproj"

# Copiar todo o código fonte
COPY . .
WORKDIR "/src/Movix.Api"
RUN dotnet build "Movix.Api.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "Movix.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Estágio Final (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Movix.Api.dll"]
