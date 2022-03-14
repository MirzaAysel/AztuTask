using System;


namespace AztuTask
{  

internal class Phone
{
    public string name;
    public string producer;
    public int year;
    public string version;
    public string color;
    public string ram;

    public Phone(string name, string producer, int year)
    { 
        this.name = name;
        this.producer = producer;
        this.year = year;
              
    }


    public Phone(string name, string producer,int year, string version, string color) : this (name, producer, year)
    {
        this.version = version;
        this.color = color;
    }

    public Phone(string name, string producer,int year, string version, string color, string ram): this (name,producer, year, version,color)
    {
        this.ram = ram;
    }
  }
}