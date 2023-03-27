namespace InternetAssignment2.Models
{
	public class Product
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ProductImage { get; set; }
		public decimal VAT { get; set; }
		public Product Products { get; set; }

	}
}
