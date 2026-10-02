# apt only runs when something is missing: it needs the dpkg lock, which unattended-upgrades holds for
# minutes after a WSL cold boot (the workflow waited on it at 0% cpu).
installed() { [ "$(dpkg-query -W -f='${Status}' "$1" 2>/dev/null)" = "install ok installed" ]; }

if ! installed snapd || ! installed unzip; then
    apt update
    apt install -y snapd unzip

    df -h
    apt-get autoremove -y
    apt-get clean
    df -h
fi

if ! snap list powershell >/dev/null 2>&1; then
    snap install powershell --classic
fi
