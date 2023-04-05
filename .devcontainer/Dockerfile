FROM mcr.microsoft.com/vscode/devcontainers/universal

USER root

RUN apt-get update && export DEBIAN_FRONTEND=noninteractive && apt-get -y install --no-install-recommends \
    powershell

USER codespace
