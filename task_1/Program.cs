Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2){
    Console.WriteLine("Максимальное первое число " + num1);
}
else if (num2>num1){
    Console.WriteLine("Максимальное второе число " + num2);
}
if (num1<num2){
    Console.WriteLine("Минимальное первое число " + num1);
}
else if (num2<num1){
    Console.WriteLine("Минимальное второе число " + num2);
}
