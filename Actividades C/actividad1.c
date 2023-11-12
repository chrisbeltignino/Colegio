#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main() {
int eleccion,operador1,operador2;

/*Empezamos usando un bucle do while para que el programa se ejecute hasta que el usuario seleccione la opcion 5*/ 
do
{
system("CLS"); //Limpia la pantalla en cada nueva operación.

printf("CALCULADORA\n\n");
printf("1. Suma\n");
printf("2. Resta\n");
printf("3. Multiplicacion\n");
printf("4. Division\n");
printf("5. Salir\n\n");

scanf("%d",&eleccion);

/*Usamos un switch como altenativa multiple para ejecutar la parte correspondiente a la elección del usuario*/ 

switch(eleccion)
		{
		    case 1:
		        printf("Introduce un numero: ");
		        scanf("%d",&operador1);
		        printf("Introduce otro numero: ");
		        scanf("%d",&operador2);
				printf("Resultado: %d\n",operador1+operador2);
		    break;
		
		    case 2:
		        printf("Introduce un numero: ");
		        scanf("%d",&operador1);
		        printf("Introduce otro numero: ");
		        scanf("%d",&operador2);
		        printf("Resultado: %d\n",operador1-operador2);
		    break;
		
		    case 3:
		        printf("Introduce un numero: ");
		        scanf("%d",&operador1);
		        printf("Introduce otro numero: ");
		        scanf("%d",&operador2);
		        printf("Resultado: %d\n",operador1*operador2);
		    break;
		
		    case 4:
		        printf("Introduce un numero: ");
		        scanf("%d",&operador1);
		        printf("Introduce otro numero: ");
		        scanf("%d",&operador2);
		
		        /*Ponemos la condicion de que no se pueda dividir entre 0 ya que de lo contrario el programa dará error*/ 
		        if(operador2==0)
		        {
		            printf("No se puede dividir entre 0, intentalo otra  vez...\n ");
		        }
		        else
		        {
		            printf("Resultado: %d\n",operador1/operador2);    
		        }
		    break;
		
		    case 5:
		        printf("Saliendo...\n\n");
		}

system("PAUSE");
/*Cuando el usuario selecciona la opción 5, el bucle termina y se cierra el programa*/

}while(!(eleccion==5));

}
