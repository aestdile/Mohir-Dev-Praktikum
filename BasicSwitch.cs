#1-vazifa

class Program{
    static void Main(){
        Console.Write("Buyruq kiriting (yur, tushun, sakra, o'giril): ");
        string command = Console.ReadLine().ToLower();

        bool isValid = true;
        string action = "";

        switch (command){
            case "yur":
                action = "Robot oldinga yurmoqda.";
                break;
            case "tushun":
                action = "Robot tushunmoqda.";
                break;
            case "sakra":
                action = "Robot baland sakramoqda.";
                break;
            case "o'giril":
                action = "Robot orqaga o'girildi.";
                break;
            default:
                isValid = false;
                break;
        }

        string message = isValid ? action : "Noma'lum buyruq kiritildi!";
        Console.WriteLine(message);
    }
}

#2-vazifa

class Program{
    static void Main(){
        Console.Write("Mahsulot nomini kiriting (olma, banan, anor, gilos): ");
        string mahsulot = Console.ReadLine().ToLower();

        switch (mahsulot){
            case "olma":
                Console.WriteLine("Narxi: 5000 so'm");
                break;

            case "banan":
                Console.WriteLine("Narxi: 12000 so'm");
                break;

            case "anor":
                Console.WriteLine("Narxi: 8000 so'm");
                break;

            case "gilos":
                Console.WriteLine("Narxi: 10000 so'm");
                break;

            default:
                Console.WriteLine("Kechirasiz, bu mahsulot yo'q");
                break;
        }
    }
}

#3-vazifa

class Program{
    static void Main(){
        string oldColor = ""; 
        for (int i = 0; i < 3; i++){
            Console.Write("Rang kiriting (qizil, sariq, yashil): ");
            string color = Console.ReadLine().ToLower();
            string message = (color == "qizil") ? "To'xtang!" :
                             (color == "sariq") ? "Tayyorgarlik ko'ring!" :
                             (color == "yashil") ? "Yuring!" : "Noma'lum rang!";

            if (oldColor == "yashil" && color == "yashil")
            {
                message = "Tez yurmayman!";
            }
            Console.WriteLine(message);
            oldColor = color;
        }
    }
}




