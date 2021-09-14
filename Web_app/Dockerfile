FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Web_app/Web_app.csproj", "Web_app/"]
RUN dotnet restore "Web_app/Web_app.csproj"
COPY . .
WORKDIR "/src/Web_app"
RUN dotnet build "Web_app.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web_app.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web_app.dll"]
