let searchBtn = document.getElementById("search-btn");
let countryInp = document.getElementById("country-inp");
let result = document.querySelector(".result");

function formatPopulation(num) {
    return num.toString().replace(/\B(?=(\d{3})+(?!\d))/g, '\u00A0');
}

searchBtn.addEventListener("click", () => {
    let countryName = countryInp.value.trim();
    let finalURL = `https://restcountries.com/v3.1/name/${countryName}?fullText=true`;
    fetch(finalURL).then((response) => response.json()).then((data) => {
        const dat = data[0];

        result.innerHTML =
        `<img src="${dat.flags.svg}" class="flag-img">
        <h2>${dat.name.common}</h2>
        <div class="wrapper">
            <div class="data-wrapper">
                <h4>Capital:</h4>
                <span>${dat.capital[0]}</span>
            </div>
        </div>

        <div class="wrapper">
            <div class="data-wrapper">
                <h4>Continent:</h4>
                <span>${dat.continents[0]}</span>
            </div>
        </div>

        <div class="wrapper">
            <div class="data-wrapper">
                <h4>Population:</h4>
                <span>${formatPopulation(dat.population)}</span>
            </div>
        </div>

        <div class="wrapper">
            <div class="data-wrapper">
                <h4>Currency:</h4>
                <span>${dat.currencies[Object.keys(dat.currencies)].name} - ${Object.keys(dat.currencies)[0]}</span>
            </div>
        </div>

        <div class="wrapper">
            <div class="data-wrapper">
                <h4>Common Languages:</h4>
                <span>${Object.values(dat.languages).toString().split(",").join(", ")}</span>
            </div>
        </div>
        `;
    }).catch(() => {
        if(countryName.length == 0)
            result.innerHTML = `<h3>The input field cannot be empty</h3>`;
        else
            result.innerHTML = `<h3>Please enter a valid country name.</h3>`;
        });
});
