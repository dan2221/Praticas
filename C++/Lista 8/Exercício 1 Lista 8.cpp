//Exercício 1 Lista 8

// Implementar um programa recursivo em C++  que imprima
// qual o “n” termo da série de fibonaci (1,1,2,3,5,8.....).

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Função recursiva
int fibonacci(int x) {
   if(x == 0){
      return 0;
   } else if(x == 1) {
      return 1;
   } else {
      return (fibonacci(x-1) + fibonacci(x-2));
   }
}

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	int n;
	
	cout << "Digite um valor: ";
	cin >> n;
	cout << endl;
	
	cout << "Termo de fibonacci: " << fibonacci(n);
	
	return 0;
 }
