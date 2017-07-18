  using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ///creating 3 basic arrays 
            int[] valArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] nameArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            bool[] boolArray = new bool[10];
            for (int i = 0; i < 10; i+= 2){
                boolArray[i] = true;
            }

            ///Multiplication Table
            int[,] mult = new int[10, 10];
            for (int x = 0; x < 10; x++){
                for (int y = 0; y < 10; y ++){
                    mult[x, y] = (x + 1) * (y + 1);

                }
            }

            ///Following code displays the multiplication table
            for (int x = 0; x < 10; x++){
                string display = "[";
                for (int y = 0; y < 10; y++){
                    display += mult[x, y] + ",";
                    //add an extra space for single digit values 
                    if(mult[x,y] < 10 ){
                        display += "";
                    }
                }
                display += "J";
                Console.WriteLine(display);
            }
            ///list of ice cream favors
            List<string> flavors = new List<string>();
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("Rocky Road");
            flavors.Add("Cookie Dough");
            flavors.Add("Neopolotan");
            flavors.Add("Rainbow Sherbet");

            ///output the length of the list
            Console.WriteLine(flavors.Count);

            /// print the 3rd value then remove it 
            Console.WriteLine("the third flavor in the list is" + flavors[2]);
            flavors.RemoveAt(2);
            ///OUtput he updated length of the list of flavors
            Console.WriteLine(flavors.Count);

            ///user dictionary Construction
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            Random rand = new Random();
            foreach(string name in nameArray){
                userInfo[name] = flavors[rand.Next(flavors.Count)];
            }
            ///Looping through info Dictionary
            Console.WriteLine("users and their favor ice cream favors");
            foreach (KeyValuePair<string, string> Info in userInfo){
                Console.WriteLine(Info.Key + "-" + Info.Value);
            }
        }
    }
}
