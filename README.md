# IoT Edge Module Generic Host

[![Build status](https://dev.azure.com/ait-fb/Public/_apis/build/status/IoT/iot-aggregator)](https://dev.azure.com/ait-fb/Public/_build/latest?definitionId=53?branchName=master)

IoT Aggregator is an Azure IoT Edge module to aggregate and transform messages before sending them to upstream sources.

## Getting Started

### Prerequisites
[.NET Core 3.1+ SDK](https://www.microsoft.com/net/download/core) must be installed.

### Installing
Build the solution ``docker build  --rm -f "src/aggregator/Dockerfile.amd64.debug" -t localhost:5000/aggregator:0.0.1-amd64.debug "src/aggregator" ; if ($?) { & "iotedgehubdev" start -d "./src/aggregator/deployment.json" -v }``

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/FlorianBader/iot-module-host/tags).

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
