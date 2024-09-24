// Creating a variable and give a type in ts:

// STRINGS
let movieTitle: string = "Amadeus";
movieTitle = "Arrival";
// movieTitle = 2; // Error

// NUMBERS
let numCatLives: number = 9;
numCatLives++;
// numCatLives = "zero"; // Error

// BOOLEANS
let gameOver: boolean = true;

// compile to js:
// in this exact directory, in terminal write:
// tsc "file name" => tsc script.ts

/////
// Type Inference
// it doesnt neccesory to write the type of variable after declare it.
// the ts look at the value and understand the type itself
let num = 2;
// num = "2"; // Error

/////
// Any
// any is a typescript type
// doesn't the type checking
let thing: any = "hello";
thing = false; // no Error
thing = 2; // no Error
thing(); // no Error
thing.toUpperCase(); // no Error

/////
// delayed initialization & implicit any
const movies = ["Arrival", "the Thing", "Aliens", "Amadeus"];
let foundMovie;

for (let movie of movies) {
  if (movie === "Amadeus") {
    foundMovie = "Amadeus";
  }
}

foundMovie = 2; // no Error
foundMovie(); // no Error

// so if you have to create a variable without initialize it, always write the type:
let foundMovie2: string;
// foundMovie2 = 2; // Error
