//
function printName(person: { first: string; last: string }): void {
  console.log(person.first, person.last);
}
printName({ first: "Thomas", last: "Creed" });

//
let coordinate: { x: number; y: number } = { x: 34, y: 2 };

//
function randomCoordinate(): { x: number; y: number } {
  return { x: Math.random(), y: Math.random() };
}

//
//printName({ first: "Mick", last: "Jagger", age: 43 }); // ERROR
const singer = { first: "Mick", last: "Jagger", age: 43 };
printName(singer); // NO ERROR

/////
// Tyoe Aliases
// instead of repeating types:
/*
function point(): { x: number; y: number } {
  return { x: Math.random(), y: Math.random() };
}

function doublePoint(point: { x: number; y: number }): {
  x: number;
  y: number;
} {
  return { x: point.x * 2, y: point.y * 2 };
}
*/
// do this:
type Point = {
  x: number;
  y: number;
};

let coordinate2: Point = { x: 34, y: 2 };

function point(): Point {
  return { x: Math.random(), y: Math.random() };
}

function doublePoint(point: Point): Point {
  return { x: point.x * 2, y: point.y * 2 };
}

/////
// Nested Objects

type Song = {
  title: string;
  artist: string;
  numStreams: number;
  credits: {
    producer: string;
    writer: string;
  };
};

function calculatePayout(song: Song): number {
  return song.numStreams * 0.0033;
}

function printSong(song: Song): void {
  console.log(`${song.title} - ${song.artist}`);
}

const mySong: Song = {
  title: "Unchained Melody",
  artist: "Rughteous Borthers",
  numStreams: 12873321,
  credits: {
    producer: "Phil Spector",
    writer: "Bill Medley",
  },
};

calculatePayout(mySong);
printSong(mySong);

/////
// Optional Properties
type Points = {
  x: number;
  y: number;
  z?: number; // ? this is not required
};

const myPoints: Point = { x: 1, y: 3 };

/////
// Readonly Modifier
type User = {
  readonly id: number;
  userName: string;
  password: string;
};
const user: User = {
  id: 12837,
  userName: "catGurl",
  password: "1234",
};
// user.id = 232; // ERROR

/////
// Intersection Types
type Circle = {
  radius: number;
};
type Colorful = {
  color: string;
};
type ColorfulCircle = Circle & Colorful;
const happyFace: ColorfulCircle = {
  radius: 4,
  color: "yellow",
};

type Cat = {
  numLives: number;
};
type Dog = {
  breed: string;
};
type CatDog = Cat &
  Dog & {
    age: number;
  };
const christy: CatDog = {
  numLives: 7,
  breed: "Husky",
  age: 9,
};

/////
// Exercise

type Movie = {
  readonly title: String;
  originalTitle?: string;
  director: string;
  releaseYear: number;
  boxOffice: {
    budget: number;
    grossUS: number;
    grossWorldWide: number;
  };
};

const dune: Movie = {
  title: "Dune",
  originalTitle: "Dune Part One",
  director: "Denis Villeneuve",
  releaseYear: 2021,
  boxOffice: {
    budget: 165000000,
    grossUS: 108327830,
    grossWorldWide: 400671789,
  },
};
const cats: Movie = {
  title: "Cats",
  director: "Tom Hooper",
  releaseYear: 2019,
  boxOffice: {
    budget: 95000000,
    grossUS: 27166770,
    grossWorldWide: 73833348,
  },
};

function getProfit(movie: Movie): number {
  const { grossWorldWide, budget } = movie.boxOffice;
  return grossWorldWide - budget;
}

getProfit(cats);
