# Country Guide App

## Overview

This is a simple web application that allows users to search for information about any country. Upon entering a country name and clicking "Search", the app fetches and displays key details including the flag, capital, continent, population, currency, and common languages. The app uses the REST Countries API to retrieve the data.

This project is inspired by the YouTube tutorial: [Country Guide App Tutorial](https://youtu.be/QDCmQHO8F8Q?si=DX-1S8iH3rx1NzZq).

## Features

- Search for countries by name
- Display country flag image
- Show basic information: capital, continent, population (formatted with spaces), currency, and languages
- Responsive design with a clean, modern UI using Poppins font
- Error handling for invalid or empty searches

## Technologies Used

- **HTML5**: Structure of the webpage
- **CSS3**: Styling with custom properties for a centered, card-like layout
- **JavaScript (ES6+)**: Fetch API for data retrieval, DOM manipulation, and formatting (e.g., population with non-breaking spaces)
- **External API**: [REST Countries API](https://restcountries.com/) (v3.1)
- **Google Fonts**: Poppins for typography

## Project Structure

```
PROJECTS/country-guide-app/
├── index.html      # Main HTML file with search input and result container
├── script.js       # JavaScript logic for searching and displaying data
└── style.css       # CSS styles for layout, colors, and responsiveness
```

## How to Run

1. Clone or download the project files to your local machine.
2. Open `index.html` in any modern web browser (e.g., Chrome, Firefox).
3. Enter a country name (e.g., "France") in the search input.
4. Click "Search" to view the results.

No additional setup or server is required since it's a static single-page application. The app works offline except for the API calls and flag image loading.

## API Details

The app queries the REST Countries API endpoint:
```
https://restcountries.com/v3.1/name/{countryName}?fullText=true
```

This returns comprehensive country data in JSON format, from which specific fields are extracted and displayed.

## Limitations

- Supports only exact or close-match country names (full-text search enabled).
- Population is displayed with non-breaking spaces for readability.
- Currency displays the first available one if multiple exist.
- Languages are joined with commas for display.

## Screenshots

(You can add screenshots here if desired, e.g., search interface and sample result.)

## Contributing

Feel free to fork this repository and submit pull requests for improvements, such as adding more country details or enhancing the UI.

## License

This project is open-source and available under the MIT License.
