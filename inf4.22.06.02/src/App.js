import 'bootstrap/dist/css/bootstrap.css';
import './App.css';
import { useState } from 'react';

function App() {
  const [name, setName] = useState("");
  const [course, setCourse] = useState("");

  const courses = [
    {id: 1, name : 'Programowanie w C#'},
    {id: 2, name: 'Angular dla początkujących'},
    {id: 3, name: 'Kurs Django'},
  ];

  function signUp(e) {
    e.preventDefault();
    console.log(name);
    console.log(courses[course-1].name);
  }

  return (
    <div className="App">
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map((course) => <li>{course.name}</li>)}
      </ol>
      <form onSubmit={signUp}>
      <div className="form-group">
        <label htmlFor="name">Imię i nazwisko</label>
        <input type="text" className="form-control" id="name" value={name}
                    onChange={e=>setName(e.target.value)} />
      </div>
      <div className="form-group">
        <label htmlFor="course">Numer kursu:</label>
        <input type="number" min="1" max={courses.length} className="form-control" id="course" value={course}
                    onChange={e=>setCourse(e.target.value)} />
      </div>
      <input type='submit' className="btn btn-primary" value="Zapisz do kursu"/>
      </form>
    </div>
  );
}

export default App;
