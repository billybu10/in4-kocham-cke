#include <iostream>
using namespace std;
 
int euclides(unsigned int a, unsigned int b){
	while(a != b){
		
    	if(a > b){
			a = a-b;
        }else{
        	b = b-a;
        }
    }
    return a;
}
 
int main() {
  unsigned int a, b;
  cin>>a;
  cin>> b;
  cout<<a<<" "<<b<<endl;
  cout << euclides(a,b);
  return 0;
}