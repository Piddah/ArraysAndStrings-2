
ProductPresentation(ProductBackend());



string ProductBackend()
{
    string[] products = ["Milk", "Yoghurt", "Cream", "Cottage Cheese"];
    string stringOfProducts = "";

    foreach (string product in products)
    {
        stringOfProducts += product + " ";
    }
    return stringOfProducts;
}

void ProductPresentation(string product)
{
    string[] productsArray = product.Split(" ");

    foreach (string p in productsArray)
    {
        Console.WriteLine(p);
    }
}