# Classes Abstratas 
Demostra o uso de classes abstratas e suas implementações em um cenario onde esta implementado 2 tipos de animais domesticos e selvagem onde ambos herdam da classe abstrata Animal
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
