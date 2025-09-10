using System;

namespace Maths_Matrices
{
    public class MatrixInt
    {
        private int[,] _values;

        public int NbLines { get; }
        public int NbColumns { get; }

        // Constructeur vide (matrice de zéros)
        public MatrixInt(int nbLines, int nbColumns)
        {
            NbLines = nbLines;
            NbColumns = nbColumns;
            _values = new int[nbLines, nbColumns];
        }

        // Constructeur à partir d’un tableau 2D
        public MatrixInt(int[,] values)
        {
            NbLines = values.GetLength(0);
            NbColumns = values.GetLength(1);
            _values = new int[NbLines, NbColumns];

            for (int i = 0; i < NbLines; i++)
            {
                for (int j = 0; j < NbColumns; j++)
                {
                    _values[i, j] = values[i, j];
                }
            }
        }

        // Constructeur de copie
        public MatrixInt(MatrixInt other)
        {
            NbLines = other.NbLines;
            NbColumns = other.NbColumns;
            _values = new int[NbLines, NbColumns];

            for (int i = 0; i < NbLines; i++)
            {
                for (int j = 0; j < NbColumns; j++)
                {
                    _values[i, j] = other[i, j];
                }
            }
        }


        // Indexeur
        public int this[int i, int j]
        {
            get => _values[i, j];
            set => _values[i, j] = value;
        }

        // Retourne un tableau 2D (copie)
        public int[,] ToArray2D()
        {
            int[,] copy = new int[NbLines, NbColumns];
            for (int i = 0; i < NbLines; i++)
            {
                for (int j = 0; j < NbColumns; j++)
                {
                    copy[i, j] = _values[i, j];
                }
            }

            return copy;
        }
    }
}
