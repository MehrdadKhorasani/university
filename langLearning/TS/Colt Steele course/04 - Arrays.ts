//
const activeUsers: string[] = [];
activeUsers.push("steven");
let numberArr: number[] = [2, 6, 8];
let isValidArr: boolean[] = [true, false];

//
const bools: Array<boolean> = [true, false];
let numsArr: Array<number> = [2, 6, 8];

type Point = {
  x: number;
  y: number;
};

const coords: Point[] = [];
coords.push({ x: 5, y: 3 });
// coords.push({ x: 7 }); //Error
const coords2: Array<Point> = [{ x: 10, y: 4 }];

//
const board: string[][] = [
  ["X", "O", "X"],
  ["X", "O", "X"],
  ["X", "O", "X"],
];

const demo: number[][][] = [[[1]]];

/////
// Exercise:
const ages: number[] = [];
const gameBoard: string[][] = [];

type Product = {
  name: string;
  price: number;
};

const coffeeMug: Product[] = [{ name: "Coffee Mug", price: 11.5 }];

function getTotal(products: Array<Product>): number {
  let total = 0;
  for (let product of products) {
    total += product.price;
  }
  return total;
}
