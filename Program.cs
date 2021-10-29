using System;
using CodingAlgorithms.Amazon;
using CodingAlgorithms.LeetCode.Easy;
using CodingAlgorithms.LeetCode.Hard;
using CodingAlgorithms.LeetCode.Medium;

namespace CodingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var easy = new Easy();
            var medium = new Medium();
                    
            // var twoDMatrix = new TwoDMatrixSearch();
            // int[,] matrix = new int[3,4] {{1,3,5,7},{10,11,16,20},{23,30,34,60}};
            // var found = twoDMatrix.SearchMatrix(matrix, 300);

            // Console.WriteLine(found);

            // var parkingSystem = new ParkingSystem(1, 1, 0);
            // Console.WriteLine(parkingSystem.AddCar(1));
            // Console.WriteLine(parkingSystem.AddCar(2));
            // Console.WriteLine(parkingSystem.AddCar(3));
            // Console.WriteLine(parkingSystem.AddCar(1));

            // var nums = new int[5] {1, 5, 6, 3, 4};
            // var numArray = new NumArray(nums);
            // Console.WriteLine(numArray.SumRange(1,3));
            // numArray.Update(3, 12);
            // Console.WriteLine(numArray.SumRange(0, 4));
            // Console.WriteLine(numArray.SumRange(2, 3));

            // var num = 357;
            // var subProdSum = new SubtractProductAndSum();
            // Console.WriteLine(subProdSum.Calculate(num));

            // var arrayPairsDiv = new ArrayPairsDivisible();
            // arrayPairsDiv.PairFound(new int[4] { 3,8,7,2 }, 10);

            // var plusOne = new PlusOne();
            // int[] nums = {9};
            // nums = plusOne.Solve(nums);
            // plusOne.Diplsay(nums);

            // var addBinary = new AddBinary();
            // string s = addBinary.Solve("1010", "1011");
            // Console.WriteLine(s);

            // var passwordChecker = new PasswordChecker();
            // int violations = passwordChecker.StrongPasswordChecker("aaaabbbbccccddeeddeeddeedd");
            // Console.WriteLine(violations);

            // var fib = new Fibonacci();
            // Console.WriteLine(fib.Sum(7));

            // var stairs = new ClimbStairs();
            // Console.WriteLine(stairs.Calculate(8));

            // Console.WriteLine(easy.Tribonacci(35));

            //Console.WriteLine(medium.LengthOfLongestSubstring("nfpdmpi"));

            // var longestPalindrome = new LongestPalindrome();
            // Console.WriteLine(longestPalindrome.LengthOfLongestPalindrome("borcdubqiupahpwjizjjbkncelfazeqynfbrnzuvbhjnyvrlkdyfyjjxnprfocrmisugizsgvhszooktdwhehojbrdbtgkiwkhpfjfcstwcajiuediebdhukqnroxbgtvottummbypokdljjvnthcbesoyigscekrqswdpalnjnhcnqrarxuufzzmkwizptyvjhpfidgmskuaggtpxqisdlyloznkarxofzeeyvteynluofuhbllyiszszbwnsglqjkignusarxsjvctpgiwnhdufmfpanfwxjwlmhgllzsmdpncbwnsbdtsvrjybynifywkulqnzprcxockbhrhvnwxrkvwumyieazclcviumvormynbryaziijpdinwatwqppamfiqfiojgwkvfzyxadyfjrgmtttvlgkqghgbcfhkigfojjkhskzenlpasyozcsuccdxhulcubsgomvcrbqwakrraesfifecmoztayrdjicypakrrneulfbqqxtrdelggedvloebqaztmfyfkhuonrognejxpesmwgnmnnnamvkxqvzrgzdqtvuhccryeowywmbixktnkqnwzlzfvloyqcageugmjqihyjxhssmhkfzxpzxmgpjgsduogfolnkkqizitbvvgrkczmojxnabruwwzxxqcevdwvtiigwckpxnnxxxdhxpgomncttjutrsvyrqcfwxhexhaguddkiesmfrqfjfdaqbkeqinwicphktffuwcazlmerdhraufbpcznbuipmymipxbsdhuesmcwnkdvilqbnkaglloswcpqzdggnhjdkkumfuzihilrpcvemwllicoqiugobhrwdxtoefynqmccamhdtxujfudbglmiwqklriolqfkknbmindxtljulnxhipsieyohnczddabrxzjmompbtnnxvivmoyfzfrxlufowtqzojfclmatthjtbhotdoheusnpirwicbtyrcuojsdmfcx"));

            // var minMeetingRooms = new MinMeetingRooms();
            // int[][] intervals = new int[3][];
            // //[[3,18],[7,16],[5,18]]
            // intervals[0] = new int[2] {3,18};
            // intervals[1] = new int[2] {7,16};
            // intervals[2] = new int[2] {5,18};
            // Console.WriteLine(minMeetingRooms.Calculate(intervals));

            //var conNumSum = new ConsecutiveNumSum();

            var watch = System.Diagnostics.Stopwatch.StartNew();

            //Console.WriteLine(conNumSum.Calculate2(36152851));
            // the code that you want to measure comes here
            
            //var watch = System.Diagnostics.Stopwatch.StartNew();

            // var missingNumArray = new MissingNumArray();
            // int missing = missingNumArray.Calculate1ToN(new int[] { 1, 2, 5, 4});
            // int missing2 = missingNumArray.Calculate0ToN(new int[] { 2, 1, 3 });
            // Console.WriteLine(missing);
            // Console.WriteLine(missing2);


            // var sumArray = new SumArrayNums();
            // var found = sumArray.TargetFound(new int[] { 5, 7, 1, 3, 2, 8 , 4 }, 10);
            // Console.WriteLine(found);
            // var indices = sumArray.FindIndicesOfTarget(new int[] { 5, 7, 1, 3, 2, 8, 4 }, 10);
            // foreach(int i in indices) Console.Write(i + ",");
            // Console.WriteLine();


            // var validPlanidrome = new ValidPalindrome();
            // Console.WriteLine("Is Palindrome: " + validPlanidrome.IsValid2("ebcbbececabbacecbbcbe"));    

            // var specialArray = new SpecialArray();
            // Console.WriteLine(specialArray.XSpecialArrau(new int[6] { 1,0,0,6,4,9 }));

            // var selfDividingNumbers = new SelfDividingNumbers();
            // var retList = selfDividingNumbers.FindSelfDividingNumbers(1, 22);
            // foreach(int i in retList) Console.Write(i + ",");

            // var perfectNumber = new PerfectNumber();
            // int num = 99999999;
            // Console.WriteLine($"Is perfect number {num}:  {perfectNumber.CheckPerfectNumber(num)}");


            // var primePalindrome = new PrimePalindrome();
            // Console.WriteLine(primePalindrome.FindPrimePalindrome(9989900));     

            // var rankTransformArray = new RankTransformArray();
            // var results = rankTransformArray.TransformArray(new int[20] {7,-10,9,36,43,2,37,44,43,-38,29,-44,19,38,49,-20,19,18,29,-12});

            // foreach(int i in results) Console.Write(i + ","); 

            var townJudge = new FindTownJudge();
            int[][] people = new int[3][];
            people[0] = new int[2] { 1, 3 };
            people[1] = new int[2] { 2, 3 };
            people[2] = new int[2] { 3, 1 };
            Console.WriteLine(townJudge.FindJudge(2, people));

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time:  {elapsedMs}ms");
        }
    }
}
