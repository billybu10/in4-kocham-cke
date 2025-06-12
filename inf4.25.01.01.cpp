#include <iostream>
#include <ctime>
#include <cstdlib>

class ArrayOperations{
private:
	int* array;
	int arraySize;
public:
	ArrayOperations(int arraySize){
		this->arraySize = arraySize;
		array = new int[arraySize]; 
		srand(time(0));

		for (int i = 0; i < arraySize; i++)
		{
			array[i] = (rand() % 1000) + 1;
		}
	}

	void printArray(){
		for (int i = 0; i < arraySize; i++)
		{
			std::cout<< i << " : " <<  array[i] <<std::endl;
		}
	}

	int findValue(int value){
		int index = -1;
		for (int i = 0; i < arraySize; i++)
		{
			if (array[i] == value)
			{
				index = i;
				break;
			}
			
		}

		return index;
	}

	int printAndCountOdds(){
		int odds = 0;

		std::cout<<"Liczby nieparzyste: "<<std::endl;
		for (int i = 0; i < arraySize; i++)
		{
			if (array[i] % 2 == 1)
			{
				std::cout<<array[i]<<std::endl;
				odds++;
			}
		}

		return odds;
	}

	double countAverage(){
		int sum = 0;
		for (int i = 0; i < arraySize; i++)
		{
			sum += array[i];
		}
		return sum/arraySize;
	}

};

int main(){
	ArrayOperations a = ArrayOperations(50);
	a.printArray();
	int foundIndex = a.findValue(500);
	if (foundIndex != -1)
	{
		std::cout<<"Wartość 500 odnaleziona na indeksie "<<foundIndex<<std::endl;
	}
	
	int oddsNumber = a.printAndCountOdds();
	std::cout<<"Razem nieparzystych: " << oddsNumber << std::endl;
	double average = a.countAverage();
	std::cout<<"Średnia arytmetyczna: " << average << std::endl;

}