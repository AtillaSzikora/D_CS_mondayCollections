// Create a program that changes the written numbers in a text to numerals ( e.g.: “three” - 3)
// The string and the numerical pairs should be stored in a Dictionary type!

using System;
using System.Collections.Generic;

namespace NumberSwapper {
	internal class NumberSwapper {

		private static readonly Dictionary<string, string> NumPairs = new Dictionary<string, string> {
			{"0", "zero"}, {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"},
			{"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"} };

		private static string SwapNumsToNames(string textToChange) {
			string changedText = "";
			foreach (var numPair in NumPairs) { changedText = textToChange.Replace(numPair.Value, numPair.Key); }
			return changedText; }

		private static void Main(string[] args) {
			Console.WriteLine(SwapNumsToNames("zero,one two.three-zero:four;five/zero?six")); }
	}
}