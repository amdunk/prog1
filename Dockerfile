FROM microsoft/dotnet

CMD mkdir /dotnet_proj

ADD src/Proj1/bin/Release/PublishOutput /dotnet_proj

ADD src/Proj1/big.txt /big_test.txt

ADD startup.sh /

CMD chmod ug+x /startup.sh
