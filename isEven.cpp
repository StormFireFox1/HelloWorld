#include <iostream>

/* "Even number check"
 *
 * C++ was the second programming language I ever learned, and I did because I wanted to study Object-Oriented Programming.
 * God, I was stupid back then.
 * 
 * Frankly, I'll admit: I picked this language back then to study next because I was too much of a wuss to try any other one.
 * I thought it would be similar to C and not be a completely different language to spook me out. I was not wrong, but not
 * right either.
 * 
 * Templates are hell to try to write, and this program will completely avoid them. But the classes are a nice touch to C that
 * I really like. Plus, C++ was actually the language I used for schoolwork, not C. So I guess C++ brings me the bad memories.
 * 
 * This algorithm just checks for an even number from standard input. Simple enough.
 */

bool isEven(long long int x)
{
    if (x % 2 == 0) 
    {
        return true;
    } else {
        return false;
    }
}

int main()
{
    long long int x;
    std::cout << "Gimme an even number: ";
    std::cin >> x;
    if (isEven(x))
    {
        std::cout << "That's an even number! Well done!";
    } else {
        std::cout << "You donut, that isn't even. What are you doing with your life?";
    }
    return 0;
}