#!/bin/bash

unzip -P $1 big.txt.zip

dotnet Proj1.dll /big.txt