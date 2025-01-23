///// TYPE NARROWING

function triple(value: number | string) {
  if (typeof value === "number") return value * 3;
  else return value.repeat(3);
}
console.log(triple(2)); //=> 6
console.log(triple("Hi")); //=> HiHiHi

const printLetters = (word: string | null) => {
  if (!word) console.log("No word was provided.");
  else [...word].forEach((letter) => console.log(letter));
};

const printLetter = (word?: string) => {
  if (word) for (let char of word) console.log(char);
  else console.log("No word was provided.");
};

printLetters("Kiiifasda");

const el = document.getElementById("idk");
if (el) {
  console.log(el);
} else {
  console.log("el is not exist");
}

///// In Operator Narrowing
interface Movie {
  title: string;
  duration: number;
}
interface TVShow {
  title: string;
  numEpisodes: number;
  episodeDuration: number;
}
function getRuntime(media: Movie | TVShow) {
  if ("numEpisodes" in media) {
    return media.numEpisodes * media.episodeDuration;
  }
  return media.duration;
}

///// Instanceof Narrowing
function printFullDate(date: string | Date) {
  if (date instanceof Date) console.log(date.toUTCString());
  else console.log(new Date(date).toUTCString());
}

class User {
  constructor(public name: string) {}
}
class Company {
  constructor(public name: string) {}
}
function printName(entity: User | Company) {
  if (entity instanceof User) return entity.name;
}

///// Type Predicates
interface Cat {
  name: string;
  numLives: number;
}
interface Dog {
  name: string;
  breed: string;
}
function isCat(animal: Cat | Dog): animal is Cat {
  return (animal as Cat).numLives !== undefined;
}
function makeNoise(animal: Cat | Dog): string {
  if (isCat(animal)) {
    return "Meow";
  }
  return "Woof";
}

///// Discriminated unions
interface Rooster {
  name: string;
  weight: number;
  age: number;
  kind: "rooster";
}
interface Cow {
  name: string;
  weight: number;
  age: number;
  kind: "cow";
}
interface Pig {
  name: string;
  weight: number;
  age: number;
  kind: "pig";
}
type FarmAnimal = Pig | Rooster | Cow;
function getFarmAnimalSound(animal: FarmAnimal) {
  switch (animal.kind) {
    case "pig":
      console.log("oink");
      break;
    case "cow":
      console.log("mooo");
      break;
    case "rooster":
      console.log("Cockadoodledoo");
      break;
    default:
      const _exhaustiveCheck: never = animal; // Exhaustiveness checks with Never
      return _exhaustiveCheck;
  }
}
const stevie: Rooster = {
  name: "stevie Chicks",
  weight: 2,
  age: 1.5,
  kind: "rooster",
};
console.log(getFarmAnimalSound(stevie));
