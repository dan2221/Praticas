// Exerc�cio 6
/*
Criar um programa que receba um n�mero que corresponda
a um m�s do 1� trimestre e escreva o m�s correspondente;
caso o usu�rio digite o n�mero fora do intervalo dever�
aparecer inv�lido, mas utilizando uma fun��o do tipo void.
*/

// Bibliotecas
#include <iostream>

using namespace std;

// M�todo do tipo void

// A instru��o void significa aus�ncia de retorno.
void EscreverMes(int x)
{
	cout << "--------------------------------" << endl;
	if (!(x >= 1 && x <=6)){
		cout << "valor inv�lido!";
	} else if (x == 1) {
		cout << "Janeiro";
	} else if (x == 2) {
		cout << "Fevereiro";
	} else if (x == 3) {
		cout << "Mar�o";
	} else if (x == 4) {
		cout << "Abril";
	} else if (x == 5) {
		cout << "Maio";
	} else {
		cout << "junho";
	}
	
	// N�o h� return, pois a fun��o � do tipo void!
}


int main()
{	
	// Caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Declara��o de vari�veis
	int numero;
	
	// Inser��o de valor
	cout << "Insira o n�mero do m�s do 1� semestre: ";
	cin >> numero;
	
	// Chamada de m�todo
	EscreverMes(numero);

	return 0; //finalizar programa
}

