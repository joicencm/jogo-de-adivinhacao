# Jogo de Adivinha��o

![](https://imgur.com/CpxOS6h.gif)

## Descri��o

O **Jogo de Adivinha��o** � um jogo simples desenvolvido em C# onde o objetivo � tentar adivinhar um n�mero secreto gerado aleatoriamente. O jogo oferece tr�s n�veis de dificuldade, com base no n�mero de tentativas permitidas:

- **F�cil**: 10 tentativas
- **Normal**: 5 tentativas
- **Dif�cil**: 3 tentativas

A cada tentativa, o jogador tenta adivinhar um n�mero entre 1 e 20. Se o n�mero escolhido for muito alto ou muito baixo, o jogo fornece dicas e ajusta a pontua��o do jogador de acordo com a proximidade do chute.

O jogador pode tentar adivinhar o n�mero at� que o acerte ou as tentativas se esgotem.

## Tecnologias Usadas

[![My Skills](https://skillicons.dev/icons?i=visualstudio,cs,dotnet,git,github)](https://skillicons.dev)

## Como Executar o Jogo

1. Clone este reposit�rio ou fa�a o download do c�digo-fonte.
2. Abra o projeto no Visual Studio ou qualquer outro editor compat�vel com C#.
3. Compile e execute o projeto.
4. O jogo ser� iniciado no terminal, e voc� poder� seguir as instru��es para jogar.

## Instru��es do Jogo

1. Ao iniciar, o jogo perguntar� o n�vel de dificuldade:
    - **F�cil (10 tentativas)**, **Normal (5 tentativas)**, ou **Dif�cil (3 tentativas)**.
   
2. O jogador deve inserir um n�mero de 1 a 20 para tentar adivinhar o n�mero secreto.
   
3. Caso o jogador j� tenha chutado o mesmo n�mero antes, ele ser� avisado e poder� tentar novamente.
   
4. Cada erro resulta em uma penalidade de pontos, com base na diferen�a entre o chute e o n�mero secreto.

5. Quando o jogador acerta o n�mero, ele ganha parab�ns e o jogo exibe sua pontua��o final.

6. Ap�s o final do jogo, o jogador pode optar por continuar jogando.