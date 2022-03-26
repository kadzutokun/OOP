using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aidar
{
    class Program
    {
        static void Main(string[] args)
        {
            klient aidar = new klient("123", 19, "Aidar", "Lilili");
            aidar.parsname();
        }
    }
    class klient
    {
        public string nomer;
        public int age;
        public string name;
        public string firstname;


        public klient(string nomer, int age, string name, string firstname)
        {
            this.nomer = nomer;
        }
    public void parsname()
        {
            if (name is string)
            {
                Console.WriteLine(name);
                Console.ReadKey();
            }
        }

    }
    class pk
    {

    }
    class price
    {

    }
    class zakaz
    {

    }
    class account
    {

    }
}   
