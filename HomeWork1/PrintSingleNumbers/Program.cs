

int inputvalue = int.parse(console.readline());

bool isprime = true;

if (inputvalue < 2)
{
    isprime = false;
}
else if (inputvalue == 2)
{
    isprime = true;
}
else if (inputvalue % 2 == 0)
{
    isprime = false;
}
else
{
    int divisor = 3;
    while (divisor <= math.sqrt(inputvalue))
    {
        if (inputvalue % divisor == 0)
        {
            isprime = false;
            break;
        }
        divisor += 2;
    }


}

if (isprime)
{
    console.writeline("the prime number");
}
else
{
    console.writeline("not a prime number");
}
