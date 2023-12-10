using System.Data;

public class Address
{

    protected string _city;

    protected string _state;

    protected int _zipCode;

    protected string _street;
    




    public  Address(string street, string state, string city, int zipCode) 
    {
        _street =   street;

        _state   =   state;

        _city = city;

        _zipCode = zipCode;
    }
    public string GetAddress()
    {
        return  $"{_street},{_state}, {_zipCode}";

    }
}

