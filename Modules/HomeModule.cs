using Nancy;
using Automobile.Objects;
using System.Collections.Generic;

namespace Automobile
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["new-model"], Request.Form["new-price"], Request.Form["new-mile"]);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
