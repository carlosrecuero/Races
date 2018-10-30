FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Registration/Races.Registration/Races.Registration.csproj Registration/Races.Registration/
RUN dotnet restore Registration/Races.Registration/Races.Registration.csproj
COPY . .
WORKDIR /src/Registration/Races.Registration
RUN dotnet build Races.Registration.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Races.Registration.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Races.Registration.dll"]
