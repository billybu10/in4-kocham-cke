#include <iostream>
#include <vector>
#include <cstdlib>
#include <ctime>

class RandomArraySearch{
private:
    std::vector<int> array;
    int searchedValue;
    int count;
public:
    void fillArray(){
        srand(time(0));

        for (int i = 0; i < count; i++)
        {
            array.push_back(rand()%101);
        }
    }

    void showArrayAndFoundElement(){
        std::cout<<"Zawartość tablicy";
        for(int a : array){
            std::cout<<a<<", ";
        }

        int index = search();
        if (index == -1)
        {
            std::cout<<std::endl<<"Podana wartość nie ostała odnaleziona w tablicy";
        }else{
            std::cout<<std::endl<<"Indeks wyszukiwanego elementu: "<<index;
        }
    }

    int search(){
        int index;
        array.push_back(searchedValue);
        for (int i = 0; i < array.size(); i++)
        {
            if(array[i] == searchedValue){
                index = i;
                break;
            }
        }

        array.pop_back();

        if(index == count){
           return -1;
        }else{
            return index;
        }
        
        
    }

    RandomArraySearch(int count, int searchedValue){
        this->searchedValue  = searchedValue;
        this->count = count;
        array = std::vector<int>();
    }
};

int main(){
    int count, searchedValue;
    std::cout<<"Podaj ilość elementów w tablicy: ";
    std::cin >> count;
    std::cout<<std::endl;
    while (count < 50)
    {
        std::cout<<"Tablica musi posiadać minimum 50 elementów, podaj inną ilość elementów w tablicy: ";
        std::cin>>count;
        std::cout<<std::endl;
    }

    std::cout<<"Podaj wartość do wyszukania w tablicy: ";
    std::cin >> searchedValue;
    std::cout<<std::endl;
    while (searchedValue < 0)
    {
        std::cout<<"Tablica zawiera elementy mające wartość od 0 do 100, podaj inną wartość do wyszukania w tablicy: ";
        std::cin>>searchedValue;
        std::cout<<std::endl;
    }

    RandomArraySearch r = RandomArraySearch(count, searchedValue);
    r.fillArray();
    r.search();
    r.showArrayAndFoundElement();
}