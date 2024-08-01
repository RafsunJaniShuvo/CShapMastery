using AbstractExample;

//Car car=new Car();
//car.Start();        
//car.Stop();

string type = Console.ReadLine();
Vehicle vehicle = GetVehicleType(type);
vehicle.Start();
vehicle.Stop();
Vehicle GetVehicleType(string type){
    if(type == "Car")
    {
        return new Car();
    }else if(type == "Plane")
    {
        return new Plane();
    }
    else
    {
        return null;
    }

}