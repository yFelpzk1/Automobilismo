#include <iostream>
#include <locale>
#include <string>
#include <vector>   
#include <cctype>   

using namespace std;

struct Formula1 {
    string Piloto, Construtor;
    float pontosPiloto, pontosConstrutor;
    int Corridas, Sprints;
    
    int posPiloto, posConstrutor;         
    vector<float> pontosRivaisPilotos;     
    vector<float> pontosRivaisConstrutores; 
};

void Ler_Pontos(Formula1 *pPiloto) {
    pPiloto->pontosRivaisPilotos.clear();
    pPiloto->pontosRivaisConstrutores.clear();

    cout << endl << "Digite quantas corridas tem restantes na temporada: ";
    cin >> pPiloto->Corridas;
    cout << "Digite quantas sprints tem restantes na temporada: ";
    cin >> pPiloto->Sprints;
    cin.ignore(); 
    cout << endl << "--- Campeonato de Pilotos ---" << endl;
    cout << "Digite o nome do seu piloto: ";
    getline(cin, pPiloto->Piloto);
    cout << "Digite quantos pontos tem seu piloto: ";
    cin >> pPiloto->pontosPiloto;
    cout << "Digite a posição ATUAL do seu piloto: ";
    cin >> pPiloto->posPiloto;

    if (pPiloto->posPiloto > 1) {
        cout << "--- Digite os pontos dos pilotos a frente ---" << endl;
        for (int i = 1; i < pPiloto->posPiloto; ++i) {
            float pontosRival;
            cout << "Pontos do " << i << "º colocado: ";
            cin >> pontosRival;
            pPiloto->pontosRivaisPilotos.push_back(pontosRival);
        }
    }
    cin.ignore(); 
    cout << endl << "--- Campeonato de Construtores ---" << endl;
    cout << "Digite o nome de sua equipe: ";
    getline(cin, pPiloto->Construtor);
    cout << "Digite quantos pontos tem sua equipe: ";
    cin >> pPiloto->pontosConstrutor;
    cout << "Digite a posição ATUAL da sua equipe: ";
    cin >> pPiloto->posConstrutor;

    if (pPiloto->posConstrutor > 1) {
        cout << "--- Digite os pontos das equipes a frente ---" << endl;
        for (int i = 1; i < pPiloto->posConstrutor; ++i) {
            float pontosRival;
            cout << "Pontos da " << i << "ª colocada: ";
            cin >> pontosRival;
            pPiloto->pontosRivaisConstrutores.push_back(pontosRival); 
        }
    }
}

void Calcular_Resultado(Formula1 *pPiloto) {
    float maxPontosPiloto = pPiloto->pontosPiloto + (pPiloto->Corridas * 25) + (pPiloto->Sprints * 8);
    float maxPontosConstrutor = pPiloto->pontosConstrutor + (pPiloto->Corridas * 43) + (pPiloto->Sprints * 15);

    cout << endl << "-----------------------------------------------" << endl;
    cout << "--- Potencial Máximo (Simulação) ---" << endl;
    cout << "Pontuação máxima que " << pPiloto->Piloto << " pode alcançar: " << maxPontosPiloto << endl;
    cout << "Pontuação máxima que " << pPiloto->Construtor << " pode alcançar: " << maxPontosConstrutor << endl;
    cout << "-----------------------------------------------" << endl;


    int novaPosPiloto = pPiloto->posPiloto; 
    
    for (float pontosRival : pPiloto->pontosRivaisPilotos) {
        if (maxPontosPiloto > pontosRival) {
            novaPosPiloto--; 
        }
    }

    int novaPosConstrutor = pPiloto->posConstrutor; 

    for (float pontosRival : pPiloto->pontosRivaisConstrutores) {
        if (maxPontosConstrutor > pontosRival) {
            novaPosConstrutor--; 
        }
    }

    cout << endl << "--- Resultado da Simulação (se rivais não pontuarem) ---" << endl;
    
    if (pPiloto->posPiloto == 1) {
        cout << pPiloto->Piloto << " já está em 1º lugar!" << endl;
    } else {
        cout << pPiloto->Piloto << " pode matematicamente alcançar a " << novaPosPiloto << "ª posição." << endl;
    }

    if (pPiloto->posConstrutor == 1) {
        cout << pPiloto->Construtor << " já está em 1º lugar!" << endl;
    } else {
        cout << pPiloto->Construtor << " pode matematicamente alcançar a " << novaPosConstrutor << "ª posição." << endl;
    }
}

int main() {
    setlocale(LC_ALL, "Portuguese");

    Formula1 Piloto;
    char repetir;

    do {
        Ler_Pontos(&Piloto);
        Calcular_Resultado(&Piloto); 

        cout << endl << "Deseja repetir o processo? (S/N): ";
        cin >> repetir;
        repetir = toupper(repetir);
        cin.ignore(); 
    } while (repetir == 'S');

    cout << endl << "O processo foi terminado com sucesso!" << endl;
    return 0;
}