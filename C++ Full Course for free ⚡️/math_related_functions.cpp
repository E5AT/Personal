#include <iostream>
#include <cmath>
int main(){
    double a = 3.14;
    int b = 4;

    std::cout << "a = " << a << ", b = " << b << "\n\n";
    std::cout << "max = " << std::max(a,(double)b)
    << "\nmin = " << std::min(a,(double)b)
    << "\nb in pow 2 = " << pow(b,2)
    << "\nsqrt of b = " << sqrt(b)
    << "\nabs of -a = " << abs(-a)
    << "\na rounded = " << round(a)
    << "\nceiling of a = " << ceil(a)
    << "\nfloor of a = " << floor(a);
    return 0;
}