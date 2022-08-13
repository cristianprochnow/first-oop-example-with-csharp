#include <stdio.h>

// Verificador de idades, para definir uma mensagem para cada idade.
int main()
{
	int age;
	char name[0];
	
	printf("Qual seu nome? \n");
	gets(name);
	fflush(stdin);
	
	printf("Qual a sua idade? \n");
	scanf("%i", &age);
	fflush(stdin);
	
	if (age < 18) {
		printf("Ainda muito jovem, mu cumpadi. Vai pra casa!");
	}
	else if (age >= 18 && age < 60) {
		printf("Aí simmmmm!");
	}
	else {
		printf("Vish...");
	}
	
	return 0;
}
