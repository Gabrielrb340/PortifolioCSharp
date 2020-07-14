# Classes Abstratas e Interfaces
Demostra o uso de classes abstratas e suas implementações em um cenario onde esta implementado 2 tipos de animais ```AnimalDomestico ``` e ``` AnimalSelvagem ``` onde ambos herdam da classe abstrata ```Animal ```, também demostra o uso de interfaces e segregação de interfaces 
# Exemplos de codigo
## Exemplo 1

### Funciona
```C#
AnimalDomestico animal = new Gato("Anakin");
AnimalDomestico animal = new Cachorro("Kako");
```
### Não funciona
```C#
AnimalDomestico animal = new Lobo("Kako");// lobo não herda da classe AnimalDomestico sim da classe AnimalSelvagem
```
## Exemplo 2
Usando a abstração mais generica possivel , porem desta forma perco acesso aos metodos mais especificos
### Funciona
```C#
Animal animal = new Gato("Anakin");
Animal animal = new Cachorro("Kako");
```
### Também funciona
```C#
Animal animal = new Lobo("Kako");//Diferente do exemplo 1 tanto o lobo, cachorro ou gato são animais 
``` 
# Interfaces
Utilizando metodos implementados pela classe via interface
## Exemplo 1
```C#
            IComportamentoPadrao animalComportamentoPadrao = new Cachorro("Nina");
            animalComportamentoPadrao.Brincar(); // Cachorros sabem brincar
            //Mudando a instancia de animalComportamentoPadrao para ser um gato inicialmente erá um cachorro
            animalComportamentoPadrao = new Gato("Apolo");
            animalComportamentoPadrao.Brincar();
```

