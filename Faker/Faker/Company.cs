﻿//-----------------------------------------------------------------------
// <copyright file="Company.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Static company class
    /// </summary>
    public static class Company
    {
        // Logo
        private static List<string> name;
        private static List<string> catchPhrase;
        private static List<string> suffix;
        private static List<string> sector;
        private static List<string> industry;

        /// <summary>
        /// Gets a suffix value
        /// </summary>
        /// <returns>String of suffix</returns>
        public static string Suffix()
        {
            if (suffix == null)
            {
                suffix = XML.GetListString("Company", "Suffix");
            }

            return suffix[Number.RandomNumber(0, suffix.Count - 1)];
        }

        /// <summary>
        /// Gets a random sector
        /// </summary>
        /// <returns>A string value</returns>
        public static string Sector()
        {
            if (sector == null)
            {
                sector = XML.GetListString("Company", "Sector");
            }

            return sector[Number.RandomNumber(0, sector.Count - 1)];
        }

        /// <summary>
        /// Gets a random industry
        /// </summary>
        /// <returns>A string value</returns>
        public static string Industry()
        {
            if (industry == null)
            {
                industry = XML.GetListString("Company", "Industry");
            }

            return industry[Number.RandomNumber(0, industry.Count - 1)];
        }

        /// <summary>
        /// Gets a random symbol
        /// </summary>
        /// <returns>A string value</returns>
        public static string Symbol()
        {
            string val = string.Empty;
            for (int i = 0; i < Number.RandomNumber(3, 5); i++)
            {
                val += Utilities.Character();
            }

            return val.ToUpper();
        }

        private static string Name()
        {
            if (name == null)
            {
                name = XML.GetListString("Company", "Name");
            }

            return name[Number.RandomNumber(0, name.Count - 1)];
        }

        private static string CatchPhrase()
        {
            if (catchPhrase == null)
            {
                catchPhrase = XML.GetListString("Company", "CatchPhrase");
            }

            return catchPhrase[Number.RandomNumber(0, catchPhrase.Count - 1)];
        }
    }
}
