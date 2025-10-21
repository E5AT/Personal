import React, { useState } from 'react';
import './App.css';

const NASA_IMAGE_API_URL = `https://images-api.nasa.gov/search?q=space&media_type=image`;

function App() {
  const [photo, setPhoto] = useState(null);
  const [loading, setLoading] = useState(false);

  const getRandomPhoto = async () => {
    setLoading(true);
    try {
      const res = await fetch(NASA_IMAGE_API_URL);
      const data = await res.json();
      const items = data.collection.items;
      if (items.length > 0) {
        const randomIndex = Math.floor(Math.random() * items.length);
        const selected = items[randomIndex];
        // Resmi ve başlığı al
        const imageUrl = selected.links[0].href;
        const title = selected.data[0].title;
        const description = selected.data[0].description;
        setPhoto({ imageUrl, title, description });
      }
    } catch (err) {
      console.error('Hata:', err);
      setPhoto(null);
    }
    setLoading(false);
  };

  return (
    <div className="container">
      <h1>Random Space Snap 🌌</h1>
      <button onClick={getRandomPhoto}>Rastgele Fotoğraf Getir</button>
      {loading && <p>Yükleniyor...</p>}
      {photo && (
        <div className="photo-container">
          <h3>{photo.title}</h3>
          <img src={photo.imageUrl} alt={photo.title} className="space-image" />
          <p>{photo.description}</p>
        </div>
      )}
    </div>
  );
}

export default App;
