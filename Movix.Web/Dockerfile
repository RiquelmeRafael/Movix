# Estágio de Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar arquivos de projeto e restaurar dependências
COPY ["Movix.Web/Movix.Web.csproj", "Movix.Web/"]
COPY ["Movix.Application/Movix.Application.csproj", "Movix.Application/"]
COPY ["Movix.Domain/Movix.Domain.csproj", "Movix.Domain/"]
COPY ["Movix.Infrastructure/Movix.Infrastructure.csproj", "Movix.Infrastructure/"]
RUN dotnet restore "Movix.Web/Movix.Web.csproj"

# Copiar todo o código fonte
COPY . .
WORKDIR "/src/Movix.Web"
RUN dotnet build "Movix.Web.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "Movix.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Estágio Final (Runtime)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Movix.Web.dll"]
