/*
class Player {
  public readonly first: string;
  public readonly last: string;
  private score: number = 0;
  constructor(first: string, last: string) {
    this.first = first;
    this.last = last;
  }
  private secretMethod() {
    console.log("Secret");
  }
}

const elton = new Player("Elton", "Steele");
// elton.first = "John"; // Error
*/

/*
class Player {
  private score: number = 0;
  constructor(public first: string, public last: string) {}
  private secretMethod() {
    console.log("Secret");
  }
}
const elton = new Player("Elton", "Steele");
console.log(elton); //=> Player {first: 'Elton', last: 'Steele', score: 0}
*/

///// Getters & Setters
class Player {
  constructor(
    public first: string,
    public last: string,
    // private _score: number
    protected _score: number
  ) {}
  private secretMethod() {
    console.log("Secret");
  }
  get fullName(): string {
    return `${this.first} ${this.last}`;
  }
  get score(): number {
    return this._score;
  }

  set score(newScore: number) {
    if (newScore < 0) throw new Error("Score can not be negative");
    this._score = newScore;
  }
}

const elton = new Player("Elton", "Steele", 0);
console.log(elton.fullName); //=> Elton Steele
console.log(elton.score); //=> 0
elton.score = 99;
console.log(elton.score); //=> 99

class SuperPlayer extends Player {
  public isAdmin: boolean = true;
  maxScore() {
    this._score = 99999;
    // unlike the private, protected types are accessible in child classes.
  }
}

///// Classes & Interfaces
interface Colorful {
  color: string;
}
interface Printable {
  print(): void;
}
class Bike implements Colorful {
  constructor(public color: string) {}
}
class Jacket implements Colorful, Printable {
  constructor(public brand: string, public color: string) {}
  print() {
    console.log(`%{this.color} ${this.brand} jacket`);
  }
}
const bike1 = new Bike("red");
const jacket1 = new Jacket("Zara", "Brown");

///// Abstract Classes
abstract class Employee {
  constructor(public firstName: string, public lastName: string) {}
  abstract getPay(): number;
}

class FullTimeEmployee extends Employee {
  constructor(firstName: string, lastName: string, private salary: number) {
    super(firstName, lastName);
  }
  getPay(): number {
    return this.salary;
  }
}
class PartTimeEmployee extends Employee {
  constructor(
    firstName: string,
    lastName: string,
    private hourlyRate: number,
    private hoursWorked: number
  ) {
    super(firstName, lastName);
  }

  getPay(): number {
    return this.hourlyRate * this.hoursWorked;
  }
}

const betty = new FullTimeEmployee("Betty", "White", 95000);
console.log(betty.getPay()); //=> 95000

const bill = new PartTimeEmployee("Bill", "Billerson", 24, 1100);
console.log(bill.getPay()); //=> 26400
