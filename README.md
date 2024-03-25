# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
### 📌 Construindo um Sistema de Hospedagem de um Hotel no C#
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

<br>

## Explicando minhas soluções 😉

*1º TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido.*

```csharp
Hospedes.Count()
```

Utilizei o método *Count()* para contar o número dos hóspedes na minha lista e compará-lo com a capacidade da minha suíte.

```csharp
Suite.Capacidade
```

Na classe *“Suite”* foi criada uma propriedade chamada *“Capacidade”* para receber e armazenar o valor da capacidade de hóspedes da minha suíte. Para poder usá-la no program, basta acrescentá-la como parâmetro construtor na classe *“Suite”* para que desta forma possamos puxá-la na hora da instanciação de *“Suite”* para objeto no program. Sendo assim, ao acrescentar um valor no objeto dentro do espaço reservado para capacidade podemos chamar o *“Suite.Capacidade”* na nossa classe *“Reserva”* e fazermos a comparação proposta.

<br>
<br>


*2º TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido.*

```csharp
throw new Exception("Olá! Infelizmente esta suíte possui limitação para no máximo 3 hóspedes.");
```

O **Throw** é usado para especificarmos uma exceção. Ele pode ser usado dentro do *try catch* para propagar a exceção em um tipo de fila, passando de método a método para que ocorra a resolução *“jogando para cima”*, ou em qualquer lugar do código para interromper sua execução por determinado motivo. Neste caso, conforme proposto usei o *throw* para especificar que não pode ser cadastrado mais que 3 hóspedes na suíte Standard do nosso hotel. 

<br>
<br>


*3ª TODO: Retorna a quantidade de hóspedes (propriedade Hospedes).*

```csharp
return Hospedes.Count();
```

Novamente utilizei o método *Count()* para contar os hóspedes da lista. 

<br>
<br>

*4º TODO: Retorna o valor da diária.* <br>
***Cálculo: DiasReservados X Suite.ValorDiaria***

```csharp
decimal valorDaDiaria = DiasReservados * Suite.ValorDiaria;
```

Usei o tipo *decimal* para armazenar o cálculo de *“DiasReservados * Suite.ValorDiaria”* dentro da variável *valorDaDiaria*. A variável *valorDaDiaria* vai pegar o meu número de *“DiasReservados”* que eu irei incluir lá no meu program dentro da minha lista de Reserva e multiplicar pelo *“Suite.ValorDiaria”*. Tanto o *“DiasReservados”* quanto o *“ValorDiaria”* são propriedades criadas da mesma forma que as outras neste desafio. 

***Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%.***

```csharp
if (DiasReservados >= 10)
{
return valorDaDiaria * 0.90M; 
}
else 
{  
return valorDaDiaria;
} 
```

Para solucionar a última implementação usei o *if* e o *else* comparando meus dias reservados. Se (if) meu número de *DiasReservados* for maior ou igual a 10, ele retorna (aplica) o desconto de 10% em cima do *valorDaDiaria*, senão (else) ele retorna (aplica) o valor do cálculo normal. 

<br>

## 🔎 Detalhes do projeto

📌 Este é um projeto de cunho educacional e faz parte da formação: **".NET Developer"** da DIO.
<br>
<br>

<p align="left">
  Caso queira entrar em contato: ⤵️
</p>

<p align="left">

  
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/adrianycmc/)
</p>

