using Data;
using File = Data.File;

File exemple = new File()
{
    Name = "Note",
    Extantion = "txt",
    Size = 1233,
    Creation = DateTime.Parse("05.09.2010")
};

Console.WriteLine(exemple.FileSize());

File[] files = new File[]
{
    new File("List","txt",234,DateTime.Parse("12.03.2007")),
    new File("Photo","jpeg",2342334,DateTime.Parse("30.12.2020")),
    new File("Listuaua","txt",23445554,DateTime.Parse("23.03.2021")),
    new File("Start","exe",236704,DateTime.Parse("23.09.2022")),
    new File("boot","ini",4334,DateTime.Parse("23.09.2022")),
    new File("FullListua","txt",9845623224,DateTime.Parse("12.03.2007")),
    new File("Test","exe",1234,DateTime.Parse("12.03.2007"))
};
for (int i = 0; i < files.Length; i++)
{
    files[i].Print();
}

Console.WriteLine("*************************************************");

for (int i = 0; i < files.Length; i++)
{
    if (files[i].Extantion == "txt") files[i].Print();
}

Console.WriteLine("*************************************************");

for (int i = 0; i < files.Length; i++)
{
    for (int j = 0; j < files[i].Name.Length; j++)
    {
        if (files[i].Name[j] == 'u' && files[i].Name[j + 1] == 'a')
        {
            files[i].Print();
            break;
        }
    }
}

Console.WriteLine("*************************************************");

for(int i = 0; i < files.Length; i++)
{
    if(files[i].Creation < DateTime.Parse("17.09.2022")) files[i].Print();
}