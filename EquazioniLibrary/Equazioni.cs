﻿using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool risposta = false;
            if (a != 0)
            {
                risposta = false;
            }
            else
            {
                risposta = true;
            }
            return risposta;
        }

        public static bool IsInconsisted(double a,double b)
        {
            if (a == 0 && b != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDegree2(double a)
        {
            if (a == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
