// Exerc�cio 2

// Fa�a um programa que leia uma temperatura em graus Cent�grados e apresente-a
// convertida em graus Fahrenheit. A f�rmula de convers�o �:
// F = (9 * C + 160) / 5, onde F � a temperatura em Fahrenheit e C em graus Cent�grados.

#include <iostream>
#include<stdlib.h>
using namespace std; 
int main() 
{ 
 float C,F;  
 cout << "Insira a temperatura em graus celsius:";
 cin>>C; 
 F=(9*C+160)/5; 
 cout <<"Fahrenheit=" << F << endl; 
 return 0;
}
