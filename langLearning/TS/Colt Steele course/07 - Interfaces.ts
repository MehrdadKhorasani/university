//
interface Point {
  x: number;
  y: number;
}

const pt: Point = { x: 123, y: 123 };

//
interface Person {
  readonly id: number;
  firstName: string;
  lastName: string;
  nickName?: string;
}

const thomas: Person = {
  nickName: "Tom",
  firstName: "Thomas",
  id: 21837,
  lastName: "Hardy",
};

/////
// METHODS
interface Human {
  readonly id: number;
  firstName: string;
  lastName: string;
  sayHi: () => string; // first way
  sayHi2(): string; // second way
}
const andy: Human = {
  firstName: "Andy",
  lastName: "Samberg",
  id: 1336598,
  sayHi: () => `Hello ${andy.firstName}`,
  sayHi2: () => {
    return `dss`;
  },
};

// Method Parameters
interface Product {
  name: string;
  price: number;
  applyDiscount(discount: number): number;
}
const shoes: Product = {
  name: "Blue Suede Shoes",
  price: 100,
  applyDiscount(amount: number) {
    const newPrice = this.price * (1 - amount);
    this.price = newPrice;
    return this.price;
  },
};
console.log(shoes.applyDiscount(0.4));

// unlike the type Aliases, we can re-open and add new properties to interfaces after describe them:
interface Persons {
  name: string;
}
interface Persons {
  age: number;
}
const Ali: Persons = {
  name: "ali",
  age: 12,
};

interface Dog {
  name: string;
  age: number;
}
interface Dog {
  breed: string;
  bark(): string;
}
const elton: Dog = {
  name: "Elton",
  age: 0.5,
  breed: "Australian Shepherd",
  bark() {
    return "Woof";
  },
};

/////
// Extending Interfaces
interface ServiceDog extends Dog {
  job: "drug sniffer" | "bomb" | "guide Dog";
}

const chewy: ServiceDog = {
  name: "Chewy",
  age: 5,
  breed: "Lab",
  bark() {
    return "Bark";
  },
  job: "bomb",
};

/////
// Multiple Inheritance
interface Personn {
  name: string;
}
interface Employee {
  readonly id: number;
  email: string;
}
interface Engineer extends Personn, Employee {
  level: string;
  skills: string[];
}

const pierre: Engineer = {
  name: "Pierre",
  id: 122,
  email: "a@gmail.com",
  level: "senior",
  skills: ["python", "Javascript"],
};

/////
// Type Aliases vs Interfaces
/*
1. interfaces can only describe the shape of an object, unlike the type aliases:
type Color = "red" | "blue";

2. we can re-open and add on with interfaces

3. Interface is more oop (extends)

*/
