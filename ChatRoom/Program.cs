using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ChatRoom
{
    internal class Program
    {
        private readonly Dictionary<string, List<string>> chatroom = null;
        public bool flag;
        string name = null;
        public Program()
        {
            chatroom = new Dictionary<string, List<string>>();
        }
        public void Join()
        {
            WriteLine("Enter The Chat Room Name");
             name = ReadLine();
            if (!chatroom.ContainsKey(name))
            {
                chatroom[name] = new List<string>();
                WriteLine($"ChatRoom Created,You Need To Enter The ChatRoom : {name}");
                flag = true;
            }
            else
            {
                WriteLine($"ChatRoom Already Exist,You Need To Enter The ChatRoom : {name}");
               
            }
        }
        public void Send()
        {
            if (flag == true)
            {
                WriteLine("Enter The Message");
                chatroom[name].Add(ReadLine());
            }
            else
            {
                WriteLine("Join a ChatRoom First");
            }
        }
        public void Display()
        {
            if(flag == true)
            {
               foreach(string s in chatroom[name])
                {
                    WriteLine(s);
                }
            }
            else
            {
                WriteLine("Join a ChatRoom First");
            }
        }
        static void Main(string[] args)
        {
            bool loop = true;
            Program p = new Program();
            p.flag = false;
            while (loop) { 
            WriteLine("Enter 1 to Join,2 to Send Message,3 to Display and 4 to Exit");
            int input = Convert.ToInt32(ReadLine());
            if (input == 1)
                p.Join();
            else if (input == 2)
            {
                p.Send();
            }
            else if (input == 3)
                p.Display();
            else
            {
                p.flag = false;
                loop = false;
            }
        }
        }


    }
}
