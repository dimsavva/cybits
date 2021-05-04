#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /app

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
ENTRYPOINT ["dotnet", "CyBits.Node.dll"]