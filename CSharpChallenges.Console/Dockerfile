FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

COPY ["CSharpChallenges.Console/CSharpChallenges.Console.csproj", "CSharpChallenges.Console/"]

# COPY CSharpChallenges.Console/CSharpChallenges.Console.csproj CSharpChallenges.Console
RUN dotnet restore "CSharpChallenges.Console/CSharpChallenges.Console.csproj"
COPY . .

# COPY CSharpChallenges.Console CSharpChallenges.Console

RUN dotnet publish "CSharpChallenges.Console/CSharpChallenges.Console.csproj" -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

# Entry point when the container starts
ENTRYPOINT ["dotnet", "CSharpChallenges.Console.dll"]