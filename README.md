![SpaceInvadersphoto](https://github.com/Saramiss7/Camel_Race/raw/main/Camel.png?raw=true)
## 🚀 DESCRIPTION (ENGLISH)

# Camel Race in C#

**Camel Race** is a game developed in **C#** that simulates an exciting camel race, inspired by the popular fair game. The objective is for each camel to move across the race track in a random manner, with different behaviors depending on the type of camel. The player controls one of the camels, while the other camels follow predefined behaviors, making the race unpredictable and challenging.

## Main Features

- **Turn-based race**: Camels move in turns, and the game does not end until all camels have moved.
- **Varied camel behaviors**: Each camel has a different way of advancing, making each race unique and exciting.
- **Player controls**: The player controls one camel and must make strategic decisions about how to advance, while other camels follow predefined behaviors.
- **Race track**: The goal is to move from the left side of the track to the finish line on the right side. Each camel has its own lane.
- **Competition**: Camels not controlled by the player have specific behaviors that affect their speed and movement.

## Camel Behaviors

Each camel has a unique behavior that determines how it advances in the race. Here are the different types of camels:

1. **Normal Camel**:  
   The player controls a camel and must simulate the tossing of a ball to determine how many pixels it will advance. The ball has a random value that determines how many positions the camel moves each round.

2. **Sprinter Camel**:  
   This camel advances quickly when it rolls high numbers (e.g., the top 70% of numbers). If it rolls a high number, it will move double the pixels, but if it rolls a low number, it will only advance by that number of pixels.

3. **Endurance Camel**:  
   These camels have a more conservative strategy and always move 1 or 2 positions per turn.

4. **Anti-Odd Camel**:  
   This camel only advances if the number rolled is even. If it rolls an odd number, it will only move 1 position.

5. **Flip Camel**:  
   This camel is unpredictable. It moves one position forward, but then moves one position backward. This alternating movement can create unusual situations during the race.

6. **Cheating Camel**:  
   This camel has a more "aggressive" behavior and can change lanes at certain times. If the camel from another lane is behind, it cannot overtake the cheating camel.

7. **Spinning Camel**:  
   This camel spins its image 360º continuously, and its movement is random, advancing between 0 to 6 positions.

8. **Bouncing Camel**:  
   This camel moves in a bouncing manner, changing direction with each move, creating a "bounce effect." It is the smallest in size to make its strange and fun behavior easier to observe.

- Each lane contains a camel at the start of the race.
- The finish line determines which camel crosses it first.
- If the player-controlled camel (Normal Camel) wins, a "YOU WIN!" screen will appear. If another camel wins, a "GAME OVER!" screen will appear with the name of the winning camel.
- In both cases, there will be an option to play again or return to the start screen.

## Project Structure

- `Camel_Race.sln`: Main solution file that groups all related projects.
- `Camel_Race/`: Contains the source files for the game.
  - `Game.cs`: Main game logic, including race management and events.
  - `Camel.cs`: Defines the properties and behaviors of the camels.
  - `RaceTrack.cs`: Represents the race track and its features.
  - `Program.cs`: Entry point of the application that initializes the game.
  - `Resources/`: Folder that stores images, sounds, and other resources used in the game.
- `global.json`: Global configuration file for the project.

## Requirements

- **Operating System**: Windows 7 or higher.
- **.NET Framework**: 4.7.2 or higher.
- **Additional Libraries**: [Heirloom](https://github.com/HeirloomEngine/Heirloom) for managing graphics and user input.

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Saramiss7/Camel_Race.git


## 🚀 DESCRIPCIÓN (SPANISH)
# Camel Race en C#

**Camel Race** es un juego desarrollado en **C#** que simula una emocionante carrera de camellos, inspirada en el popular juego de las ferias. El objetivo es que cada camello avance por la pista de carreras de manera aleatoria, con distintos comportamientos según el tipo de camello. El jugador controla uno de los camellos, mientras que los otros camellos tienen comportamientos predefinidos, haciendo que la carrera sea impredecible y desafiante.

## Características principales

- **Carrera por turnos**: Los camellos avanzan por turnos, y el juego no termina hasta que todos los camellos se han movido.
- **Comportamientos variados de los camellos**: Cada camello tiene una manera diferente de avanzar, lo que hace que cada carrera sea única y emocionante.
- **Controles del jugador**: El jugador controla un camello, y debe tomar decisiones estratégicas sobre cómo avanzar, mientras que los otros camellos siguen comportamientos predefinidos.
- **Pista de carreras**: El objetivo es avanzar por la pista desde el lado izquierdo hasta la línea de meta en el lado derecho. Cada camello tiene su propio carril.
- **Competencia**: Los camellos que no están controlados por el jugador tienen comportamientos específicos que afectan su velocidad y movimiento.

## Comportamientos de los camellos

Cada camello tiene un comportamiento único que determina cómo avanza en la carrera. Aquí te explico los distintos tipos de camellos:

1. **Camello Normal**: 
   El jugador controla un camello, y debe simular el lanzamiento de una bola para determinar cuántos píxeles avanzará. La bola tiene un valor aleatorio que determina el número de posiciones que avanza el camello en cada ronda.

2. **Camello Esprintador**: 
   Este camello avanza de forma acelerada cuando obtiene los números más altos (por ejemplo, el 70% de los números más altos). Si obtiene un número alto, avanzará el doble de píxeles, pero si obtiene un número bajo, solo avanzará esos puntos.

3. **Camello Fondista**: 
   Estos camellos tienen una estrategia más conservadora y siempre avanzan entre 1 o 2 posiciones en cada turno.

4. **Camello Anti-Senars**: 
   Este camello solo avanzará si el número obtenido es par. Si el número es impar, avanzará solo una posición.

5. **Camello Flipado**: 
   Este camello es impredecible. Avanza una posición hacia adelante, pero luego retrocede una posición. Este movimiento alternado puede crear situaciones inusuales en la carrera.

6. **Camello Tramposo**: 
   Este camello tiene un comportamiento más "agresivo" y puede cambiar de carril en ciertas ocasiones. Si el camello de otro carril está detrás, no podrá adelantar al camello tramposo.

7. **Camello Rotado**:
  Este camello rota 360º su imagen sin parar mientras y su manera de avanzar es random de 0 a 6 posiciones.

8. **Camello Bota**:
   Ente camello tiene un comportamiento ya que avanza posiciones cambiando su direcció creando un efeto de bote, es por eso que es el mas pequeño en tamaño, para que se pueda observar mejor su comportamiento extraño y divertido.

- Cada carril contine un camello al inicio de la partida.
- La meta se encarga de decir qual es el camello que a cruzado la linia de meta antes.
- En caso de que gane el camello normal(el que controla la persona que esta jugando), saldra una pantalla de YOU WIN!, en canvio si gana otro camello saldra una pantalla de       GAME OVER! con el nombre del camello que a ganado.
- En todos los casos tendra la opcion de volver a jugar, o de ir a la pantalla de inicio.
   
## Estructura del proyecto

- `Camel_Race.sln`: Archivo de solución principal que agrupa todos los proyectos relacionados.
- `Camel_Race/`: Contiene los archivos fuente del juego.
  - `Game.cs`: Lógica principal del juego, incluyendo la gestión de la carrera y los eventos.
  - `Camel.cs`: Define las propiedades y comportamientos de los camellos.
  - `RaceTrack.cs`: Representa la pista de carrera y sus características.
  - `Program.cs`: Punto de entrada de la aplicación que inicializa el juego.
  - `Resources/`: Carpeta que almacena imágenes, sonidos y otros recursos utilizados en el juego.
- `global.json`: Archivo de configuración global del proyecto.

## Requisitos

- **Sistema operativo**: Windows 7 o superior.
- **.NET Framework**: 4.7.2 o superior.
- **Librerías adicionales**: [Heirloom](https://github.com/HeirloomEngine/Heirloom) para la gestión de gráficos y entrada de usuario.

## Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Saramiss7/Camel_Race.git
