/*
// const btn: HTMLElement | null
const btn = document.getElementById("btn");
btn?.addEventListener("click", () => console.log("Hello"));
*/

/*
// const btn: HTMLElement
const btn = document.getElementById("btn")!;
btn.addEventListener("click", () => console.log("Hello"));
*/

/*
/////
// Type Assertions
let mystery: unknown = "Hello World!!!";

// const numChars = mystery.length; //mystery' is of type 'unknown' so you can not use string method on it
//solution:
const numChars = (mystery as string).length;
console.log(numChars); //=> 14

/////
// Type Assertion with the DOM
const btn = document.getElementById("btn")! as HTMLButtonElement;
// first solution:
const input = document.getElementById("todoinput")! as HTMLInputElement;
btn.addEventListener("click", () => {
  console.log(input.value);
  input.value = "";
});
//second solution:
// const input = document.getElementById("todoinput")!;
// btn.addEventListener("click", () => {
//   console.log((<HTMLInputElement>input).value);
//   (<HTMLInputElement>input).value = "";
// });
// first solution was better and cleaner
*/

//////////////////////////////////////
// TODO APP
const btn = document.getElementById("btn")! as HTMLButtonElement;
const input = document.getElementById("todoinput")! as HTMLInputElement;
const form = document.querySelector("form")!;
const list = document.getElementById("todolist")!;

interface Todo {
  text: string;
  completed: boolean;
}

const todos: Todo[] = readTodos();
todos.forEach(createTodoElement);

function readTodos(): Todo[] {
  const todosJSON = localStorage.getItem("todos");
  if (todosJSON === null) return [];
  return JSON.parse(todosJSON);
}

form.addEventListener("submit", function (e: SubmitEvent) {
  e.preventDefault();

  const newTodo: Todo = {
    text: input.value,
    completed: false,
  };

  createTodoElement(newTodo);
  todos.push(newTodo);
  saveTodos();
  input.value = "";
});

function createTodoElement(todo: Todo) {
  const newLI = document.createElement("li");
  const checkbox = document.createElement("input");
  checkbox.type = "checkbox";
  checkbox.checked = todo.completed;

  checkbox.addEventListener("change", function () {
    todo.completed = checkbox.checked;
    saveTodos();
  });

  newLI.append(todo.text);
  newLI.append(checkbox);
  list.append(newLI);
}

function saveTodos() {
  localStorage.setItem("todos", JSON.stringify(todos));
}
