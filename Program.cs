using System;
using System.Collections.Generic;
using System .IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writecsvfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //addRecord("124", "mercy", "56", "cake.txt");
            Console.WriteLine(string.Join("", readRecord("124", "cake.txt", 1)));
        }
        public static void addRecord(string ID,string name,string age,string filepath)
        {
            try
            {
                using(System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath,true))
                {
                    file.WriteLine(ID + "," + name + "," + age);
                }
           
            }
            catch(Exception ex)
            {
                throw new ApplicationException("this program did an oopsie", ex);
            }
        }
        public static string[] readRecord(string searchTerm,string filepath,int positionofsearchTerm)
        {
            positionofsearchTerm--;
            string[] recordNotFound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                
                for (int i = 0;i < lines.Length;i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchTerm, fields, positionofsearchTerm))
                    {
                        Console.WriteLine("Record found");
                        return fields;
                    }
                }

                return recordNotFound;
            }
            catch(Exception ex)
            {
                Console.WriteLine("This program did not an oopsie");
                return recordNotFound;
                throw new ApplicationException("This program did an oopsie :" ,ex);
            }
        }

        public static bool recordMatches(string searchTerm, string[] record, int positionofsearchTerm)
        {
            if(record[positionofsearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        } 
    }
}
