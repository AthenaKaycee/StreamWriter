static void ReadText() 
{
    //create variable for path and insert path
    string path = "C:\\User\\Username\\Desktop\\word.txt";
    //add statement to test if file alread exists of specified npath and filename
    if (File.Exists(path))
    {
        //inser statement to display message if file can not be read successfully 
        try
        {
            Console.WriteLine("File Read: " + path + "\n");
        }
        catch(Exception error)
        {
            Console.WriteLine(error.Message);
        }

    }
    else 
    {
    
    }
}