using System;
using System.Collections;

namespace Exercise
{
    class HashtableDemo
    {
        static void RunDemo()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add("Name","One"); //adding a key/value using the Add() method
            numberNames.Add(2,"Two");
            numberNames.Add(3,"Three");

//The following throws run-time exception: key already added.
//numberNames.Add(3, "Three"); 

foreach(DictionaryEntry de in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            
       System.Console.WriteLine("Starting");

       
        }
       
            
        
    }
}