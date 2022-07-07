//Exerc�cio 2 Lista 6

//Considerar o programa de exemplo sobre Filas (menu.cpp) e adicionar:
//  a)	uma op��o no menu que permita inverter o conte�do da fila.
//  b)	uma op��o que retorne o n�mero de elementos existentes na fila circular.
//  c)	O primeiro elemento da fila
//  d)	O �ltimo elemento da fila

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <Fila.h>
#include <Pilha.h>

using namespace std;

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das Vari�veis 	
	int elem,op,x,i,y;
	struct queue q;
	struct queue q2;
	
	struct Pilha P1;
	struct Pilha P2;

	IniPilha(&P1);
	IniPilha(&P2);

 	inicFila(&q);   /*Inicializa a fila*/
 	inicFila(&q2);  /*Inicializa a fila*/
	op=0;

 	// Loop principal: para sair escolher opcao 4
	while (op!=4)
	{
	 	op=0;
	 	
	 	// Desenhando o menu principal
	  	system("cls"); 
	  	cout << "\n                     Fila Circular  \n\n\n";
	  	cout << "\n                (1) - Insere um elemento na Fila";
	  	cout << "\n                (2) - Remove um elemento da Fila";
	  	cout << "\n                (3) - Imprime a Fila";
	  	cout << "\n                (4) - Para SAIR";
	  	
	  	cout << "\n                (5) - Inverte o conte�do da Fila";
	  	cout << "\n                (6) - Retorna o n�mero de elementos existentes na Fila Circular";
	  	cout << "\n                (7) - O primeiro elemento da fila";
	  	cout << "\n                (8) - O �ltimo elemento da fila";
	  	cout << "\n                Digite sua opcao: ";
	  	cin >> op;
	  	cout << endl;
	
	 	// Recebendo a op��o at� que seja fornecida uma v�lida
	 	while (op<1 || op>8)
	 	{
	 		cout << "Op��o inv�lida! Digite novamente: ";
		 	cin >> op;
	 	}

		// Escolha
		switch (op)
		{
	 		case 1:
	 			if (filaCheia(&q) == 1)
	 			{
	   				cout << "A fila est� cheia!!";
	   				
	  			}
	  			else
	  			{
	  				cout << "Entre com um valor: ";
	  				cin >> elem;
	  				insFila(&q,elem);
	  				cout << "\nValor " << elem << " adicionado!";
	  			}
	    		break;

	    	case 2:
	    		if (filaVazia(&q) == 1)
	 			{
	    			cout << "A fila est� vazia!!";
	  			} else {
	  				x = remFila(&q);
  					cout << "Valor removido: " << x;
				}
	        	break;
	           
	 		case 3:
	 			if (filaVazia(&q) == 1)
	 			{
	    			cout << "A fila est� vazia!!";
	  			}
	  			else
				{
	  				cout << "Conte�do: ";
  					y = guardainicio(&q); // Armazena o �ndice do primeiro elemento da fila
		  			while (!filaVazia(&q))
		 			{
		  				x=remFila(&q);
		  				cout << x << " ";
		 			}
	  				retornainicio(&q,y); // Retorna para o primeiro elemento da fila	 		
				}
	 			break;
	 		
	 		case 4:
	 			exit (1);
	 			break;
	  		
	  		case 5:
	 			if (filaVazia(&q) == 1)
	 			{
	    			cout << "A fila est� vazia!!";
	  			}
	  			else
				{
					// Atribuindo valores da fila para uma falsa fila
					q2 = q;
					
					// Adicionando valores da falsa fila para uma pilha
		 			while (!filaVazia(&q2))
				 	{
				 		x = remFila(&q2);
				 		Push(&P1, x);
				 	}
				 	
				 	cout << "Fila invertida: ";
				 	// Invertendo valores da pilha
				 	P2 = P1;
					while (!pilhavazia(&P2))
					{
						cout << Pop(&P2) << " ";
					}
	
					// Limpando Pilha 1
					while (!pilhavazia(&P1))
					{
						Pop(&P1);
					}		
				}
				break;
			
			case 6:
				if (filaVazia(&q) == 1)
	 			{
	    			cout << "A fila est� vazia!!";
	  			} else {
	  				// Atribuindo valores da fila para uma falsa fila
					q2 = q;
					
					y = 0;
		 			while (!filaVazia(&q2))
				 	{
				 		x = remFila(&q2);
				 		y++;
				 	}
					cout << "Quantidade de valores na fila: " << y;
	  			}	
				break;
			
			case 7:
				if (filaVazia(&q) == 1)
	 			{
	    			cout << "A fila est� vazia!!";
	  			} else {
		  			y=guardainicio(&q); // Armazena o �ndice do primeiro elemento da fila
	
			  		cout  << "Primeiro elemento: " << remFila(&q);
			  			while (!filaVazia(&q))
			 			{
			  				x=remFila(&q);
			 			}
		  			retornainicio(&q,y); // Retorna para o primeiro elemento da fila
				}	
				break;
			
			case 8:
				if (filaVazia(&q) == 1)
	 			{
	    			cout << "A fila est� vazia!!";
	  			} else {
	  				// Atribuindo valores da fila para uma falsa fila
					q2 = q;
					
					// Adicionando valores da falsa fila para uma pilha
		 			while (!filaVazia(&q2))
				 	{
				 		x = remFila(&q2);
				 		Push(&P1, x);
				 	}
				 	
				 	// Invertendo valores da pilha
				 	P2 = P1;
				 	cout << "Ultimo elemento: " << Pop(&P2);
					while (!pilhavazia(&P2))
					{
						Pop(&P2);
					}
	
					// Limpando Pilha 1
					while (!pilhavazia(&P1))
					{
						Pop(&P1);
					}
				}
				break;
	   	}
		cout << endl;
   		system("PAUSE");
   	}
	return 0;
 }


 
