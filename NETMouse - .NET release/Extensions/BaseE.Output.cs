using System;

namespace ABCNET.Extensions
{
    /// <summary>
    /// ������������� ���������� ��� ������ � �������� ������.
    /// </summary>
    public static partial class BaseE
    {
        #region public
        /// <summary>
        /// ������� �������� ���� Boolean.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool Print(this bool item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Boolean � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool PrintLine(this bool item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char Print(this char item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char PrintLine(this char item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double Print(this double item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double PrintLine(this double item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int Print(this int item)
        {
            Console.Write(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32 � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int PrintLine(this int item)
        {
            Console.WriteLine(item.ToString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Boolean?.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool? Print(this bool? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Boolean? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Boolean.</param>
        /// <returns>��������.</returns>
        public static bool? PrintLine(this bool? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char?.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char? Print(this char? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Char? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Char.</param>
        /// <returns>��������.</returns>
        public static char? PrintLine(this char? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double?.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double? Print(this double? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Double? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Double.</param>
        /// <returns>��������.</returns>
        public static double? PrintLine(this double? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32?.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int? Print(this int? item)
        {
            Console.Write(item.NilOrString());
            return item;
        }

        /// <summary>
        /// ������� �������� ���� Int32? � ��������� �� ����� ������.
        /// </summary>
        /// <param name="item">Int32.</param>
        /// <returns>��������.</returns>
        public static int? PrintLine(this int? item)
        {
            Console.WriteLine(item.NilOrString());
            return item;
        }
        #endregion public
    }
}