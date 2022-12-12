﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class Utilidades
    {
        private static string[] unidades = {"Cero", "Uno", "Dos", "Tres",
        "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once",
        "Doce", "Trece", "Catorce", "Quince", "Diesiseis", "Diesiciete",
        "Diesiocho", "Diesinueve"};

        private static string[] decenas = {"", "Diez", "Veinte", "Treinta", 
        "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa" };

        private static string[] centenas = {"", "Cien", "Dosciento", "Treciento", 
        "Cuatrociento", "Quiniento", "Seisciento", "Sieteciento", "Ochociento", 
        "Noveciento" };
        public static string getUnidades(int num)
        {
            string aux = " ";
            aux = unidades[num];
            return aux;
        }
        public static string getDecenas(int num)
        {
            string aux = " ";
            int x = num / 10;
            int res = num % 10;

            //Si es de 0 a 19 salen las unidades que es el primer array
            if (num < 20)
            
                aux = getUnidades(num);
  
            //Y si no salen las centenas que estan en el segundo array
            else
            {
                string uni = res == 0 ? "" : " y " + getUnidades(res);
                aux = decenas[x] + uni;
            }

            return aux;
        }
        public static string getCentenas(int num)
        {
            string aux = "";
            int x = num / 100;
            int res = num % 100;
            if (num < 100)

            return aux;
        }
        public static string getMil(int num)
        {
            string aux = "";
            int x = num / 1000;
            int res = num % 1000;

            if (num < 1000)
            {
                aux = getCentenas(num);
            }
            else
            {
                string mil = res == 0 ? "" : getCentenas(res) + " ";
                string centenas = x > 1 ? getCentenas(x) + " " : " ";
                aux = centenas + "mil" + " " + mil;
            }

            return aux;
        }

    }
}
