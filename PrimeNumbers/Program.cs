using System.Collections;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application started");
            List<long> primes = new List<long>();
            
            int ctr = 0;

            for (int i=2;i<1000;i++)
            {
                ctr = 0;
        
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        ctr = 1;
                        break;
                        
                    }

                }

                if(ctr==0)
                {
                    primes.Add(i);
                }
                
            }

            
            for(int m=0;m<primes.Count;m++)
            {
                for (int n = 1; n < primes.Count - 2; n++)
                {
                    
                    long product = (long)primes[m] * (long)primes[n] * (long)primes[n + 1] * (long)primes[n + 2];
                    
                    double length = Math.Floor(Math.Log10(product) + 1);
                    
                    //Console.Write("the product is" + product + "and length" + length + "\n");
                    if (length == 12)
                    {
                       
                        String productStr = product.ToString();
                        char[] digitsChar = new char[12];
                        for(int i=0;i<12;i++)
                        {
                            digitsChar[i] = Convert.ToChar(productStr[i]);
                        }
                      
                        int[] digitsInt = new int[12];
                        for (int i = 0; i < 12; i++)
                        {
                            digitsInt[i] = Convert.ToInt32(new String(digitsChar[i], 1));
                        }
                        // Array.ForEach(digitsInt, Console.WriteLine);
                        //Console.Write(primes[m] + "and" + primes[n] + "and" + primes[n + 1] + "and" + primes[n + 2] + "\n");
                        //Console.Write("The product has 12 digits " + product + "and length" + length + "\n");
                        bool result = false;

                        //Array.ForEach(digitsInt, Console.WriteLine);
                        //Console.Write("The product has 12 digits " + product + "\n");

                        for (int k=0;k<11;k++)
                        {
                            //Console.WriteLine(digitsInt[k] + "and " + digitsInt[k+1]);
                            if(digitsInt[k+1] == digitsInt[k] + 1 || digitsInt[k+1] == digitsInt[k])
                            {
                               result = true;
                               continue;
                            }else
                            {
                               result = false;
                               break;
                            }
                               
                            
                        }
                        if(result == true)
                        {
                            Console.Write(primes[m] + "and" + primes[n] + "and" + primes[n + 1] + "and" + primes[n + 2] + "\n");
                            Console.Write("The product has 12 digits " + product + "\n");
                            Console.Write("the result is" + result +  "\n");
                        }
                      
                        continue;
                        //Console.Write("The product does not have 12 digits " + product + "\n");
                
                    }
                    else
                    {
                       
                        continue;
                        
                    }

                }

            }
        }
    }
}
