using System.Collections.Generic;

namespace Car.Objects
{
  public class Car
  {
    private string _Model;
    private int _Price;
    private int _Mile;

    public Car (string newModel, int newPrice, int newMile)
    {
      _Model = newModel;
      _Price = newPrice;
      _Mile = newMile;
    }

    public string GetModel()
    {
      return _Model;
    }

    public void SetModel(string newModel)
    {
      _Model = newModel;
    }

    public int GetPrice()
    {
      return _Price;
    }

    public void SetPrice(int newPrice)
    {
      _Price = newPrice;
    }

    public int GetMile()
    {
      return _Mile;
    }

    public void SetMile(int newMile)
    {
      _Mile = newMile
    }




    private static List<string> _instances = new Car<string> {};

    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_description);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
