// Exerc�cio 1

// Fa�a um programa que leia dois valores e informe a m�dia entre eles.
// (use float como tipo de dado). 

#include <iostream> // Biblioteca

using namespace std;

int main()
{
	// Vari�veis da fun��o
	float v1, v2, m;
	
	// Limpa a tela
	system("CLS");
	
	cout<< "Valor 1:";
	cin >>v1;
	cout <<"Valor 2:";
	cin>>v2;
	
	// C�lculo
	m=(v1+v2)/2;
	
	cout <<"Media=" << m << endl;

	return EXIT_SUCCESS; //pode ser return 0;
} 
