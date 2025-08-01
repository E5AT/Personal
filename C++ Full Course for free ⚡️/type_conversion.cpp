#include <iostream>
int main(){
    int pi = 3.14;          // implicit 3.14 ==> 3
    double PI = (int) 3.14; // explicit 3.14 ==> 3

    int correct = 8, questions = 10;
    int score = (double)correct/ /*(double)*/ questions * 100;

    std::cout << "Score: " << score << "%";
    return 0;
}