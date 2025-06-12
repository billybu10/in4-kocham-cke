using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace albumy2
{
    public partial class Form1 : Form
    {
        struct Album
        {
            public string author;
            public string name;
            public int songsNumber;
            public int year;
            public int downloadNumber;
            public int id;
        };

        List<Album> albums;

        private List<Album> getAlbumsFromFile(string filename)
        {
            List<Album> albums = new List<Album>();
            List<string> tempLines = new List<string>();
            tempLines = File.ReadAllLines(filename).ToList();


            Album tempAlbum = new Album();

            for (int i = 0; i < tempLines.Count(); i += 6)
            {
                tempAlbum.author = tempLines[i];
                tempAlbum.name = tempLines[i + 1];
                tempAlbum.songsNumber = Int32.Parse(tempLines[i + 2]);
                tempAlbum.year = Int32.Parse(tempLines[i + 3]);
                tempAlbum.downloadNumber = Int32.Parse(tempLines[i + 4]);
                tempAlbum.id = i;
                albums.Add(tempAlbum);
            }

            return albums;
        }

        public Form1()
        {
            InitializeComponent();
            string filename = "data.txt";
            albums = getAlbumsFromFile(filename);
            label1.Text = albums[0].author;
            label2.Text = "Liczba pobrań: " + albums[0].downloadNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arrLines = File.ReadAllLines("data.txt");
            arrLines[albums[0].id + 4] = Convert.ToString(albums[0].downloadNumber+1);
            File.WriteAllLines("data.txt", arrLines);
            albums = getAlbumsFromFile("data.txt");
            label2.Text = "Liczba pobrań: " + albums[0].downloadNumber;
        }
    }
}
