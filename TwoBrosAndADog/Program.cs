int count = 0;                                                  //количество перебежек собаки от друга к другу
double distance = 10000;                                           //стартовое расстояние между друзьями (м)
double firstFriendSpeed = 1.08;                                       //Скорость первого друга (м/с)
double secondFriendSpeed = 1.15;                                      //Скорость второго друга (м/с)
double dogSpeed = 2.25;                                               //Скорость собаки (м/с)
double time = 0;                                                   //Стартовое время (с)
int friend = 2;                                                 //Собака бежит к другу2 от друга1

while(distance > 10)                                            //пока расстояние между друзьями не станет меньше 10м
{
    if(friend == 1)                                             //Если собака бежит к другу1
    {
        time = distance / (firstFriendSpeed + dogSpeed);        //вычисляем время за которое собака добежала до друга1
        friend = 2;                                             //меняем друга, к которому бежит собака
    }
    else                                                        //иначе (собака бежит к другу2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);       //вычисляем время, за которое собака пробежала до друга2
        friend = 1;                                             //меняем друга
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;        //вычисляем расстояние между друзьями спустя время, которое собака бежала от друга к другу
    count++;                                                    //Добавляем 1 к количеству пробежек собаки от друга к другу
}

Console.Write("Неудержимый лабрадор пробежит ");
Console.Write(count);
Console.Write(" раз!!!");

