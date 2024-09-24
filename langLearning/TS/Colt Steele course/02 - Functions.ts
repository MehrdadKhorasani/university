function square(num: number) {
  return num * num;
}
square(3);
// square("asd"); // Error
// square(true); // Error

function greet(person: string) {
  return `Hi there, ${person}`;
}
console.log(greet("Tom"));

const doSomething = (person: string, age: number, isFunny: boolean) =>
  `${person} is ${age} years old and is ${isFunny ? "funny" : "not funny"}`;

/////
// default value
function asd(num: number = 10) {
  console.log(num);
}

/////
// Return Type annotations
function func(num: number): number {
  return num * num;
  // but it's not necessary.
  // the ts itself understands that what is the returning value from a function
  // but it's a good practice to do this
}

// return more than one type:
function rando(num: number): number | string {
  if (Math.random() < 0.5) return num.toString();
  return num;
}

/////
// Anonymous functions
const colors = ["red", "orange", "yellow"];
colors.map((color) => {
  // return color.toFixed() //Error
  return color.toUpperCase();
});

/////
// Void
// void is a return type for functions that don't return anything
function printTwice(msg: string): void {
  console.log(msg);
  console.log(msg);
}

/////
// Never
// the never type represents values that NEVER occur.
// it's ts type. not a js type.
const neverStop = (): never => {
  while (true) console.log("I'm Still Going!");
};

function makeError(msg: string): never {
  throw new Error(msg);
}

//////
// EXERCISE
function twoFer(name: string = "you"): string {
  return `one for ${name}, one for me`;
}

console.log(twoFer());
console.log(twoFer("Elton"));

function isLeapyear(year: number): boolean {
  return (year % 4 === 0 && year % 100 !== 0) || year % 400 === 0;
}

console.log(isLeapyear(2012));
console.log(isLeapyear(2013));
