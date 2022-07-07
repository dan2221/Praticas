//Exercício 3 da Lista 2

// Efetuar o cálculo da quantidade de litros de combustível gastos em uma viagem.


// output desejado:

// • velocidade média
// • tempo de viagem
// • distância percorrida
// • litros na viagem

// DISTÂNCIA= TEMPO * VELOCIDADE

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	float t, v, d, litros, x;
	
	cout << "Insira o tempo gasto: ";
	cin >> t;
	
	cout << "\nInsira a velocidade média: ";
	cin >> v;
	
	d = t * v;

	cout << "\nInsira a variável de Km/l: ";
	cin >> x;
	
	litros = d / x;
	cout << "----------------------------------------";
	cout << "\nVelocidade Média: " << v << endl;
	cout << "Tempo gasto na viagem: " << t << endl;
	cout << "Distância Percorrida: " << d << endl;
	cout << "Quantidade de Litros Utilizados: " << litros << endl;
	cout << "----------------------------------------";
	
	return 0;
}
