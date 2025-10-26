apt update
apt install -y snapd unzip
snap install powershell --classic

df -h
sudo apt-get remove -y '^ghc-8.*'
sudo apt-get remove -y 'php.*'
sudo apt-get remove -y azure-cli google-cloud-sdk hhvm google-chrome-stable firefox mono-devel
sudo apt-get autoremove -y
sudo apt-get clean
df -h
