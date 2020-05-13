.\build.ps1
if ($?) { & "iotedgehubdev" start -d "./src/aggregator/deployment.json" -v }
