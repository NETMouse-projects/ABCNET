﻿using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Partition.
    /// </summary>
    public class PartitionResult<T>
    {
        /// <summary>
        /// Элементы, отвечающие условию.
        /// </summary>
        public IEnumerable<T> True { get; }

        /// <summary>
        /// Элементы, не отвечающие условию.
        /// </summary>
        public IEnumerable<T> False { get; }

        /// <summary>
        /// Конструктор для PartitionResult.
        /// </summary>
        /// <param name="trueCollection">Элементы, отвечающие условию.</param>
        /// <param name="falseCollection">Элементы, неотвечающие условию.</param>
        public PartitionResult(IEnumerable<T> trueCollection, IEnumerable<T> falseCollection)
        {
            True = trueCollection;
            False = falseCollection;
        }

        /// <summary>
        /// Деконструктор для NumerateResult.
        /// </summary>
        /// <param name="trueCollection">Элементы, отвечающие условию.</param>
        /// <param name="falseCollection">Элементы, неотвечающие условию.</param>
        public void Deconstruct(out IEnumerable<T> trueCollection, out IEnumerable<T> falseCollection)
        {
            trueCollection = True;
            falseCollection = False;
        }

        /// <summary>
        /// Метод для преобразования в строку.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"[{True.NilOrString()} - {False.NilOrString()}]";
        }
    }
}
