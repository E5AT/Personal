import MovieCard from "../components/MovieCard";
import { useState } from "react";
import "../css/Home.css"

function Home(){
    const[searchQueary, setSearchQueary] = useState("");

    const movies =[
        {id:1, title:"Inception", release_date:"2010"},
        {id:2, title:"The Dark Knight", release_date:"2008"},
        {id:3, title:"Interstellar", release_date:"2014"},
    ];

    const handleSearch = (e) => {
        e.preventDefault()

    };

    return (
    <div className="home">
        <form onSubmit={handleSearch} className="search-form">
            <input
                type="text"
                placeholder="Search for movies..."
                className="search-input"
                value={searchQueary}
                onChange={(e)=>setSearchQueary(e.target.value)}
            />
            <button type="submit" className="search-button">Search</button>
        </form>

        <div className="movies-grid">
            {movies.map(
                (movie) =>
                    (
                        <MovieCard movie={movie} key={movie.id}/>
                    )
            )}
        </div>
    </div>
    );
}

export default Home;