# Passo a passo

1. ```dotnet publish -c Release```
2. ```sudo useradd -s /sbin/nologin pedro```
3. ```sudo mkdir /var/SystemdPocAWS```
4. ```sudo cp /home/ubuntu/pocAWS/bin/Release/netcoreapp2.0/publish/* /var/SystemdPocAWS```
5. ```sudo chown -R pedro:pedro /var/SystemdPocAWS```
6. Criar o arquivo pocAWS.service no diretório "/etc/systemd/system/"
7. ```sudo systemctl start pocAWS.service```


**pocAWS.service**:
```
[Unit]
Description = Poc dotnet core service
DefaultDependencies = no

[Service]
Type = oneshot
RemainAfterExit = no
ExecStart = /usr/bin/dotnet pocAWS.dll
User = pedro
Group = pedro
```