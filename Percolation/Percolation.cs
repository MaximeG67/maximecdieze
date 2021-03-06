using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percolation
{
    public class Percolation
    {
        private readonly bool[,] _open;
        private readonly bool[,] _full;
        private readonly int _size;
        private bool _percolate;

        public Percolation(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), size, "Taille de la grille négative ou nulle.");
            }

            _open = new bool[size, size];
            _full = new bool[size, size];
            _size = size;
        }

        public bool IsOpen(int i, int j)
        {
            if (_open[i, j])
            {
                return true;
            }
            return false;
        }

        public bool IsFull(int i, int j)
        {
            if (_full[i, j])
            {
                return true;
            }
            return false;
        }

        public bool Percolate()
        {
            for (int i = 0; i < _size; i++)
            {
                if (_full[i, _size-1])
                {
                    return true;
                }
            }
            return false;
        }

        private List<KeyValuePair<int, int>> CloseNeighbors(int i, int j)
        {
            List<KeyValuePair<int, int>> neighbor = new List<KeyValuePair<int, int>>();
            if (i > 0) neighbor.Add(new KeyValuePair<int, int>(i - 1, j));
            if (j > 0) neighbor.Add(new KeyValuePair<int, int>(i, j - 1));
            if (i < _size - 1) neighbor.Add(new KeyValuePair<int, int>(i + 1, j));
            if (j < _size - 1) neighbor.Add(new KeyValuePair<int, int>(i, j + 1));

            return neighbor;
        }

        public void Open(int i, int j)
        {
            if (!IsOpen(i, j))
            {
                _open[i, j] = true;
                //SI 1ère ligne
                if (i == 0)
                {
                    //ALORS remplir case
                    _full[i, j] = true;
                    OpenNeighboors(i, j);
                }
                //SINON
                else
                {
                    //POUR chaque voisin
                    foreach (var neighbor in CloseNeighbors(i, j))
                    {
                        //SI voisin est plein
                        if (IsFull(neighbor.Key, neighbor.Value))
                        {
                            //ALORS remplir case
                            _full[i, j] = true;
                            OpenNeighboors(i, j);
                        }

                    }       
                }
            }
        }

        private void OpenNeighboors(int i, int j)
        {
            foreach (var neighbor in CloseNeighbors(i, j))
            {
                if (IsOpen(neighbor.Key, neighbor.Value))
                {
                    _full[neighbor.Key, neighbor.Value] = true;
                    OpenNeighboors(neighbor.Key, neighbor.Value);
                }
            }
        }
    }
}


