interface Person {
  name: string;
  age: number;
}
 
function greet(person: Person) {
  return "Hello " + person.name;
}

const person: Person = { name: "Alice", age: 25 };
console.log(greet(person));
