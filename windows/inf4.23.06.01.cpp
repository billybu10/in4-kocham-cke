#include <iostream>
#include <array>
#include <cmath>
 
using namespace std;
 
void fillArray(array<bool, 101>* arr){
	for(int i = 0; i < arr->size(); i++){
	    (*arr )[i] = true;
	}
}


 void eratostenes(array<bool, 101>* arr){
	for (int i = 2; i < sqrt(arr->size()); i++)
	{
		if((*arr)[i]){
			for (int j = 2; j*i < arr->size(); j++)
			{
				(*arr)[j*i] = false;
			}
			
		}
	}
	
 }
 
 
int main() {
  array<bool, 101> arr = array<bool, 101>();
  fillArray(&arr);
  eratostenes(&arr);

  for (int i = 2; i < arr.size(); i++)
  {
	if (arr[i])
	{
		cout<<i<<endl;
	}
	
  }
  
 
  return 0;
}