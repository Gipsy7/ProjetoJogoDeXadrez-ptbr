# Jogo de Xadrez no console

Partida de xadrez para dois jogadores no terminal, escrita em C# com orientação a objetos.

> Projeto de estudo (fevereiro/2022), feito para praticar encapsulamento, herança, polimorfismo, classes abstratas e exceções personalizadas.

## Funcionalidades

- Tabuleiro desenhado no console, com as peças pretas em destaque
- Ao escolher a peça de origem, as **casas possíveis ficam marcadas** no tabuleiro
- Movimentos de todas as peças: rei, dama, torre, bispo, cavalo e peão
- Controle de **turno**, jogador atual e **peças capturadas** por cor
- Detecção de **xeque** e **xeque-mate** (fim de partida com o vencedor)
- Impede jogadas que deixam o próprio rei em xeque
- Jogadas especiais: **roque** pequeno e grande, **en passant** e **promoção** do peão

## Como jogar

Informe as casas em notação de xadrez, coluna e linha:

```
Origem: e2
Destino: e4
```

## Estrutura

```
Xadrez-console/
├── Tabuleiro/      Camada genérica: tabuleiro, posição, peça abstrata, cor e exceção
├── Xadrez/         Regras do xadrez: partida, posição em notação de xadrez
│   └── Pecas/      Rei, Dama, Torre, Bispo, Cavalo e Peão
├── Tela.cs         Desenho do tabuleiro e leitura das jogadas
└── Program.cs      Laço principal da partida
```

## Como executar

Pré-requisito: SDK do .NET Core 3.1 (ou ajuste o `TargetFramework` para uma versão instalada).

```bash
dotnet run --project Xadrez-console
```

---

Feito por **Mikael Francisco** · [Portfólio](https://mikaelfrancisco.vercel.app) · [LinkedIn](https://www.linkedin.com/in/mikael-francisco-a4300b180)
