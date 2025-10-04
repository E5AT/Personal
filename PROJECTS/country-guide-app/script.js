let searchBtn = document.getElementById("search-btn");
let countryInp = document.getElementById("country-inp");
let result = document.querySelector(".result");

searchBtn.addEventListener("click", () => {
    let countryName = countryInp.value;
    let finalURL = `https://restcountries.com/v3.1/name/${countryName}?fullText=true`;
    fetch(finalURL).then((response) => response.json()).then((data) => {
        const dat = data[0];
        console.log(dat.capital[0]);
        console.log(dat.flags.svg);
        console.log(dat.name.common);
        console.log(dat.continents[0]);
        console.log(Object.keys(dat.currencies)[0]);
        console.log(dat.currencies[Object.keys(dat.currencies)].name);
        console.log(Object.values(dat.languages).toString().split(",").join(", "));
        result.innerHTML =
        `<img src="${dat.flags.svg}" class="flag-img">
        <h2>${dat.name.common}</h2>
        <div class="wrapper">
            <div class="data-wrapper">
                <h4>Capital:</h4>
                <span>${dat.capital[0]}</span>
            </div>
        </div>
        `
        // https://youtu.be/QDCmQHO8F8Q?si=fiwh6ZxyacLAFRIu&t=1001
    });
});