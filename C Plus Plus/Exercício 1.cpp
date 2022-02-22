// Exercício 1

// Faça um programa que leia dois valores e informe a média entre eles.
// (use float como tipo de dado). 

#include <iostream> // Biblioteca

using namespace std;

int main()
{
	// Variáveis da função
	float v1, v2, m;
	
	// Limpa a tela
	system("CLS");
	
	cout<< "Valor 1:";
	cin >>v1;
	cout <<"Valor 2:";
	cin>>v2;
	
	// Cálculo
	m=(v1+v2)/2;
	
	cout <<"Media=" << m << endl;

	return EXIT_SUCCESS; //pode ser return 0;
} 
