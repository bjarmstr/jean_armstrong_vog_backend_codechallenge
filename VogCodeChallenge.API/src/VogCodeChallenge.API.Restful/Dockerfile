#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["VogCodeChallenge.API/src/VogCodeChallenge.API.Restful/VogCodeChallenge.API.Restful.csproj", "VogCodeChallenge.API/src/VogCodeChallenge.API.Restful/"]
COPY ["VogCodeChallenge.API/src/VogCodeChallenge.API.Application/VogCodeChallenge.API.Application.csproj", "VogCodeChallenge.API/src/VogCodeChallenge.API.Application/"]
COPY ["VogCodeChallenge.API/src/VogCodeChallenge.API.Domain/VogCodeChallenge.API.Domain.csproj", "VogCodeChallenge.API/src/VogCodeChallenge.API.Domain/"]
COPY ["VogCodeChallenge.API/src/VogCodeChallenge.API.Infrastructure/VogCodeChallenge.API.Infrastructure.csproj", "VogCodeChallenge.API/src/VogCodeChallenge.API.Infrastructure/"]
RUN dotnet restore "VogCodeChallenge.API/src/VogCodeChallenge.API.Restful/VogCodeChallenge.API.Restful.csproj"
COPY . .
WORKDIR "/src/VogCodeChallenge.API/src/VogCodeChallenge.API.Restful"
RUN dotnet build "VogCodeChallenge.API.Restful.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VogCodeChallenge.API.Restful.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VogCodeChallenge.API.Restful.dll"]