// TUPLES
let myTuple: [number, string];
myTuple = [10, "String is the best"];
// myTuple = ["s", 10]; // Error

const color: [number, number, number] = [231, 110, 211];

type HTTPResponse = [number, string];
const goodRes: HTTPResponse = [200, "OK"];
const badRes: HTTPResponse = [404, "Not Found"];

// goodRes[0] = "200" //Error
goodRes.push("true"); //No Error (Weird)
goodRes.pop(); //No Error (Weird)
goodRes.pop(); //No Error (Weird)
goodRes.pop(); //No Error (Weird)

const responses: HTTPResponse[] = [
  [404, "Not Found"],
  [200, "OK"],
  [404, "Not Found"],
  [200, "OK"],
];

// ENUMS
enum OrderStatus {
  PENDING, //0
  SHIPPED, //1
  DELIVERED, //2
  RETURNED, //3
}

const myStatus = OrderStatus.DELIVERED;

function isDelivered(status: OrderStatus): boolean {
  return status === OrderStatus.DELIVERED;
}

isDelivered(OrderStatus.RETURNED);

enum OrderStatuses {
  PENDING = 10,
  SHIPPED, //11
  DELIVERED, //12
  RETURNED, //13
}

enum ArrowKeys {
  UP = "up",
  DOWN = "down",
  LEFT = "left",
  RIGHT = "right",
  Error = 404,
}
