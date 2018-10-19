using System;
using System.Linq;

namespace iPodInventoryProblem
{
    public enum Countries
    {
        Brazil,
        Argentina,
        None
    }

    public class CalculateOptimisedPrice
    {
        private readonly int TRANSPORT_CHARGES = 40,
                                BRAZIL_IPOD_PRICE = 100,
                                ARGENTINA_IPOD_PRICE = 50,
                                BRAZIL_IPODS = 100,
                                ARGENTINA_IPODS = 100,
                                MAX_IPODS_ORDER = 200;

        private readonly string OUT_OF_STOCK = "Out of stock";

        public string GetOptimisedPrice(string input)
        {
            var countryIPodRequired = input.Split(new string[] { " : " }, StringSplitOptions.None);
            int iPodRequired = 0;
            Countries country = Countries.None;

            string output = string.Empty;

            if (countryIPodRequired.Count() == 2)
            {
                country = (Countries)Enum.Parse(typeof(Countries), countryIPodRequired[0]);
                iPodRequired = Convert.ToInt32(countryIPodRequired[1]);
            }
            else
            {
                output = "Invalid Input";
            }



            if (iPodRequired > MAX_IPODS_ORDER)
            {
                output = OUT_OF_STOCK;
            }
            else if (iPodRequired % 10 == 0 && iPodRequired <= 100)
            {
                switch (country)
                {
                    case Countries.Brazil:
                        output = $"{(ARGENTINA_IPOD_PRICE + TRANSPORT_CHARGES) * iPodRequired} : {BRAZIL_IPODS} : {ARGENTINA_IPODS - iPodRequired}";
                        break;
                    case Countries.Argentina:
                        output = $"{(ARGENTINA_IPOD_PRICE) * iPodRequired} : {BRAZIL_IPODS} : {ARGENTINA_IPODS - iPodRequired}";
                        break;
                }
            }
            else if (iPodRequired % 10 == 0 && iPodRequired > 100)
            {
                switch (country)
                {
                    case Countries.Brazil:
                        output = $"{(ARGENTINA_IPOD_PRICE + TRANSPORT_CHARGES) * 100} : {200 - iPodRequired} : {0}";
                        break;
                    case Countries.Argentina:
                        output = $"{ARGENTINA_IPOD_PRICE * 100 + (BRAZIL_IPOD_PRICE + TRANSPORT_CHARGES) * (iPodRequired - 100)} : {200 - iPodRequired} : {0}";
                        break;
                }
            }
            else if (iPodRequired % 10 != 0 && iPodRequired <= 100)
            {
                switch (country)
                {
                    case Countries.Brazil:
                        output = $"{(BRAZIL_IPOD_PRICE) * iPodRequired} : {BRAZIL_IPODS - iPodRequired} : {ARGENTINA_IPODS}";
                        break;
                    case Countries.Argentina:
                        output = $"{(ARGENTINA_IPOD_PRICE) * iPodRequired} : {BRAZIL_IPODS} : {ARGENTINA_IPODS - iPodRequired}";
                        break;
                }
            }
            else if (iPodRequired % 10 != 0 && iPodRequired > 100)
            {
                switch (country)
                {
                    case Countries.Brazil:
                    case Countries.Argentina:
                        output = OUT_OF_STOCK;
                        break;
                }
            }
            else
            {
                output = OUT_OF_STOCK;
            }

            return output;
        }
    }
}
