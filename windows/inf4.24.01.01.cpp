#include <iostream>
#include <string>
#include <cstdlib>

using namespace std;

int getNumberFromChar(char a){
	return a - '0';
}

char getGender(string pesel){
	if (getNumberFromChar(pesel[9]) % 2 == 0)
	{
		return 'K';
	}else{
		return 'M';
	}
	
}

bool checkPesel(string pesel){
	int sum = 0;
	sum += getNumberFromChar(pesel[0])*1;
	sum += getNumberFromChar(pesel[1])*3;
	sum += getNumberFromChar(pesel[2])*7;
	sum += getNumberFromChar(pesel[3])*9;
	sum += getNumberFromChar(pesel[4])*1;
	sum += getNumberFromChar(pesel[5])*3;
	sum += getNumberFromChar(pesel[6])*7;
	sum += getNumberFromChar(pesel[7])*9;
	sum += getNumberFromChar(pesel[8])*1;
	sum += getNumberFromChar(pesel[9])*3;

	int m = sum % 10;

	int r;
	if (m == 0)
	{
		r = 0;
	}else{
		r = 10 - m;
	}

	return r == getNumberFromChar(pesel[10]);
	
}

int main(){
	string userPesel;
	cin>>userPesel;
	cout<<"Płeć : "<<getGender(userPesel)<<endl;
	cout<<"Pesel jest poprawny? "<<(checkPesel(userPesel) == 1 ? "tak" :  "nie")<<endl;

}