﻿Console.WriteLine("введите номер дня недели");
int nomer = Convert.ToInt32(Console.ReadLine());

// if (nomer < 1 || nomer > 7)
// {
//     Console.WriteLine("нет такого дня недели");
// }
// else
// {
//     if (nomer == 1)
//     {
//         Console.WriteLine("понедельник");
//     }
//     if (nomer == 2)
//     {
//         Console.WriteLine("вторник");
//     }
//     if (nomer == 3)
//     {
//         Console.WriteLine("среда");
//     }
//     if (nomer == 4)
//     {
//         Console.WriteLine("четверг");
//     }
//     if (nomer == 5)
//     {
//         Console.WriteLine("пятница");
//     }
//     if (nomer == 6)
//     {
//         Console.WriteLine("суббота");
//     }
//     if (nomer == 7)
//     {
//         Console.WriteLine("воскресенье");
//     }
// }

switch (nomer)
{
    case 1:
        {
            Console.WriteLine("понедельник");
            break;
        }
    case 2:
        {
            Console.WriteLine("вторник");
            break;
        }
    case 3:
        {
            Console.WriteLine("среда");
            break;
        }
    case 4:
        {
            Console.WriteLine("четверг");
            break;
        }
    case 5:
        {
            Console.WriteLine("пятница");
            break;
        }
    case 6:
        {
            Console.WriteLine("суббота");
            break;
        }
    case 7:
        {
            Console.WriteLine("воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine("нет такого дня недели");
            break;
        }
}