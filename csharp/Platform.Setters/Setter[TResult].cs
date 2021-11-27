using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Setters
{
    /// <summary>
    /// <para>Represents the <see cref="Setter{TResult}"/>.</para>
    /// <para>Представляет <see cref="Setter{TResult}"/>.</para>
    /// </summary>
    /// <typeparam name="TResult">
    /// <para>The type of a result value.</para>
    /// <para>Тип результирующего значения.</para>
    /// </typeparam>
    /// <seealso cref="Setter{TResult, bool}"/>
    public class Setter<TResult> : Setter<TResult, bool>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult}"/> class.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult}"/>.</para>
        /// </summary>
        /// <param name="defaultValue">
        /// <para>A default value.</para>
        /// <para>Значение по умолчанию.</para>
        /// </param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter(TResult defaultValue) : base(true, false, defaultValue) { }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Setter{TResult}"/> class.</para>
        /// <para>Инициализирует новый экземпляр класса <see cref="Setter{TResult}"/>.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Setter() : base(true, false) { }
    }
}
