using System;
using System.Collections.Generic;

public class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}   {_city}   {_state}   {_country} ";
    }


    
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }  

    







}