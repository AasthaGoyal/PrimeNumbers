using System.Collections;

namespace PrimeNumbers
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Application started \n");

            // Get the list of primes between 0-1000
            List<long> primes = getPrimes(1000);

            //Calculate the product of all 4 possible primes 
         
            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k <= j; k++)
                    {
                        for (int l = 0; l <= k; l++)
                        {
                            long product = primes[i] * primes[j] * primes[k] * primes[l];
                            
                            if(checkSequence(product))
                            {
                                Console.Write("The four prime numbers are " + primes[i] + ", " + primes[j] + ", " + primes[k] + " and " + primes[l] + "\n");
                                Console.Write("The product is " + product + "\n");
                            }

                        }
                    }
                }

            }
            Console.WriteLine("Application completed \n");
        }

        //Function to get all the prime numbers between 0-limit(1000)
        static List<long> getPrimes(int limit)
        {
            List<long> primes = new List<long>();

            int ctr = 0;

            for (int i = 2; i < limit; i++)
            {
                ctr = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ctr = 1;
                        break;
                    }
                }
                if (ctr == 0)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        //Function to check the conditions on the product 
        static bool checkSequence(long product)
        {
            double length = Math.Floor(Math.Log10(product) + 1);
            if(length != 12)
            {
                return false;
            }
           
            String productStr = product.ToString();
            char[] digitsChar = new char[12];
            for (int i = 0; i < 12; i++)
            {
                digitsChar[i] = Convert.ToChar(productStr[i]);
            }

            int[] digitsInt = new int[12];
            for (int i = 0; i < 12; i++)
            {
                digitsInt[i] = Convert.ToInt32(new String(digitsChar[i], 1));
            }

            for (int k = 1; k < 12; k++)
            {
                int diff = digitsInt[k] - digitsInt[k - 1];
                if (diff != 0 && diff != 1)
                {
                    return  false;
                   
                }
            }

            return true;
        }
    }
}
