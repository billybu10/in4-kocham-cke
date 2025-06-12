#include <iostream>
#include <array>

class SelectionSort{
private:
    std::array<int, 10> array;

    int getMaxIndex(int startIndex){
        int max = array[startIndex];
        int maxIndex = startIndex;
        for(int i = startIndex+1; i < array.size(); i++){
            if(array[i] > max){
                max = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

public:
    std::array<int, 10> getArray(){
        return array;
    }

    void setArray(std::array<int, 10> a){
        this->array = a;
    }

    void getNumbersFromUser(){
        std::cout<<"Podaj liczby do posortowania :"<<std::endl;
        for(int i = 0; i < array.size(); i++){
            std::cout<<"Podaj "<<i+1<<". liczbę: ";
            std::cin>>array[i];
        }
    } 

    void sortDescending(){
        int temp;
        int maxIndex;
        for(int i = 0; i < array.size(); i++){
            maxIndex = this->getMaxIndex(i);
            temp = array[i];
            array[i] = array[maxIndex];
            array[maxIndex] = temp;
        }
    } 

    void showNumbersToUser(){
        for(int i = 0; i < array.size(); i++){
            std::cout<<i+1<<". liczba: "<<array[i]<<std::endl;
        }
    }

    SelectionSort (std::array<int, 10> a){
        this->array = a;
    }

    SelectionSort (){
        this->array = std::array<int, 10>();
    }

};

int main(){
    SelectionSort s = SelectionSort();
    s.getNumbersFromUser();
    s.sortDescending();
    std::cout<<"Posortowane liczby :"<<std::endl;
    s.showNumbersToUser();
}