

build :
dotnet publish --configuration Release --runtime linux-x64
dotnet publish --configuration Release --runtime win-x64
dotnet publish --configuration Release --runtime osx-x64

Copy solution to linux : 
scp -rp /Users/chuch/Documents/IFX/avalonia/Calc-main/publish-linux.tgz chch@10.211.55.4:~/Downloads
