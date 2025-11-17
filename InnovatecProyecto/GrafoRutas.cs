using System;
using System.Collections.Generic;
using System.Linq;

public class GrafoRutas
{
    private Dictionary<string, List<(string, int)>> Adyacencias = new Dictionary<string, List<(string, int)>>();

    // Agrega una arista no dirigida con distancia (sin cambios)
    public void AgregarArista(string edificio1, string edificio2, int distancia)
    {
        if (!Adyacencias.ContainsKey(edificio1)) Adyacencias[edificio1] = new List<(string, int)>();
        if (!Adyacencias.ContainsKey(edificio2)) Adyacencias[edificio2] = new List<(string, int)>();
        Adyacencias[edificio1].Add((edificio2, distancia));
        Adyacencias[edificio2].Add((edificio1, distancia)); // No dirigido
    }

    // Devuelve una lista de strings con las conexiones de un edificio
    public List<string> MostrarConexiones(string edificio)
    {
        List<string> resultado = new List<string>();
        if (Adyacencias.ContainsKey(edificio))
        {
            foreach (var (conectado, dist) in Adyacencias[edificio])
            {
                resultado.Add($"{edificio} -> {conectado} ({dist}m)");
            }
        }
        else
        {
            resultado.Add($"Edificio '{edificio}' no encontrado.");
        }
        return resultado;
    }

    // Calcula la ruta más corta usando Dijkstra (devuelve distancia y camino como lista)
    public (int distancia, List<string> camino) RutaMasCorta(string inicio, string fin)
    {
        if (!Adyacencias.ContainsKey(inicio) || !Adyacencias.ContainsKey(fin))
        {
            return (-1, new List<string> { "Edificio no encontrado." });
        }

        var distancias = new Dictionary<string, int>();
        var previos = new Dictionary<string, string>();
        var cola = new SortedSet<(int distancia, string edificio)>(); // Para simular PriorityQueue

        foreach (var edificio in Adyacencias.Keys)
        {
            distancias[edificio] = int.MaxValue;
            previos[edificio] = null;
        }
        distancias[inicio] = 0;
        cola.Add((0, inicio));

        while (cola.Count > 0)
        {
            var (distActual, actual) = cola.Min;
            cola.Remove(cola.Min);

            if (distActual > distancias[actual]) continue;

            foreach (var (vecino, peso) in Adyacencias[actual])
            {
                int nuevaDist = distActual + peso;
                if (nuevaDist < distancias[vecino])
                {
                    cola.Remove((distancias[vecino], vecino)); // Remover si existe
                    distancias[vecino] = nuevaDist;
                    previos[vecino] = actual;
                    cola.Add((nuevaDist, vecino));
                }
            }
        }

        if (distancias[fin] == int.MaxValue)
        {
            return (-1, new List<string> { "No hay ruta disponible." });
        }

        // Reconstruir camino
        List<string> camino = new List<string>();
        string actualCamino = fin;
        while (actualCamino != null)
        {
            camino.Insert(0, actualCamino);
            actualCamino = previos[actualCamino];
        }

        return (distancias[fin], camino);
    }

    // Valida si el grafo es conexo (todos los edificios conectados)
    public (bool esConexo, List<string> componentes) EsConexo()
    {
        if (Adyacencias.Count == 0) return (true, new List<string>());

        var visitados = new HashSet<string>();
        var componentes = new List<string>();

        foreach (var edificio in Adyacencias.Keys)
        {
            if (!visitados.Contains(edificio))
            {
                var componente = BFS(edificio, visitados);
                componentes.Add(string.Join(", ", componente));
            }
        }

        bool esConexo = componentes.Count == 1;
        return (esConexo, componentes);
    }

    // BFS auxiliar para conexidad
    private List<string> BFS(string inicio, HashSet<string> visitados)
    {
        var cola = new Queue<string>();
        var componente = new List<string>();
        cola.Enqueue(inicio);
        visitados.Add(inicio);

        while (cola.Count > 0)
        {
            string actual = cola.Dequeue();
            componente.Add(actual);
            foreach (var (vecino, _) in Adyacencias[actual])
            {
                if (!visitados.Contains(vecino))
                {
                    visitados.Add(vecino);
                    cola.Enqueue(vecino);
                }
            }
        }
        return componente;
    }
}