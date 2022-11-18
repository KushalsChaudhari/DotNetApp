namespace WebApp.Services;

public class SimpleInterest : IInterest
{
    public double SI(int p, int n , float r)=> p * n * r / 100;
}