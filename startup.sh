#!/bin/bash

unzip -P $1 big.txt.zip

dotnet /dotnet_proj/Proj1.dll /big.txt