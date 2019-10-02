FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["PieceOfChess.WebAPI/PieceOfChess.WebAPI.csproj", "PieceOfChess.WebAPI/"]
RUN dotnet restore "PieceOfChess.WebAPI/PieceOfChess.WebAPI.csproj"
COPY . .
WORKDIR "/src/PieceOfChess.WebAPI"
RUN dotnet build "PieceOfChess.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PieceOfChess.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PieceOfChess.WebAPI.dll"]