"use strict";
class Player {
    constructor(first, last) {
        this.score = 0;
        this.first = first;
        this.last = last;
    }
    secretMethod() {
        console.log("Secret");
    }
}
const elton = new Player("Elton", "Steele");
// elton.first = "John"; // Error
