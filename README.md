#   Dotnet OpenAI Project

This project demonstrates how to use the OpenAI API in a .NET Core application using a worker service. The application reads prompts from the console and generates responses using OpenAI's GPT-3 model.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [Contributing](#contributing)

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- An OpenAI API key. You can obtain one by signing up at [OpenAI](https://beta.openai.com/signup/).

## Installation

Clone the repository:

  ```bash
    git clone https://github.com/yourusername/dotnet-openai-project.git
    cd dotnet-openai-project
  ```

## Configuration

Set your OpenAI API key as an environment variable. Replace my OpenAI key with your actual OpenAI API key.

  **For Windows (Command Prompt):**
    ```cmd
    setx OPENAI_API_KEY "your-api-key"
    ```

## Usage

1. Run the application:

    ```bash
    dotnet run
    ```

2. The application will wait for you to enter a text input. Type your prompt and press Enter to get a response from the OpenAI API.

    ```
    ::Merhaba! Ne sormak istersiniz?
    ```

    Example input:
    
    ```
    ::How many insects are in the world?
    ```

3. The application will display the response from the OpenAI API. // not working properly yet

## Contributing

If you would like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.
