using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable MemberCanBePrivate.Global MemberCanBeMadeStatic.Global
namespace Polyglot.CSharp
{
    /// Empty2
    public class Empty2 : Challenge<int, int>
    {
        public int Solution(int n)
        {
            return n;
        }

        protected override IEnumerable<(int, int)> TestCases =>
            new List<(int, int)>(new[]
            {
                (0, 0),
                (2, 2),
                (5, 5)
            });

        protected override int Invoke(int input)
        {
            return Solution(input);
        }
    }
    
    /// Empty
    public class Empty : Challenge<int, int>
    {
        public int Solution(int n)
        {
            return n;
        }

        protected override IEnumerable<(int, int)> TestCases =>
            new List<(int, int)>(new[]
            {
                (0, 0),
                (2, 2),
                (5, 5)
            });

        protected override int Invoke(int input)
        {
            return Solution(input);
        }
    }
    
    /// Return letters with odd count
    public class ReturnLettersWithOddCount : Challenge<int, string>
    {
        public string Solution(int n)
        {
            var builder = new StringBuilder(new string('a', n));
            if (n % 2 == 0)
            {
                builder[0] = 'b';
            }

            return builder.ToString();
        }

        protected override IEnumerable<(int, string)> TestCases =>
            new List<(int, string)>(new[]
            {
                (1, "a"),
                (2, "ba"),
                (3, "aaa"),
                (9, "aaaaaaaaa"),
                (10, "baaaaaaaaa")
            });

        protected override string Invoke(int input)
        {
            return Solution(input);
        }
    }

    /// Has any pair that are close to eachother
    public class HasAnyPairCloseToEachother : Challenge<int[], bool>
    {
        public bool Solution(int[] a)
        {
            var indices = Enumerable.Range(0, a.Length).ToArray();
            Array.Sort(a, indices);
            for (var i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] - a[i] == 1)
                {
                    return true;
                }
            }

            return false;
        }

        protected override IEnumerable<(int[], bool)> TestCases =>
            new List<(int[], bool)>(new[]
            {
                (new[] {0}, false),
                (new[] {1, 2}, true),
                (new[] {3, 5}, false),
                (new[] {3, 4, 6}, true),
                (new[] {2, 4, 6}, false)
            });

        protected override bool Invoke(int[] input)
        {
            return Solution(input);
        }
    }

    public class Challenges
    {
        public IEnumerable<IChallenge> GetChallenges() =>
            new IChallenge[]
            {
                new Empty2(),
                // new Empty(),
                // new ReturnLettersWithOddCount(),
                // new HasAnyPairCloseToEachother()
            };
    }
}
