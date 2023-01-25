/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double line_length(int[] a,int[] b){
    if (a.Length<3||b.Length<3){
        
        return double.NaN;
    }else{
        return Math.Sqrt(Math.Pow(a[0]-b[0],2)+Math.Pow(a[1]-b[1],2)+Math.Pow(a[2]-b[2],2));
    }
}
void reshenie(int[] a,int[] b)
{
    double d=line_length(a,b);
    if (d==double.NaN){
        System.Console.WriteLine("Координаты введены не верно");
    }else{
        System.Console.WriteLine($"Длинна отрезка от A({a[0]},{a[1]},{a[2]}) до B({b[0]},{b[1]},{b[2]}) составляет "+string.Format("{0:0.##}",d));
    }
}
int[] a={3,6,8};
int[] b={2,1,-7};
reshenie(a,b);
int[] aa={7,-5,0};
int[] bb={1,-1,9};
reshenie(aa,bb);