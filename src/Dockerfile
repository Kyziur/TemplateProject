FROM mcr.microsoft.com/dotnet/core/sdk:3.0-bionic AS build
# Use native linux file polling for better performance
# install the .net core debugger
RUN apt-get update
RUN apt-get -y --no-install-recommends install unzip
RUN apt-get -y --no-install-recommends install procps
RUN rm -rf /var/lib/apt/lists/*

RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /vsdbg
ENV DOTNET_USE_POLLING_FILE_WATCHER 1

VOLUME /app
WORKDIR /app/ProjectTemplate.Api/

EXPOSE 5000/tcp 

ENTRYPOINT ["dotnet","watch", "run", "--server.urls", "http://0.0.0.0:5000"]

