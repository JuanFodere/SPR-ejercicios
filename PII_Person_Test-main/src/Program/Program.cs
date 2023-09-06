﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Ucu.Poo.Persons
{
    /// <summary>
    /// El programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            IntroducePersons();
        }

        private static void IntroducePersons()
        {
            Person lucho = new Person("Luis", "Suárez");
            Person chino = new Person("Sergio", "Rochet");
            chino.IntroduceTo(lucho);
            lucho.IntroduceTo(chino);
        }
    }
}