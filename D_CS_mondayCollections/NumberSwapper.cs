/*
Create a program that organizes the strings given by the user! Use the ArrayList collection!
Create a program that shows the integers - given by the user - in reverse sequence! Use Stack to change the sequence!
Create a program that changes the written numbers in a text to numerals ( e.g.: “three” - 3) The string and the numerical pairs should be stored in a Dictionary type!
Create your own generic storage to solve the problem described in Task 1.!
Create a generic LinkedList, wherein the elements contains three different types of value (the generic type has three type parameter)!
*/

using System;
using System.Collections.Generic;

namespace NumberSwapper {
	internal class NumberSwapper {

		private static readonly char[] Delimiters = {' ', ',', '.', ':', ';', '!', '?', '/', '-'};
		private readonly Dictionary<int, string> _numPairs = new Dictionary<int, string> {
			{0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"},
			{5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"} };

		private static string SwapNumsToNames(string textToChange) {
			foreach (char c in textToChange) {
				if (textToChange[textToChange.IndexOf(c)].Equals(' ')) {

				}
			}
			return ""; }

		private static void Main(string[] args) {
		}
	}
}
