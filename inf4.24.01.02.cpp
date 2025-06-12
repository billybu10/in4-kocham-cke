#include <iostream>
#include <string_view>
#include <string>

class WordUtilities
{
private:
	static constexpr std::string_view vowelsWithOneCodePoint = "aeiouyAEIOUY";
	static constexpr std::string_view vowelsWithTwoCodePoints = "ąęóÓĄĘ";

public:
	static int countVowels(std::string inputString)
	{
		int tempVowelCount = 0;
		if (inputString.length() == 0 || inputString.empty())
		{
			return 0;
		}
		else
		{
			for (int i = 1; i < inputString.length(); i++)
			{
				for (int j = 1; j < vowelsWithTwoCodePoints.length(); j += 2)
				{
					if (inputString[i] == vowelsWithTwoCodePoints[j] && inputString[i - 1] == vowelsWithTwoCodePoints[j - 1])
					{
						tempVowelCount++;
					}
				}
			}

			for (char vowel : vowelsWithOneCodePoint)
			{
				for (char letter : inputString)
				{
					if (letter == vowel)
					{
						tempVowelCount++;
					}
				}
			}
			return tempVowelCount;
		}
	}

	static std::string removeImmediateRepetitions(std::string inputString)
	{
		std::string outputString = "";

		for (int i = 0; i < inputString.length() - 1; i++)
		{
			if ((int)inputString[i] < 0)
			{
				if (inputString[i + 2] != inputString[i])
				{
					outputString += inputString[i];
				}
			}
			else if (inputString[i + 1] != inputString[i])
			{
				outputString += inputString[i];
			}
		}
		outputString += inputString[inputString.length() - 1];

		return outputString;
	}
};

int main()
{
	std::string userProvidedText;
	std::cout << "Podaj tekst: ";
	std::cin >> userProvidedText;
	std::cout << std::endl
			  << "Liczba samogłosek w tekście: " << WordUtilities::countVowels(userProvidedText);
	std::cout << std::endl
			  << "Tekst bez bezpośrednich powtórzeń: " << WordUtilities::removeImmediateRepetitions(userProvidedText);
}
