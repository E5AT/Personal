# Weather App

A simple, responsive web application that allows users to search for current weather information by city name. It fetches data from the OpenWeatherMap API and displays the temperature, humidity, wind speed, and a corresponding weather icon.

## Source
This project is inspired by the tutorial video: [How To Make Weather App Using JavaScript Step By Step Explained](https://youtu.be/MIYQR-Ybrn4?si=yNfjpcXn9vSO5LDm).

## Features
- Search for weather by entering a city name.
- Displays current temperature in Celsius, humidity percentage, and wind speed in km/h.
- Shows weather icons based on conditions (e.g., clouds, clear, rain, drizzle, mist).
- Responsive design with a modern gradient card layout.
- Error handling for invalid city names.
- Built with vanilla HTML, CSS, and JavaScript—no external frameworks required.

## Technologies Used
- **HTML5**: Structure the user interface.
- **CSS3**: Styling with Flexbox for layout, custom fonts (Poppins), and gradients.
- **JavaScript (ES6)**: Fetch API for weather data, DOM manipulation for dynamic updates.
- **OpenWeatherMap API**: Free weather data service (requires an API key).

## Prerequisites
- A web browser (e.g., Chrome, Firefox).
- An API key from [OpenWeatherMap](https://openweathermap.org/api). Sign up for a free account to get one.

## Setup
1. Clone or download the project files.
2. Replace the placeholder API key in `index.html` (line in the script: `const apiKey = "your_api_key_here";`) with your actual OpenWeatherMap API key.
3. Open `index.html` in a web browser or serve it via a local server (e.g., using Python: `python -m http.server` or Live Server in VS Code).

## Usage
1. Enter a city name (e.g., "London", "New York") in the search input field.
2. Click the search button (magnifying glass icon).
3. The app will fetch and display the current weather details.
4. If the city is invalid, an error message will appear.

Default display shows sample data for New York (22°C, 50% humidity, 15 km/h wind).

## Project Structure
- `index.html`: Main HTML file with embedded JavaScript for API calls and DOM updates.
- `style.css`: Styles for the card-based UI, search bar, and weather display.
- `images/`: Directory for weather icons (not provided in this setup; add files like `clouds.png`, `clear.png`, `rain.png`, etc., or use CDN links).

## API Configuration
The app uses the OpenWeatherMap current weather endpoint:
```
https://api.openweathermap.org/data/2.5/weather?units=metric&q={city}&appid={API_KEY}
```
- Units set to metric (Celsius).
- Supports basic weather conditions for icon switching.

## Limitations
- Only fetches current weather (no forecasts).
- Requires internet connection for API calls.
- API key must be kept private in production (consider environment variables for advanced setups).
- Icons assume local images; update paths if using external resources.

## Contributing
Feel free to fork the repo, make improvements (e.g., add forecasts, geolocation), and submit pull requests.

## License
This project is open-source and free to use under the MIT License.
