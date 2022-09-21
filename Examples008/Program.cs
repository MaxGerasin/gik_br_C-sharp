// Найти наибольшее из 9 чиел

int a1 = 12;
int b1 = 23;
int a2 = 45;
int b2 = 44;
int a3 = 11;
int b3 = 76;
int a4 = 75;
int b4 = 33;
int c4 = 35;

int max = a1;
if (b1 > max) max = b1;
if (a2 > max) max = a2;

if (b2 > max) max = b2;
if (a3 > max) max = a3;

if (b3 > max) max = b3;
if (a4 > max) max = a4;

if (b4 > max) max = b4;
if (c4 > max) max = c4;

Console.WriteLine(max);

