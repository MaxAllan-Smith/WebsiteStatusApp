# Website Status Tracker Worker Service

This Worker Service is built using C# and .NET 8. It tracks the status of the website [ms-dev.co.uk](https://ms-dev.co.uk) and logs the information to a `LogFile.txt` in a `temp` directory in the C Drive.

## Features

- Tracks the status of the website [ms-dev.co.uk](https://ms-dev.co.uk)
- Logs information to a `LogFile.txt`
- Built using .NET 8
- Utilizes `Serilog` for logging
- Configured with `Microsoft.Extensions`
- Runs as a Windows Service

## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio or any other C# IDE

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/MaxAllan-Smith/WebsiteStatusApp.git
    ```

2. Navigate to the project directory:

    ```bash
    cd WebsiteStatusApp
    ```

3. Restore the required NuGet packages:

    ```bash
    dotnet restore
    ```

### Configuration

Ensure the following NuGet packages are installed:

- Serilog
- Microsoft.Extensions

You can install these packages via the NuGet Package Manager Console:

```bash
dotnet add package Serilog
dotnet add package Microsoft.Extensions.Hosting
```

### Running the Service

You can run the Worker Service using the .NET CLI:

```bash
dotnet run
```

### Logging

The service logs the website status to a `LogFile.txt` located in the `C:\temp` directory. Make sure this directory exists, or you have the necessary permissions to create it.

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.

## Contact

Max Allan-Smith - [max.allan-smith@mit-tech.co.uk](mailto:max.allan-smith@mit-tech.co.uk)

Project Link: [https://github.com/yourusername/website-status-tracker](https://github.com/MaxAllan-Smith/WebsiteStatusApp)
