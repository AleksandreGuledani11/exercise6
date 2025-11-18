def add(x, y):          return x + y
def subtract(x, y):     return x - y
def multiply(x, y):     return x * y
def divide(x, y):       return x // y
def mod(x, y):          return x % y

def and_func(x, y):     return x and y
def or_func(x, y):      return x or y
def not_func(x):        return not x

def greater_than(x, y): return x > y
def less_equal(x, y):   return x <= y
def equal(x, y):        return x == y

a, b, c, d, e, f = 5, 3, 7, 4, 2, 10
x, y, z, is_admin = True, False, True, False

# Expression 1
actual1 = or_func(
    and_func(
        greater_than(
            add(a, multiply(b, c)),
            subtract(d, e)
        ),
        x
    ),
    y
)

# (a - b) * (c + d) <= e and z and not x
actual2 = and_func(
    and_func(
        less_equal(
            multiply(
                subtract(a, b), add(a,b)
            ), 
            e
        ),z
    ),
    not_func(x)
)

 #(a + b + c) % d == 0 or (f > e and is_admin)
actual3 = or_func(
    equal(
        mod(
            add(
                add(a, b),
                c
            ),
            d
        ),
        0
    ),
    and_func(
        greater_than(f, e),
        is_admin
    )
)

#  not (x or y) and (a * a > b * c)
actual4 = and_func(
    not_func(
        or_func(x, y)
    ),
    greater_than(
        multiply(a, a),
        multiply(b,c)
    )
)

print(actual1)
print(actual2)
print(actual3)
print(actual4)