#include <iostream>
#include <fstream>
#include <string>
#include <vector>

using namespace std;

struct Album{
	string author;
	string name;
	int songsNumber;
	int year;
	int downloadNumber;
};

vector<Album> getAlbumsFromFile(string filename){
	fstream file = fstream(filename);
	vector<Album> albums = vector<Album>();
	vector<string> tempLines = vector<string>();
	if (file.is_open())
	{
		tempLines.push_back("");
		for (int i = 0; getline(file, tempLines[i] ); i++)
		{
			tempLines.push_back("");
		}

		Album tempAlbum;

		for (int i = 0; i < tempLines.size(); i+=6)
		{
			tempAlbum.author = tempLines[i];
			tempAlbum.name = tempLines[i+1];
			tempAlbum.songsNumber = stoi(tempLines[i+2]);
			tempAlbum.year = stoi(tempLines[i+3]);
			tempAlbum.downloadNumber = stoi(tempLines[i+4]);
			albums.push_back(tempAlbum);
		}
		
		
	}
	
	return albums;
}

int main(){
	vector<Album> albums = getAlbumsFromFile("Data.txt");
	for (Album album  : albums)
	{
		cout<<album.author<<endl<<album.name<<endl<<album.songsNumber<<endl<<album.year<<endl<<album.downloadNumber<<endl<<endl;
	}
	
}