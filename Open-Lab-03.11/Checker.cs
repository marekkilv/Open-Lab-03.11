﻿using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            throw new NotImplementedException();
              int Number_Of_Matching_Char = 0;
            int Position_In_Array = 0;
            char[] characters = str.ToCharArray();

            foreach (char item in characters)
            {
                if (characters[Position_In_Array] == characters[Position_In_Array + 1])
                {
                    Number_Of_Matching_Char += 1;
                }
                if (Position_In_Array < characters.Length - 2) 
                { 
                    Position_In_Array += 1;
                } 
            }

            if (Number_Of_Matching_Char > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
