#include<iostream>
#include <array>
#include <cstdlib>
#include <ctime>

void bubbleSort(std::array<int, 100>& array){
    int temp;
    for (int i = 99; i > 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
           if (array[j]>array[j+1])
           {
                temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
           }
           
        }
        
    }
    
}

int main(){
    std::array<int, 100> array;

    srand(time(0));

    std::cout<<"Tablica do posortowania";

    for (int i = 0; i < 100; i++)
    {
        array[i] = rand();
        std::cout<<array[i]<<", ";
    }
    
    bubbleSort(array);

    std::cout<<std::endl<<"Posortowana tablica: ";
    for (int i = 0; i < 100; i++)
    {
        std::cout<<array[i]<<", ";
    }
}