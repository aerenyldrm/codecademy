using System;

class Program
{
    public static void Main()
    {
        FieldAgent agent1 = new()
        {
            Name = "Agent Smith",
            SecretCode = 007
        };

        FieldAgent agent2 = agent1;
        agent2.SecretCode = 999;
        Console.WriteLine(agent1.SecretCode);
        Console.WriteLine(agent2.SecretCode);

        File file1 = new()
        {
            FileName = "Confidential.txt",
            FileSize = 1024
        };

        File file2 = new()
        {
            FileName = "Confidential.txt",
            FileSize = 1024
        };

        bool sameFile = file1 == file2;
        Console.WriteLine(sameFile);

        Server mainServer = new();
        Server backupServer = new();
        mainServer.Status = "Active";
        backupServer.Status = "Inactive";
        ISystem[] systems = [mainServer, backupServer];

        foreach (ISystem system in systems)
            system.Operate();
    }
}