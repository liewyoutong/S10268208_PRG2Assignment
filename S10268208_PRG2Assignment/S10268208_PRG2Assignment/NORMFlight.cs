﻿//==========================================================
// Student Number : S10268208B
// Student Name : Gao Yu Hao
// Partner Name : Liew You Tong
//==========================================================
class NORMFlight : Flight
{
    public NORMFlight(string flightNumber, string origin, string destination, DateTime expectedTime)
        : base(flightNumber, origin, destination, expectedTime)
    {

    }


    public override double CalculateFees()
    {
        return base.CalculateFees();
    }
    public override string ToString()
    {
        return $"Flight Number: {FlightNumber}\n" +
               $"Origin: {Origin}\n" +
               $"Destination: {Destination}\n" +
               $"Expected Time: {ExpectedTime}\n";
    }
}