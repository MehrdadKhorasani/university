const totalNumber = 1000;

function generateRandomNumbers(num) {
  let arr = [];
  for (let x = 0; x < num; x++) {
    const randomNumber = Math.floor(Math.random() * 100) + 1;
    arr.push(randomNumber);
  }
  return arr;
}

const array = generateRandomNumbers(totalNumber);

console.log("array before bubble sorting:");
console.log(array);

function bubbleSort(array) {
  for (let x = 0; x < array.length; x++) {
    for (let y = 0; y < array.length; y++) {
      if (array[y] > array[y + 1]) {
        let temp = array[y];
        array[y] = array[y + 1];
        array[y + 1] = temp;
      }
    }
  }
  return array;
}

const sortedArray = bubbleSort(array);
console.log("array after bubble sorting:");
console.log(sortedArray);
