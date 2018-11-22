﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR2.Model;
using LR2.View;
using LR2.Controller;
using LR2.Model.Table;
using NHibernate;

namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.OpenSession();//открываем сессию
            int key;
            bool tmp = true;
            while (tmp)
            {
                PrintCMD.MenuUP();
                key = PrintCMD.ReadKey();
                switch (key)
                {
                    case 1:
                        Controll.Genre();
                        break;
                    case 0:
                        tmp = false;
                        break;
                }
            }
        }
        private static void Delete()
        {
            Console.Write("id \n");
            int id = Console.Read();
            Console.Write(Singleton.Instance.Genre.Read().List<Genre>().Count + "\n");
            Console.Write(id.GetType() + "\n");
            Console.Write(id + "\n");
            //Genre d = Singleton.Instance.Genre.Read().List<Genre>()[0];
            //Singleton.Instance.Genre.Delete(d);
        }
    }
}
