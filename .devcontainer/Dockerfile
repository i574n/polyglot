FROM mcr.microsoft.com/vscode/devcontainers/universal

USER root

COPY scripts/init.sh /usr/local/bin/init.sh
RUN chmod +x /usr/local/bin/init.sh
RUN /usr/local/bin/init.sh
USER codespace
