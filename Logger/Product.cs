using System;
namespace Logger
{
	public record class Product(string Name, double Price, string Description)
	{
		public string Name { get; init; } = Name?? throw new ArgumentNullException(nameof(Name));
		public double Price { get; set; } = Price;
	}
	public bool Equals(Product? other) //=> (Id, Name) == (other Id, other Name);
	public override int GetHashCode()
	{
		return  (Id,Name).GetHashCode();
	}
	#if NOTSEALED
	public record class SuperProduct(string Name, double Price, string? Description,double Discount):
		Product(Id: 42,Name, Price, Description)
	{



	}

}

