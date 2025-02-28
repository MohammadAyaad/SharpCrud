using SharpCrud.Actions;

namespace SharpCrud.Crud;

public interface ICrudManyAsync<
    TCreateResult,
    TCreateInput,
    TReadResult,
    TReadQuery,
    TUpdateResult,
    TUpdateQuery,
    TUpdateInput,
    TDeleteQuery
>
    : ICreateManyAsync<TCreateResult, TCreateInput>,
        IReadManyAsync<TReadResult, TReadQuery>,
        IUpdateManyAsync<TUpdateResult, TUpdateQuery, TUpdateInput>,
        IDeleteManyAsync<TDeleteQuery> { }
