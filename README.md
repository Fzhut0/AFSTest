# Leet Speak Translator

## Overview

This ASP.NET MVC application allows users to input text and convert it into "l33t sp34k" using the Fun Translations API. Applications saves translations to database file.

## Technologies Used

- ASP.NET MVC
- Entity Framework Core
- SQLite
- jQuery
- AJAX
- Moq (for unit testing)
- xUnit (for unit testing)

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or later)
- SQLite

## Setup

1. Download the project
2. Run the application (database file is already included in project)

## Usage

1. Enter text you want to translate.
2. Click translate button.
3. Wait for output.

API has limited amount of usages to 10 per hour. User will get error after exceeding amount of tries.

## Testing

Application includes one unit test in AFSTest.Tests project.

