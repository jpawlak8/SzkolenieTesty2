namespace StringCalculator1
{
    public class StringCalculator
    {
        public int AddNumbers(string numbers)
        {
            List<int> numberList = new List<int>();
            if (numbers == null || numbers == "")
            {
                return 0;
            }
            else
            {
                string[] nums = numbers.Split(',','\n');

                foreach (var num in nums)
                {
                    try
                    {
                        numberList.Add(Convert.ToInt32(num));
                    }
                    catch(Exception ex)
                    {
                        throw new ArgumentException("Zła wartość seperatora");
                    }
                }

                return Sum(numberList);
            }
        }

        public int Sum(List<int> lists)
        {
            int sum = 0;    
            foreach (var list in lists)
            {
                if (list <= 1000)
                {
                    sum = sum + list;
                }
            }
            return sum;
        }

        public int AddNumbersFindDelimiter(string numbers)
        {
            // //;\n1;2;3;4;5;6;
            List<int> numberList = new List<int>();
            if (numbers == null || numbers == "")
            {
                return 0;
            }
            else if (numbers.Length > 5)
            {
                var delimiter = "";
                if (numbers.StartsWith("//"))
                {
                    delimiter = numbers.Substring(2, 1);
                }

                numbers = numbers.Substring(4, numbers.Length - 4);

                string[] nums = numbers.Split(delimiter);

                foreach (var num in nums)
                {
                    try
                    {
                        numberList.Add(Convert.ToInt32(num));
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException("Zła wartość seperatora");
                    }
                }
                return Sum(numberList);
            }
            else
            {
                throw new Exception("Podano za mało znaków");
            }
        }
    }
}