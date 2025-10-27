FROM mcr.microsoft.com/vscode/devcontainers/universal:dev

USER root

RUN apt-get update && export DEBIAN_FRONTEND=noninteractive && apt-get -y install --no-install-recommends \
    powershell


RUN df -h
RUN apt-get remove -y '^dotnet-.*'
RUN df -h
RUN ls -al /usr/share/dotnet/sdk
RUN rm -rf /usr/share/dotnet/
RUN df -h


USER codespace

COPY scripts/core.ps1 /usr/local/bin/core.ps1
COPY scripts/init.ps1 /usr/local/bin/init.ps1
COPY requirements.txt /usr/local/requirements.txt
RUN pwsh /usr/local/bin/init.ps1 -init 1
