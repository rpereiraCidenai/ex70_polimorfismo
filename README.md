
# Sistema de Gestão de Utilizadores numa Loja

Este projeto faz parte das aulas de **Programação de Sistemas de Informação (PSI)** na **Escola Profissional de Serviços de Cidenai**, orientadas pelo professor **Roberto Pereira**. 

O objetivo é implementar um sistema de gestão de utilizadores numa loja, utilizando conceitos de **Programação Orientada a Objetos (POO)**, como **herança** e **polimorfismo**.

---

## Descrição do Problema

A loja possui três tipos de utilizadores:
1. **Gerente** - tem a capacidade de fechar o caixa pode registar vendsa visto que herda de funcionario 
2. **Funcionário** - pode registar vendas,
3. **Cliente** - pode visualizar as suas informações pessoais.

Todos os utilizadores partilham atributos e métodos da classe base **Utilizador**.

---

## Estrutura do Projeto

### Diagrama de Classes

```
+------------------+
|     Utilizador   |
|------------------|
| - Nome           |
| - Senha          |
|------------------|
| + ExibirInfo()   |
+------------------+
        ▲
        |
        +---------------------+
        |                     |
+------------------+    +--------------------+
|     Cliente       |   |   Funcionário      |
|------------------ |   |------------------  |
| - Endereço        |   |                    |
| - Telefone        |   |                    |
|------------------ |   |-----------------   |
| + ExibirInfo()    |   | + RegistrarVenda() |
+------------------+    +--------------------+
                                  ▲
                                  |
                          +------------------+
                          |     Gerente          |
                          |------------------    |
                          |                      |
                          |------------------    |
                          | + FecharCaixa()      |
                          +------------------+
```

### Funcionalidades

1. **Utilizador (Classe Base)**
   - Atributos: Nome, Senha.
   - Método: `ExibirInfo()` - Exibe informações básicas.

2. **Cliente (Subclasse)**
   - Atributos: Endereço, Telefone.
   - Método: `ExibirInfo()` - Exibe informações pessoais.

3. **Funcionário (Subclasse)**
   - Método: `RegistrarVenda()` - Regista vendas realizadas.

4. **Gerente (Subclasse de Funcionário)**
   - Método: `FecharCaixa()` - Realiza o fecho de caixa.

---

## Objetivo

- Implementar as classes de acordo com o diagrama de classes.
- Criar um programa principal com as seguintes ações:
  - Criar um **Cliente** e exibir as suas informações e fechar vendas
  - Criar um **Funcionário** e registar uma venda.
  - Criar um **Gerente** e realizar o fecho de caixa.

---

## Requisitos Técnicos

- **Linguagem:** C#.
- **Conceitos Utilizados:**
  - Herança.
  - Polimorfismo.
  - Reutilização de Código.

---

## Como Executar

1. Clone o repositório:
   ```bash
   git clone 
   ```
2. Abra o projeto num editor C# (ex.: Visual Studio).
3. Compile e execute o programa principal.

---

## Contato

- **Professor:** Roberto Pereira.
- **Disciplina:** PSI.
- **Escola:** Escola Profissional de Serviços de Cidenai.
