FROM microsoft/dotnet

RUN mkdir /dotnet_proj

RUN apt-get update

RUN apt-get -y install zip

ADD src/Proj1/bin/Release/PublishOutput /dotnet_proj

ADD src/Proj1/big.txt /big_test.txt

ADD startup.sh /

RUN chmod ug+x /startup.sh

RUN mkdir /test


