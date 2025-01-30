namespace _3._9lesson
{
    internal class Program
    {
        public delegate void Calculate(int otabekzor, int islomzor);
        static void Main(string[] args)
        {
            //Calculate calculatde = Add;
            //calculatde += multiply;
            //calculatde += divide;
            //calculatde += minus;

            //calculatde.Invoke(10, 5);


            //Func<int, int, int> func = Add;
            //func += minus;
            //func.Invoke(15, 10);

            // Main Number Functions //
            Func<int, int, int, int> func1 = Add;
            Func<int, int, int, int, int> func2 = Multiply;
            Func<double, double, double> func3 = Divide;
            Func<int, int, (int, int)> func4 = SumAndProduct;
            Predicate<int> func5 = IsEven;

            // String Manipulation //

            Func<string, string, string, string> func6 = ConcatThree;
            Func<string, (string, string)> func7 = GetUpperAndLower;
            Func<string, string, bool> func8 = ContainsSubstring;
            Func<string, string> func9 = ReverseString;

            // Array/List Functions //

            Func<int[], int> func10 = GetMax;
            Func<int[], int> func11 = GetMin;
            Func<int[], int[]> func12 = GetSorted;
            Func<int[], (int, int)> func13 = GetMaxAndMin;
            Func<int[], int, bool> func14 = ContainsElement;

            // Random Utility //

            Func<int, int, int> func15 = GetRandomNumber;
            Func<(int, int, int)> func16 = GetRandomTriple;
            Func<string> func17 = GetCurrentDateTime;

            // 💡 Boolean & Conditions //

            Predicate<int> func18 = IsOdd;
            Predicate<int> func19 = IsPrime;

            // 🚀 Tuple-Based Functions 

            Func<double, (double, double)> func20 = GetCircleAreaAndCircumference;
            Func<int[], (int, double)> func21 = SumAndAverage;

            // 🔄 Swapping & Printing

            //Action<int, int> func22 = swap;

            Action<string> func23 = PrintMessage;
            Action<int[]> func24 = PrintArray;

            // 🛠 Advanced Functions

            Func<double, string, string> func25 = FormatCurrency;
            Func<double, double, double> func26 = CalculateDiscount;
            Predicate<string> func27 = IsPalindrome;
            Func<string, int> func28 = CountWords;
            Func<string, (string, string)> func29 = GetFirstAndLastWord;

            // 🚀 List Functions

            Func<List<int>, List<int>> func30 = FilterEvenNumbers;
            Func<List<string>, List<string>> func31 = ToUpperCaseList;
            Func<List<int>, List<int>> func32 = RemoveDuplicates;

            // 🔥 Array Functions

            Func<int[], int[]> func33 = FilterPositiveNumbers;
            Func<string[], string[]> func34 = ConvertToLowerCase;
            Func<string[], string[]> func35 = RemoveEmptyStrings;
            Func<int[], int[]> func36 = SortArrayDescending;

            // ✅ Dictionary Functions

            Func<List<int>, List<string>, Dictionary<int, string>> func37 = CreateDictionaryFromList;
            Func<List<string>, Dictionary<string, int>> func38 = CountStringOccurrences;
            Func<Dictionary<int, string>, string, Dictionary<int, string>> func39 = FilterDictionary;
            Func<List<string>, Dictionary<string, int>> func40 = GetStringLengthDictionary;

            // 🔄 Collection Manipulations

            Func<List<int>, List<int>, List<int>> func41 = MergeLists;
            Func<int[], int[], int[]> func42 = MergeArrays;
            Func<Dictionary<int, string>, Dictionary<int, string>, Dictionary<int, string>> func43 = MergeDictionaries;

            // 🛠 Collection Transformations

            Func<List<int>, List<int>> func44 = SquareNumbers;
            Func<int[], int[]> func45 = GetSquares;
            Func<List<string>, int, List<string>> 
                
                
                
                func46 = FilterByLength;

        }



        //public static class RandomFunctions
        //{
        // 🚀 Math & Number Functions
        public static int Add(int a, int b, int c) => a + b + c; //
            public static int Multiply(int a, int b, int c, int d) => a * b * c * d; //
            public static double Divide(double a, double b) => b != 0 ? a / b : double.NaN; //
            public static (int sum, int product) SumAndProduct(int a, int b) => (a + b, a * b);
            public static bool IsEven(int num) => num % 2 == 0;

            // 🔥 String Manipulation
            public static string ConcatThree(string s1, string s2, string s3) => $"{s1}{s2}{s3}";
            public static (string upper, string lower) GetUpperAndLower(string str) => (str.ToUpper(), str.ToLower());
            public static bool ContainsSubstring(string main, string sub) => main.Contains(sub);
            public static string ReverseString(string str) => new string(str.Reverse().ToArray());

            // ✅ Array/List Functions
            public static int GetMax(params int[] numbers) => numbers.Max();
            public static int GetMin(params int[] numbers) => numbers.Min();
            public static int[] GetSorted(int[] numbers) => numbers.OrderBy(n => n).ToArray();
            public static (int max, int min) GetMaxAndMin(int[] numbers) => (numbers.Max(), numbers.Min());
            public static bool ContainsElement(int[] numbers, int value) => numbers.Contains(value);

            // ⚡️ Random & Utility
            public static int GetRandomNumber(int min, int max) => new Random().Next(min, max);
            public static (int, int, int) GetRandomTriple() => (new Random().Next(1, 100), new Random().Next(1, 100), new Random().Next(1, 100));
            public static string GetCurrentDateTime() => DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 💡 Boolean & Conditions
            public static bool IsOdd(int num) => num % 2 != 0;
            public static bool IsPrime(int num)
            {
                if (num <= 1) return false;
                for (int i = 2; i * i <= num; i++)
                    if (num % i == 0) return false;
                return true;
            }

            // 🚀 Tuple-Based Functions
            public static (double, double) GetCircleAreaAndCircumference(double radius)
            {
                double area = Math.PI * radius * radius;
                double circumference = 2 * Math.PI * radius;
                return (area, circumference);
            }

            public static (int sum, double average) SumAndAverage(int[] numbers)
            {
                int sum = numbers.Sum();
                double avg = numbers.Average();
                return (sum, avg);
            }

            // 🔄 Swapping & Printing
            public static void swap(ref int a, ref int b) { int temp = a; a = b; b = temp; }
            public static void PrintMessage(string message) => Console.WriteLine(message);
            public static void PrintArray(int[] numbers) => Console.WriteLine(string.Join(", ", numbers));

            // 🛠 Advanced Functions
            public static string FormatCurrency(double amount, string currency) => $"{currency} {amount:N2}";
            public static double CalculateDiscount(double price, double discountPercent) => price - (price * (discountPercent / 100));
            public static bool IsPalindrome(string str) => str == new string(str.Reverse().ToArray());
            public static int CountWords(string sentence) => sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            public static (string first, string last) GetFirstAndLastWord(string sentence)
            {
                var words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return (words.First(), words.Last());
            }

        // 🚀 List Functions
        public static List<int> FilterEvenNumbers(List<int> numbers) => numbers.Where(n => n % 2 == 0).ToList();
        public static List<string> ToUpperCaseList(List<string> strings) => strings.Select(s => s.ToUpper()).ToList();
        public static List<int> RemoveDuplicates(List<int> numbers) => numbers.Distinct().ToList();

        //public static List<int> AddToList(List<int> numbers, params int[] additionalNumbers);
        //}




        // 🔥 Array Functions
        public static int[] FilterPositiveNumbers(int[] numbers) => numbers.Where(n => n > 0).ToArray();
        public static string[] ConvertToLowerCase(string[] words) => words.Select(w => w.ToLower()).ToArray();
        public static string[] RemoveEmptyStrings(string[] strings) => strings.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        public static int[] SortArrayDescending(int[] numbers) => numbers.OrderByDescending(n => n).ToArray();

        // ✅ Dictionary Functions
        public static Dictionary<int, string> CreateDictionaryFromList(List<int> keys, List<string> values)
        {
            if (keys.Count != values.Count)
                throw new ArgumentException("Keys and values lists must have the same length.");

            return keys.Zip(values, (key, value) => new KeyValuePair<int, string>(key, value))
                       .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<string, int> CountStringOccurrences(List<string> strings)
        {
            return strings.GroupBy(s => s)
                          .ToDictionary(group => group.Key, group => group.Count());
        }

        public static Dictionary<int, string> FilterDictionary(Dictionary<int, string> dictionary, string filter)
        {
            return dictionary.Where(pair => pair.Value.Contains(filter))
                             .ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public static Dictionary<string, int> GetStringLengthDictionary(List<string> strings)
        {
            return strings.ToDictionary(str => str, str => str.Length);
        }

        // 🔄 Collection Manipulations
        public static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            return list1.Concat(list2).ToList();
        }

        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            return array1.Concat(array2).ToArray();
        }

        public static Dictionary<int, string> MergeDictionaries(Dictionary<int, string> dict1, Dictionary<int, string> dict2)
        {
            var merged = new Dictionary<int, string>(dict1);
            foreach (var pair in dict2)
            {
                if (!merged.ContainsKey(pair.Key))
                {
                    merged.Add(pair.Key, pair.Value);
                }
            }
            return merged;
        }

        // 🛠 Collection Transformations
        public static List<int> SquareNumbers(List<int> numbers) => numbers.Select(n => n * n).ToList();
        public static int[] GetSquares(int[] numbers) => numbers.Select(n => n * n).ToArray();
        public static List<string> FilterByLength(List<string> strings, int length) => strings.Where(s => s.Length > length).ToList();









        













        //    public static int Add(int number, int nomer)
        //    {
        //        var res = number + nomer;
        //        return res;
        //    }
        //    public static void multiply(int number, int nomer)
        //    {
        //        var res = number * nomer;
        //        Console.WriteLine($"{res} is multiply result");
        //    }
        //    public static void divide(int number, int nomer)
        //    {
        //        var res = number / nomer;
        //        Console.WriteLine($"{res} is divide result");
        //    }
        //    public static int minus(int number, int nomer)
        //    {
        //        var res = number - nomer;
        //        return res;
        //    }
    }
}
