int  Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > arg1) result = arg2;
    if(arg3 > arg2) result = arg3;
    return  result;
}

int a1 = 12;
int b1 = 23;
int c1 = 45;
int a2 = 44;
int b2 = 11;
int c2 = 76;
int a3 = 75;
int b3 = 33;
int c3 = 35;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);