namespace Entities.RequestParameters;

public class ProductParameters
{
    public decimal Min { get; set; }
    public decimal Max { get; set; }

    public bool IsValid => Max >= Min;
}