using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������� ���������.
    /// </summary>
    public static partial class Tup
    {
        #region public

        /// <summary>
        /// ������ ������ �� 2 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T2> New<T, T2>(T item1, T2 item2)
        {
            return new Tuple<T, T2>(item1, item2);
        }

        /// <summary>
        /// ������ ������ �� 3 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T2, T3> New<T,T2, T3>(T item1, T2 item2, T3 item3)
        {
            return new Tuple<T, T2, T3>(item1, item2, item3);
        }

        /// <summary>
        /// ������ ������ �� 4 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T2, T3, T4> New<T, T2, T3, T4>(T item1, T2 item2, T3 item3, T4 item4)
        {
            return new Tuple<T, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// ������ ������ �� 5 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        /// <param name="item5">����� ��������.</param>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T2, T3, T4, T5> New<T, T2, T3, T4, T5>(T item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new Tuple<T, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// ������ ������ �� 6 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        /// <param name="item5">����� ��������.</param>
        /// <param name="item6">������ ��������.</param>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T2, T3, T4, T5, T6> New<T, T2, T3, T4, T5, T6>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new Tuple<T, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// ������ ������ �� 7 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        /// <param name="item5">����� ��������.</param>
        /// <param name="item6">������ ��������.</param>
        /// <param name="item7">������� ��������.</param>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T2, T3, T4, T5, T6, T7> New<T, T2, T3, T4, T5, T6, T7>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new Tuple<T, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<int, int> Rand2(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ��� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<int, int, int> Rand3(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ������ ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<int, int, int, int> Rand4(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<int, int, int, int, int> Rand5(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ����� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<int, int, int, int, int, int> Rand6(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<int, int, int, int, int, int, int> Rand7(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<double, double> Rand2(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ��� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<double, double, double> Rand3(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ������ ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<double, double, double, double> Rand4(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<double, double, double, double, double> Rand5(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ����� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<double, double, double, double, double, double> Rand6(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<double, double, double, double, double, double, double> Rand7(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return New(Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high), Base.Rand(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T> Fill2<T>(T value)
        {
            return New(value, value);
        }

        /// <summary>
        /// ������ ������ �� ��� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T, T> Fill3<T>(T value)
        {
            return New(value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ������ ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T, T, T> Fill4<T>(T value)
        {
            return New(value, value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T, T, T, T> Fill5<T>(T value)
        {
            return New(value, value, value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ����� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T, T, T, T, T> Fill6<T>(T value)
        {
            return New(value, value, value, value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        [Obsolete(ObsoletePABCSystemStyleHelper.Message + "Tuple.")]
        public static Tuple<T, T, T, T, T, T, T> Fill7<T>(T value)
        {
            return New(value, value, value, value, value, value, value);
        }

        #endregion public
    }
}