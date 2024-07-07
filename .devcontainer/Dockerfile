FROM mcr.microsoft.com/vscode/devcontainers/universal

USER root

COPY scripts/init.sh /usr/local/bin/init.sh
RUN chmod +x /usr/local/bin/init.sh
RUN /usr/local/bin/init.sh

USER codespace

COPY scripts/core.ps1 /usr/local/bin/core.ps1
COPY scripts/init.ps1 /usr/local/bin/init.ps1
COPY requirements.txt /usr/local/requirements.txt
RUN pwsh /usr/local/bin/init.ps1 -init 1
