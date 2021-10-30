FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CodingInterview.AuthorizationServer/CodingInterview.AuthorizationServer.csproj", "CodingInterview.AuthorizationServer/"]
RUN dotnet restore "CodingInterview.AuthorizationServer/CodingInterview.AuthorizationServer.csproj"
COPY . .
WORKDIR "/src/CodingInterview.AuthorizationServer"
RUN dotnet build "CodingInterview.AuthorizationServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CodingInterview.AuthorizationServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodingInterview.AuthorizationServer.dll"]
