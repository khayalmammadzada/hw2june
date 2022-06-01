using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("XeyalM");
            user1.Password = "Xeyal123";

            Console.WriteLine($"Istifadecinin adi:" + user1.UserName);
            Console.WriteLine($"Istifadecinin shifresi:" + user1.Password);
            
        }
        
  
    }


}


