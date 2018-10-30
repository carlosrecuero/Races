FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["src/Result/Races.Result/Races.Result.csproj", "src/Result/Races.Result/"]
RUN dotnet restore "src/Result/Races.Result/Races.Result.csproj"
COPY . .
WORKDIR "/src/src/Result/Races.Result"
RUN dotnet build "Races.Result.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Races.Result.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Races.Result.dll"]