using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Polyglot.CSharp
{
    public class TestCaseResult
    {
        public string Input;
        public string Expected;
        public string Result;
    }

    public interface IChallenge
    {
        IEnumerable<TestCaseResult> Run();
    }

    public abstract class Challenge<TInput, TExpected> : IChallenge
    {
        protected abstract IEnumerable<(TInput, TExpected)> TestCases { get; }
        protected abstract TExpected Invoke(TInput input);

        public IEnumerable<TestCaseResult> Run()
        {
            foreach (var testCase in TestCases)
            {
                var (input, expected) = testCase;

                var inputStr =
                    input is ICollection inputList
                        ? string.Join(",", inputList.Cast<object>())
                        : input.ToString();

                var result = Invoke(input);

                yield return new TestCaseResult
                {
                    Input = inputStr,
                    Expected = expected.ToString(),
                    Result = result.ToString()
                };
            }
        }
    }

    public static class Program
    {
        private static void Main()
        {
            foreach (var challenge in new Challenges().GetChallenges())
            {
                Console.WriteLine("");
                Console.WriteLine($"Test: {challenge.GetType().Name}");

                var resultList = challenge.Run().ToList();

                var header = new[]
                {
                    new TestCaseResult
                    {
                        Input = nameof(TestCaseResult.Input),
                        Expected = nameof(TestCaseResult.Expected),
                        Result = nameof(TestCaseResult.Result)
                    },
                    new TestCaseResult
                    {
                        Input = "---",
                        Expected = "---",
                        Result = "---"
                    },
                };

                var getWidth = new Func<Func<TestCaseResult, string>, int>(fn =>
                    resultList
                        .Concat(header)
                        .Select(x => fn(x).Length)
                        .OrderByDescending(x => x)
                        .FirstOrDefault());

                var inputWidth = getWidth(x => x.Input);
                var expectedWidth = getWidth(x => x.Expected);
                var resultWidth = getWidth(x => x.Result);

                foreach (var result in header.Concat(resultList))
                {
                    result.Input = result.Input.PadRight(inputWidth);
                    result.Expected = result.Expected.PadRight(expectedWidth);
                    result.Result = result.Result.PadRight(resultWidth);
                }

                static void PrintLine(TestCaseResult result) => 
                    Console.WriteLine($"{result.Input}\t{result.Expected}\t{result.Result}");

                foreach (var result in header)
                {
                    PrintLine(result);
                }
                
                foreach (var result in resultList)
                {
                    Console.ForegroundColor = 
                        result.Expected.Trim() != result.Result.Trim()
                            ? ConsoleColor.DarkRed 
                            : ConsoleColor.DarkGreen;
                    
                    PrintLine(result);
                    
                    Console.ResetColor();
                }
            }
        }
    }
}
