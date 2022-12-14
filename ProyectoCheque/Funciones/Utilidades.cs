using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class Utilidades
    {
        public static string[] unidades = { "cero", "uno", "dos",
        "tres", "cuatro",
        "cinco", "seis", "siete", "ocho", "nueve", "diez", "once",
        "doce", "trece", "catorce", "quince"
        , "diesciseis", "diescisiete", "diesciocho", "diescinueve"};

        private static string[] decenas = { "", "diez", "veinte",
        "treina", "cuarenta", "cincuenta", "sesenta", "setenta",
        "ochenta", "noventa" };
        private static string[] centenas = { "", "cien", "doscientos",
        "trescientos", "cuatrocientos",
        "quinientos", "seiscientos", "setecientos", "ochocientos",
        "novescientos" };
        public static string getUnidades(int num)
        {
            string aux = " ";
            aux = unidades[num];
            return aux;
        }
        public static string getDecenas(int num)
        {
            string decena = "";
            int x = num / 10;
            int res = num % 10;
            //Si es de 0 a 19 salen las unidades que es el primer array
            if (num < 20)
            {
                decena = getUnidades(num);
            }
            //Y si no salen las centenas que estan en el segundo array
            else
            {
                string uni = res == 0 ? "" : " y " + getUnidades(res) + " ";
                decena = decenas[x] + uni;
            }
            return decena;
        }
        public static string getCentenas(int num)
        {
            string centena = "";
            int x = num / 100;
            int res = num % 100;
            if (num < 100)
            {
                centena = getDecenas(num);
            }
            else if (num < 200)
            {
                string cent = res == 0 ? "" : "to " + getDecenas(res) + " ";
                centena = centenas[x] + cent;
            }
            else
            {
                string cent = res == 0 ? "" : " " + getDecenas(res) + " ";
                centena = centenas[x] + cent;
            }
            return centena;
        }
        public static string getMill(int n)
        {
            string millar = "";
            int x = n / 1000;
            int res = n % 1000;

            if (n < 1000)
            {
                millar = getCentenas(n);
            }
            else
            {
                string m = res == 0 ? "" : getCentenas(res) + " ";
                string c = x > 1 ? getCentenas(x) + " " : "";
                millar = c + mill[0] + " " + m;
            }
            return millar;
        }
        public static string getMillon(int num)
        {
            string illon = "";
            int x = num / 1000000;
            int res = num % 1000000;

            if (num < 1000000)
            {
                illon = getMill(num);
            }
            else
            {
                string mil = res == 0 ? "" : getMill(res) + " ";
                string cent = x > 1 ? getMill(x) + " " : "";
                string espacio = x > 1 ? millon[0] + "es " : getCentenas(x).Remove(getCentenas(x).Length - 1, 1) + " " + millon[0];
                illon = cent + espacio + " " + mil;


            }
            return illon;
        }

































        private static string[] mill = { "mil" };
        private static string[] millon = { "millon" };
    }
}
