// Exercício 2

// Faça um programa que leia uma temperatura em graus Centígrados e apresente-a
// convertida em graus Fahrenheit. A fórmula de conversão é:
// F = (9 * C + 160) / 5, onde F é a temperatura em Fahrenheit e C em graus Centígrados.

// Bibliotecas
#include <iostream>
#include<stdlib.h>
using namespace std; 


int main() 
{
 // Definição de Variáveis
 float C,F;
 
 // Print de frase
 cout << "Insira a temperatura em graus celsius:";
 
 // Input
 cin >> C;
 
 // Cálculo
 F = (9 * C + 160) / 5;
 
 // Output do resultado
 cout <<"Fahrenheit=" << F << endl; 
 return 0;
}
