// Exercício 3

// Calcular e apresentar o valor do volume de uma lata de óleo,
// utilizando a fórmula: VOLUME = 3.14159 * R^2 * ALTURA.

#include <iostream> // Biblioteca

using namespace std;

int main()
{
	// Variáveis da função
	float volume, raio, altura;
	
	// Limpa a tela
	system("CLS");
	
	cout << "Escreva a Altura da lata: ";
	cin >> altura;
	cout <<"Escreva o raio da lata: ";
	cin >> raio;
	
	// Cálculo
	volume = 3.14159 * (raio*raio) * altura;
	
	cout << "-------------------------------" << endl;
	cout << "Volume da lata de oleo: " << volume << endl;
	cout << "-------------------------------" << endl;
	
	return 0; //pode ser return 0;
} 
