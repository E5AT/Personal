#include <iostream>

int main(){

    const double PI = 3.14159;
    double radius = 5.0;
    std::cout << "Hi, today we are gonna calculate the area of a circle!" << "\n"
    << "We got these variables:" << "\n"
    << "PI: " << PI << "," << "\n"
    << "Radius: " << radius << " cm." << "\n\n";

    double area = PI * (radius*radius);
    std::cout << "And when we calculate the area of this circle it appears to be: "
    << area << " cm2.";
    return 0;
}