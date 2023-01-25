// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.Write("Введите пятизначное число: ");
string number=Console.ReadLine();
if (number.Length==5){
    bool otvet=true;
    for (int i=0;i<=number.Length/2; i++){
        if (Convert.ToInt32(number[i])!=Convert.ToInt32(number[number.Length-i-1])){
            otvet=false;
        }
    }
    if (otvet==true){
        System.Console.WriteLine($"Число {number} является полиндромом");
    } else{
        System.Console.WriteLine($"Число {number} НЕ является полиндромом");
    }
}else{
    System.Console.WriteLine("Длинна числа не соответствует 5");
}