FROM microsoft/dotnet

RUN mkdir /dotnet_proj

ADD src/Proj1/bin/Release/PublishOutput /dotnet_proj

ADD src/Proj1/big.txt /big_test.txt

ADD startup.sh /

RUN chmod ug+x /startup.sh

RUN apt-get install zip
