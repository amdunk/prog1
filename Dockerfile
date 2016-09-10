FROM microsoft/dotnet

CMD mkdir /dotnet_proj

ADD src/Proj1/bin/Release/PublishOutput /dotnet_proj