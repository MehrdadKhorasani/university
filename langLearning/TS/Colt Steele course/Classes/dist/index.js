"use strict";
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
    constructor(first, last, 
    // private _score: number
    _score) {
        this.first = first;
        this.last = last;
        this._score = _score;
    }
    secretMethod() {
        console.log("Secret");
    }
    get fullName() {
        return `${this.first} ${this.last}`;
    }
    get score() {
        return this._score;
    }
    set score(newScore) {
        if (newScore < 0)
            throw new Error("Score can not be negative");
        this._score = newScore;
    }
}
const elton = new Player("Elton", "Steele", 0);
console.log(elton.fullName); //=> Elton Steele
console.log(elton.score); //=> 0
elton.score = 99;
console.log(elton.score); //=> 99
class SuperPlayer extends Player {
    constructor() {
        super(...arguments);
        this.isAdmin = true;
    }
    maxScore() {
        this._score = 99999;
        // unlike the private, protected types are accessible in child classes.
    }
}
class Bike {
    constructor(color) {
        this.color = color;
    }
}
class Jacket {
    constructor(brand, color) {
        this.brand = brand;
        this.color = color;
    }
    print() {
        console.log(`%{this.color} ${this.brand} jacket`);
    }
}
const bike1 = new Bike("red");
const jacket1 = new Jacket("Zara", "Brown");
///// Abstract Classes
class Employee {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
class FullTimeEmployee extends Employee {
    constructor(firstName, lastName, salary) {
        super(firstName, lastName);
        this.salary = salary;
    }
    getPay() {
        return this.salary;
    }
}
class PartTimeEmployee extends Employee {
    constructor(firstName, lastName, hourlyRate, hoursWorked) {
        super(firstName, lastName);
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }
    getPay() {
        return this.hourlyRate * this.hoursWorked;
    }
}
const betty = new FullTimeEmployee("Betty", "White", 95000);
console.log(betty.getPay()); //=> 95000
const bill = new PartTimeEmployee("Bill", "Billerson", 24, 1100);
console.log(bill.getPay()); //=> 26400
