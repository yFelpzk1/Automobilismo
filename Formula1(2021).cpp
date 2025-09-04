#include <iostream>
#include <locale>
#include <string>

using namespace std;

struct Formula1 {
    string Piloto, Construtor;
    float pontosPiloto, pontosConstrutor;
    int Corridas, Sprints;
};

void Ler_Pontos(Formula1 *pPiloto) {
    cout << endl << "Digite quantas corridas tem restantes na temporada: ";
    cin >> pPiloto->Corridas;
    cout << "Digite quantas sprints tem restantes na temporada: ";
    cin >> pPiloto->Sprints;
    cin.ignore();
    cout << "Digite o nome do seu piloto: ";
    getline(cin, pPiloto->Piloto);
    cout << "Digite o nome de sua equipe: ";
    getline(cin, pPiloto->Construtor);
    cout << "Digite quantos pontos tem seu piloto: ";
    cin >> pPiloto->pontosPiloto;
    cout << "Digite quantos pontos tem sua equipe: ";
    cin >> pPiloto->pontosConstrutor;
}

void Contar_Pontos(Formula1 *pPiloto) {
    float pontosPiloto = pPiloto->pontosPiloto + (pPiloto->Corridas * 26) + (pPiloto->Sprints * 3);
    float pontosConstrutor = pPiloto->pontosConstrutor + (pPiloto->Corridas * 44) + (pPiloto->Sprints * 5);

    cout << endl << "A pontuação que " << pPiloto->Piloto << " pode alcançar é de: " << pontosPiloto;
    cout << endl << "A pontuação que " << pPiloto->Construtor << " pode alcançar é de: " << pontosConstrutor;
}

int main() {
    setlocale(LC_ALL, "Portuguese");

    Formula1 Piloto;
    char repetir;

    do {
        Ler_Pontos(&Piloto);
        Contar_Pontos(&Piloto);

        cout << endl << "Deseja repetir o processo? (S/N): ";
        cin >> repetir;
        repetir = toupper(repetir);
        cin.ignore();
    } while (repetir == 'S');

    cout << endl << "O processo foi terminado com sucesso!";
    return 0;
}