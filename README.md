# Jogo de Adivinhação

![](https://imgur.com/CpxOS6h.gif)

## Descrição

O **Jogo de Adivinhação** é um jogo simples desenvolvido em C# onde o objetivo é tentar adivinhar um número secreto gerado aleatoriamente. O jogo oferece três níveis de dificuldade, com base no número de tentativas permitidas:

- **Fácil**: 10 tentativas
- **Normal**: 5 tentativas
- **Difícil**: 3 tentativas

A cada tentativa, o jogador tenta adivinhar um número entre 1 e 20. Se o número escolhido for muito alto ou muito baixo, o jogo fornece dicas e ajusta a pontuação do jogador de acordo com a proximidade do chute.

O jogador pode tentar adivinhar o número até que o acerte ou as tentativas se esgotem.

## Tecnologias Usadas

[![My Skills](https://skillicons.dev/icons?i=visualstudio,cs,dotnet,git,github)](https://skillicons.dev)

## Como Executar o Jogo

1. Clone este repositório ou faça o download do código-fonte.
2. Abra o projeto no Visual Studio ou qualquer outro editor compatível com C#.
3. Compile e execute o projeto.
4. O jogo será iniciado no terminal, e você poderá seguir as instruções para jogar.

## Instruções do Jogo

1. Ao iniciar, o jogo perguntará o nível de dificuldade:
    - **Fácil (10 tentativas)**, **Normal (5 tentativas)**, ou **Difícil (3 tentativas)**.
   
2. O jogador deve inserir um número de 1 a 20 para tentar adivinhar o número secreto.
   
3. Caso o jogador já tenha chutado o mesmo número antes, ele será avisado e poderá tentar novamente.
   
4. Cada erro resulta em uma penalidade de pontos, com base na diferença entre o chute e o número secreto.

5. Quando o jogador acerta o número, ele ganha parabéns e o jogo exibe sua pontuação final.

6. Após o final do jogo, o jogador pode optar por continuar jogando.