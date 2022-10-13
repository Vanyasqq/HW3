int coordinates(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

double DistanceSearch(int Xa, int Xb,int Ya, int Yb, int Za, int Zb)
{
    double result = Math.Sqrt(Math.Pow(Xa +Xb, 2) + Math.Pow(Ya +Yb, 2) + Math.Pow(Za +Zb, 2));
    return result;
}


int Xa = coordinates("Введите координаты точки A по X");
int Ya = coordinates("Введите координаты точки A по Y");
int Za = coordinates("Введите координаты точки A по Z");
int Xb = coordinates("Введите координаты точки B по X");
int Yb = coordinates("Введите координаты точки B по Y");
int Zb = coordinates("Введите координаты точки B по Z");



Console.WriteLine(DistanceSearch(Xa, Xb, Ya, Yb, Za, Zb));