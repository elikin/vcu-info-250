// Eli Kin
// Assignment 4 - Trip Advisor
// 2/11/2019

using System;
using static System.Console;

namespace TripAdvisor
{
    public class TripAdvisor
    {
        static void Main(string[] args)
        {
            Place o1 = new Place();
            WriteLine("Please enter the values for the location");
            o1.PlaceAddress = GetValue("place address");
            o1.PlaceName = GetValue("place name");
            o1.PlaceDescription = GetValue("place description");
            o1.PlaceRating = double.Parse(GetValue("place rating out of 5"));
            o1.PlaceComment = GetValue("place comment");

            Clear();
            DisplayObject(o1);
            ReadKey();
        }

        static string GetValue(string whichOne)
        {
            WriteLine("Enter the {0}", whichOne);
            return ReadLine();
        }

        static void DisplayObject(Place anyObject)
        {
            Write("\n\n______________________\nPlace Information:\n" + "\tAddress:\t" + anyObject.PlaceAddress + "\n\tName:\t" + anyObject.PlaceName + "\n\tRating:\t " + anyObject.PlaceRating +
                "\n\tDescription:\t" + anyObject.PlaceDescription + "\n\tComment:\t" + anyObject.PlaceComment + "\n______________________\n");
        }
    }

    public class Place
    {
        // fields
        private string placeAddress;
        private string placeName;
        private string placeDescription;
        private double placeRating;
        private string placeComment;

        // constructors
        public Place()
        { }

        public Place(string pN, string pA)
        {
            placeName = pN;
            placeAddress = pA;
        }

        public Place(string pN, string pA, string pD, double pR, string pC)
        {
            placeName = pN;
            placeAddress = pA;
            placeDescription = pD;
            placeRating = pR;
            placeComment = pC;
        }


        // properties
        public string PlaceAddress
        {
            get
            { return placeAddress; }
            set
            { placeAddress = value; }
        }

        public string PlaceName
        {
            get
            { return placeName; }
            set
            { placeName = value; }
        }

        public string PlaceDescription
        {
            get
            { return placeDescription; }
            set
            { placeDescription = value; }
        }

        public double PlaceRating
        {
            get
            { return placeRating; }
            set
            { placeRating = value; }
        }

        public string PlaceComment
        {
            get
            { return placeComment; }
            set
            { placeComment = value; }
        }
    }
}