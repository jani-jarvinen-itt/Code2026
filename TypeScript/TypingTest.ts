function myFunc(a: { name: string; age: number }) {
    console.log(a.name);
    console.log(a.age);
}

myFunc({ name: "Alice", age: 30 });
