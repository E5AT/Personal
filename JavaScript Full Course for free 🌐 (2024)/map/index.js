/*const numbers = [1,2,3,4,5];

const squares = numbers.map(square);
const cubes = numbers.map(cube);

console.log(cubes);

function square(element){
    return Math.pow(element, 2);
}

function cube(element){
    return Math.pow(element, 3);
}*/

/*const students = ["Spongebob", "Patrick", "Spidward", "Sandy"];

const studUpper = students.map(upperCase);
const studLower = students.map(lowerCase);

console.log(studLower);

function upperCase(element){
    return element.toUpperCase();
}

function lowerCase(element){
    return element.toLowerCase();
}*/

const dates = ["2024-1-10", "2025-2-20","2-26-3-30"];

const formattedDates = dates.map(formatDates);

console.log(formattedDates);

function formatDates(element){
    const parts = element.split("-");
    return `${parts[1]}/${parts[2]}/${parts[0]}`;
}