using SharpCrud.Actions;

namespace SharpCrud.Crud;

public interface ICrudMany<
    TCreateResult,
    TCreateInput,
    TReadResult,
    TReadQuery,
    TUpdateResult,
    TUpdateQuery,
    TUpdateInput,
    TDeleteQuery
>
    : ICreateMany<TCreateResult, TCreateInput>,
        IReadMany<TReadResult, TReadQuery>,
        IUpdateMany<TUpdateResult, TUpdateQuery, TUpdateInput>,
        IDeleteMany<TDeleteQuery> { }
