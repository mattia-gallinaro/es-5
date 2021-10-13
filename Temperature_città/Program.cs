//nickname: matgal
//Data: 13/10/2021
/* Dopo aver acquisito da tastiera una serie di dati relativi alla misurazione della temperatura di una certa città, 
 * scrivere il codice di un programma(OOP) in C# che determini e visualizzi la temperatura più bassa e quella più alta.*/
using System;
using System.Collections.Generic;

namespace Temperature_città
{
    class Temperature
    {
        //attributi
        int t,min,max;

        //costruttore
        public Temperature(int t)
        {
            this.t = t;
            min = 9999;
            max = -9999;
        }
        //metodi
        //
        public void setTemp()
        {
            t = int.Parse(Console.ReadLine());
            minimo();
            massimo();
        }
        //se la temperatura inserita è minore di min allora t viene assegnata a min
        public void minimo()
        {
            if (min > t)
                min = t;

        }
        //se la temperatura inserita è maggiore di max allora t viene assegnata a max
        public void massimo()
        {
            if (max < t)

                max = t;

        }
        //ritorna min
        public int mostraMinimo()
        {
            return min;
        }
        //ritorna max
        public int mostraMassimo()
        {
            return max;
        }
        //l'utente indica quante temperature deve inserire
        //il for si ripete per la quantità indicata dall'utente
        //e ad ogni ciclo l'utente inserisce una temperatura che viene contrallata nel caso in cui sia quella minore o quella maggiore
        //alla fine mostra la temperatura massima e minima inserita dall'utente
        static void Main(string[] args)
        {
            int quantità = 0;
            Console.WriteLine("Quante temperature vuoi inserire?");
            Temperature t = new Temperature(quantità);
            quantità = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantità; i++)
            {
                Console.Write("Inserisci la temperatura");
                t.setTemp();
            }
            Console.WriteLine("La temperatura minima è :" + t.mostraMinimo());
            Console.WriteLine("La temperatura massima è :" + t.mostraMassimo());
        }
    }
}
