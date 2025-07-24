        string asc = "1 2 3 4 5 6 7 8";
        string des = "8 7 6 5 4 3 2 1";

        string input = Console.ReadLine();

        if (input.Equals(asc))
            Console.WriteLine("ascending");
        else if (input.Equals(des))
            Console.WriteLine("descending");
        else
            Console.WriteLine("mixed");