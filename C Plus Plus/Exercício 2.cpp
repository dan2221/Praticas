// Exercício 2

// Faça um programa que leia uma temperatura em graus Centígrados e apresente-a
// convertida em graus Fahrenheit. A fórmula de conversão é:
// F = (9 * C + 160) / 5, onde F é a temperatura em Fahrenheit e C em graus Centígrados.

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
