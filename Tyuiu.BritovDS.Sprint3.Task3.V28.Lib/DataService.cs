using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BritovDS.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string ans = value;
            foreach (char c in ans)
            {
                if (Char.IsDigit(c))
                {
                    ans = ans.Replace(c, item);
                }
            }
            return ans;
        }
    }
}