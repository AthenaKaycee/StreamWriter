
AppendText();
static void WriteText() 
{
    //initialize 2 variables 1 for file path and 1 for peom
    string path = "C:\\Users\\Username\\Desktop\\poem.txt"; //include YOUR username
    string poem = "\r\n\tI never saw a man who looked";
    poem += "\r\n\tWith such a waistful eye"; //\r\n\t escape sequence for carriage return, new line and ta
    poem += "\r\n\tHELP ME";
}

static void AppendText()
{
    //initialize 3 variables, one for file path, one for poem, one for attrib
    string path = "C:\\User\\Username\\ Desktop\\oscar.txt";
    string[] poem = new string[]
    {
        "\tIn Debtors' Yard the stones are hard",
        "\tAND the dripping wall is high"
    };
    string attrib = "\r\n\tThe Ballad Of Reading Gaol";
    attrib += ("Oscar Wilde 1898");

    //add statement to test if a file already exists of the specified path and filename
    if (File.Exists(path)) 
    {
        //insert statement the attempt to append text if the file already exists, and advise of success
        File.AppendAllText(path, attrib);
        Console.WriteLine("Appended To File: " + path);
    }
    else 
    {
        //insert statment that attempt to write a text file and confirm success or advise failure
        try 
        {
            File.WriteAllLines(path, poem);
            Console.WriteLine("File Written: " + path);
        }
        catch (Exception error) 
        {
            Console.WriteLine(error.Message);
        }
    }
    Console.ReadLine();

}  