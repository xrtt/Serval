using System;

namespace Serval.Domain
{
    public class StringProvider
    {
        public string GetString(int num = 0)
        {
            return $"Hell world! {num}";
        }
    }
}
