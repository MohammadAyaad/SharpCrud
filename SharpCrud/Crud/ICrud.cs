using SharpCrud.Actions;

namespace SharpCrud.Crud;

public interface ICrud<
    TCreateResult,
    TCreateInput,
    TReadResult,
    TReadQuery,
    TUpdateResult,
    TUpdateQuery,
    TUpdateInput,
    TDeleteQuery
>
    : ICreate<TCreateResult, TCreateInput>,
        IRead<TReadResult, TReadQuery>,
        IUpdate<TUpdateResult, TUpdateQuery, TUpdateInput>,
        IDelete<TDeleteQuery> { }
