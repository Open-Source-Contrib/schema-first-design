# Design the schema

Here are the requirement for our systems.
> Let's say we are building a weather system that can show the weather on a web page, the web page get's the data from an API that we need to build. This website will allow the user to type in a place and see it's weather. The following features are desired.
> 1. Let user select a search mode out of 2 modes - we will support searching by Lat/Long or City Name.
> 2. Once the user has selected a mode - depending on the mode selected we will either show 2 input fields (for Lat/Long) or single input field (for city name). 
> 3. Once the user types in the information in all available input fields - the ```Search``` button will be enabled.
> 4. When the user clicks on the ```Search``` button - the data will be fetched from the server.
> 5. If we have weather information about the place we will return the following data:
>    - Expected Low Temprature for today (degrees celcius)
>    - Expected High Temprature for today (degrees celcius)
>    - Expected Windspeed for today (miles per hour)
>    - Wind Direction for today (like N, NE, NW, S, SE, SW, E, W)
>    - Atmospheric conditions (like sunny, cloudy, overcast, rain, hailstorm, thunderstorm, drizzle, windy etc.)
> 6. If we don't have the weather information we will show an error message on the webpage - "No information available".
> 7. If the user typed in incorrect data - like numbers in city name etc. - we will show an error message on the webpage - "Invalid search parameters"

## Design

Based on the above information we can design our API specs in the top level API spec file in OpenAPI V3 format in file [openapi.yaml](../specs/openapi.yaml). This file defines the API operations, models and responses. It is possible to split this file into individual files per operation/route but that is beyond the scope of this workshop.
