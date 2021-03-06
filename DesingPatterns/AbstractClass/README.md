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
AnimalDomestico animal = new Lobo("Kako");
```
 Lobo não herda da classe ```AnimalDomestico``` sim da classe ```AnimalSelvagem``` 
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
Utilizando metodos implementados pela classe via interface.
Quando utilizamos diretamente a interface para instanciar uma classe apenas podemos utilizar apenas os metodos que este contrato (interface) implementa.
## Exemplo 1
```C#
            IComportamentoPadrao animalComportamentoPadrao = new Cachorro("Nina");
            animalComportamentoPadrao.Brincar(); // Cachorros sabem brincar
            //Mudando a instancia de animalComportamentoPadrao para ser um gato inicialmente erá um cachorro
            animalComportamentoPadrao = new Gato("Apolo");
            animalComportamentoPadrao.Brincar();
```
Mesmo sendo uma instancia de ```Gato``` ou ```Cachorro``` que existem diversos outros metodos apenas podemos utilizar os metodos definidos na interface ``` IComportamentoPadrao ``` pois ela foi o tipo definido.
# Explicações extras
- Quanto mais auto nível for a hierarquia mais simples é refatorar o codigo , porem menos metodos disponiveis teremos tanto para interface quanto para as classes
- Não use níveis altos de hierarquia se for necessario criar conversões

# Diagramas
![Screenshot_1](https://user-images.githubusercontent.com/43249105/87601817-39964980-c6cc-11ea-9aaf-9a5773031f01.png)
![Screenshot_2](https://user-images.githubusercontent.com/43249105/87601846-49ae2900-c6cc-11ea-8762-4cc6e22be6e2.png)

