using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }

        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in products)
        {
            packingLabel += "Product ID: " + product.ProductId + ", Name: " + product.Name + "\n";
        }

        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += "Customer Name: " + customer.Name + "\n";
        shippingLabel += "Address: " + customer.Address.GetFullAddress() + "\n";

        return shippingLabel;
    }
}