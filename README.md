Sure, here is a basic template for your README file. Feel free to modify it as necessary:

---

# Rectangle Matcher API

## Overview

This is a web-based API designed to perform searches and matches of input coordinates against established sets of rectangles in a database. The API maintains best practices and has the ability to scale to meet load.

## Requirements

The application:

- Contains data seed methods to populate 200 rectangle data entries into the database.
- Defines each data entry (and therefore row(s)) as rectangle coordinates and/or dimensions.
- Defines an endpoint that accepts an array of coordinates.
- For each passed coordinate, outputs a list of rectangles defined in the database that the coordinate falls into.

The application also:

- Implements automated tests.
- Makes use of indexes and foreign keys in the database.
- Implements basic authentication for the caller of the API.
- Has further design considerations assuming scaling this system and integrations with external consumers.

## Getting Started

### Prerequisites

- .NET 7.0.5
- Entity Framework Core
- Microsoft SQL Server 2019 Express
- Git 2.40.1

### Installation

1. Clone the repo
```
git clone https://github.com/blucyk/rectangles.git
```
2. Install .NET packages
```
dotnet restore
```
3. Update the database
```
dotnet ef database update
```
4. Run the application
```
dotnet run
```

## Usage

### Endpoint

**POST /api/rectangle**

Request Header:

Add 'X-Api-Key' key with a value of 'SampleAPIKey-ONEHSN123'

Request Body:

```json
{
  "coordinates": [
    {"x": 1, "y": 2},
    {"x": 3, "y": 4},
    // ...more coordinates
  ]
}
```

Response:

```json
[
    {
        "id": 1,
        "x1": 0,
        "y1": 0,
        "x2": 5,
        "y2": 5
    },
    {
        "id": 101,
        "x1": 0,
        "y1": 0,
        "x2": 6,
        "y2": 6
    },

  // ...more results
]
```

## Testing

Run the tests with the following command:

```
dotnet test
```

## License

[MIT](https://choosealicense.com/licenses/mit/)

