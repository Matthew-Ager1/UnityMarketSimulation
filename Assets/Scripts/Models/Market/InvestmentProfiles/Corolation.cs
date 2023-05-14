using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Market
{
    public static class Corolation
    {
        public static float[] ConsumerDiscretionaryCorolation = new float[] { 1.00f, 0.52f, 0.45f, 0.78f, 0.51f, 0.85f, 0.72f, 0.74f, 0.54f, 0.26f, 0.07f };
        public static float[] ConsumerStaplesCorolation =       new float[] { 0.52f, 1.00f, 0.34f, 0.58f, 0.65f, 0.57f, 0.27f, 0.47f, 0.39f, 0.43f, 0.55f };
        public static float[] EnergyCorolation =                new float[] { 0.45f, 0.34f, 1.00f, 0.49f, 0.35f, 0.60f, 0.37f, 0.67f, 0.31f, 0.43f, 0.37f };
        public static float[] FinancialsCorolation =            new float[] { 0.78f, 0.58f, 0.49f, 1.00f, 0.60f, 0.81f, 0.51f, 0.69f, 0.42f, 0.33f, 0.72f };
        public static float[] HealthcareCorolation =            new float[] { 0.51f, 0.65f, 0.35f, 0.60f, 1.00f, 0.56f, 0.39f, 0.43f, 0.41f, 0.37f, 0.51f };
        public static float[] IndustrialsCorolation =           new float[] { 0.85f, 0.57f, 0.60f, 0.81f, 0.56f, 1.00f, 0.66f, 0.83f, 0.49f, 0.37f, 0.69f }; 
        public static float[] InformationTechnologyCorolation = new float[] { 0.72f, 0.27f, 0.37f, 0.51f, 0.39f, 0.66f, 1.00f, 0.54f, 0.51f, 0.16f, 0.53f };
        public static float[] MaterialsCorolation =             new float[] { 0.74f, 0.47f, 0.67f, 0.69f, 0.43f, 0.83f, 0.54f, 1.00f, 0.39f, 0.30f, 0.62f };
        public static float[] CommunicationCorolation =         new float[] { 0.54f, 0.39f, 0.31f, 0.42f, 0.41f, 0.49f, 0.51f, 0.39f, 1.00f, 0.30f, 0.34f };
        public static float[] UtilitiesCorolation =             new float[] { 0.26f, 0.43f, 0.43f, 0.33f, 0.37f, 0.37f, 0.16f, 0.30f, 0.30f, 1.00f, 0.44f };
        public static float[] RealEstateCorolation =            new float[] { 0.74f, 0.55f, 0.37f, 0.72f, 0.51f, 0.69f, 0.53f, 0.62f, 0.34f, 0.44f, 1.00f };
    }
}

