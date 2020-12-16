﻿using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        public static string username;
        public static string filename;
        public static string blogcontent;
        public static string blogtitle;
        public static DateTime datepublished = DateTime.Now;
    

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User! This is a Program that creates a Html blogpost");
            Console.Write("Enter your name: ");
            username = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your chosen File Name: ");
            filename = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Blog Title");
            blogtitle = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your Blog Content here: ");
            blogcontent = Convert.ToString(Console.ReadLine());
            
            
            var path = "C:\\New cshrp\\"+filename+".html";
            LowLevelWrite(path);
            Console.ReadLine();
            
            
        }


        static void LowLevelWrite(string path)
        {

            using (StreamWriter str = new StreamWriter(path))
            {
               str.WriteLine("<!DOCTYPE html>");
               str.WriteLine("<html lang='en'>");
               str.WriteLine("<head>");
               str.WriteLine("<meta charset='UTF - 8'>");
               str.WriteLine("<meta name='viewport' content='width = device - width, initial - scale = 1.0'>");
               str.WriteLine($"<title> {blogtitle} </title>");
               str.WriteLine("</head>");
               str.WriteLine("<body>");
               str.WriteLine($"   <h1>{blogtitle}</h1>");
               str.WriteLine($"<h5 style='background-color:black; color:white;'>{username} / {datepublished}</h5>");
               str.WriteLine($"<p style:>{blogcontent}</p>");
               str.WriteLine("</body>");
               str.WriteLine("</html>");


            }
            
        }
    }
}
