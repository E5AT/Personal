#include <iostream>
int main(){
    std::string name, address;
    int age;

    std::cout << "Ur name: ";
    std::cin >> name;

    std::cout << "Ur age: ";
    std::cin >> age;

    std::cout << "Ur address: ";
    std::getline(std::cin >> std::ws, address);
    
    std::cout << "\nHi " << name << ",\n"
    << "ur " << age << " years old\n"
    << "and live in " << address << ".\n"
    << "Right?\n";
    return 0;
}