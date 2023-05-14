using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Models.Market
{
    public static class MarketState
    {
        public static float EnergyAnualGrowth = 3.5f;
        public static float MaterialsAnualGrowth = 8.8725f;
        public static float IndustrialsGrowth = 10.4115f;
        public static float UtilitiesGrowth = 11.8f;
        public static float HealthcareGrowth = 14.0f;
        public static float FinancialsGrowth = 12.3f;
        public static float ConsumerDiscretionaryGrowth = 17.4f;
        public static float ConsumerStaplesGrowth = 12.3f;
        public static float InformationTechnologyGrowth = 17.0f;
        public static float CommunicationServicesGrowth = 16.0f;
        public static float RealEstateGrowth = 2.405f;
        public static float SNP500Growth = 13.6f;

        public static float ConsumerStaplesStdDev = 10.7f;
        public static float UtilitiesStdDev = 11.8f;
        public static float IndustrialsStdDev = 12.0f;
        public static float HealthCareStdDev = 12.4f;
        public static float SNP500StdDev = 12.6f;
        public static float MaterialsStdDev = 13.0f;
        public static float CommunicationServicesStdDev = 14.1f;
        public static float RealEstateStdDev = 14.4f;
        public static float ConsumerDiscretionaryStdDev = 14.6f;
        public static float InformationTechnologyStdDev = 14.8f;
        public static float FinancialsStdDev = 16.8f;
        public static float EnergyStdDev = 20.3f;

        private static int _randomSeed = 101;

        public static float GetReturnsOn(Sector primary, Sector secondary, Sector tirtiary, float _inherientVolitility, float _inherientGrowth)
        {
            float growth = GrowthBySector(primary);
            growth += GrowthBySector(secondary) / 2f;
            growth += GrowthBySector(tirtiary) / 4f;
            growth /= 1.75f; //normalize
            growth *= _inherientGrowth;

            float stdDev = StandardDevationBySector(primary);
            stdDev += StandardDevationBySector(secondary) / 2f;
            stdDev += StandardDevationBySector(tirtiary) / 4f;
            stdDev /= 1.75f; //normalize
            stdDev *= _inherientVolitility;

            System.Random rand = new System.Random(_randomSeed);
            float x = (float)rand.NextDouble();
            x -= .5f;
            x *= 4.5f;

            float realizedGrowth = growth + (x * stdDev);

            return realizedGrowth;
        }


        private static float GrowthBySector(Sector sector)
        {
            switch (sector)
            {
                case Sector.Energy:
                    return EnergyAnualGrowth;
                case Sector.Materials:
                    return MaterialsAnualGrowth;
                case Sector.Industrials:
                    return IndustrialsGrowth;
                case Sector.Utilities:
                    return UtilitiesGrowth;
                case Sector.Healthcare:
                    return HealthcareGrowth;
                case Sector.Financials:
                    return FinancialsGrowth;
                case Sector.ConsumerDiscretionary:
                    return ConsumerDiscretionaryGrowth;
                case Sector.ConsumerStaples:
                    return ConsumerStaplesGrowth;
                case Sector.InformationTechnology:
                    return InformationTechnologyGrowth;
                case Sector.Communication:
                    return CommunicationServicesGrowth;
                case Sector.RealEstate:
                    return RealEstateGrowth;
                case Sector.SNP500:
                    return SNP500Growth;
            }
            Debug.LogError("No Such Sector: " + sector);
            return 0;
        }
        private static float StandardDevationBySector(Sector sector)
        {
            switch (sector)
            {
                case Sector.Energy:
                    return EnergyStdDev;
                case Sector.Materials:
                    return MaterialsStdDev;
                case Sector.Industrials:
                    return IndustrialsStdDev;
                case Sector.Utilities:
                    return UtilitiesStdDev;
                case Sector.Healthcare:
                    return HealthCareStdDev;
                case Sector.Financials:
                    return FinancialsStdDev;
                case Sector.ConsumerDiscretionary:
                    return ConsumerDiscretionaryStdDev;
                case Sector.ConsumerStaples:
                    return ConsumerStaplesStdDev;
                case Sector.InformationTechnology:
                    return InformationTechnologyStdDev;
                case Sector.Communication:
                    return CommunicationServicesStdDev;
                case Sector.RealEstate:
                    return RealEstateStdDev;
                case Sector.SNP500:
                    return SNP500StdDev;
            }
            Debug.LogError("No Such Sector: " + sector);
            return 0;
        }
    }
}

