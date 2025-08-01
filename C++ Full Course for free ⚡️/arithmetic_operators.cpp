#include <iostream>

int main(){
    double a = 10, b = 3;
    a+=2; a++; a/=2;
    b+=2; b--; b*=2;

    std::cout << "a = " << a << "\n";
    std::cout << "b = " << b << "\n\n";

    double addition = a+b, subtraction = a-b,
           multiplication = a*b, division = a/b;

    std::cout << "a+b=" << addition << "\n"
    << "a-b=" << subtraction << "\n"
    << "a*b=" << multiplication << "\n"
    << "a/b=" << division;
    return 0;
}