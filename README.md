# InnovatecProyecto: Árboles y Grafos en C# para el Parque Tecnológico “Innovatec”

## Descripción
Este proyecto implementa estructuras de datos en C# para simular la jerarquía organizativa y rutas en el Parque Tecnológico “Innovatec”. Incluye un árbol general para jerarquía y un grafo no dirigido ponderado para rutas, con algoritmos como Dijkstra. La aplicación usa Windows Forms para interacciones gráficas.

## Características
- **Árbol Jerarquía**: Insertar nodos, buscar, recorridos (preorden, niveles), conteo.
- **Grafo Rutas**: Agregar aristas, mostrar conexiones, calcular rutas más cortas (Dijkstra), validar conexidad.
- **UI Gráfica**: Interfaz intuitiva con botones, cajas de texto y listas para visualización.
- **Validaciones**: Manejo de errores (ej. padres no encontrados, distancias inválidas).

## Instalación
1. Clona el repositorio: `https://github.com/ClaudiaLiraB/CasoDeEstudio_Arboles_Grafos.git`
2. Abre en Visual Studio.
3. Restaura paquetes NuGet si es necesario.
4. Compila y ejecuta (F5).

## Uso
- **Árbol**: Inserta nodos (padre-hijo), muestra jerarquía o busca.
- **Grafo**: Agrega rutas, consulta conexiones o calcula rutas (ej. A a C).
- Ejemplo: Inserta "Director" -> "Gerente", calcula ruta de "A" a "B".

## Estructura del Proyecto
- `/src`: Código fuente (Form1.cs, ArbolJerarquia.cs, GrafoRutas.cs).
- `/docs`: Informe y diagramas.
- `/tests`: Pruebas unitarias (opcional).

## Contribución
1. Forkea el repo.
2. Crea una rama (`git checkout -b feature/nueva-funcion`).
3. Commit cambios (`git commit -m "Agrega nueva función"`).
4. Push y crea Pull Request.

## Autor
[Claudia Lira] - Universidad Americana (UAM).
