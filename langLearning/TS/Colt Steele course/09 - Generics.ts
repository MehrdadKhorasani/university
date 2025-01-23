const nums_regular: number[] = [];
const nums_generic: Array<number> = [];
/////
const colors: Array<string> = ["Red", "Blue", "Green"];
/////
const inputEl = document.querySelector<HTMLInputElement>("#input")!;
console.log(inputEl);
inputEl.value = "xxx";

const btnEl = document.querySelector<HTMLButtonElement>(".btn");
if (btnEl) btnEl.value = "yyy";
/////
function numberIdentity(item: number): number {
  return item;
}
function stringIdentity(item: string): string {
  return item;
}
function booleanIdentity(item: boolean): boolean {
  return item;
}
// solution1:
function identity(item: any): any {
  return item; // not good
  // how we know the types of the input and output of function are the same?
}
// solution2:
function genericIdentity<Type>(item: Type): Type {
  return item;
}
const r1 = genericIdentity<string>("hello");
const r2 = genericIdentity<number>(2);
const r3 = genericIdentity<boolean>(true);
console.log(r1, r2, r3); //=> hello 2 true
// it gets an input and returns an output in the same type

/////
interface Cat {
  name: string;
  breed: string;
}

function getRandomElement<T>(list: T[]): T {
  const len = list.length;
  const randomNumber = Math.floor(Math.random() * len);
  return list[randomNumber];
}

getRandomElement<string>(["a", "b", "c", "d"]);
getRandomElement<number>([2, 5, 8, 3, 1]);
getRandomElement<boolean>([true, false]);
getRandomElement<Cat>([
  { name: "farokh", breed: "shepard" },
  { name: "golrokh", breed: "Tai" },
]);
// note:
getRandomElement(["a", "v", "asd"]); // u dont need specify the type in the initialize, because all the values must be in a same type.
getRandomElement([131, 5252, 67734, 2, 37]);

///// Generics with multiple types
function merge<T, U>(object1: T, object2: U) {
  return {
    ...object1,
    ...object2,
  };
}
const combo = merge({ name: "colt" }, { pets: ["blue", "elton"] });
console.log(combo);
// Adding type constraints:
function mergeTheSecond<T extends object, U extends object>(
  object1: T,
  object2: U
) {
  return {
    ...object1,
    ...object2,
  };
}
function tt<T extends number>(number: T) {
  return number;
}
tt(2);
// tt("hello"); // ERROR

interface Lengthy {
  length: number;
}
function printDoubleLength<T extends Lengthy>(thing: T): number {
  return thing.length * 2;
}
printDoubleLength("asd");
// printDoubleLength(234); // Error

///// Default Type Parameters
function makeEmptyArray<T = number>(): T[] {
  return [];
}
const nums = makeEmptyArray();
const bools = makeEmptyArray<boolean>();

///// Generic classes
interface Song {
  title: string;
  artist: string;
}
interface Video {
  title: string;
  creator: string;
  resolution: string;
}

class Playlist<T> {
  public queue: T[] = [];
  add(el: T) {
    this.queue.push(el);
  }
}

const songs = new Playlist<Song>();
const videos = new Playlist<Video>();
songs.add({ title: "fly me to the moon", artist: "frank sinatra" });
videos.add({
  title: "interstellar",
  creator: "Hans zimmer",
  resolution: "1920x1280",
});
