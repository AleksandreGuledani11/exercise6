using System;

class Program
{
    static int Add(int x, int y)          => x + y;
    static int Subtract(int x, int y)     => x - y;
    static int Multiply(int x, int y)     => x * y;
    static int Divide(int x, int y)       => x / y;
    static int Mod(int x, int y)          => x % y;

    static bool AndFunc(bool x, bool y)   => x && y;
    static bool OrFunc(bool x, bool y)    => x || y;
    static bool NotFunc(bool x)           => !x;

    static bool GreaterThan(int x, int y) => x > y;
    static bool LessEqual(int x, int y)   => x <= y;
    static bool Equal(int x, int y)       => x == y;

    static void Main()
    {
        int a = 5, b = 3, c = 7, d = 4, e = 2, f = 10;
        bool x = true, y = false, z = true, isAdmin = false;

        // Expression 1
        bool expr1 =
            OrFunc(
                AndFunc(
                    GreaterThan(
                        Add(a, Multiply(b, c)),
                        Subtract(d, e)
                    ),
                    x
                ),
                y
            );

        // Expression 2
        bool expr2 =
            AndFunc(
                AndFunc(
                    LessEqual(
                        Multiply(
                            Subtract(a, b),
                            Add(c, d)
                        ),
                        e
                    ),
                    z
                ),
                NotFunc(x)
            );

        // Expression 3
        bool expr3 =
            OrFunc(
                Equal(
                    Mod(
                        Add(
                            Add(a, b),
                            c
                        ),
                        d
                    ),
                    0
                ),
                AndFunc(
                    GreaterThan(f, e),
                    isAdmin
                )
            );

        // Expression 4
        bool expr4 =
            AndFunc(
                NotFunc(
                    OrFunc(x, y)
                ),
                GreaterThan(
                    Multiply(a, a),
                    Multiply(b, c)
                )
            );

        Console.WriteLine(expr1);
        Console.WriteLine(expr2);
        Console.WriteLine(expr3);
        Console.WriteLine(expr4);
    }
}
