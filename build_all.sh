#!/bin/bash

dotnet clean --configuration Release --runtime linux-x64
dotnet clean --configuration Release --runtime win-x64
dotnet clean --configuration Release --runtime osx-x64
dotnet publish --configuration Release --runtime linux-x64
dotnet publish --configuration Release --runtime win-x64
dotnet publish --configuration Release --runtime osx-x64

pushd /Users/chuch/RiderProjects/LoginFormExample/LoginFormExample/bin/Release/net6.0/linux-x64/
zip -r ~/Downloads/linux-release.zip ./publish/
popd

pushd /Users/chuch/RiderProjects/LoginFormExample/LoginFormExample/bin/Release/net6.0/osx-x64/
zip -r ~/Downloads/osx-release.zip ./publish/
popd

pushd /Users/chuch/RiderProjects/LoginFormExample/LoginFormExample/bin/Release/net6.0/win-x64/
zip -r ~/Downloads/win-release.zip ./publish/
popd