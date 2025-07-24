#1-vazifa

class Program{
    static void Main(){
        Console.Write("Iltimos, bitta harf kiriting: ");
        char harf = Console.ReadKey().KeyChar; 
        Console.WriteLine(); 
        bool isUpper = (harf >= 'A' && harf <= 'Z');
        Console.WriteLine(isUpper ? "Ha" : "Yo'q");
    }
}

#2-vazifa

class Program{
    static void Main(){
        Console.Write("Dasturlash yoqadimi? (H/Y): ");
        char javob = Console.ReadKey().KeyChar; 
        Console.WriteLine(); 
        bool likely = (char.ToLower(javob) == 'h');
        Console.WriteLine(likely? "Ajoyib!" : "Afsus!");
    }
}

#3-vazifa

class Program{
    static void Main(){
        Console.Write("Ismingizni kiriting: ");
        string ism = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(ism)){
            char first = ism[0]; 
            Console.WriteLine("Birinchi harf: " + first);
        }
        else{
            Console.WriteLine("Iltimos, ism kiriting!");
        }
    }
}




