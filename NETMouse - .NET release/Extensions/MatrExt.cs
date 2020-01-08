using ABCNET.Utils;
using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������.
    /// </summary>
    public static class MatrExt
    {
        /// <summary>
        /// �������� ������� �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ �������.</param>
        /// <returns>�������.</returns>
        public static T[] Col<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetCol(index);
        }

        /// <summary>
        /// �������� ������� �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ �������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <returns>�������.</returns>
        public static TOutput[] Col<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetCol(index, selector);
        }

        /// <summary>
        /// �������� ������ �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ ������.</param>
        /// <returns>������.</returns>
        public static T[] Row<T>(this T[,] matrix, int index)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRow(index);
        }

        /// <summary>
        /// �������� ������ �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="index">������ ������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <returns>������.</returns>
        public static TOutput[] Row<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalGetRow(index, selector);
        }

        /// <summary>
        /// ������ ������� ��� ������ �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="firstIndex">������ ������ ������.</param>
        /// <param name="secondIndex">������ ������ ������.</param>
        /// <returns>�������.</returns>
        public static T[,] SwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalSwapRows(firstIndex, secondIndex);
        }

        /// <summary>
        /// ������ ������� ��� ������ �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="firstIndex">������ ������ ������.</param>
        /// <param name="secondIndex">������ ������ ������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <returns>�������.</returns>
        public static T[,] SwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalSwapRows(firstIndex, secondIndex, selector);
        }

        /// <summary>
        /// ������ ������� ��� ������� �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="firstIndex">������ ������� �������.</param>
        /// <param name="secondIndex">������ ������� �������.</param>
        /// <returns>�������.</returns>
        public static T[,] SwapCols<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalSwapColumns(firstIndex, secondIndex);
        }

        /// <summary>
        /// ������ ������� ��� ������� �������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="firstIndex">������ ������� �������.</param>
        /// <param name="secondIndex">������ ������� �������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <returns>�������.</returns>
        public static T[,] SwapCols<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            return matrix.InternalSwapColumns(firstIndex, secondIndex, selector);
        }

        /// <summary>
        /// ������� ������� � ��������� �� ����� ������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="delimiter">�����������.</param>

        public static T[,] Print<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
        	
        	return matrix.InternalPrint(delimiter);
        }

        /// <summary>
        /// ������� ������� � ��������� �� ����� ������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="delimiter">�����������.</param>

        public static T[,] PrintBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	if (matrix == null)
        		throw new ArgumentNullException("matrix");
            if (selector == null)
                throw new ArgumentNullException("selector");
        	
        	return matrix.InternalPrintBy(selector, delimiter);
        }

        /// <summary>
        /// ��������� ������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="selector">������� ��������.</param>
        /// <param name="rowFirstIndex">��������� ������ ������.</param>
        /// <param name="columnFirstIndex">��������� ������ �������.</param>
        public static void Gen<T>(this T[,] matrix, Func<int, int, T> selector, int rowFirstIndex = 0, int columnFirstIndex = 0)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            if (selector == null)
                throw new ArgumentNullException("selector");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = selector(i + rowFirstIndex, j + columnFirstIndex);
        }

        /// <summary>
        /// ��������� ������� ���������� ������� ���� Integer.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        public static void Rand(this int[,] matrix, int low = IntegerBordersHelper.Low, int high = IntegerBordersHelper.High)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.Rand(low, high);
        }

        /// <summary>
        /// ��������� ������� ���������� ������� ���� Real.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        public static void Rand(this double[,] matrix, double low = RealBordersHelper.Low, double high = RealBordersHelper.High)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            if (low > high)
                throw new ArgumentException("low");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.Rand(low, high);
        }

        /// <summary>
        /// ��������� ������� ��������� ���������.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static void Fill<T>(this T[,] matrix, T value)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = value;
        }

        /// <summary>
        /// ��������� ������� ���������� ���� Boolean.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="prompt">����������� � �����.</param>
        public static void ReadBoolean(this bool[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadBoolean(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// ��������� ������� ���������� ���� Char.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="prompt">����������� � �����.</param>
        public static void ReadChar(this char[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.ReadChar(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
        }

        /// <summary>
        /// ��������� ������� ���������� ���� Real.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="prompt">����������� � �����.</param>
        public static void ReadReal(this double[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadReal(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// ��������� ������� ���������� ���� Integer.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="prompt">����������� � �����.</param>
        public static void ReadInteger(this int[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            int i = 0;
            int j = 0;

            while (i < matrix.GetLength(0))
            {
                while (j < matrix.GetLength(1))
                    try
                    {
                        matrix[i, j] = Base.ReadInteger(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
                        j++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(InputErrorHelper.Message);
                    }

                i++;
                j = 0;
            }
        }

        /// <summary>
        /// ��������� ������� ���������� ���� String.
        /// </summary>
        /// <param name="matrix">�������.</param>
        /// <param name="prompt">����������� � �����.</param>
        public static void ReadString(this string[,] matrix, string prompt = EmptyStringHelper.Empty)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Base.ReadString(prompt is null ? EmptyStringHelper.Empty : string.Format(prompt, i, j));
        }


        private static T[] InternalGetCol<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            T[] column = new T[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = matrix[i, index];

            return column;
        }
        
        private static TOutput[] InternalGetCol<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            int length = matrix.GetLength(0);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            TOutput[] column = new TOutput[length];
            for (int i = 0; i < column.Length; i++)
                column[i] = selector(matrix[i, index]);

            return column;
        }
        
        private static T[] InternalGetRow<T>(this T[,] matrix, int index)
        {
            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            T[] row = new T[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = matrix[index, i];

            return row;
        }
        
        private static TOutput[] InternalGetRow<T, TOutput>(this T[,] matrix, int index, Func<T, TOutput> selector)
        {
            if (selector == null)
                throw new ArgumentNullException("selector");

            int length = matrix.GetLength(1);
            if (!index.IsBetween(0, length - 1))
                throw new IndexOutOfRangeException("index");
            
            TOutput[] row = new TOutput[length];
            for (int i = 0; i < row.Length; i++)
                row[i] = selector(matrix[index, i]);

            return row;
        }

        private static T[,] InternalSwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            int lastRowIndex = matrix.GetLength(0) - 1;
            if (!firstIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException("firstIndex");
            if (!secondIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException("secondIndex");

            T[,] newMatrix = (T[,])matrix.Clone();

            int columnsCount = newMatrix.GetLength(1);
            for (int j = 0; j < columnsCount; j++)
                Base.Swap(ref newMatrix[firstIndex, j], ref newMatrix[secondIndex, j]);
            return newMatrix;
        }

        private static T[,] InternalSwapRows<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            int lastRowIndex = matrix.GetLength(0) - 1;
            if (!firstIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException("firstIndex");
            if (!secondIndex.IsBetween(0, lastRowIndex))
                throw new ArgumentOutOfRangeException("secondIndex");

            T[,] newMatrix = (T[,])matrix.Clone();

            int columnsCount = newMatrix.GetLength(1);
            for (int j = 0; j < columnsCount; j++)
            {
                newMatrix[firstIndex, j] = selector(newMatrix[firstIndex, j]);
                newMatrix[secondIndex, j] = selector(newMatrix[secondIndex, j]);
                Base.Swap(ref newMatrix[firstIndex, j], ref newMatrix[secondIndex, j]);
            }

            return newMatrix;
        }

        private static T[,] InternalSwapColumns<T>(this T[,] matrix, int firstIndex, int secondIndex)
        {
            int lastColumnIndex = matrix.GetLength(1) - 1;
            if (!firstIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException("firstIndex");
            if (!secondIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException("secondIndex");

            T[,] newMatrix = (T[,])matrix.Clone();

            int rowsCount = newMatrix.GetLength(0);
            for (int i = 0; i < rowsCount; i++)
                Base.Swap(ref newMatrix[i, firstIndex], ref newMatrix[i, secondIndex]);
            return newMatrix;
        }

        private static T[,] InternalSwapColumns<T>(this T[,] matrix, int firstIndex, int secondIndex, Func<T, T> selector)
        {
            int lastColumnIndex = matrix.GetLength(1) - 1;
            if (!firstIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException("firstIndex");
            if (!secondIndex.IsBetween(0, lastColumnIndex))
                throw new ArgumentOutOfRangeException("secondIndex");

            T[,] newMatrix = (T[,])matrix.Clone();

            int rowsCount = newMatrix.GetLength(0);
            for (int i = 0; i < rowsCount; i++)
            {
                newMatrix[i, firstIndex] = selector(newMatrix[i, firstIndex]);
                newMatrix[i, secondIndex] = selector(newMatrix[i, secondIndex]);
                Base.Swap(ref newMatrix[i, firstIndex], ref newMatrix[i, secondIndex]);
            }

            return newMatrix;
        }

        private static T[,] InternalPrint<T>(this T[,] matrix, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	int rowsCount = matrix.GetLength(0);
        	int columnsCount = matrix.GetLength(1);
        	int[] lengths = new int[columnsCount];
        	
			for (int j = 0; j < columnsCount; j++)
				for (int i = 0; i < rowsCount; i++)
				{
					int itemLength = matrix[i, j].ToString().Length;
					if (itemLength > lengths[j])
						lengths[j] = itemLength;
				}
			
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
					Console.Write(string.Format("{0}{1}", matrix[i, j].ToString().PadLeft(lengths[j]), delimiter));
				Console.WriteLine();
			}
			
			return matrix;
        }
        
        private static T[,] InternalPrintBy<T, TOutput>(this T[,] matrix, Func<T, TOutput> selector, string delimiter = DefaultDelimiterHelper.Delimiter)
        {
        	int rowsCount = matrix.GetLength(0);
        	int columnsCount = matrix.GetLength(1);
        	int[] lengths = new int[columnsCount];
        	
			for (int j = 0; j < columnsCount; j++)
				for (int i = 0; i < rowsCount; i++)
				{
					int itemLength = selector(matrix[i, j]).ToString().Length;
					if (itemLength > lengths[j])
						lengths[j] = itemLength;
				}
			
			for (int i = 0; i < rowsCount; i++)
			{
				for (int j = 0; j < columnsCount; j++)
					Console.Write(string.Format("{0}{1}", selector(matrix[i, j]).ToString().PadLeft(lengths[j]), delimiter));
				Console.WriteLine();
			}
			
			return matrix;
        }
    }
}