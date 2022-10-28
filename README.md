# P03_II

## Ejercicio 1

Crear una escena simple en Unity, con dos objetos: Notificador y Suscriptor y prueba el código en las transparencias.

![](/docs/Exercise1.gif)

## Ejercicio 2

Crear una escena en Unity, con objetos de tipo A, B y un único objeto C con los siguientes comportamientos:

Cuando el jugador colisiona con un objeto de tipo B, los objetos A se acercan al objeto C. 
![](/docs/ABehaviour_1.gif)

Cuando toca algún objeto A se incrementa el tamaño de cualquier objeto B
![](/docs/BBehaviour_1.gif)

Cuando el jugador se aproxima al objeto de tipo C, los objetos de tipo A cambian su color y saltan y los objetos de tipo B se orientan hacia un objetivo ubicado en la escena con ese propósito. 
![](/docs/cBehaviour.gif)

En la implementación, podemos diferenciar los objetos A, B y C por su color, además el cilindro en la escena es la "baliza" a la que orientarán los objetos de tipo B cuando el jugador se aproxima al objeto C.

Finalmente se adjunta un gif mostrando los rayos dibujados en la ventana de escena por Debug.DrawRay: 

![](/docs/DebugRays_1.gif)
