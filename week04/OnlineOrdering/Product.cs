using System;
using System.Numerics;



public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantityOfProduct;


    public Product(string name, int productId, double price, int quantityOfProduct )

    {

        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantityOfProduct = quantityOfProduct;

    }

    public double GetTotalCost()
    {
        
        return _price * _quantityOfProduct;

    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantityOfProduct()
    {
        return _quantityOfProduct;
    }









}