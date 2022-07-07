// Exercício 6
/*
Criar um programa que receba um número que corresponda
a um mês do 1º trimestre e escreva o mês correspondente;
caso o usuário digite o número fora do intervalo deverá
aparecer inválido, mas utilizando uma função do tipo void.
*/

// Bibliotecas
#include <iostream>

using namespace std;

// Método do tipo void

// A instrução void significa ausência de retorno.
void EscreverMes(int x)
{
	cout << "--------------------------------" << endl;
	if (!(x >= 1 && x <=6)){
		cout << "valor inválido!";
	} else if (x == 1) {
		cout << "Janeiro";
	} else if (x == 2) {
		cout << "Fevereiro";
	} else if (x == 3) {
		cout << "Março";
	} else if (x == 4) {
		cout << "Abril";
	} else if (x == 5) {
		cout << "Maio";
	} else {
		cout << "junho";
	}
	
	// Não há return, pois a função é do tipo void!
}


int main()
{	
	// Caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Declaração de variáveis
	int numero;
	
	// Inserção de valor
	cout << "Insira o número do mês do 1º semestre: ";
	cin >> numero;
	
	// Chamada de método
	EscreverMes(numero);

	return 0; //finalizar programa
}

