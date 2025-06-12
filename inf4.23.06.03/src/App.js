import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import { useState } from 'react';

function App() {
  const [type, setType] = useState("");
  const [title, setTitle] = useState("");

  const movieTypes = [
    {id: 1, name : 'Komedia'},
    {id: 2, name: 'Obyczajowy'},
    {id: 3, name: 'Sensacyjny'},
    {id: 4, name: 'Horror'},
  ];

  function add(e) {
    e.preventDefault();
    console.log({tytul: title, kategoria: Number.parseInt(type)});
  }

  return (
    <div className="App">
      <form onSubmit={add}>
      <div className="form-group">
        <label htmlFor="movieTitle">Tytuł filmu</label>
        <input type="text" className="form-control" id="movieTitle" value={title}
                    onChange={e=>setTitle(e.target.value)} />
      </div>
      <div className="form-group">
        <label htmlFor="movieType">Rodzaj</label>
        <select className="form-control" id="movieType" value={type} onChange={e => setType(e.target.value)}>
          {movieTypes.map((movieType) => <option value={movieType.id} >{movieType.name}</option>)}
        </select>
      </div>
      <input type='submit' className="btn btn-primary" value="Dodaj"/>
      </form>
    </div>
  );
}

export default App;
