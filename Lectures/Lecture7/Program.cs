﻿void FindWords (string alphabet, char[] word, int length =0 )

{
    if (length==word.Length)
    {
        Console.WriteLine(word); return; 
    }
    else 
    {
        for (int i=0; i<alphabet.Length; i++)
        {
            word[length]=alphabet[i];
            FindWords(alphabet, word, length+1);
        }  
        
    }
}
FindWords("абвг", new char[3]);