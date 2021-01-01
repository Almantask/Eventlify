using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eventlify.SharedKernel.Handlers
{
    /// <summary>
    /// Query to get something handler.
    /// </summary>
    /// <typeparam name="TQuery">Query type.</typeparam>
    /// <typeparam name="TResult">Result. If many things returned, use <see cref="IEnumerable{TResult}"/></typeparam>
    public interface IQueryHandler<in TQuery, TResult>
    {
        /// <summary>
        /// Gets result using the query object.
        /// </summary>
        /// <param name="query">Query used for getting the object(s).</param>
        /// <returns></returns>
        Task<TResult> GetBy(TQuery query);
    }

    /// <summary>
    /// Query to get everything handler.
    /// </summary>
    public interface IQueryHandler<TResult>
    {
        /// <summary>
        /// Gets all available <see cref="TResult"/>.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TResult>> GetAll();
    }
}
