int count = 0;
int distance = 10000;
int firstFriendSpeed = 3;
int secondFriendSpeed = 5;
int dogSpeed = 7;
int time = 0;
int friend = 2;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.Write("Неудержимый лабрадор пробежит ");
Console.Write(count);
Console.Write(" раз!!!");

