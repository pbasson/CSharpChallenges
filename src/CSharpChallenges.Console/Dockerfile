FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

COPY ["CSharpChallenges.Consoles/CSharpChallenges.Consoles.csproj", "CSharpChallenges.Consoles/"]

RUN dotnet restore "CSharpChallenges.Consoles/CSharpChallenges.Consoles.csproj"
COPY . .

RUN dotnet publish "CSharpChallenges.Consoles/CSharpChallenges.Consoles.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "CSharpChallenges.Consoles.dll"]