#!/bin/bash

unzip -P $1 /big.txt.zip -x /test/ >> /dev/null

dotnet /dotnet_proj/Proj1.dll /test/big.txt