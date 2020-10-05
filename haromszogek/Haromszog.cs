﻿using System;
using System.Collections.Generic;

namespace haromszog
{
    internal class Haromszog
    {
        private double aoldal;
        private double boldal;
        private double coldal;

        public double Terulet { get; private set; }
        public double Kerulet { get; private set; }
        public bool Szerkesztheto { get; private set; }

        private void Szerk()
        {
            if (aoldal + boldal > coldal && boldal + coldal > aoldal && aoldal+ coldal > boldal)
            {
                Szerkesztheto = true;
                Terulet = TeruletSzamitas();
                Kerulet = KeruletSzamitas();
            }
            else
            {
                Szerkesztheto = false;
                Terulet = 0;
                Kerulet = 0;
            }
        }
        private double TeruletSzamitas()
        {
            double s = (aoldal + boldal + coldal) / 2;
            return Math.Sqrt(s * (s - aoldal) * (s - boldal) * (s - coldal));
        }
        private double KeruletSzamitas()
        {
           return  aoldal + boldal + coldal;
        }

        public List<string> AdatokSzoveg()
        {
            List<string> adatok = new List<string>();
            adatok.Add($"a: {aoldal} - b: {boldal} - c: {coldal}");
            if (Szerkesztheto)
            {
                adatok.Add($"Kerület: {Kerulet:N2} Terület: {Terulet:N2}");
            }
            else
            {
                adatok.Add("Nem szerkeszthető!");
            }
 
            return adatok;
        }

        public Haromszog(double aoldal, double boldal, double coldal)
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.coldal = coldal;
            Szerk();
        }
    }
}