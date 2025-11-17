using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class NodoArbol
{
    public string Nombre { get; set; }
    public List<NodoArbol> Hijos { get; set; } = new List<NodoArbol>();
}

public class ArbolJerarquia
{
    public NodoArbol Raiz { get; set; }

    // Inserta un hijo bajo un padre
    public bool Insertar(string padre, string hijo)
    {
        if (Raiz == null)
        {
            Raiz = new NodoArbol { Nombre = padre };
            Raiz.Hijos.Add(new NodoArbol { Nombre = hijo });
            return true;
        }
        var nodoPadre = Buscar(padre);
        if (nodoPadre != null)
        {
            nodoPadre.Hijos.Add(new NodoArbol { Nombre = hijo });
            return true;
        }
        else
        {
            // Padre no encontrado, no inserta
            return false;
        }
    }

    // Busca un nodo por nombre (devuelve el nodo o null)
    public NodoArbol Buscar(string nombre)
    {
        return BuscarRecursivo(Raiz, nombre);
    }

    // Método para buscar
    private NodoArbol BuscarRecursivo(NodoArbol nodo, string nombre)
    {
        if (nodo == null) return null;
        if (nodo.Nombre == nombre) return nodo;
        foreach (var hijo in nodo.Hijos)
        {
            var encontrado = BuscarRecursivo(hijo, nombre);
            if (encontrado != null) return encontrado;
        }
        return null; // Cubre el caso si no se encuentra
    }

    // Recorre en preorden
    public List<string> RecorrerPreorden(NodoArbol nodo)
    {
        List<string> resultado = new List<string>();
        if (nodo == null) return resultado;
        resultado.Add(nodo.Nombre);
        foreach (var hijo in nodo.Hijos) resultado.AddRange(RecorrerPreorden(hijo));
        return resultado;
    }

    // Cuenta los nodos totales
    public int ContarNodos(NodoArbol nodo)
    {
        if (nodo == null) return 0;
        int count = 1;
        foreach (var hijo in nodo.Hijos) count += ContarNodos(hijo);
        return count;
    }

    // Muestra niveles (devuelve lista de strings por nivel, usando BFS)
    public List<string> MostrarNiveles()
    {
        List<string> resultado = new List<string>();
        if (Raiz == null) return resultado;

        var cola = new Queue<NodoArbol>();
        cola.Enqueue(Raiz);
        int nivel = 0;

        while (cola.Count > 0)
        {
            int tamañoNivel = cola.Count;
            resultado.Add($"Nivel {nivel}:");
            for (int i = 0; i < tamañoNivel; i++)
            {
                var actual = cola.Dequeue();
                resultado.Add($"  {actual.Nombre}");
                foreach (var hijo in actual.Hijos) cola.Enqueue(hijo);
            }
            nivel++;
        }
        return resultado;
    }

    // Devuelve lista de strings con resultado)
    public List<string> BuscarParaForms(string nombre)
    {
        var nodo = Buscar(nombre);
        if (nodo != null)
        {
            return new List<string> { $"Nodo encontrado: {nodo.Nombre}" };
        }
        else
        {
            return new List<string> { $"Nodo '{nombre}' no encontrado." };
        }
    }

    public void PoblarTreeView(TreeNodeCollection nodosTreeView, NodoArbol nodoArbol)
    {
        if (nodoArbol == null) return;
        // Crea un nodo en TreeView con el nombre
        TreeNode nodoTV = new TreeNode(nodoArbol.Nombre);
        nodosTreeView.Add(nodoTV);
        // Recursivamente agrega hijos
        foreach (var hijo in nodoArbol.Hijos)
        {
            PoblarTreeView(nodoTV.Nodes, hijo);
        }
    }
}
