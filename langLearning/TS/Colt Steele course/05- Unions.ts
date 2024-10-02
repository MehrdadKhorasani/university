//
let age: number | string = 21;
age = "twenty one";

//
type Point = {
  x: number;
  y: number;
};
type Loc = {
  lat: number;
  long: number;
};

let coordinates: Point | Loc = { x: 1, y: 32 };
coordinates = { lat: 12.231, long: 4.44 };

//
function printAge(age: number | string): void {
  console.log(`You are ${age} years old`);
}
printAge(21);
printAge("23");

/////
// Type Narrowing
function calcTax(price: number | string, tax: number) {
  // return price * tax; //Error,because of the possiblity of that price be a string
  // price.replace("$", ""); //Error, because replace is a string method but it's possible for price to be a number

  if (typeof price === "string") {
    price = parseFloat(price.replace("$", ""));
  }

  // return typeof price === "number" && price * tax; //good
  return price * tax;

  //this called type narrowing
}

/////
// Union Types & arrays:
const nums: number[] = [1, 2, 3, 4];
const stuff: any[] = [true, 2, "hello", {}];
let stuffs2: number[] | string[] = [2]; // str || num
stuffs2 = ["2"];
const stuffs: (number | string)[] = [2, "2"]; // str && num

const coords: (Point | Loc)[] = [];
coords.push({ lat: 321.213, long: 23.334 });
coords.push({ x: 3, y: 88 });

/////
// Literal Types
let zero: 0 = 0;
// zero = 2; // Error
let hi: "hi" = "hi";

// combine literal types with union types:
const giveAnswer = (answer: "yes" | "no" | "maybe") =>
  `The answer is ${answer}`;
giveAnswer("no");
// giveAnswer("No"); //Error

let mood: "Happy" | "Sad" = "Happy";
mood = "Sad";
// mood = "Angry"; // Error

type DayOfWeek =
  | "Monday"
  | "Tuesday"
  | "Wednesday"
  | "Thursday"
  | "Friday"
  | "Saturday"
  | "Sunday";

let today: DayOfWeek = "Sunday";
// today = "y"; //Error

/////
// Exercise
//1.
let highScore: number | boolean;
highScore = 2;
highScore = true;

//2.
let stuffss: number[] | string[];

//3.
type SkillLevel = "Beginner" | "Intermediate" | "Advanced" | "Expert";
let skill: SkillLevel = "Beginner";

//4.
type SkiSchoolStudent = {
  name: string;
  age: number;
  sport: "Ski" | "Snowboard"; //literal type
  level: SkillLevel;
};

//5.
type RGB = {
  r: number;
  g: number;
  b: number;
};
type HSL = {
  h: number;
  s: number;
  l: number;
};

const colors: (RGB | HSL)[] = [];

colors.push({ r: 12, g: 13, b: 14 });
colors.push({ h: 12, s: 13, l: 14 });

//6.
function greet(names: string | string[]): void {
  if (typeof names === "object") {
    for (const name of names) {
      console.log(`Hello ${name}`);
    }
  } else {
    console.log(`Hello ${names}`);
  }
}
