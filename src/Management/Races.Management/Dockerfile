FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["src/Management/Races.Management/Races.Management.csproj", "src/Management/Races.Management/"]
RUN dotnet restore "src/Management/Races.Management/Races.Management.csproj"
COPY . .
WORKDIR "/src/src/Management/Races.Management"
RUN dotnet build "Races.Management.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Races.Management.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Races.Management.dll"]