


double value;
string typeinput;
string typeresult;

Console.WriteLine("Hi, please input your number value.");

value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What kind of value is this: kelvin, celsius or fahrenheit?");

typeinput =Console.ReadLine();
typeinput = typeinput.ToLower();

if (typeinput=="kelvin")
{
    Console.WriteLine("What do you want to convert this into: celsius or fahrenheit?");
}
else if(typeinput=="celsius")
{
    Console.WriteLine("What do you want to convert this into: kelvin or fahrenheit?");
}
else if(typeinput=="fahrenheit")
{
    Console.WriteLine("What do you want to convert this into: kelvin or celsius?");
}
else
{
    Console.WriteLine("I don't know that type.");
}


typeresult = Console.ReadLine();
typeresult = typeresult.ToLower();


if (typeresult=="kelvin"||"kelvin".StartsWith(typeresult))
{
    double convertedToKelvin = convertToKelvin(value, typeinput);
    Console.WriteLine("This value converted to kelvin is " + convertedToKelvin);
}
else if(typeresult=="celsius"||"celsius".StartsWith(typeresult))
{
    double convertedToCelsius = convertToCelsius(value, typeinput);
    Console.WriteLine("This value converted to celsius is " + convertedToCelsius);
}
else if(typeresult=="fahrenheit"||"fahrenheit".StartsWith(typeresult))
{
    double convertedToFahrenheit = convertToFahrenheit(value, typeinput);
    Console.WriteLine("This value converted to fahrenheit is " + convertedToFahrenheit);
}
else
{
    Console.WriteLine("Sorry, I can not do that.");
}
    












double convertToFahrenheit(double valuenumber, string typedegrees)
{
    if (typedegrees == "kelvin")
    {
        double kelvin = (valuenumber - 273.15) * 9 / 5 + 32;
        return kelvin;
    }
    else if (typedegrees == "celsius")
    {
        double celsius = (valuenumber * 9 / 5) + 32;
        return celsius;
    }
    else
    {
        return 0;
    }
}







double convertToCelsius(double valuenumber, string typedegrees)
{
    if (typedegrees == "kelvin")
    {
        double kelvin = valuenumber -273.15;
        return kelvin;
    }
    else if (typedegrees == "fahrenheit")
    {
        double fahreinheit = (valuenumber-32)*5/9;
        return fahreinheit;
    }
    else
    {
        return 0;
    }
}






double convertToKelvin(double valuenumber, string typedegrees)
{
    if (typedegrees == "celsius")
    {
        double celsius = valuenumber + 273.15;
        return celsius;
    }
    else if(typedegrees =="fahrenheit")
    {
        double fahreinheit = (valuenumber - 32) * 5 / 9 + 273.15;
        return fahreinheit;
    }
    else
    {
        return 0;
    }

}
