#include <iostream>

class Device
{
public:
    void printMessage(std::string message){
        std::cout<<message<<std::endl;
    }
};

class WashingMachine : public Device{
private:
	int programNumber = 0;
public:
	int setProgramNumber(int programNumber){
		if (programNumber > 0 && programNumber < 13)
		{
			this->programNumber = programNumber;
		}else{
			this->programNumber = 0;
		}
		
		return this->programNumber;
	}
};

class Vacuum : public Device{
private:
	bool state = false;
public:
	void on(){
		if (!state)
		{
			state = true;
			this->printMessage("Odkurzacz włączono");
		}
		
	}

	void off(){
		if (state)
		{
			state = false;
			this->printMessage("Odkurzacz wyłączono");
		}
		
	}
};

int main(){
	WashingMachine pralka = WashingMachine();
	int programNumber;
	std::cout<<"Podaj numer prania 1..12"<<std::endl;
	std::cin>>programNumber;
	int internalProgramNumber = pralka.setProgramNumber(programNumber);
	if (internalProgramNumber == 0)
	{
		pralka.printMessage("Podano niepoprawny numer programu");
	}else{
		pralka.printMessage("Program został ustawiony");
	}

	Vacuum odkurzacz = Vacuum();
	odkurzacz.on();
	odkurzacz.printMessage("Odkurzacz wyładował się");
	odkurzacz.off();
	
}

