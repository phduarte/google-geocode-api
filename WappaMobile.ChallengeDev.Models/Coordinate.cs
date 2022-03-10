﻿namespace WappaMobile.ChallengeDev.Models
{
    public struct Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public bool IsEmpty => Latitude == 0 && Longitude == 0;

        public Coordinate(double lat, double lng)
        {
            Latitude = lat;
            Longitude = lng;
        }

        public static Coordinate Empty => new Coordinate(0, 0);

        public override string ToString()
        {
            return $"{Latitude}x{Longitude}";
        }
    }
}
