using System;

namespace app_code.Controllers
{
    public class PrimeService
    {
        public bool IsPrime(int candidate) 
        {
            return (candidate < 2 ? false : true);
            throw new NotImplementedException("Please create a test first");
        } 
    }
}