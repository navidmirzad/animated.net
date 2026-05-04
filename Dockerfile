# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copy project files
COPY ["animated/animated.csproj", "animated/"]
RUN dotnet restore "animated/animated.csproj"

# Copy source code
COPY . .

# Build and publish the application
RUN dotnet publish "animated/animated.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Expose ports
EXPOSE 5000

# Set environment variables
ENV ASPNETCORE_URLS=http://+:5000

ENTRYPOINT ["dotnet", "animated.dll"]
