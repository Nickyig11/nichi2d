<p align="center">
  <img src="URL_DE_TU_IMAGEN_DE_TITULO" alt="Título de tu Juego" width="400"/>
</p>
![imagen](https://github.com/user-attachments/assets/c6dc43eb-360a-48e7-95d2-13f33fc620be)

## **[Nombre de tu Juego]**

¡Bienvenido a [Nombre de tu Juego], una reinterpretación fresca y desafiante del clásico juego de puzzles 2048! En esta versión, no solo tendrás que combinar fichas para alcanzar la meta, sino que también podrás seleccionar tu nivel de dificultad al inicio de la partida. ¿Estás listo para el desafío?

<p align="center">
  <img src="URL_DE_TU_IMAGEN_DEL_JUEGO" alt="Captura de pantalla del Juego" width="600"/>
</p>

## **Estructura del Proyecto**

El juego se construye sobre una base de componentes de Unity interconectados, organizados de la siguiente manera:

*   **Canvas Principal:** Contenedor de todos los elementos de la UI, incluyendo el menú de inicio, el tablero de juego (Grid), los paneles de Game Over y Game Win.

*   **Grid (Mapa de Fondo):** Representa el área de juego donde se desplazan las fichas.

*   **Tiles (Fichas):** Son las piezas numéricas que se combinan en el juego.

## **Descripción del Código**

El código del juego se divide en los siguientes scripts:

*   **GameManager.cs:** (El Corazón del Juego)
    Este script es el núcleo del juego. Controla el flujo general, desde el inicio hasta el final. Sus responsabilidades incluyen:

    *   Gestionar las pantallas de Game Start, Game Over y Game Win utilizando CanvasGroups.
    *   Permitir la selección de dificultad al inicio del juego.
    *   Iniciar un nuevo juego con la dificultad seleccionada.
    *   Detectar cuándo el juego termina (Game Over o Game Win) y mostrar la pantalla correspondiente.
    *   Funciones esenciales como `NewGame()`, `GameOver()`, `GameWin()` y `StartGameWithDifficulty()`.
    *   Utiliza `Time.timeScale` para pausar el juego durante la pantalla de inicio y la función `Fade` para animar la aparición y desaparición de los menús.

*   **TileBoard.cs:**
    Este script gestiona el tablero del juego, la creación de fichas, la lógica de movimiento y fusión, y la detección de Game Over y Game Win. Interactúa con el `GameManager` para informar sobre el estado del juego.

*   **TilesGrid.cs:**
    Representa la cuadrícula del tablero de juego. Proporciona métodos para acceder a las celdas y obtener celdas adyacentes.

*   **TilesRow.cs:**
    Representa una fila en la cuadrícula del tablero de juego.

*   **TilesCell.cs:**
    Representa una celda individual en la cuadrícula del tablero de juego.

*   **TileState.cs:**
    Define el estado visual de una ficha (color de fondo, color de texto, valor objetivo para Game Win).

*   **Tile.cs:**
    Controla el comportamiento individual de cada ficha, incluyendo su estado visual, movimiento y fusión.

## **Demostración del Juego**

[INSERTA AQUÍ UN ENLACE A TU VÍDEO DE DEMOSTRACIÓN]

Aquí tienes una muestra en vídeo de mi juego, ¡disfrútala!
