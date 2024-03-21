using BT6._3;

List<Car> cars = new List<Car>()
{
    new Car ("Toyota","Red"),
    new Car ("Suzuki","Blue"),
    new Car ("Ford","Red"),
    new Car ("Honda","Yellow"),
    new Car ("Hyundai","Black"),
    new Car ("Isuzu","Red"),
    new Car ("KIA","White"),
    new Car ("Mercedes Benz","Black"),
    new Car ("BMW","Red"),
    new Car ("Volkswagen","Yellow"),
};
int demCar = cars.Count;
for (int i = 0; i < demCar; i++)
{
    if (cars[i].color.IndexOf("Red") > -1)
    {
        cars.RemoveAt(i);
        i--;
        demCar--;
    }
}
foreach(var car in cars)
{
    Console.WriteLine(car);
}    