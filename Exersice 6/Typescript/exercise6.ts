function add(x: number, y: number): number          { return x + y; }
function subtract(x: number, y: number): number     { return x - y; }
function multiply(x: number, y: number): number     { return x * y; }
function divide(x: number, y: number): number       { return Math.trunc(x / y); }
function mod(x: number, y: number): number          { return x % y; }

function andFunc(x: boolean, y: boolean): boolean   { return x && y; }
function orFunc(x: boolean, y: boolean): boolean    { return x || y; }
function notFunc(x: boolean): boolean               { return !x; }

function greaterThan(x: number, y: number): boolean { return x > y; }
function lessEqual(x: number, y: number): boolean   { return x <= y; }
function equal(x: number, y: number): boolean       { return x === y; }

const a = 5, b = 3, c = 7, d = 4, e = 2, f = 10;
const x = true, y = false, z = true, isAdmin = false;

// Expression 1
const expr1 = orFunc(
    andFunc(
        greaterThan(add(a, multiply(b, c)), subtract(d, e)),
        x
    ),
    y
);

// Expression 2
const expr2 = andFunc(
    andFunc(
        lessEqual(multiply(subtract(a, b), add(c, d)), e),
        z
    ),
    notFunc(x)
);

// Expression 3
const expr3 = orFunc(
    equal(mod(add(add(a, b), c), d), 0),
    andFunc(greaterThan(f, e), isAdmin)
);

// Expression 4
const expr4 = andFunc(
    notFunc(orFunc(x, y)),
    greaterThan(multiply(a, a), multiply(b, c))
);

console.log(expr1);
console.log(expr2);
console.log(expr3);
console.log(expr4);
