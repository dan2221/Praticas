// Exerc�cio 3

// Calcular e apresentar o valor do volume de uma lata de �leo,
// utilizando a f�rmula: VOLUME = 3.14159 * R^2 * ALTURA.

#include <iostream> // Biblioteca

using namespace std;

int main()
{
	// Vari�veis da fun��o
	float volume, raio, altura;
	
	// Limpa a tela
	system("CLS");
	
	cout << "Escreva a Altura da lata: ";
	cin >> altura;
	cout <<"Escreva o raio da lata: ";
	cin >> raio;
	
	// C�lculo
	volume = 3.14159 * (raio*raio) * altura;
	
	cout << "-------------------------------" << endl;
	cout << "Volume da lata de oleo: " << volume << endl;
	cout << "-------------------------------" << endl;
	
	return 0; //pode ser return 0;
} 
