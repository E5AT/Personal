import { useState } from "react";
import "./App.css";
import supabase from "./supabase-client";

function App() {
  const [todoList, setTodoList] = useState([]);
  const [newTodo, setNewTodo] = useState("");
  const addTodo = async () => {
    const newTodoData = {
      name: newTodo,
      isCompleted: false,
    };
    const { data, error } = await supabase
      .from("TodoList")
      .insert([newTodoData])
      .single();

    if (error) {
      console.log("Error: ", error);
    } else {
      setTodoList((prev) => [...prev, data]);
      setNewTodo("");
    }
  };

  return (
    <>
      <div>
        <h1>Todo List</h1>
        <div>
          <input
            type="text"
            placeholder="New Todo..."
            onChange={(e) => setNewTodo(e.target.value)}
            value={newTodo}
          />
          <button onClick={addTodo}>Add Todo Item</button>
        </div>

        <ul>
          {todoList.map((todo) => (
            <li key={todo.id}>{todo.name}</li>
          ))}
        </ul>
      </div>
    </>
  );
}

export default App;
