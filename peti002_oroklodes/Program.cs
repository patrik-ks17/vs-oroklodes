// See https://aka.ms/new-console-template for more information

using peti002_oroklodes;

Allat a1 = new("Bimbó");
Allat a2 = new("Antenna", 5, 13);

a1.mozog(10, 8);
a2.mozog(-4, 6);

Kutya k1 = new("Bodri");
Macska m1 = new("Cirmi", 4, 6);

k1.ugat();
m1.nyavog();

Papagaj p1 = new("Pap");
Banyaszpapagaj p3D = new("Peti", 6, 8, 2);

p1.mozog(5, 8);
p1.mozog(-1, 2, 4);

p3D.mozog(-2, 2, -5);

Console.ReadKey();