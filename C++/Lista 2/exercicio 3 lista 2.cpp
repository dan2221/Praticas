//Exerc�cio 3 da Lista 2

// Efetuar o c�lculo da quantidade de litros de combust�vel gastos em uma viagem.


// output desejado:

// � velocidade m�dia
// � tempo de viagem
// � dist�ncia percorrida
// � litros na viagem

// DIST�NCIA= TEMPO * VELOCIDADE

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	float t, v, d, litros, x;
	
	cout << "Insira o tempo gasto: ";
	cin >> t;
	
	cout << "\nInsira a velocidade m�dia: ";
	cin >> v;
	
	d = t * v;

	cout << "\nInsira a vari�vel de Km/l: ";
	cin >> x;
	
	litros = d / x;
	cout << "----------------------------------------";
	cout << "\nVelocidade M�dia: " << v << endl;
	cout << "Tempo gasto na viagem: " << t << endl;
	cout << "Dist�ncia Percorrida: " << d << endl;
	cout << "Quantidade de Litros Utilizados: " << litros << endl;
	cout << "----------------------------------------";
	
	return 0;
}
