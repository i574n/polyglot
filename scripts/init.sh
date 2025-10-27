apt update
apt install -y snapd unzip
snap install powershell --classic

df -h
apt-get remove -y '^ghc-8.*'
apt-get remove -y '^llvm-.*'
apt-get remove -y 'php.*'
apt-get remove -y azure-cli google-cloud-sdk hhvm google-chrome-stable firefox mono-devel
apt-get autoremove -y
apt-get clean
df -h
