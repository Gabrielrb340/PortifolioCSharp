# Classes Abstratas e Interfaces
Demostra o uso de classes abstratas e suas implementações em um cenario onde esta implementado 2 tipos de animais ```AnimalDomestico ``` e ``` AnimalSelvagem ``` onde ambos herdam da classe abstrata ```Animal ```, também demostra o uso de interfaces e segregação de interfaces 
# Exemplos de codigo
## Exemplo 1

### Funciona
```C#
AnimalDomestico animal = new Gato("Anakin");
AnimalDomestico animal = new Cachorro("Kako");
```
### Não Funciona
```C#
AnimalDomestico animal = new Lobo("Kako"); lobo não herda da classe AnimalDomestico sim da classe AnimalSelvagem
```
## Exemplo 2
Usando a abstração mais generica possivel , porem desta forma perco acesso aos metodos mais especificos
### Funciona
```C#
Animal animal = new Gato("Anakin");
AnimalDomestico animal = new Cachorro("Kako");
```
### Também Funciona
```C#
Animal animal = new Lobo("Kako");Diferente do exemplo tanto o lobo, cachorro ou gato são animais 
