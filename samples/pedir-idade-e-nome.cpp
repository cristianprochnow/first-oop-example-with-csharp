#include <iostream>
#include <string>

// Verificador de idades, para definir uma mensagem para cada idade.
main()
{
	int age;
	std::string name;
	
	std::cout << "Qual seu nome? \n";
	std::getline(std::cin, name);
	fflush(stdin);
	
	std::cout << "Qual a sua idade? \n";
	std::cin >> age;
	fflush(stdin);
	
	if (age < 18) {
		std::cout << "Ainda muito jovem, meu cumpadi. Vai pra casa!";
	}
	else if (age >= 18 && age < 60) {
		std::cout << "Aí simmmmm!";
	}
	else {
		std::cout << "Vish...";
	}
	
	return 0;
}
