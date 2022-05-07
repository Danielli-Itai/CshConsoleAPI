/****************************************************************\
* This code written by Itai Danielly                             *
* This program is free software: you can redistribute it and/or  *
* modify it under the terms of the GNU General Public License    *
* as published by the Free Software Foundation, either version 3 *
* of the License, or (at your option) any later version.         *
* This program is distributed in the hope that it will be useful *
* but WITHOUT ANY WARRANTY; without even the implied warranty of *
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.           *
* See the GNU General Public License for more details.           *
\****************************************************************/
using System.Text.RegularExpressions;





namespace CshConsoleAPI
{
	public class CStrTrim
	{
		/***
		* Trim left white spaces by replasing with empty string.
		*/
		public static string ltrim(in string s)
		{
			return Regex.Replace(s, "^\\s+", "");
		}

		/***
		* Trim righ white spaces by replasing with empty string.
		*/
		public static string rtrim(in string s)
		{
			return	Regex.Replace(s, "\\s+$", "");
		}

		/***
		* Trim left and right using trim functions.
		*/
		public static string trim(in string s)
		{
			return ltrim(rtrim(s));
		}
	}
}
