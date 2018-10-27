FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5509
EXPOSE 44347

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Races.Registration/Races.Registration.csproj", "Races.Registration/"]
RUN dotnet restore "Races.Registration/Races.Registration.csproj"
COPY . .
WORKDIR "/src/Races.Registration"
RUN dotnet build "Races.Registration.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Races.Registration.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Races.Registration.dll"]