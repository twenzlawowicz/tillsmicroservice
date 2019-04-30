FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY tillsMicroservice.csproj tillsMicroservice/
RUN dotnet restore tillsMicroservice/tillsMicroservice.csproj
WORKDIR /src/tillsMicroservice
COPY . .
RUN dotnet build tillsMicroservice.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish tillsMicroservice.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tillsMicroservice.dll"]