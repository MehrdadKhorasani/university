"use strict";
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
const btn = document.getElementById("btn");
const input = document.getElementById("todoinput");
const form = document.querySelector("form");
const list = document.getElementById("todolist");
form.addEventListener("submit", function (e) {
    e.preventDefault();
    const newTodoText = input.value;
    const newLI = document.createElement("li");
    const checkbox = document.createElement("input");
    checkbox.type = "checkbox";
    newLI.append(newTodoText);
    newLI.append(checkbox);
    list.append(newLI);
    input.value = "";
    console.log("Submitted");
});
