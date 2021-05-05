#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1-buster-slim AS base
WORKDIR /app
COPY ["src/CyBits.Node/cybits.conf.docker", "/root/.blockcore/cybits/CyBitsMain/cybits.conf"]

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/CyBits.Node/CyBits.Node.csproj", "src/CyBits.Node/"]
COPY ["src/CyBits/CyBits.csproj", "src/CyBits/"]


RUN dotnet restore "src/CyBits.Node/CyBits.Node.csproj"
COPY . .
WORKDIR "/src/src/CyBits.Node"
RUN dotnet build "CyBits.Node.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CyBits.Node.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN mkdir -p root/.blockcore/cybits/CyBitsMain/
EXPOSE 15003 15002 15001
ENTRYPOINT ["dotnet", "CyBits.Node.dll"]