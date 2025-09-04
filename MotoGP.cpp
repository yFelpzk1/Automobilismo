#include <iostream>
#include <locale>
#include <string>

using namespace std;

struct MotoGP {
    string Piloto, Construtor;
    float pontosPiloto, pontosConstrutor;
    int Corridas;
};

void Ler_Pontos(MotoGP *pPiloto) {
    cout << endl << "Digite quantas corridas tem restantes na temporada: ";
    cin >> pPiloto->Corridas;
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

void Contar_Pontos(MotoGP *pPiloto) {
    float pontosPiloto = pPiloto->pontosPiloto + (pPiloto->Corridas * 37);
    float pontosConstrutor = pPiloto->pontosConstrutor + (pPiloto->Corridas * 66);

    cout << endl << "A pontuação que " << pPiloto->Piloto << " pode alcançar é de: " << pontosPiloto;
    cout << endl << "A pontuação que " << pPiloto->Construtor << " pode alcançar é de: " << pontosConstrutor;
}

int main() {
    setlocale(LC_ALL, "Portuguese");

    MotoGP Piloto;
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