// Exerc�cio 7

// Fa�a um programa que apresente a s�rie de Fibonacci
// at� o d�cimo quinto termo. A s�rie � formada pela
// seq��ncia: 1,1,2,3,5,8,13,21,34,....,etc. 

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
