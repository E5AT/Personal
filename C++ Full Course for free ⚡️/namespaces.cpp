#include <iostream>

namespace Nietzsche{
    std::string name = "Nietzsche";

    std::string bornMonthAndDay = "October 15";
    int bornYear = 1844;
    std::string bornPlace = "Röcken, Saxony, Prussia";

    std::string diedMonthAndDay = "August 25";
    int diedYear = 1900;
    std::string diedPlace = "Weimar, Germany";
}

int main(){
    using namespace Nietzsche;

    std::cout << name << " was born on " << bornMonthAndDay << ", " << bornYear << ", in " << bornPlace << ".\n";

    std::cout << "He died on " << diedMonthAndDay << ", " << diedYear << ", in " << diedPlace << ".";
    return 0;
}