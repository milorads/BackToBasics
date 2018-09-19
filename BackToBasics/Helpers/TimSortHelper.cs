using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Linq
{
    using TimSort;

    #region partial class TimSortExtender

    public static class TimSortExtender
    {

        #region TryNativeTimSort

        /// <summary>Tries to use native sorting on given array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <returns><c>true</c> if sorted using native types, <c>false</c> otherwise.</returns>
        internal static bool TryNativeTimSort<T>(T[] array)
        {
            if (array == null) return true;
            var typeofT = typeof(T);
            if (!typeofT.IsValueType) return false;

            if (typeofT == typeof(Byte))
            {
                // at runtme we know it is Byte[], but at compile time cast is required
                var typed = array as Byte[];
                if (typed == null) return false;
                ByteArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(SByte))
            {
                // at runtme we know it is SByte[], but at compile time cast is required
                var typed = array as SByte[];
                if (typed == null) return false;
                SByteArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Int16))
            {
                // at runtme we know it is Int16[], but at compile time cast is required
                var typed = array as Int16[];
                if (typed == null) return false;
                Int16ArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(UInt16))
            {
                // at runtme we know it is UInt16[], but at compile time cast is required
                var typed = array as UInt16[];
                if (typed == null) return false;
                UInt16ArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Int32))
            {
                // at runtme we know it is Int32[], but at compile time cast is required
                var typed = array as Int32[];
                if (typed == null) return false;
                Int32ArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(UInt32))
            {
                // at runtme we know it is UInt32[], but at compile time cast is required
                var typed = array as UInt32[];
                if (typed == null) return false;
                UInt32ArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Int64))
            {
                // at runtme we know it is Int64[], but at compile time cast is required
                var typed = array as Int64[];
                if (typed == null) return false;
                Int64ArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(UInt64))
            {
                // at runtme we know it is UInt64[], but at compile time cast is required
                var typed = array as UInt64[];
                if (typed == null) return false;
                UInt64ArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Single))
            {
                // at runtme we know it is Single[], but at compile time cast is required
                var typed = array as Single[];
                if (typed == null) return false;
                SingleArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Double))
            {
                // at runtme we know it is Double[], but at compile time cast is required
                var typed = array as Double[];
                if (typed == null) return false;
                DoubleArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Decimal))
            {
                // at runtme we know it is Decimal[], but at compile time cast is required
                var typed = array as Decimal[];
                if (typed == null) return false;
                DecimalArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Char))
            {
                // at runtme we know it is Char[], but at compile time cast is required
                var typed = array as Char[];
                if (typed == null) return false;
                CharArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(DateTime))
            {
                // at runtme we know it is DateTime[], but at compile time cast is required
                var typed = array as DateTime[];
                if (typed == null) return false;
                DateTimeArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(TimeSpan))
            {
                // at runtme we know it is TimeSpan[], but at compile time cast is required
                var typed = array as TimeSpan[];
                if (typed == null) return false;
                TimeSpanArrayTimSort.Sort(typed);
                return true;
            }
            if (typeofT == typeof(Guid))
            {
                // at runtme we know it is Guid[], but at compile time cast is required
                var typed = array as Guid[];
                if (typed == null) return false;
                GuidArrayTimSort.Sort(typed);
                return true;
            }
            return false;
        }

        /// <summary>Tries to use native sorting on given array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="lo">The low limit.</param>
        /// <param name="hi">The high limit.</param>
        /// <returns><c>true</c> if sorted using native types, <c>false</c> otherwise.</returns>
		internal static bool TryNativeTimSort<T>(T[] array, int lo, int hi)
        {
            if (array == null) return true;
            var typeofT = typeof(T);
            if (!typeofT.IsValueType) return false;

            if (typeofT == typeof(Byte))
            {
                // at runtme we know it is Byte[], but at compile time cast is required
                var typed = array as Byte[];
                if (typed == null) return false;
                ByteArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(SByte))
            {
                // at runtme we know it is SByte[], but at compile time cast is required
                var typed = array as SByte[];
                if (typed == null) return false;
                SByteArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Int16))
            {
                // at runtme we know it is Int16[], but at compile time cast is required
                var typed = array as Int16[];
                if (typed == null) return false;
                Int16ArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(UInt16))
            {
                // at runtme we know it is UInt16[], but at compile time cast is required
                var typed = array as UInt16[];
                if (typed == null) return false;
                UInt16ArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Int32))
            {
                // at runtme we know it is Int32[], but at compile time cast is required
                var typed = array as Int32[];
                if (typed == null) return false;
                Int32ArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(UInt32))
            {
                // at runtme we know it is UInt32[], but at compile time cast is required
                var typed = array as UInt32[];
                if (typed == null) return false;
                UInt32ArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Int64))
            {
                // at runtme we know it is Int64[], but at compile time cast is required
                var typed = array as Int64[];
                if (typed == null) return false;
                Int64ArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(UInt64))
            {
                // at runtme we know it is UInt64[], but at compile time cast is required
                var typed = array as UInt64[];
                if (typed == null) return false;
                UInt64ArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Single))
            {
                // at runtme we know it is Single[], but at compile time cast is required
                var typed = array as Single[];
                if (typed == null) return false;
                SingleArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Double))
            {
                // at runtme we know it is Double[], but at compile time cast is required
                var typed = array as Double[];
                if (typed == null) return false;
                DoubleArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Decimal))
            {
                // at runtme we know it is Decimal[], but at compile time cast is required
                var typed = array as Decimal[];
                if (typed == null) return false;
                DecimalArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Char))
            {
                // at runtme we know it is Char[], but at compile time cast is required
                var typed = array as Char[];
                if (typed == null) return false;
                CharArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(DateTime))
            {
                // at runtme we know it is DateTime[], but at compile time cast is required
                var typed = array as DateTime[];
                if (typed == null) return false;
                DateTimeArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(TimeSpan))
            {
                // at runtme we know it is TimeSpan[], but at compile time cast is required
                var typed = array as TimeSpan[];
                if (typed == null) return false;
                TimeSpanArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            if (typeofT == typeof(Guid))
            {
                // at runtme we know it is Guid[], but at compile time cast is required
                var typed = array as Guid[];
                if (typed == null) return false;
                GuidArrayTimSort.Sort(typed, lo, hi);
                return true;
            }
            return false;
        }

        #endregion

        #region Array

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <param name="array">The array.</param>
        public static void TimSort<T>(this T[] array)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (array.Length < 2) return;

            if (TryNativeTimSort(array)) return;

            if (TryComparableTimSort(array)) return;
            AnyArrayTimSort<T>.Sort(array, Comparer<T>.Default.Compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        public static void TimSort<T>(this T[] array, int start, int length)
        {
            if (array == null) throw new ArgumentNullException("array");
            length = Math.Min(length, array.Length - start);
            if (length < 2) return;

            if (TryNativeTimSort(array, start, start + length)) return;

            if (TryComparableTimSort(array, start, start + length)) return;

            AnyArrayTimSort<T>.Sort(array, start, start + length, Comparer<T>.Default.Compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="compare">The compare method.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this T[] array, int start, int length, Comparison<T> compare)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (compare == null) throw new ArgumentNullException("compare");
            length = Math.Min(length, array.Length - start);
            if (length < 2) return;

            AnyArrayTimSort<T>.Sort(array, start, start + length, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="compare">The compare method.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
	    public static void TimSort<T>(this T[] array, Comparison<T> compare)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (compare == null) throw new ArgumentNullException("compare");
            if (array.Length < 2) return;

            AnyArrayTimSort<T>.Sort(array, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this T[] array, int start, int length, Comparer<T> comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (comparer == null) throw new ArgumentNullException("comparer");
            length = Math.Min(length, array.Length - start);
            if (length < 2) return;
            Comparison<T> compare = comparer.Compare;

            AnyArrayTimSort<T>.Sort(array, start, start + length, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this T[] array, Comparer<T> comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (comparer == null) throw new ArgumentNullException("comparer");
            if (array.Length < 2) return;
            Comparison<T> compare = comparer.Compare;

            AnyArrayTimSort<T>.Sort(array, compare);
        }

        #endregion

        #region List

        /// <summary>Tries to extract internal representation and sort it (it should be much faster).</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <returns><c>true</c> if succeeded, <c>false</c> otherwise.</returns>
        private static bool TryInternalTimSort<T>(List<T> list, int start, int length)
        {
            var array = GetInternalMember(list);
            if (array == null) return false;
            TimSort(array, start, length);
            return true;
        }

        /// <summary>Tries to extract internal representation and sort it (it should be much faster).</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="compare">The compare method.</param>
        /// <returns><c>true</c> if succeeded, <c>false</c> otherwise.</returns>
        private static bool TryInternalTimSort<T>(List<T> list, int start, int length, Comparison<T> compare)
        {
            var array = GetInternalMember(list);
            if (array == null) return false;
            TimSort(array, start, length, compare);
            return true;
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <param name="array">The array.</param>
        public static void TimSort<T>(this List<T> array)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (array.Count < 2) return;

            if (TryInternalTimSort(array, 0, array.Count)) return;

            if (TryComparableTimSort(array)) return;
            AnyListTimSort<T>.Sort(array, Comparer<T>.Default.Compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        public static void TimSort<T>(this List<T> array, int start, int length)
        {
            if (array == null) throw new ArgumentNullException("array");
            length = Math.Min(length, array.Count - start);
            if (length < 2) return;

            if (TryInternalTimSort(array, start, length)) return;

            if (TryComparableTimSort(array, start, start + length)) return;

            AnyListTimSort<T>.Sort(array, start, start + length, Comparer<T>.Default.Compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="compare">The compare method.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this List<T> array, int start, int length, Comparison<T> compare)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (compare == null) throw new ArgumentNullException("compare");
            length = Math.Min(length, array.Count - start);
            if (length < 2) return;

            if (TryInternalTimSort(array, start, length, compare)) return;

            AnyListTimSort<T>.Sort(array, start, start + length, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="compare">The compare method.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
	    public static void TimSort<T>(this List<T> array, Comparison<T> compare)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (compare == null) throw new ArgumentNullException("compare");
            if (array.Count < 2) return;

            if (TryInternalTimSort(array, 0, array.Count, compare)) return;

            AnyListTimSort<T>.Sort(array, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this List<T> array, int start, int length, Comparer<T> comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (comparer == null) throw new ArgumentNullException("comparer");
            length = Math.Min(length, array.Count - start);
            if (length < 2) return;
            Comparison<T> compare = comparer.Compare;

            if (TryInternalTimSort(array, start, length, compare)) return;

            AnyListTimSort<T>.Sort(array, start, start + length, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this List<T> array, Comparer<T> comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (comparer == null) throw new ArgumentNullException("comparer");
            if (array.Count < 2) return;
            Comparison<T> compare = comparer.Compare;

            if (TryInternalTimSort(array, 0, array.Count, compare)) return;

            AnyListTimSort<T>.Sort(array, compare);
        }

        #endregion

        #region IList

        /// <summary>Tries to extract internal representation and sort it (it should be much faster).</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <returns><c>true</c> if succeeded, <c>false</c> otherwise.</returns>
        private static bool TryInternalTimSort<T>(IList<T> list, int start, int length)
        {
            var array = GetInternalMember(list);
            if (array == null) return false;
            TimSort(array, start, length);
            return true;
        }

        /// <summary>Tries to extract internal representation and sort it (it should be much faster).</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="compare">The compare method.</param>
        /// <returns><c>true</c> if succeeded, <c>false</c> otherwise.</returns>
        private static bool TryInternalTimSort<T>(IList<T> list, int start, int length, Comparison<T> compare)
        {
            var array = GetInternalMember(list);
            if (array == null) return false;
            TimSort(array, start, length, compare);
            return true;
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <param name="array">The array.</param>
        public static void TimSort<T>(this IList<T> array)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (array.Count < 2) return;

            if (TryInternalTimSort(array, 0, array.Count)) return;

            if (TryComparableTimSort(array)) return;
            AnyIListTimSort<T>.Sort(array, Comparer<T>.Default.Compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Type of item.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        public static void TimSort<T>(this IList<T> array, int start, int length)
        {
            if (array == null) throw new ArgumentNullException("array");
            length = Math.Min(length, array.Count - start);
            if (length < 2) return;

            if (TryInternalTimSort(array, start, length)) return;

            if (TryComparableTimSort(array, start, start + length)) return;

            AnyIListTimSort<T>.Sort(array, start, start + length, Comparer<T>.Default.Compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="compare">The compare method.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this IList<T> array, int start, int length, Comparison<T> compare)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (compare == null) throw new ArgumentNullException("compare");
            length = Math.Min(length, array.Count - start);
            if (length < 2) return;

            if (TryInternalTimSort(array, start, length, compare)) return;

            AnyIListTimSort<T>.Sort(array, start, start + length, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="compare">The compare method.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
	    public static void TimSort<T>(this IList<T> array, Comparison<T> compare)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (compare == null) throw new ArgumentNullException("compare");
            if (array.Count < 2) return;

            if (TryInternalTimSort(array, 0, array.Count, compare)) return;

            AnyIListTimSort<T>.Sort(array, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="length">The length.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this IList<T> array, int start, int length, Comparer<T> comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (comparer == null) throw new ArgumentNullException("comparer");
            length = Math.Min(length, array.Count - start);
            if (length < 2) return;
            Comparison<T> compare = comparer.Compare;

            if (TryInternalTimSort(array, start, length, compare)) return;

            AnyIListTimSort<T>.Sort(array, start, start + length, compare);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="comparer">The comparer.</param>
        /// <exception cref="System.ArgumentNullException">array or compare</exception>
        public static void TimSort<T>(this IList<T> array, Comparer<T> comparer)
        {
            if (array == null) throw new ArgumentNullException("array");
            if (comparer == null) throw new ArgumentNullException("comparer");
            if (array.Count < 2) return;
            Comparison<T> compare = comparer.Compare;

            if (TryInternalTimSort(array, 0, array.Count, compare)) return;

            AnyIListTimSort<T>.Sort(array, compare);
        }

        #endregion

        #region dynamic invocation for IComparable

        #region class SorterProxy

        /// <summary>Proxy object to resolve sorter dynamically.</summary>
        internal class SorterProxy
        {
            #region fields (public)

            /// <summary>The sort all proxy.</summary>
            public Action<object> SortAll;

            /// <summary>The sort range proxy.</summary>
            public Action<object, int, int> SortRange;

            #endregion
        }

        #endregion

        private static readonly Dictionary<Type, SorterProxy> SorterProxyMap
            = new Dictionary<Type, SorterProxy>();

        /// <summary>Determines whether type implements IComparable.</summary>
        /// <typeparam name="T">Any type.</typeparam>
        /// <returns><c>true</c> if  implements IComparable; otherwise, <c>false</c>.</returns>
        private static bool IsIComparable<T>()
        {
            return (typeof(IComparable<T>)).IsAssignableFrom(typeof(T));
        }

        /// <summary>Gets the sorter proxy for IComparable.</summary>
        /// <typeparam name="TContainer">The type of the container.</typeparam>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="sorterType">Type of the sorter.</param>
        /// <returns>Sorter proxy.</returns>
        private static SorterProxy GetComparableSorterProxy<TContainer, TItem>(Type sorterType)
            where TContainer : class
        {
            var key = sorterType;
            SorterProxy sorter;

            if (!SorterProxyMap.TryGetValue(key, out sorter))
            {
                const BindingFlags flags = BindingFlags.Static | BindingFlags.NonPublic;
                sorter = new SorterProxy();
                var staticType = sorterType.MakeGenericType(typeof(TItem));
                var sortAll = (Action<TContainer>)Delegate.CreateDelegate(
                    typeof(Action<TContainer>),
                    staticType.GetMethod("SortAll", flags));
                var sortRange = (Action<TContainer, int, int>)Delegate.CreateDelegate(
                    typeof(Action<TContainer, int, int>),
                    staticType.GetMethod("SortRange", flags));
                sorter.SortAll = (array) => sortAll(array as TContainer);
                sorter.SortRange = (array, lo, hi) => sortRange(array as TContainer, lo, hi);
                SorterProxyMap[key] = sorter;
            }

            return sorter;
        }

        /// <summary>Tries sorting as IComparable.</summary>
        /// <typeparam name="TItem">Item type.</typeparam>
        /// <param name="array">The array.</param>
        /// <returns><c>true</c> if sorting was successful, <c>false</c> otherwise.</returns>
        private static bool TryComparableTimSort<TItem>(TItem[] array)
        {
            if (!IsIComparable<TItem>()) return false;
            GetComparableSorterProxy<TItem[], TItem>(typeof(ComparableArrayTimSort<>)).SortAll(array);
            return true;
        }

        /// <summary>Tries sorting as IComparable.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="lo">The lower bound.</param>
        /// <param name="hi">The upper bound.</param>
        /// <returns><c>true</c> if sorting was successful, <c>false</c> otherwise.</returns>
        private static bool TryComparableTimSort<TItem>(TItem[] array, int lo, int hi)
        {
            if (!IsIComparable<TItem>()) return false;
            GetComparableSorterProxy<TItem[], TItem>(typeof(ComparableArrayTimSort<>)).SortRange(array, lo, hi);
            return true;
        }

        /// <summary>Tries sorting as IComparable.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns><c>true</c> if sorting was successful, <c>false</c> otherwise.</returns>
        private static bool TryComparableTimSort<TItem>(List<TItem> list)
        {
            if (!IsIComparable<TItem>()) return false;
            GetComparableSorterProxy<TItem[], TItem>(typeof(ComparableListTimSort<>)).SortAll(list);
            return true;
        }

        /// <summary>Tries sorting as IComparable.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="lo">The lower bound.</param>
        /// <param name="hi">The upper bound.</param>
        /// <returns><c>true</c> if sorting was successful, <c>false</c> otherwise.</returns>
        private static bool TryComparableTimSort<TItem>(List<TItem> list, int lo, int hi)
        {
            if (!IsIComparable<TItem>()) return false;
            GetComparableSorterProxy<TItem[], TItem>(typeof(ComparableListTimSort<>)).SortRange(list, lo, hi);
            return true;
        }

        /// <summary>Tries sorting as IComparable.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns><c>true</c> if sorting was successful, <c>false</c> otherwise.</returns>
        private static bool TryComparableTimSort<TItem>(IList<TItem> list)
        {
            if (!IsIComparable<TItem>()) return false;
            GetComparableSorterProxy<TItem[], TItem>(typeof(ComparableIListTimSort<>)).SortAll(list);
            return true;
        }

        /// <summary>Tries sorting as IComparable.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="lo">The lower bound.</param>
        /// <param name="hi">The upper bound.</param>
        /// <returns><c>true</c> if sorting was successful, <c>false</c> otherwise.</returns>
        private static bool TryComparableTimSort<TItem>(IList<TItem> list, int lo, int hi)
        {
            if (!IsIComparable<TItem>()) return false;
            GetComparableSorterProxy<TItem[], TItem>(typeof(ComparableIListTimSort<>)).SortRange(list, lo, hi);
            return true;
        }

        #endregion

        #region internal implementation access

        /// <summary>The map of '_items' member in <see cref="List{T}"/></summary>
	    private static readonly Dictionary<Type, FieldInfo> ItemMemberMap =
            new Dictionary<Type, FieldInfo>();

        /// <summary>Tries to get '_items' member from <see cref="List{T}" />.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>Array of items (if available)</returns>
        private static TItem[] GetInternalMember<TItem>(List<TItem> list)
        {
            FieldInfo member;
            var listType = typeof(List<TItem>);
            if (!ItemMemberMap.TryGetValue(listType, out member))
            {
                member = typeof(List<TItem>).GetField("_items", BindingFlags.NonPublic | BindingFlags.Instance);
                ItemMemberMap.Add(listType, member);
            }
            if (member == null) return null;
            return (TItem[])member.GetValue(list);
        }

        // ReSharper disable ParameterTypeCanBeEnumerable.Local

        /// <summary>Tries to cast <see cref="IList{T}" /> to <see cref="List{T}" />.</summary>
        /// <typeparam name="TItem">The type of the item.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns><see cref="List{T}"/> if possible.</returns>
        private static List<TItem> GetInternalMember<TItem>(IList<TItem> list)
        {
            return list as List<TItem>;
        }

        // ReSharper restore ParameterTypeCanBeEnumerable.Local

        #endregion

    }

    #endregion
}

namespace TimSort
{

    #region class ByteArrayTimSort

    /// <summary>TimSort implementation for ByteArray.</summary>
    internal class ByteArrayTimSort : TimSortBase<Byte[], Byte>
    {
        /// <summary>
        /// Prevents a default instance of the ByteArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private ByteArrayTimSort(Byte[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Byte[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Byte[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Byte[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Byte[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new ByteArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Byte[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Byte * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Byte[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Byte * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Byte* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Byte* source, int sourceIndex, Byte* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Byte* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Byte key, Byte[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Byte * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Byte key, Byte[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Byte * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Byte * m = &mergeBuffer[0])
			fixed (Byte * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Byte * m = &mergeBuffer[0])
			fixed (Byte * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class SByteArrayTimSort

    /// <summary>TimSort implementation for SByteArray.</summary>
    internal class SByteArrayTimSort : TimSortBase<SByte[], SByte>
    {
        /// <summary>
        /// Prevents a default instance of the SByteArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private SByteArrayTimSort(SByte[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(SByte[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(SByte[] array) { Sort(array); }

        // redirection
        internal static void SortRange(SByte[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(SByte[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new SByteArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(SByte[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (SByte * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(SByte[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (SByte * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(SByte* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(SByte* source, int sourceIndex, SByte* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(SByte* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(SByte key, SByte[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (SByte * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(SByte key, SByte[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (SByte * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (SByte * m = &mergeBuffer[0])
			fixed (SByte * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (SByte * m = &mergeBuffer[0])
			fixed (SByte * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class Int16ArrayTimSort

    /// <summary>TimSort implementation for Int16Array.</summary>
    internal class Int16ArrayTimSort : TimSortBase<Int16[], Int16>
    {
        /// <summary>
        /// Prevents a default instance of the Int16ArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private Int16ArrayTimSort(Int16[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Int16[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Int16[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Int16[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Int16[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new Int16ArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Int16[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Int16 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Int16[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Int16 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Int16* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Int16* source, int sourceIndex, Int16* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Int16* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Int16 key, Int16[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Int16 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Int16 key, Int16[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Int16 * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Int16 * m = &mergeBuffer[0])
			fixed (Int16 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Int16 * m = &mergeBuffer[0])
			fixed (Int16 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class UInt16ArrayTimSort

    /// <summary>TimSort implementation for UInt16Array.</summary>
    internal class UInt16ArrayTimSort : TimSortBase<UInt16[], UInt16>
    {
        /// <summary>
        /// Prevents a default instance of the UInt16ArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private UInt16ArrayTimSort(UInt16[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(UInt16[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(UInt16[] array) { Sort(array); }

        // redirection
        internal static void SortRange(UInt16[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(UInt16[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new UInt16ArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(UInt16[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (UInt16 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(UInt16[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (UInt16 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(UInt16* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(UInt16* source, int sourceIndex, UInt16* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(UInt16* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(UInt16 key, UInt16[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (UInt16 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(UInt16 key, UInt16[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (UInt16 * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (UInt16 * m = &mergeBuffer[0])
			fixed (UInt16 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (UInt16 * m = &mergeBuffer[0])
			fixed (UInt16 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class Int32ArrayTimSort

    /// <summary>TimSort implementation for Int32Array.</summary>
    internal class Int32ArrayTimSort : TimSortBase<Int32[], Int32>
    {
        /// <summary>
        /// Prevents a default instance of the Int32ArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private Int32ArrayTimSort(Int32[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Int32[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Int32[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Int32[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Int32[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new Int32ArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Int32[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Int32 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Int32[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Int32 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Int32* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Int32* source, int sourceIndex, Int32* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Int32* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Int32 key, Int32[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Int32 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Int32 key, Int32[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Int32 * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Int32 * m = &mergeBuffer[0])
			fixed (Int32 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Int32 * m = &mergeBuffer[0])
			fixed (Int32 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class UInt32ArrayTimSort

    /// <summary>TimSort implementation for UInt32Array.</summary>
    internal class UInt32ArrayTimSort : TimSortBase<UInt32[], UInt32>
    {
        /// <summary>
        /// Prevents a default instance of the UInt32ArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private UInt32ArrayTimSort(UInt32[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(UInt32[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(UInt32[] array) { Sort(array); }

        // redirection
        internal static void SortRange(UInt32[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(UInt32[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new UInt32ArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(UInt32[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (UInt32 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(UInt32[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (UInt32 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(UInt32* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(UInt32* source, int sourceIndex, UInt32* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(UInt32* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(UInt32 key, UInt32[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (UInt32 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(UInt32 key, UInt32[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (UInt32 * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (UInt32 * m = &mergeBuffer[0])
			fixed (UInt32 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (UInt32 * m = &mergeBuffer[0])
			fixed (UInt32 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class Int64ArrayTimSort

    /// <summary>TimSort implementation for Int64Array.</summary>
    internal class Int64ArrayTimSort : TimSortBase<Int64[], Int64>
    {
        /// <summary>
        /// Prevents a default instance of the Int64ArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private Int64ArrayTimSort(Int64[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Int64[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Int64[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Int64[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Int64[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new Int64ArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Int64[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Int64 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Int64[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Int64 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Int64* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Int64* source, int sourceIndex, Int64* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Int64* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Int64 key, Int64[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Int64 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Int64 key, Int64[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Int64 * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Int64 * m = &mergeBuffer[0])
			fixed (Int64 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Int64 * m = &mergeBuffer[0])
			fixed (Int64 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class UInt64ArrayTimSort

    /// <summary>TimSort implementation for UInt64Array.</summary>
    internal class UInt64ArrayTimSort : TimSortBase<UInt64[], UInt64>
    {
        /// <summary>
        /// Prevents a default instance of the UInt64ArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private UInt64ArrayTimSort(UInt64[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(UInt64[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(UInt64[] array) { Sort(array); }

        // redirection
        internal static void SortRange(UInt64[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(UInt64[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new UInt64ArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(UInt64[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (UInt64 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(UInt64[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (UInt64 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(UInt64* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(UInt64* source, int sourceIndex, UInt64* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(UInt64* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(UInt64 key, UInt64[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (UInt64 * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(UInt64 key, UInt64[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (UInt64 * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (UInt64 * m = &mergeBuffer[0])
			fixed (UInt64 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (UInt64 * m = &mergeBuffer[0])
			fixed (UInt64 * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class SingleArrayTimSort

    /// <summary>TimSort implementation for SingleArray.</summary>
    internal class SingleArrayTimSort : TimSortBase<Single[], Single>
    {
        /// <summary>
        /// Prevents a default instance of the SingleArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private SingleArrayTimSort(Single[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Single[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Single[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Single[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Single[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new SingleArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Single[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Single * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Single[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Single * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Single* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Single* source, int sourceIndex, Single* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Single* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Single key, Single[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Single * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Single key, Single[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Single * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Single * m = &mergeBuffer[0])
			fixed (Single * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Single * m = &mergeBuffer[0])
			fixed (Single * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class DoubleArrayTimSort

    /// <summary>TimSort implementation for DoubleArray.</summary>
    internal class DoubleArrayTimSort : TimSortBase<Double[], Double>
    {
        /// <summary>
        /// Prevents a default instance of the DoubleArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private DoubleArrayTimSort(Double[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Double[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Double[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Double[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Double[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new DoubleArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Double[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Double * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Double[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Double * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Double* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Double* source, int sourceIndex, Double* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Double* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Double key, Double[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Double * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Double key, Double[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Double * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Double * m = &mergeBuffer[0])
			fixed (Double * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Double * m = &mergeBuffer[0])
			fixed (Double * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class DecimalArrayTimSort

    /// <summary>TimSort implementation for DecimalArray.</summary>
    internal class DecimalArrayTimSort : TimSortBase<Decimal[], Decimal>
    {
        /// <summary>
        /// Prevents a default instance of the DecimalArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private DecimalArrayTimSort(Decimal[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Decimal[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Decimal[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Decimal[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Decimal[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new DecimalArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Decimal[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Decimal * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Decimal[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Decimal * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Decimal* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Decimal* source, int sourceIndex, Decimal* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Decimal* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Decimal key, Decimal[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Decimal * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Decimal key, Decimal[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Decimal * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Decimal * m = &mergeBuffer[0])
			fixed (Decimal * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Decimal * m = &mergeBuffer[0])
			fixed (Decimal * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class CharArrayTimSort

    /// <summary>TimSort implementation for CharArray.</summary>
    internal class CharArrayTimSort : TimSortBase<Char[], Char>
    {
        /// <summary>
        /// Prevents a default instance of the CharArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private CharArrayTimSort(Char[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Char[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Char[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Char[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Char[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new CharArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Char[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Char * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Char[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Char * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Char* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Char* source, int sourceIndex, Char* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Char* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Char key, Char[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Char * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Char key, Char[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Char * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Char * m = &mergeBuffer[0])
			fixed (Char * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Char * m = &mergeBuffer[0])
			fixed (Char * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class DateTimeArrayTimSort

    /// <summary>TimSort implementation for DateTimeArray.</summary>
    internal class DateTimeArrayTimSort : TimSortBase<DateTime[], DateTime>
    {
        /// <summary>
        /// Prevents a default instance of the DateTimeArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private DateTimeArrayTimSort(DateTime[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(DateTime[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(DateTime[] array) { Sort(array); }

        // redirection
        internal static void SortRange(DateTime[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(DateTime[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new DateTimeArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(DateTime[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (DateTime * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(DateTime[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (DateTime * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(DateTime* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(DateTime* source, int sourceIndex, DateTime* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(DateTime* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(DateTime key, DateTime[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (DateTime * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(DateTime key, DateTime[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (DateTime * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (DateTime * m = &mergeBuffer[0])
			fixed (DateTime * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (DateTime * m = &mergeBuffer[0])
			fixed (DateTime * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class TimeSpanArrayTimSort

    /// <summary>TimSort implementation for TimeSpanArray.</summary>
    internal class TimeSpanArrayTimSort : TimSortBase<TimeSpan[], TimeSpan>
    {
        /// <summary>
        /// Prevents a default instance of the TimeSpanArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private TimeSpanArrayTimSort(TimeSpan[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(TimeSpan[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(TimeSpan[] array) { Sort(array); }

        // redirection
        internal static void SortRange(TimeSpan[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(TimeSpan[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new TimeSpanArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(TimeSpan[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (TimeSpan * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot < a[mid]) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(TimeSpan[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (TimeSpan * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++] < a[lo]) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi] < a[runHi - 1]) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi] >= a[runHi - 1]) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(TimeSpan* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(TimeSpan* source, int sourceIndex, TimeSpan* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(TimeSpan* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(TimeSpan key, TimeSpan[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (TimeSpan * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key > a[lo + hint]) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key > a[lo + hint + ofs]) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key <= a[lo + hint - ofs]) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key > a[lo + m]) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(TimeSpan key, TimeSpan[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (TimeSpan * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key < a[lo + hint]) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key < a[lo + hint - ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key >= a[lo + hint + ofs])
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key < a[lo + m])
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (TimeSpan * m = &mergeBuffer[0])
			fixed (TimeSpan * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2] < m[cursor1]) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (TimeSpan * m = &mergeBuffer[0])
			fixed (TimeSpan * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2] < a[cursor1]) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class GuidArrayTimSort

    /// <summary>TimSort implementation for GuidArray.</summary>
    internal class GuidArrayTimSort : TimSortBase<Guid[], Guid>
    {
        /// <summary>
        /// Prevents a default instance of the GuidArrayTimSort class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private GuidArrayTimSort(Guid[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(Guid[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(Guid[] array) { Sort(array); }

        // redirection
        internal static void SortRange(Guid[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(Guid[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new GuidArrayTimSort(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
#if UNSAFE
		unsafe
#endif
        private static void BinarySort(Guid[] array, int lo, int hi, int start)
        {
#if UNSAFE
			fixed (Guid * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot.CompareTo(a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
#if UNSAFE
		unsafe
#endif
        private static int CountRunAndMakeAscending(Guid[] array, int lo, int hi)
        {
#if UNSAFE
			fixed (Guid * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++].CompareTo(a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) < 0) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

#if UNSAFE

		/// <summary>Copies range of items.</summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Guid* buffer, int sourceIndex, int targetIndex, int length)
	    {
			if (sourceIndex >= targetIndex)
			{
                var source = buffer + sourceIndex;
                var target = buffer + targetIndex;
				while (length-- > 0) *target++ = *source++;
			}
			else
			{
				var source = buffer + sourceIndex + length - 1;
                var target = buffer + targetIndex + length - 1;
				while (length-- > 0) *target-- = *source--;
			}
	    }

		/// <summary>Copies range of items.</summary>
		/// <param name="source">The source buffer.</param>
		/// <param name="sourceIndex">Index of the source.</param>
		/// <param name="target">The target buffer.</param>
		/// <param name="targetIndex">Index of the target.</param>
		/// <param name="length">The length.</param>
	    unsafe protected static void ArrayCopyRange(Guid* source, int sourceIndex, Guid* target, int targetIndex, int length)
	    {
			source += sourceIndex;
			target += targetIndex;
			while (length-- > 0) *target++ = *source++;
	    }

		/// <summary>Reverse the specified range of the specified array.</summary>
		/// <param name="array">the array in which a range is to be reversed.</param>
		/// <param name="lo">the index of the first element in the range to be reversed.</param>
		/// <param name="hi">the index after the last element in the range to be reversed.</param>
	    unsafe protected static void ArrayReverseRange(Guid* array, int lo, int hi)
	    {
			var loPtr = array + lo;
			var hiPtr = array + hi - 1;
			while (loPtr < hiPtr)
			{
				var t = *loPtr;
				*loPtr++ = *hiPtr;
				*hiPtr-- = t;
			}
	    }

#endif
        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopLeft(Guid key, Guid[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Guid * a = &array[0])
#else
            var a = array;
#endif
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key.CompareTo(a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
#if UNSAFE
		unsafe
#endif
        internal static int GallopRight(Guid key, Guid[] array, int lo, int length, int hint)
        {
#if UNSAFE
			fixed (Guid * a = &array[0])
#else
            var a = array;
#endif
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key.CompareTo(a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

#if UNSAFE
			fixed (Guid * m = &mergeBuffer[0])
			fixed (Guid * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2].CompareTo(m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
#if UNSAFE
		unsafe
#endif
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

#if UNSAFE
			fixed (Guid * m = &mergeBuffer[0])
			fixed (Guid * a = &array[0])
#else
            var m = mergeBuffer;
            var a = array;
#endif
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2].CompareTo(a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class AnyArrayTimSort<T>

    /// <summary>TimSort implementation for AnyArray.</summary>
    /// <typeparam name="T">Type of item.</typeparam>
    internal class AnyArrayTimSort<T> : TimSortBase<T[], T>
    {
        /// <summary>The comparator for this sort.</summary>
        private readonly Comparison<T> _comparer;

        /// <summary>
        /// Prevents a default instance of the AnyArrayTimSort&lt;T&gt; class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <param name="comparer">The comparator to determine the order of the sort.</param>
        private AnyArrayTimSort(T[] array, Comparison<T> comparer)
            : base(array, array.Length)
        {
            _comparer = comparer;
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="comparer">Comparer.</param>
        public static void Sort(T[] array, Comparison<T> comparer)
        {
            Sort(array, 0, array.Length, comparer);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="comparer">The comparator to determine the order of the sort.</param>
        public static void Sort(T[] array, int lo, int hi, Comparison<T> comparer)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi, comparer);
                BinarySort(array, lo, hi, lo + initRunLength, comparer);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new AnyArrayTimSort<T>(array, comparer);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi, comparer);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen, comparer);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
        /// <param name="comparer">The comparator to used for the sort.</param>
        private static void BinarySort(T[] array, int lo, int hi, int start, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (comparer(pivot, a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <param name="comparer">the comparator to used for the sort.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
        private static int CountRunAndMakeAscending(T[] array, int lo, int hi, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (comparer(a[runHi++], a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && comparer(a[runHi], a[runHi - 1]) < 0) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && comparer(a[runHi], a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var comparer = _comparer;
            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0, comparer);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1, comparer);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <param name="comparer">the comparator used to order the range, and to search.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
        internal static int GallopLeft(T key, T[] array, int lo, int length, int hint, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (comparer(key, a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && comparer(key, a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && comparer(key, a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (comparer(key, a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <param name="comparer">the comparator used to order the range, and to search.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
        internal static int GallopRight(T key, T[] array, int lo, int length, int hint, Comparison<T> comparer)
        {
            var a = array;
            {

                var ofs = 1;
                var lastOfs = 0;
                if (comparer(key, a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && comparer(key, a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && comparer(key, a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (comparer(key, a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var comparer = _comparer;  // Use local variables for performance
                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (comparer(a[cursor2], m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0, comparer);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0, comparer);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var comparer = _comparer;  // Use local variables for performance
                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (comparer(m[cursor2], a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1, comparer);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1, comparer);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class AnyListTimSort<T>

    /// <summary>TimSort implementation for AnyList.</summary>
    /// <typeparam name="T">Type of item.</typeparam>
    internal class AnyListTimSort<T> : TimSortBase<List<T>, T>
    {
        /// <summary>The comparator for this sort.</summary>
        private readonly Comparison<T> _comparer;

        /// <summary>
        /// Prevents a default instance of the AnyListTimSort&lt;T&gt; class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <param name="comparer">The comparator to determine the order of the sort.</param>
        private AnyListTimSort(List<T> array, Comparison<T> comparer)
            : base(array, array.Count)
        {
            _comparer = comparer;
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="comparer">Comparer.</param>
        public static void Sort(List<T> array, Comparison<T> comparer)
        {
            Sort(array, 0, array.Count, comparer);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="comparer">The comparator to determine the order of the sort.</param>
        public static void Sort(List<T> array, int lo, int hi, Comparison<T> comparer)
        {
            CheckRange(array.Count, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi, comparer);
                BinarySort(array, lo, hi, lo + initRunLength, comparer);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new AnyListTimSort<T>(array, comparer);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi, comparer);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen, comparer);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
        /// <param name="comparer">The comparator to used for the sort.</param>
        private static void BinarySort(List<T> array, int lo, int hi, int start, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (comparer(pivot, a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            IndexedCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <param name="comparer">the comparator to used for the sort.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
        private static int CountRunAndMakeAscending(List<T> array, int lo, int hi, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (comparer(a[runHi++], a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && comparer(a[runHi], a[runHi - 1]) < 0) runHi++;
                    IndexedReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && comparer(a[runHi], a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="srcIndex">Source index in array.</param>
        /// <param name="dstIndex">Target index in array.</param>
        /// <param name="length">Number of elements to be copied.</param>
		private static void IndexedCopyRange(List<T> buffer, int srcIndex, int dstIndex, int length)
        {
            if (dstIndex > srcIndex) // copy forward to the same array => use reverse order
            {
                srcIndex += length - 1;
                dstIndex += length - 1;
                while (length-- > 0) buffer[dstIndex--] = buffer[srcIndex--];
            }
            else // copy to different array or backwards => use natural order
            {
                while (length-- > 0) buffer[dstIndex++] = buffer[srcIndex++];
            }
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(T[] src, int srcIndex, List<T> dst, int dstIndex, int length)
        {
            var s = src;
            { // fixed (...)
                while (length-- > 0) dst[dstIndex++] = s[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(List<T> src, int srcIndex, T[] dst, int dstIndex, int length)
        {
            var d = dst;
            { // fixed (...)
                while (length-- > 0) d[dstIndex++] = src[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Reverse the specified range of the specified array.</summary>
        /// <param name="array">the array in which a range is to be reversed.</param>
        /// <param name="lo">the index of the first element in the range to be reversed.</param>
        /// <param name="hi">the index after the last element in the range to be reversed.</param>
        private static void IndexedReverseRange(List<T> array, int lo, int hi)
        {
            hi--;
            while (lo < hi)
            {
                var t = array[lo];
                array[lo++] = array[hi];
                array[hi--] = t;
            }
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var comparer = _comparer;
            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0, comparer);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1, comparer);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <param name="comparer">the comparator used to order the range, and to search.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
        internal static int GallopLeft(T key, List<T> array, int lo, int length, int hint, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (comparer(key, a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && comparer(key, a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && comparer(key, a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (comparer(key, a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <param name="comparer">the comparator used to order the range, and to search.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
        internal static int GallopRight(T key, List<T> array, int lo, int length, int hint, Comparison<T> comparer)
        {
            var a = array;
            {

                var ofs = 1;
                var lastOfs = 0;
                if (comparer(key, a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && comparer(key, a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && comparer(key, a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (comparer(key, a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var comparer = _comparer;  // Use local variables for performance
                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (comparer(a[cursor2], m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = AnyArrayTimSort<T>.GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0, comparer);
                        if (count1 != 0)
                        {
                            IndexedCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0, comparer);
                        if (count2 != 0)
                        {
                            IndexedCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var comparer = _comparer;  // Use local variables for performance
                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (comparer(m[cursor2], a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1, comparer);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            IndexedCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - AnyArrayTimSort<T>.GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1, comparer);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            IndexedCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class AnyIListTimSort<T>

    /// <summary>TimSort implementation for AnyIList.</summary>
    /// <typeparam name="T">Type of item.</typeparam>
    internal class AnyIListTimSort<T> : TimSortBase<IList<T>, T>
    {
        /// <summary>The comparator for this sort.</summary>
        private readonly Comparison<T> _comparer;

        /// <summary>
        /// Prevents a default instance of the AnyIListTimSort&lt;T&gt; class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        /// <param name="comparer">The comparator to determine the order of the sort.</param>
        private AnyIListTimSort(IList<T> array, Comparison<T> comparer)
            : base(array, array.Count)
        {
            _comparer = comparer;
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="comparer">Comparer.</param>
        public static void Sort(IList<T> array, Comparison<T> comparer)
        {
            Sort(array, 0, array.Count, comparer);
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="comparer">The comparator to determine the order of the sort.</param>
        public static void Sort(IList<T> array, int lo, int hi, Comparison<T> comparer)
        {
            CheckRange(array.Count, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi, comparer);
                BinarySort(array, lo, hi, lo + initRunLength, comparer);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new AnyIListTimSort<T>(array, comparer);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi, comparer);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen, comparer);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
        /// <param name="comparer">The comparator to used for the sort.</param>
        private static void BinarySort(IList<T> array, int lo, int hi, int start, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (comparer(pivot, a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            IndexedCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <param name="comparer">the comparator to used for the sort.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
        private static int CountRunAndMakeAscending(IList<T> array, int lo, int hi, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (comparer(a[runHi++], a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && comparer(a[runHi], a[runHi - 1]) < 0) runHi++;
                    IndexedReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && comparer(a[runHi], a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="srcIndex">Source index in array.</param>
        /// <param name="dstIndex">Target index in array.</param>
        /// <param name="length">Number of elements to be copied.</param>
		private static void IndexedCopyRange(IList<T> buffer, int srcIndex, int dstIndex, int length)
        {
            if (dstIndex > srcIndex) // copy forward to the same array => use reverse order
            {
                srcIndex += length - 1;
                dstIndex += length - 1;
                while (length-- > 0) buffer[dstIndex--] = buffer[srcIndex--];
            }
            else // copy to different array or backwards => use natural order
            {
                while (length-- > 0) buffer[dstIndex++] = buffer[srcIndex++];
            }
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(T[] src, int srcIndex, IList<T> dst, int dstIndex, int length)
        {
            var s = src;
            { // fixed (...)
                while (length-- > 0) dst[dstIndex++] = s[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(IList<T> src, int srcIndex, T[] dst, int dstIndex, int length)
        {
            var d = dst;
            { // fixed (...)
                while (length-- > 0) d[dstIndex++] = src[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Reverse the specified range of the specified array.</summary>
        /// <param name="array">the array in which a range is to be reversed.</param>
        /// <param name="lo">the index of the first element in the range to be reversed.</param>
        /// <param name="hi">the index after the last element in the range to be reversed.</param>
        private static void IndexedReverseRange(IList<T> array, int lo, int hi)
        {
            hi--;
            while (lo < hi)
            {
                var t = array[lo];
                array[lo++] = array[hi];
                array[hi--] = t;
            }
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var comparer = _comparer;
            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0, comparer);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1, comparer);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <param name="comparer">the comparator used to order the range, and to search.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
        internal static int GallopLeft(T key, IList<T> array, int lo, int length, int hint, Comparison<T> comparer)
        {
            var a = array;
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (comparer(key, a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && comparer(key, a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && comparer(key, a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (comparer(key, a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <param name="comparer">the comparator used to order the range, and to search.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
        internal static int GallopRight(T key, IList<T> array, int lo, int length, int hint, Comparison<T> comparer)
        {
            var a = array;
            {

                var ofs = 1;
                var lastOfs = 0;
                if (comparer(key, a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && comparer(key, a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && comparer(key, a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (comparer(key, a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var comparer = _comparer;  // Use local variables for performance
                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (comparer(a[cursor2], m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = AnyArrayTimSort<T>.GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0, comparer);
                        if (count1 != 0)
                        {
                            IndexedCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0, comparer);
                        if (count2 != 0)
                        {
                            IndexedCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var comparer = _comparer;  // Use local variables for performance
                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (comparer(m[cursor2], a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1, comparer);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            IndexedCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - AnyArrayTimSort<T>.GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1, comparer);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            IndexedCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class ComparableArrayTimSort<T>

    /// <summary>TimSort implementation for ComparableArray.</summary>
    /// <typeparam name="T">Type of item.</typeparam>
    internal class ComparableArrayTimSort<T> : TimSortBase<T[], T> where T : IComparable<T>
    {
        /// <summary>
        /// Prevents a default instance of the ComparableArrayTimSort&lt;T&gt; class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private ComparableArrayTimSort(T[] array)
            : base(array, array.Length)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(T[] array)
        {
            Sort(array, 0, array.Length);
        }

        // redirection
        internal static void SortAll(T[] array) { Sort(array); }

        // redirection
        internal static void SortRange(T[] array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(T[] array, int lo, int hi)
        {
            CheckRange(array.Length, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new ComparableArrayTimSort<T>(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
        private static void BinarySort(T[] array, int lo, int hi, int start)
        {
            var a = array;
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot.CompareTo(a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            ArrayCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
        private static int CountRunAndMakeAscending(T[] array, int lo, int hi)
        {
            var a = array;
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++].CompareTo(a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) < 0) runHi++;
                    ArrayReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
        internal static int GallopLeft(T key, T[] array, int lo, int length, int hint)
        {
            var a = array;
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key.CompareTo(a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
        internal static int GallopRight(T key, T[] array, int lo, int length, int hint)
        {
            var a = array;
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key.CompareTo(a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                ArrayCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2].CompareTo(m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            ArrayCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            ArrayCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    ArrayCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                ArrayCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2].CompareTo(a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            ArrayCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            ArrayCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    ArrayCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    ArrayCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class ComparableListTimSort<T>

    /// <summary>TimSort implementation for ComparableList.</summary>
    /// <typeparam name="T">Type of item.</typeparam>
    internal class ComparableListTimSort<T> : TimSortBase<List<T>, T> where T : IComparable<T>
    {
        /// <summary>
        /// Prevents a default instance of the ComparableListTimSort&lt;T&gt; class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private ComparableListTimSort(List<T> array)
            : base(array, array.Count)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(List<T> array)
        {
            Sort(array, 0, array.Count);
        }

        // redirection
        internal static void SortAll(List<T> array) { Sort(array); }

        // redirection
        internal static void SortRange(List<T> array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(List<T> array, int lo, int hi)
        {
            CheckRange(array.Count, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new ComparableListTimSort<T>(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
        private static void BinarySort(List<T> array, int lo, int hi, int start)
        {
            var a = array;
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot.CompareTo(a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            IndexedCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
        private static int CountRunAndMakeAscending(List<T> array, int lo, int hi)
        {
            var a = array;
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++].CompareTo(a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) < 0) runHi++;
                    IndexedReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="srcIndex">Source index in array.</param>
        /// <param name="dstIndex">Target index in array.</param>
        /// <param name="length">Number of elements to be copied.</param>
		private static void IndexedCopyRange(List<T> buffer, int srcIndex, int dstIndex, int length)
        {
            if (dstIndex > srcIndex) // copy forward to the same array => use reverse order
            {
                srcIndex += length - 1;
                dstIndex += length - 1;
                while (length-- > 0) buffer[dstIndex--] = buffer[srcIndex--];
            }
            else // copy to different array or backwards => use natural order
            {
                while (length-- > 0) buffer[dstIndex++] = buffer[srcIndex++];
            }
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(T[] src, int srcIndex, List<T> dst, int dstIndex, int length)
        {
            var s = src;
            { // fixed (...)
                while (length-- > 0) dst[dstIndex++] = s[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(List<T> src, int srcIndex, T[] dst, int dstIndex, int length)
        {
            var d = dst;
            { // fixed (...)
                while (length-- > 0) d[dstIndex++] = src[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Reverse the specified range of the specified array.</summary>
        /// <param name="array">the array in which a range is to be reversed.</param>
        /// <param name="lo">the index of the first element in the range to be reversed.</param>
        /// <param name="hi">the index after the last element in the range to be reversed.</param>
        private static void IndexedReverseRange(List<T> array, int lo, int hi)
        {
            hi--;
            while (lo < hi)
            {
                var t = array[lo];
                array[lo++] = array[hi];
                array[hi--] = t;
            }
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
        internal static int GallopLeft(T key, List<T> array, int lo, int length, int hint)
        {
            var a = array;
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key.CompareTo(a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
        internal static int GallopRight(T key, List<T> array, int lo, int length, int hint)
        {
            var a = array;
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key.CompareTo(a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2].CompareTo(m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = ComparableArrayTimSort<T>.GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            IndexedCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            IndexedCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2].CompareTo(a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            IndexedCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - ComparableArrayTimSort<T>.GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            IndexedCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

    #region class ComparableIListTimSort<T>

    /// <summary>TimSort implementation for ComparableIList.</summary>
    /// <typeparam name="T">Type of item.</typeparam>
    internal class ComparableIListTimSort<T> : TimSortBase<IList<T>, T> where T : IComparable<T>
    {
        /// <summary>
        /// Prevents a default instance of the ComparableIListTimSort&lt;T&gt; class from being created.
        /// Creates a TimSort instance to maintain the state of an ongoing sort.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        private ComparableIListTimSort(IList<T> array)
            : base(array, array.Count)
        {
        }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(IList<T> array)
        {
            Sort(array, 0, array.Count);
        }

        // redirection
        internal static void SortAll(IList<T> array) { Sort(array); }

        // redirection
        internal static void SortRange(IList<T> array, int lo, int hi) { Sort(array, lo, hi); }

        /// <summary>Sorts the specified array.</summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        public static void Sort(IList<T> array, int lo, int hi)
        {
            CheckRange(array.Count, lo, hi);

            var width = hi - lo;
            if (width < 2) return; // Arrays of size 0 and 1 are always sorted

            // If array is small, do a "mini-TimSort" with no merges
            if (width < MIN_MERGE)
            {
                var initRunLength = CountRunAndMakeAscending(array, lo, hi);
                BinarySort(array, lo, hi, lo + initRunLength);
                return;
            }

            // March over the array once, left to right, finding natural runs,
            // extending short natural runs to minRun elements, and merging runs
            // to maintain stack invariant.
            var sorter = new ComparableIListTimSort<T>(array);
            int minRun = GetMinimumRunLength(width);
            do
            {
                // Identify next run
                var runLen = CountRunAndMakeAscending(array, lo, hi);

                // If run is short, extend to min(minRun, nRemaining)
                if (runLen < minRun)
                {
                    var force = width <= minRun ? width : minRun;
                    BinarySort(array, lo, lo + force, lo + runLen);
                    runLen = force;
                }

                // Push run onto pending-run stack, and maybe merge
                sorter.PushRun(lo, runLen);
                sorter.MergeCollapse();

                // Advance to find next run
                lo += runLen;
                width -= runLen;
            } while (width != 0);

            // Merge all remaining runs to complete sort
            sorter.MergeForceCollapse();
        }

        /// <summary>
        /// Sorts the specified portion of the specified array using a binary insertion sort. This is the best method for 
        /// sorting small numbers of elements. It requires O(n log n) compares, but O(n^2) data movement (worst case).
        /// If the initial part of the specified range is already sorted, this method can take advantage of it: the method 
        /// assumes that the elements from index <c>lo</c>, inclusive, to <c>start</c>, exclusive are already sorted.
        /// </summary>
        /// <param name="array">the array in which a range is to be sorted.</param>
        /// <param name="lo">the index of the first element in the range to be sorted.</param>
        /// <param name="hi">the index after the last element in the range to be sorted.</param>
        /// <param name="start">start the index of the first element in the range that is not already known to be sorted 
        /// (<c><![CDATA[lo <= start <= hi]]></c>)</param>
        private static void BinarySort(IList<T> array, int lo, int hi, int start)
        {
            var a = array;
            { // fixed (...)

                if (start == lo) start++;

                for (/* nothing */; start < hi; start++)
                {
                    var pivot = a[start];

                    // Set left (and right) to the index where a[start] (pivot) belongs
                    var left = lo;
                    var right = start;

                    // Invariants:
                    // * pivot >= all in [lo, left).
                    // * pivot < all in [right, start).
                    while (left < right)
                    {
                        var mid = (left + right) >> 1;
                        if (pivot.CompareTo(a[mid]) < 0) // c(pivot, a[mid]) < 0
                        {
                            right = mid;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }

                    // The invariants still hold: pivot >= all in [lo, left) and
                    // pivot < all in [left, start), so pivot belongs at left.  Note
                    // that if there are elements equal to pivot, left points to the
                    // first slot after them -- that's why this sort is stable.
                    // Slide elements over to make room to make room for pivot.

                    var n = start - left; // The number of elements to move

                    // switch is just an optimization for copyRange in default case
                    switch (n)
                    {
                        case 2:
                            a[left + 2] = a[left + 1];
                            a[left + 1] = a[left];
                            break;
                        case 1:
                            a[left + 1] = a[left];
                            break;
                        default:
                            IndexedCopyRange(a, left, left + 1, n);
                            break;
                    }
                    a[left] = pivot;
                }
            } // fixed (...)
        }

        /// <summary>
        /// Returns the length of the run beginning at the specified position in
        /// the specified array and reverses the run if it is descending (ensuring
        /// that the run will always be ascending when the method returns).
        /// A run is the longest ascending sequence with: <c><![CDATA[a[lo] <= a[lo + 1] <= a[lo + 2] <= ...]]></c>
        /// or the longest descending sequence with: <c><![CDATA[a[lo] >  a[lo + 1] >  a[lo + 2] >  ...]]></c>
        /// For its intended use in a stable mergesort, the strictness of the
        /// definition of "descending" is needed so that the call can safely
        /// reverse a descending sequence without violating stability.
        /// </summary>
        /// <param name="array">the array in which a run is to be counted and possibly reversed.</param>
        /// <param name="lo">index of the first element in the run.</param>
        /// <param name="hi">index after the last element that may be contained in the run. It is required 
        /// that <c><![CDATA[lo < hi]]></c>.</param>
        /// <returns>the length of the run beginning at the specified position in the specified array</returns>
        private static int CountRunAndMakeAscending(IList<T> array, int lo, int hi)
        {
            var a = array;
            { // fixed (...)
                var runHi = lo + 1;
                if (runHi == hi) return 1;

                // Find end of run, and reverse range if descending
                if (a[runHi++].CompareTo(a[lo]) < 0) // c(a[runHi++], a[lo]) < 0
                {
                    // Descending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) < 0) runHi++;
                    IndexedReverseRange(a, lo, runHi);
                }
                else
                {
                    // Ascending
                    while (runHi < hi && a[runHi].CompareTo(a[runHi - 1]) >= 0) runHi++; // c(a[runHi], a[runHi - 1]) >= 0
                }

                return runHi - lo;
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="srcIndex">Source index in array.</param>
        /// <param name="dstIndex">Target index in array.</param>
        /// <param name="length">Number of elements to be copied.</param>
		private static void IndexedCopyRange(IList<T> buffer, int srcIndex, int dstIndex, int length)
        {
            if (dstIndex > srcIndex) // copy forward to the same array => use reverse order
            {
                srcIndex += length - 1;
                dstIndex += length - 1;
                while (length-- > 0) buffer[dstIndex--] = buffer[srcIndex--];
            }
            else // copy to different array or backwards => use natural order
            {
                while (length-- > 0) buffer[dstIndex++] = buffer[srcIndex++];
            }
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(T[] src, int srcIndex, IList<T> dst, int dstIndex, int length)
        {
            var s = src;
            { // fixed (...)
                while (length-- > 0) dst[dstIndex++] = s[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Copies the range from one array to another.</summary>
        /// <param name="src">The source array.</param>
        /// <param name="srcIndex">Starting index in source array.</param>
        /// <param name="dst">The destination array.</param>
        /// <param name="dstIndex">Starting index in destination array.</param>
        /// <param name="length">Number of elements to be copied.</param>
        private static void IndexedCopyRange(IList<T> src, int srcIndex, T[] dst, int dstIndex, int length)
        {
            var d = dst;
            { // fixed (...)
                while (length-- > 0) d[dstIndex++] = src[srcIndex++];
            } // fixed (...)
        }

        /// <summary>Reverse the specified range of the specified array.</summary>
        /// <param name="array">the array in which a range is to be reversed.</param>
        /// <param name="lo">the index of the first element in the range to be reversed.</param>
        /// <param name="hi">the index after the last element in the range to be reversed.</param>
        private static void IndexedReverseRange(IList<T> array, int lo, int hi)
        {
            hi--;
            while (lo < hi)
            {
                var t = array[lo];
                array[lo++] = array[hi];
                array[hi--] = t;
            }
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1.  Run i must be the penultimate 
        /// or antepenultimate run on the stack. In other words, i must be equal to 
        /// stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">Stack index of the first of the two runs to merge.</param>
        protected override void MergeAt(int runIndex)
        {

            var base1 = _runBase[runIndex];
            var len1 = _runLength[runIndex];
            var base2 = _runBase[runIndex + 1];
            var len2 = _runLength[runIndex + 1];

            // Record the length of the combined runs; if i is the 3rd-last
            // run now, also slide over the last run (which isn't involved
            // in this merge). The current run (i+1) goes away in any case.
            _runLength[runIndex] = len1 + len2;
            if (runIndex == _stackSize - 3)
            {
                _runBase[runIndex + 1] = _runBase[runIndex + 2];
                _runLength[runIndex + 1] = _runLength[runIndex + 2];
            }
            _stackSize--;

            // Find where the first element of run2 goes in run1. Prior elements
            // in run1 can be ignored (because they're already in place).
            var k = GallopRight(_array[base2], _array, base1, len1, 0);
            base1 += k;
            len1 -= k;
            if (len1 == 0) return;

            // Find where the last element of run1 goes in run2. Subsequent elements
            // in run2 can be ignored (because they're already in place).
            len2 = GallopLeft(_array[base1 + len1 - 1], _array, base2, len2, len2 - 1);
            if (len2 == 0) return;

            // Merge remaining runs, using tmp array with min(len1, len2) elements
            if (len1 <= len2)
                MergeLo(base1, len1, base2, len2);
            else
                MergeHi(base1, len1, base2, len2);
        }

        /// <summary>
        /// Locates the position at which to insert the specified key into the
        /// specified sorted range; if the range contains an element equal to key,
        /// returns the index of the leftmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. 
        /// The closer hint is to the result, the faster this method will run.</param>
        /// <returns>the int k,  0 &lt;= k &lt;= n such that a[b + k - 1] &lt; key &lt;= a[b + k], pretending that a[b - 1] 
        /// is minus infinity and a[b + n] is infinity. In other words, key belongs at index b + k; or in other words, the 
        /// first k elements of a should precede key, and the last n - k should follow it.</returns>
        internal static int GallopLeft(T key, IList<T> array, int lo, int length, int hint)
        {
            var a = array;
            { // fixed (...)
                var lastOfs = 0;
                var ofs = 1;

                if (key.CompareTo(a[lo + hint]) > 0) // comparer(key, a[lo + hint]) > 0
                {
                    // Gallop right until a[base+hint+lastOfs] < key <= a[base+hint+ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) > 0) // comparer(key, a[lo + hint + ofs]) > 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    lastOfs += hint;
                    ofs += hint;
                }
                else // if (key <= a[base + hint])
                {
                    // Gallop left until a[base+hint-ofs] < key <= a[base+hint-lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) <= 0) // comparer(key, a[lo + hint - ofs]) <= 0
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0) // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to base
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }

                // Now a[base+lastOfs] < key <= a[base+ofs], so key belongs somewhere
                // to the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[base + lastOfs - 1] < key <= a[base + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) > 0) // comparer(key, a[lo + m]) > 0
                        lastOfs = m + 1; // a[base + m] < key
                    else
                        ofs = m; // key <= a[base + m]
                }
                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Like GallopLeft, except that if the range contains an element equal to
        /// key, GallopRight returns the index after the rightmost equal element.
        /// </summary>
        /// <param name="key">the key whose insertion point to search for.</param>
        /// <param name="array">the array in which to search.</param>
        /// <param name="lo">the index of the first element in the range.</param>
        /// <param name="length">the length of the range; must be &gt; 0.</param>
        /// <param name="hint">the index at which to begin the search, 0 &lt;= hint &lt; n. The closer hint is to the result, 
        /// the faster this method will run.</param>
        /// <returns>int k, that 0 &lt;= k &lt;= n such that a[b + k - 1] &lt;= key &lt; a[b + k]</returns>
        internal static int GallopRight(T key, IList<T> array, int lo, int length, int hint)
        {
            var a = array;
            {

                var ofs = 1;
                var lastOfs = 0;
                if (key.CompareTo(a[lo + hint]) < 0) // comparer(key, a[lo + hint]) < 0
                {
                    // Gallop left until a[b+hint - ofs] <= key < a[b+hint - lastOfs]
                    var maxOfs = hint + 1;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint - ofs]) < 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    var tmp = lastOfs;
                    lastOfs = hint - ofs;
                    ofs = hint - tmp;
                }
                else
                {
                    // a[b + hint] <= key
                    // Gallop right until a[b+hint + lastOfs] <= key < a[b+hint + ofs]
                    var maxOfs = length - hint;
                    while (ofs < maxOfs && key.CompareTo(a[lo + hint + ofs]) >= 0)
                    {
                        lastOfs = ofs;
                        ofs = (ofs << 1) + 1;
                        if (ofs <= 0)   // int overflow
                            ofs = maxOfs;
                    }
                    if (ofs > maxOfs)
                        ofs = maxOfs;

                    // Make offsets relative to b
                    lastOfs += hint;
                    ofs += hint;
                }

                // Now a[b + lastOfs] <= key < a[b + ofs], so key belongs somewhere to
                // the right of lastOfs but no farther right than ofs.  Do a binary
                // search, with invariant a[b + lastOfs - 1] <= key < a[b + ofs].
                lastOfs++;
                while (lastOfs < ofs)
                {
                    var m = lastOfs + ((ofs - lastOfs) >> 1);

                    if (key.CompareTo(a[lo + m]) < 0)
                        ofs = m; // key < a[b + m]
                    else
                        lastOfs = m + 1; // a[b + m] <= key
                }

                return ofs;
            } // fixed (...)
        }

        /// <summary>
        /// Merges two adjacent runs in place, in a stable fashion. The first element of the first run must be greater than 
        /// the first element of the second run (a[base1] &gt; a[base2]), and the last element of the first run 
        /// (a[base1 + len1-1]) must be greater than all elements of the second run.
        /// For performance, this method should be called only when len1 &lt;= len2; its twin, mergeHi should be called if 
        /// len1 &gt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeLo(int base1, int len1, int base2, int len2)
        {

            // Copy first run into temp array
            var array = _array;
            var mergeBuffer = EnsureCapacity(len1);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base1, m, 0, len1);

                var cursor1 = 0;       // Indexes into tmp array
                var cursor2 = base2;   // Indexes int a
                var dest = base1;      // Indexes int a

                // Move first element of second run and deal with degenerate cases
                a[dest++] = a[cursor2++];
                if (--len2 == 0)
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                    return;
                }
                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; // Last elt of run 1 to end of merge
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run starts
                    // winning consistently.
                    do
                    {
                        if (a[cursor2].CompareTo(m[cursor1]) < 0) // c(a[cursor2], m[cursor1]) < 0
                        {
                            a[dest++] = a[cursor2++];
                            count2++;
                            count1 = 0;
                            if (--len2 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest++] = m[cursor1++];
                            count1++;
                            count2 = 0;
                            if (--len1 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = ComparableArrayTimSort<T>.GallopRight(a[cursor2], mergeBuffer, cursor1, len1, 0);
                        if (count1 != 0)
                        {
                            IndexedCopyRange(m, cursor1, a, dest, count1);
                            dest += count1;
                            cursor1 += count1;
                            len1 -= count1;
                            if (len1 <= 1) // len1 == 1 || len1 == 0
                                goto break_outer;
                        }
                        a[dest++] = a[cursor2++];
                        if (--len2 == 0)
                            goto break_outer;

                        count2 = GallopLeft(m[cursor1], array, cursor2, len2, 0);
                        if (count2 != 0)
                        {
                            IndexedCopyRange(a, cursor2, dest, count2);
                            dest += count2;
                            cursor2 += count2;
                            len2 -= count2;
                            if (len2 == 0)
                                goto break_outer;
                        }
                        a[dest++] = m[cursor1++];
                        if (--len1 == 1)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                }  // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len1 == 1)
                {
                    IndexedCopyRange(a, cursor2, dest, len2);
                    a[dest + len2] = m[cursor1]; //  Last elt of run 1 to end of merge
                }
                else if (len1 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, cursor1, a, dest, len1);
                }
            } // fixed (...)
        }

        /// <summary>
        /// Like mergeLo, except that this method should be called only if
        /// len1 &gt;= len2; mergeLo should be called if len1 &lt;= len2. (Either method may be called if len1 == len2.)
        /// </summary>
        /// <param name="base1">index of first element in first run to be merged.</param>
        /// <param name="len1">length of first run to be merged (must be &gt; 0).</param>
        /// <param name="base2">index of first element in second run to be merged (must be aBase + aLen).</param>
        /// <param name="len2">length of second run to be merged (must be &gt; 0).</param>
        private void MergeHi(int base1, int len1, int base2, int len2)
        {

            // Copy second run into temp array
            var array = _array; // For performance
            var mergeBuffer = EnsureCapacity(len2);

            var m = mergeBuffer;
            var a = array;
            { // fixed (...)
                IndexedCopyRange(a, base2, m, 0, len2);

                var cursor1 = base1 + len1 - 1;  // Indexes into a
                var cursor2 = len2 - 1;          // Indexes into mergeBuffer array
                var dest = base2 + len2 - 1;     // Indexes into a

                // Move last element of first run and deal with degenerate cases
                a[dest--] = a[cursor1--];
                if (--len1 == 0)
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                    return;
                }
                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];
                    return;
                }

                var minGallop = _minGallop;

                while (true)
                {
                    var count1 = 0; // Number of times in a row that first run won
                    var count2 = 0; // Number of times in a row that second run won

                    // Do the straightforward thing until (if ever) one run appears to win consistently.
                    do
                    {
                        if (m[cursor2].CompareTo(a[cursor1]) < 0) // c(m[cursor2], a[cursor1]) < 0
                        {
                            a[dest--] = a[cursor1--];
                            count1++;
                            count2 = 0;
                            if (--len1 == 0)
                                goto break_outer;
                        }
                        else
                        {
                            a[dest--] = m[cursor2--];
                            count2++;
                            count1 = 0;
                            if (--len2 == 1)
                                goto break_outer;
                        }
                    } while ((count1 | count2) < minGallop);

                    // One run is winning so consistently that galloping may be a
                    // huge win. So try that, and continue galloping until (if ever)
                    // neither run appears to be winning consistently anymore.
                    do
                    {
                        count1 = len1 - GallopRight(m[cursor2], array, base1, len1, len1 - 1);
                        if (count1 != 0)
                        {
                            dest -= count1;
                            cursor1 -= count1;
                            len1 -= count1;
                            IndexedCopyRange(a, cursor1 + 1, dest + 1, count1);
                            if (len1 == 0)
                                goto break_outer;
                        }
                        a[dest--] = m[cursor2--];
                        if (--len2 == 1)
                            goto break_outer;

                        count2 = len2 - ComparableArrayTimSort<T>.GallopLeft(a[cursor1], mergeBuffer, 0, len2, len2 - 1);
                        if (count2 != 0)
                        {
                            dest -= count2;
                            cursor2 -= count2;
                            len2 -= count2;
                            IndexedCopyRange(m, cursor2 + 1, a, dest + 1, count2);
                            if (len2 <= 1)  // len2 == 1 || len2 == 0
                                goto break_outer;
                        }
                        a[dest--] = a[cursor1--];
                        if (--len1 == 0)
                            goto break_outer;
                        minGallop--;
                    } while (count1 >= MIN_GALLOP | count2 >= MIN_GALLOP);

                    if (minGallop < 0)
                        minGallop = 0;
                    minGallop += 2;  // Penalize for leaving gallop mode
                } // End of "outer" loop

                break_outer: // goto me! ;)

                _minGallop = minGallop < 1 ? 1 : minGallop;  // Write back to field

                if (len2 == 1)
                {
                    dest -= len1;
                    cursor1 -= len1;
                    IndexedCopyRange(a, cursor1 + 1, dest + 1, len1);
                    a[dest] = m[cursor2];  // Move first elt of run2 to front of merge
                }
                else if (len2 == 0)
                {
                    throw new ArgumentException("Comparison method violates its general contract!");
                }
                else
                {
                    IndexedCopyRange(m, 0, a, dest - (len2 - 1), len2);
                }
            } // fixed (...)
        }
    }

    #endregion

}

namespace TimSort
{
    #region class TimSortBase<TList, TItem>

    /// <summary>
    /// TimSortBase is base class for all TimSort specific classes. It contains common methods.
    /// Should not be used directly.
    /// </summary>
    /// <typeparam name="TList">The type of the list.</typeparam>
    /// <typeparam name="TItem">The type of the item.</typeparam>
    internal abstract class TimSortBase<TList, TItem>
    {
        #region consts

        /// <summary>
        /// This is the minimum sized sequence that will be merged.  Shorter
        /// sequences will be lengthened by calling BinarySort.  If the entire
        /// array is less than this length, no merges will be performed.
        /// This constant should be a power of two.  It was 64 in Tim Peter's C
        /// implementation, but 32 was empirically determined to work better in
        /// this implementation.  In the unlikely event that you set this constant
        /// to be a number that's not a power of two, you'll need to change the
        /// <c>minRunLength</c> computation.
        /// If you decrease this constant, you must change the stackLen
        /// computation in the TimSort constructor, or you risk an
        /// ArrayOutOfBounds exception.  See listsort.txt for a discussion
        /// of the minimum stack length required as a function of the length
        /// of the array being sorted and the minimum merge sequence length.
        /// </summary>
        protected const int MIN_MERGE = 32;

        /// <summary>
        /// When we get into galloping mode, we stay there until both runs win less
        /// often than MIN_GALLOP consecutive times.
        /// </summary>
        protected const int MIN_GALLOP = 7;

        /// <summary>
        /// Maximum initial size of tmp array, which is used for merging. 
        /// The array can grow to accommodate demand.
        /// Unlike Tim's original C version, we do not allocate this much storage
        /// when sorting smaller arrays. This change was required for performance.
        /// </summary>
        protected const int INITIAL_TMP_STORAGE_LENGTH = 256;

        #endregion

        #region fields

        /// <summary>The array being sorted.</summary>
        protected readonly TList _array;

        /// <summary>Cached length of array, it won't change.</summary>
        protected readonly int _arrayLength;

        /// <summary>
        /// This controls when we get *into* galloping mode.  It is initialized
        /// to MIN_GALLOP.  The mergeLo and mergeHi methods nudge it higher for
        /// random data, and lower for highly structured data.
        /// </summary>
        protected int _minGallop = MIN_GALLOP;

        /// <summary>
        /// Temp storage for merges.
        /// </summary>
        protected TItem[] _mergeBuffer;

        /// <summary>
        /// A stack of pending runs yet to be merged.  Run i starts at
        /// address base[i] and extends for len[i] elements.  It's always
        /// true (so long as the indices are in bounds) that:
        /// <c>runBase[i] + runLen[i] == runBase[i + 1]</c>
        /// so we could cut the storage for this, but it's a minor amount,
        /// and keeping all the info explicit simplifies the code.
        /// </summary>
        protected int _stackSize; // = 0; // Number of pending runs on stack
        protected int[] _runBase;
        protected int[] _runLength;

        #endregion

        #region constructor

        /// <summary>Initializes a new instance of the <see cref="TimSortBase&lt;TList, TItem&gt;"/> class.</summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayLength">Length of the array.</param>
        protected TimSortBase(TList array, int arrayLength)
        {
            _array = array;
            _arrayLength = arrayLength;

            // Allocate temp storage (which may be increased later if necessary)
            int mergeBufferLength =
                arrayLength < 2 * INITIAL_TMP_STORAGE_LENGTH
                ? arrayLength >> 1
                : INITIAL_TMP_STORAGE_LENGTH;
            _mergeBuffer = new TItem[mergeBufferLength];

            // Allocate runs-to-be-merged stack (which cannot be expanded).  The
            // stack length requirements are described in listsort.txt.  The C
            // version always uses the same stack length (85), but this was
            // measured to be too expensive when sorting "mid-sized" arrays (e.g.,
            // 100 elements) in Java.  Therefore, we use smaller (but sufficiently
            // large) stack lengths for smaller arrays.  The "magic numbers" in the
            // computation below must be changed if MIN_MERGE is decreased.  See
            // the MIN_MERGE declaration above for more information.
            int stackLength =
                arrayLength < 120 ? 5 :
                arrayLength < 1542 ? 10 :
                arrayLength < 119151 ? 19 :
                40;
            _runBase = new int[stackLength];
            _runLength = new int[stackLength];
        }

        #endregion

        #region protected interface

        /// <summary>
        /// Returns the minimum acceptable run length for an array of the specified length. Natural runs shorter than this 
        /// will be extended with BinarySort.
        /// Roughly speaking, the computation is:
        /// If <c>n &lt; MIN_MERGE</c>, return n (it's too small to bother with fancy stuff).
        /// Else if n is an exact power of 2, return <c>MIN_MERGE/2</c>.
        /// Else return an int k, <c>MIN_MERGE/2 &lt;= k &lt;= MIN_MERGE</c>, such that <c>n/k</c> is close to, but strictly 
        /// less than, an exact power of 2. For the rationale, see listsort.txt.
        /// </summary>
        /// <param name="n">the length of the array to be sorted.</param>
        /// <returns>the length of the minimum run to be merged.</returns>
        protected static int GetMinimumRunLength(int n)
        {
            int r = 0; // Becomes 1 if any 1 bits are shifted off
            while (n >= MIN_MERGE)
            {
                r |= (n & 1);
                n >>= 1;
            }
            return n + r;
        }

        /// <summary>
        /// Merges the two runs at stack indices i and i+1. 
        /// Run i must be the penultimate or antepenultimate run on the stack. 
        /// In other words, i must be equal to stackSize-2 or stackSize-3.
        /// </summary>
        /// <param name="runIndex">stack index of the first of the two runs to merge.</param>
        protected abstract void MergeAt(int runIndex);

        /// <summary>
        /// Examines the stack of runs waiting to be merged and merges adjacent runs until the stack invariants are
        /// reestablished: 
        /// <c><![CDATA[1. runLen[i - 3] > runLen[i - 2] + runLen[i - 1] ]]></c> and 
        /// <c><![CDATA[2. runLen[i - 2] > runLen[i - 1] ]]></c>
        /// This method is called each time a new run is pushed onto the stack,
        /// so the invariants are guaranteed to hold for i &lt; stackSize upon
        /// entry to the method.
        /// </summary>
        protected void MergeCollapse()
        {
            while (_stackSize > 1)
            {
                var n = _stackSize - 2;

                if (n > 0 && _runLength[n - 1] <= _runLength[n] + _runLength[n + 1])
                {
                    if (_runLength[n - 1] < _runLength[n + 1]) n--;
                    MergeAt(n);
                }
                else if (_runLength[n] <= _runLength[n + 1])
                {
                    MergeAt(n);
                }
                else
                {
                    break; // Invariant is established
                }
            }
        }

        /// <summary>
        /// Merges all runs on the stack until only one remains.  This method is called once, to complete the sort.
        /// </summary>
        protected void MergeForceCollapse()
        {
            while (_stackSize > 1)
            {
                var n = _stackSize - 2;
                if (n > 0 && _runLength[n - 1] < _runLength[n + 1]) n--;
                MergeAt(n);
            }
        }

        /// <summary>
        /// Pushes the specified run onto the pending-run stack.
        /// </summary>
        /// <param name="runBase">index of the first element in the run.</param>
        /// <param name="runLength">the number of elements in the run.</param>
        protected void PushRun(int runBase, int runLength)
        {
            _runBase[_stackSize] = runBase;
            _runLength[_stackSize] = runLength;
            _stackSize++;
        }

        /// <summary>
        /// Ensures that the external array tmp has at least the specified
        /// number of elements, increasing its size if necessary.  The size
        /// increases exponentially to ensure amortized linear time complexity.
        /// </summary>
        /// <param name="minCapacity">the minimum required capacity of the tmp array.</param>
        /// <returns>tmp, whether or not it grew</returns>
        protected TItem[] EnsureCapacity(int minCapacity)
        {
            if (_mergeBuffer.Length < minCapacity)
            {
                // Compute smallest power of 2 > minCapacity
                int newSize = minCapacity;
                newSize |= newSize >> 1;
                newSize |= newSize >> 2;
                newSize |= newSize >> 4;
                newSize |= newSize >> 8;
                newSize |= newSize >> 16;
                newSize++;

                newSize = newSize < 0 ? minCapacity : Math.Min(newSize, _arrayLength >> 1);

                _mergeBuffer = new TItem[newSize];
            }
            return _mergeBuffer;
        }

        /// <summary>
        /// Checks that fromIndex and toIndex are in range, and throws an
        /// appropriate exception if they aren't.
        /// </summary>
        /// <param name="arrayLen">the length of the array.</param>
        /// <param name="fromIndex">the index of the first element of the range.</param>
        /// <param name="toIndex">the index after the last element of the range.</param>
        protected static void CheckRange(int arrayLen, int fromIndex, int toIndex)
        {
            if (fromIndex > toIndex)
                throw new ArgumentException(string.Format("fromIndex({0}) > toIndex({1})", fromIndex, toIndex));
            if (fromIndex < 0)
                throw new IndexOutOfRangeException(string.Format("fromIndex ({0}) is out of bounds", fromIndex));
            if (toIndex > arrayLen)
                throw new IndexOutOfRangeException(string.Format("toIndex ({0}) is out of bounds", toIndex));
        }

        /// <summary>Reverse the specified range of the specified array.</summary>
        /// <param name="array">the array in which a range is to be reversed.</param>
        /// <param name="lo">the index of the first element in the range to be reversed.</param>
        /// <param name="hi">the index after the last element in the range to be reversed.</param>
        protected static void ArrayReverseRange(TItem[] array, int lo, int hi)
        {
            Array.Reverse(array, lo, hi - lo);
        }

        /// <summary>Copies specified array range.</summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="sourceIndex">Index of the source.</param>
        /// <param name="targetIndex">Index of the target.</param>
        /// <param name="length">The length.</param>
        protected static void ArrayCopyRange(TItem[] buffer, int sourceIndex, int targetIndex, int length)
        {
            Array.Copy(buffer, sourceIndex, buffer, targetIndex, length);
        }

        /// <summary>Copies specified array range.</summary>
        /// <param name="source">The source.</param>
        /// <param name="sourceIndex">Index of the source.</param>
        /// <param name="target">The target.</param>
        /// <param name="targetIndex">Index of the target.</param>
        /// <param name="length">The length.</param>
        protected static void ArrayCopyRange(TItem[] source, int sourceIndex, TItem[] target, int targetIndex, int length)
        {
            Array.Copy(source, sourceIndex, target, targetIndex, length);
        }

        #endregion
    }

    #endregion
}