// Exercício 7

// Faça um programa que apresente a série de Fibonacci
// até o décimo quinto termo. A série é formada pela
// seqüência: 1,1,2,3,5,8,13,21,34,....,etc. 

#include <stdio.h>
#include <iostream>
using namespace std;

int main()
{
  float n1=0,n2=0;
  int loop;
     
  for(n1=1;n1>=0;n1=n1+n2){
    n2=n1-n2;
    loop +=1;
    cout << "serie "<< loop << ": " << n2 << endl;
    if (loop == 15){
    	break;
	}
  }
  return 0;
}
// 0 + 1 = 1
// 1 + 0 = 1
// 1 + 1 = 2
