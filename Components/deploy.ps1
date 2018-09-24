dotnet publish -r linux-arm
./tools/sshdeploy monitor -s ".\src\IotCamera\bin\Debug\netcoreapp2.0\linux-arm\publish" -t "/home/pi/target" -h 192.168.1.39 -u pi -w <password>