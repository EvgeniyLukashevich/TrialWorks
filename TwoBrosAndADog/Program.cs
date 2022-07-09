int count = 0;                                                  //количество перебежек собаки от друга к другу
int distance = 10000;                                           //стартовое расстояние между друзьями 10000м
int firstFriendSpeed = 1;                                       //Скорость первого друга 1м/с
int secondFriendSpeed = 2;                                      //Скорость второго друга 2м/с
int dogSpeed = 3;                                               //Скорость собаки 4м/с
int time = 0;                                                   //Стартовое время 0с
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
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;        //вычисляем расстояние между друзьями спустя время, пока собака бежала от друга к другу
    count++;                                                    //Добавляем 1 к количеству пробежек собаки от друга к другу
}

Console.Write("Неудержимый лабрадор пробежит ");
Console.Write(count);
Console.Write(" раз!!!");

