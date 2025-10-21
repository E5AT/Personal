const API_KEY = "api_key";
const BASE_URL = "https://api.moviedb.org/3";

export const getPopularMovies = async () =>{
    const response = await fetch(`${BASE_URL}/movie/popular?api_key=${API_KEY}`);
    const data = await response.json();
    return data.results;
};

export const search = async (query) =>{
    const response = await fetch(
        `${BASE_URL}/search/movie?api_key=${API_KEY}&query${encodeURIComponent(
            query
        )}`
    );
    const data = await response.json();
    return data.results;
};