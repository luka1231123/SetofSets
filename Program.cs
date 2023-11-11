

using System.Linq;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Dynamic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace SetofSets;

    

class Program
{
    public static void Main(string[] args)
    {
        
        int c=0;
        
        HashSet<int> odd = new HashSet<int>();
        for(int i=1;i<10000000;i++)
        {
            if(i%2==0){
                odd.Add(2021%(i));
            }
            
            
        }
        foreach(int i in odd) 
        { 
            //Console.WriteLine(i); 
            c=c+i;
        } 
        Console.WriteLine(c);
    }

}
