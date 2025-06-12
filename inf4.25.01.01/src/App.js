import './App.css';
import { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  const [flowersVisible, setFlowersVisible] = useState(true);
  const [animalsVisible, setAnimalsVisible] = useState(true);
  const [carsVisible, setCarsVisible] = useState(true);

  var [imagesData, setImagesData] =  useState([
    {id: 0, alt: "Mak", filename: "obraz1.jpg", category:1, downloads: 35},
    {id: 1, alt:"Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43},
    {id: 2, alt:"Dalmatyńczyk", filename: "obraz3.jpg", category:2, downloads: 2},
    {id: 3, alt:"Świnka morska", filename: "obraz4.jpg", category:2, downloads: 53},
    {id: 4, alt:"Rotwailer", filename: "obraz5.jpg", category:2, downloads: 43},
    {id: 5, alt:"Audi", filename: "obraz6.jpg", category:3, downloads: 11},
    {id: 6, alt:"kotki", filename: "obraz7.jpg", category:2, downloads: 22},
    {id: 7, alt:"Róża", filename: "obraz8.jpg", category:1, downloads: 33},
    {id: 8, alt:"Świnka morska", filename: "obraz9.jpg", category:2, downloads: 123},
    {id: 9, alt:"Foksterier", filename: "obraz10.jpg", category:2, downloads: 22},
    {id: 10, alt:"Szczeniak", filename: "obraz11.jpg", category:2, downloads: 12},
    {id: 11, alt:"Garbus", filename: "obraz12.jpg", category:3, downloads: 321}
  ]);

  function incrementDownload(imgData, id){
    var tempImgData = imgData;
    if(tempImgData.id == id){
      tempImgData.downloads++;
    }

    return tempImgData;
  }

  return (
    <div className="App">
      <h1>Kategorie zdjęć</h1>
      <div>
        <div className="form-check form-switch form-check-inline">
          <input className="form-check-input" checked={flowersVisible} onChange={e => setFlowersVisible(e.target.checked)} type="checkbox" id="ctrId"/>
          <label className="form-check-label" htmlFor="ctrId">Kwiaty</label>
        </div>
        <div className="form-check form-switch form-check-inline">
          <input className="form-check-input" checked={animalsVisible} onChange={e => setAnimalsVisible(e.target.checked)} type="checkbox" id="ctrId"/>
          <label className="form-check-label" htmlFor="ctrId">Zwierzęta</label>
        </div>
        <div className="form-check form-switch form-check-inline">
          <input className="form-check-input" checked={carsVisible} onChange={e => setCarsVisible(e.target.checked)} type="checkbox" id="ctrId"/>
          <label className="form-check-label" htmlFor="ctrId">Samochody</label>
        </div>
      </div>
      <div>
        {
          flowersVisible && imagesData.filter(imageData => imageData.category == 1).map(imageData => <div className='imageContainer'>
              <img src={"assets/" + imageData.filename} alt={imageData.alt} />
              <h4>Pobrań: {imageData.downloads}</h4>
              <button type="button" className="btn btn-success" onClick={() => setImagesData(imagesData.map(imgData => incrementDownload(imgData, imageData.id)))}>Pobierz</button>
            </div>)
        }
        {
          animalsVisible && imagesData.filter(imageData => imageData.category == 2).map(imageData => <div className='imageContainer'>
              <img src={"assets/" + imageData.filename} alt={imageData.alt} />
              <h4>Pobrań: {imageData.downloads}</h4>
              <button type="button" className="btn btn-success" onClick={() => setImagesData(imagesData.map(imgData => incrementDownload(imgData, imageData.id)))}>Pobierz</button>
            </div>)
        }
        {
          carsVisible && imagesData.filter(imageData => imageData.category == 3).map(imageData => <div className='imageContainer'>
              <img src={"assets/" + imageData.filename} alt={imageData.alt} />
              <h4>Pobrań: {imageData.downloads}</h4>
              <button type="button" className="btn btn-success" onClick={() => setImagesData(imagesData.map(imgData => incrementDownload(imgData, imageData.id)))}>Pobierz</button>
            </div>)
        }
      </div>
      
    </div>
  );
}

export default App;
