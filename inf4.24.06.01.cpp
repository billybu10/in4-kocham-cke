#include <iostream>
#include <vector>
#include <array>
#include <ctime>
#include <cstdlib>

std::vector<int> throwDices(int count){
    std::vector<int> outputVector = std::vector<int>();
    srand(time(0));
    for (size_t i = 0; i < count; i++)
    {
        outputVector.push_back((rand()%6) + 1);
    }
    return outputVector;
}

int countPoints(std::vector<int> rolledDicesValues){
    int points = 0;
    std::array<int, 6> amountEachNumberWasRolled = {0, 0, 0, 0, 0, 0};

    for(int value : rolledDicesValues){
        amountEachNumberWasRolled[value-1]++;
    }

    for (int i = 0; i < amountEachNumberWasRolled.size(); i++)
    {
        if(amountEachNumberWasRolled[i] > 1){
            points += amountEachNumberWasRolled[i]*(i+1);
        }
    }
    
    return points;
}

int main(){
    std::string userContinue;
    std::vector<int> diceValues;
    int amount;
    do{
        std::cout<<"Ile kostek chcesz rzucić?( 3 - 10 )"<<std::endl;
        std::cin>>amount;
    } while (amount < 3 || amount > 10);

    do
    {
        
        
        diceValues = throwDices(amount);

        for (int i = 0; i < diceValues.size(); i++)
        {
            std::cout<<"Kostka "<<i+1<<":"<<diceValues[i]<<std::endl;
        }

        std::cout<<"Liczba uzyskanych punktów: "<< countPoints(diceValues)<<std::endl;
        
        
        std::cout<<"Jeszcze raz? (t/n)";
        std::cin>>userContinue;
    } while (userContinue == "t");
    
}