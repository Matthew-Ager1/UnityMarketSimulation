using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Market;

namespace Models.Investment
{
    public static class Investments
    {
        //ExtremeRisk-HighRisk-MidRisk-LowRisk

        //Energy
        public static ReturnProfile ExtremeRiskEnergy = new ReturnProfile(4f, 8f, Sector.Energy, Sector.Industrials, Sector.Utilities, "Extreme Risk Energy");
        public static ReturnProfile HighRiskEnergy = new ReturnProfile(2f, 2f, Sector.Energy, Sector.Industrials, Sector.Utilities, "High Risk Energy");
        public static ReturnProfile MidRiskEnergy = new ReturnProfile(1f, 1f, Sector.Energy, Sector.Utilities, Sector.Industrials, "Mid Risk Energy");
        public static ReturnProfile LowRiskEnergy = new ReturnProfile(.5f, .5f, Sector.Energy, Sector.Utilities, Sector.ConsumerStaples, "Low Risk Energy");

        //Tech 
        public static ReturnProfile ExtremeRiskTech = new ReturnProfile(4f, 8f, Sector.InformationTechnology, Sector.Communication, Sector.ConsumerDiscretionary, "Extreme Risk Tech");
        public static ReturnProfile HighRiskTech = new ReturnProfile(2f, 2f, Sector.InformationTechnology, Sector.Communication, Sector.ConsumerDiscretionary, "High Risk Tech");
        public static ReturnProfile MidRiskTech = new ReturnProfile(1f, 1f, Sector.InformationTechnology, Sector.Communication, Sector.ConsumerStaples, "Mid Risk Tech");
        public static ReturnProfile LowRiskTech = new ReturnProfile(.5f, .5f, Sector.InformationTechnology, Sector.ConsumerDiscresionary, Sector.ConsumerStaples, "Low Risk Tech");

        //Financials
        public static ReturnProfile ExtremeRiskFinancials = new ReturnProfile(4f, 8f, Sector.Financials, Sector.RealEstate, Sector.Utilities, "Extreme Risk Financials");
        public static ReturnProfile HighRiskFinancials = new ReturnProfile(2f, 2f, Sector.Financials, Sector.RealEstate, Sector.Industrials, "High Risk Financials");
        public static ReturnProfile MidRiskFinancials = new ReturnProfile(1f, 1f, Sector.Financials, Sector.InformationTechnology, Sector.SNP500, "Mid Risk Financials");
        public static ReturnProfile LowRiskFinancials = new ReturnProfile(.5f, .5f, Sector.Financials, Sector.Financials, Sector.Financials, "Low Risk Financials");

        //Materials
        public static ReturnProfile ExtremeRiskMaterials = new ReturnProfile(4f, 8f, Sector.Materials, Sector.Financials, Sector.Industrials, "Extreme Risk Materials");
        public static ReturnProfile HighRiskMaterials = new ReturnProfile(2f, 2f, Sector.Materials, Sector.ConsumerDiscretionary, Sector.Healthcare, "High Risk Materials");
        public static ReturnProfile MidRiskMaterials = new ReturnProfile(1f, 1f, Sector.Materials, Sector.InformationTechnology, Sector.SNP500, "Mid Risk Materials");
        public static ReturnProfile LowRiskMaterials = new ReturnProfile(.5f, .5f, Sector.Materials, Sector.SNP500, Sector.Utilities, "Low Risk Materials");

        //Industrials
        public static ReturnProfile ExtremeRiskIndustrials = new ReturnProfile(4f, 8f, Sector.Industrials, Sector.ConsumerDiscretionary, Sector.ConsumerStaples, "Extreme Risk Industrials");
        public static ReturnProfile HighRiskIndustrials = new ReturnProfile(2f, 2f, Sector.Industrials, Sector.Energy, Sector.Healthcare, "High Risk Industrials");
        public static ReturnProfile MidRiskIndustrials = new ReturnProfile(1f, 1f, Sector.Industrials, Sector.Communication, Sector.RealEstate, "Mid Risk Industrials");
        public static ReturnProfile LowRiskIndustrials = new ReturnProfile(.5f, .5f, Sector.Industrials, Sector.SNP500, Sector.Energy, "Low Risk Industrials");

        //Utilities
        public static ReturnProfile ExtremeRiskUtilities = new ReturnProfile(4f, 8f, Sector.Utilities, Sector.RealEstate, Sector.ConsumerDiscretionary, "Extreme Risk Utilities");
        public static ReturnProfile HighRiskUtilities = new ReturnProfile(2f, 2f, Sector.Utilities, Sector.Materials, Sector.InformationTechnology, "High Risk Utilities");
        public static ReturnProfile MidRiskUtilities = new ReturnProfile(1f, 1f, Sector.Utilities, Sector.Utilities, Sector.ConsumerStaples, "Mid Risk Utilities");
        public static ReturnProfile LowRiskUtilities = new ReturnProfile(.5f, .5f, Sector.Utilities, Sector.SNP500, Sector.Industrials, "Low Risk Utilities");

        //Healthcare
        public static ReturnProfile ExtremeRiskHealthcare = new ReturnProfile(4f, 8f, Sector.Healthcare, Sector.InformationTechnology, Sector.Communication, "Extreme Risk Healthcare");
        public static ReturnProfile HighRiskHealthcare = new ReturnProfile(2f, 2f, Sector.Healthcare, Sector.Energy, Sector.Communication, "High Risk Healthcare");
        public static ReturnProfile MidRiskHealthcare = new ReturnProfile(1f, 1f, Sector.Healthcare, Sector.Financials, Sector.InformationTechnology, "Mid Risk Healthcare");
        public static ReturnProfile LowRiskHealthcare = new ReturnProfile(.5f, .5f, Sector.Healthcare, Sector.SNP500, Sector.Materials, "Low Risk Healthcare");

        //ConsumerDiscretionary
        public static ReturnProfile ExtremeRiskConsumerDiscretionary = new ReturnProfile(4f, 8f, Sector.ConsumerDiscretionary, Sector.Financials, Sector.Communication, "Extreme Risk Consumer Discretionary");
        public static ReturnProfile HighRiskConsumerDiscretionary = new ReturnProfile(2f, 2f, Sector.ConsumerDiscretionary, Sector.ConsumerStaples, Sector.Materials, "High Risk Consumer Discretionary");
        public static ReturnProfile MidRiskConsumerDiscretionary = new ReturnProfile(1f, 1f, Sector.ConsumerDiscretionary, Sector.RealEstate, Sector.Energy, "Mid Risk Consumer Discretionary");
        public static ReturnProfile LowRiskConsumerDiscretionary = new ReturnProfile(.5f, .5f, Sector.ConsumerDiscretionary, Sector.SNP500, Sector.Utilities, "Low Risk Consumer Discretionary");

        //ConsumerStaples
        public static ReturnProfile ExtremeRiskConsumerStaples = new ReturnProfile(4f, 8f, Sector.ConsumerStaples, Sector.ConsumerDiscretionary, Sector.InformationTechnology, "Extreme Risk Consumer Staples");
        public static ReturnProfile HighRiskConsumerStaples = new ReturnProfile(2f, 2f, Sector.ConsumerStaples, Sector.RealEstate, Sector.Utilities, "High Risk Consumer Staples");
        public static ReturnProfile MidRiskConsumerStaples = new ReturnProfile(1f, 1f, Sector.ConsumerStaples, Sector.Financials, Sector.Industrials, "Mid Risk Consumer Staples");
        public static ReturnProfile LowRiskConsumerStaples = new ReturnProfile(.5f, .5f, Sector.ConsumerStaples, Sector.SNP500, Sector.ConsumerDiscretionary, "Low Risk Consumer Staples");

        //CommunicationServices
        public static ReturnProfile ExtremeRiskCommunication = new ReturnProfile(4f, 8f, Sector.Communication, Sector.InformationTechnology, Sector.ConsumerDiscresionary, "Extreme Risk Energy");
        public static ReturnProfile HighRiskCommunication = new ReturnProfile(2f, 2f, Sector.Communication, Sector.Financials, Sector.InformationTechnology, "High Risk Energy");
        public static ReturnProfile MidRiskCommunication = new ReturnProfile(1f, 1f, Sector.Communication, Sector.Materials, Sector.ConsumerStaples, "Mid Risk Energy");
        public static ReturnProfile LowRiskCommunication = new ReturnProfile(.5f, .5f, Sector.Communication, Sector.SNP500, Sector.InformationTechnology, "Low Risk Energy");

        //RealEstate
        public static ReturnProfile ExtremeRiskRealEstate = new ReturnProfile(4f, 8f, Sector.RealEstate, Sector.Financials, Sector.ConsumerStaples, "Extreme Risk Energy");
        public static ReturnProfile HighRiskRealEstate = new ReturnProfile(2f, 2f, Sector.RealEstate, Sector.Utilities, Sector.Healthcare, "High Risk Energy");
        public static ReturnProfile MidRiskRealEstate = new ReturnProfile(1f, 1f, Sector.RealEstate, Sector.Energy, Sector.Utilities, "Mid Risk Energy");
        public static ReturnProfile LowRiskRealEstate = new ReturnProfile(.5f, .5f, Sector.RealEstate, Sector.SNP500, Sector.Industrials, "Low Risk Energy");

        public static List<ReturnProfile> EnergyProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskEnergy, HighRiskEnergy, MidRiskEnergy, LowRiskEnergy };
            }
        }
        public static List<ReturnProfile> TechProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskTech, HighRiskTech, MidRiskTech, LowRiskTech };
            }
        }
        public static List<ReturnProfile> FinancialsProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskFinancials, HighRiskFinancials, MidRiskFinancials, LowRiskFinancials };
            }
        }
        public static List<ReturnProfile> MaterialsProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskMaterials, HighRiskMaterials, MidRiskMaterials, LowRiskMaterials };
            }
        }
        public static List<ReturnProfile> IndustrialsProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskIndustrials, HighRiskIndustrials, MidRiskIndustrials, LowRiskIndustrials };
            }
        }
        public static List<ReturnProfile> UtilitiesProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskUtilities, HighRiskUtilities, MidRiskUtilities, LowRiskUtilities };
            }
        }
        public static List<ReturnProfile> HealthcareProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskHealthcare, HighRiskHealthcare, MidRiskHealthcare, LowRiskHealthcare };
            }
        }
        public static List<ReturnProfile> ConsumerDiscretionaryProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskConsumerDiscretionary, HighRiskConsumerDiscretionary, MidRiskConsumerDiscretionary, LowRiskConsumerDiscretionary };
            }
        }
        public static List<ReturnProfile> ConsumerStaplesProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskConsumerStaples, HighRiskConsumerStaples, MidRiskConsumerStaples, LowRiskConsumerStaples };
            }
        }
        public static List<ReturnProfile> CommunicationServicesProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskCommunication, HighRiskCommunication, MidRiskCommunication, LowRiskCommunication };
            }
        }
        public static List<ReturnProfile> RealEstateProfiles
        {
            get
            {
                return new List<ReturnProfile>() { ExtremeRiskRealEstate, HighRiskRealEstate, MidRiskRealEstate, LowRiskRealEstate };
            }
        }

        public static ReturnProfile GetProfile(Sector sector, int RiskLevel) //0 = extreme, 3 = low
        {
            switch (sector)
            {
                case Sector.Energy:
                    return EnergyProfiles[RiskLevel];
                case Sector.InformationTechnology:
                    return TechProfiles[RiskLevel];
                case Sector.Financials:
                    return FinancialsProfiles[RiskLevel];
                case Sector.Materials:
                    return MaterialsProfiles[RiskLevel];
                case Sector.Industrials:
                    return IndustrialsProfiles[RiskLevel];
                case Sector.Utilities:
                    return UtilitiesProfiles[RiskLevel];
                case Sector.Healthcare:
                    return HealthcareProfiles[RiskLevel];
                case Sector.ConsumerDiscresionary:
                    return ConsumerDiscretionaryProfiles[RiskLevel];
                case Sector.ConsumerStaples:
                    return ConsumerStaplesProfiles[RiskLevel];
                case Sector.Communication:
                    return CommunicationServicesProfiles[RiskLevel];
                case Sector.RealEstate:
                    return RealEstateProfiles[RiskLevel];
                default:
                    return null;
            }
        }
    }
}
