using System;

namespace TekFront.Code.Option.Result
{
    public sealed class Result<T>
    {
        private readonly Result _result;
        private readonly T _value;

        public Result(Result result, T value)
        {
            _result = result;
            _value = value;
        }

        public void Match(Action<T> onSuccess, FailureResultHandler onFailure)
        {
            

            _result.Match(
                onSuccess: () => onSuccess(_value),
                onFailure: onFailure);
        }

        public Result<T> Filter(Func<T, bool> predicate, Func<T, string> errorFactory)
        {


            return _result.Filter(
                    predicate: () => predicate(_value),
                    errorFactory: () => errorFactory(_value))
                .Unwrap(
                    onSuccess: () => Result.Success(_value),
                    onFailure: Result.Failure<T>);
        }

        public Result<TResult> FlatMap<TResult>(Func<T, Result<TResult>> mapper)
        {


            return _result.Unwrap(
                onSuccess: () => mapper(_value),
                onFailure: Result.Failure<TResult>);
        }

        public Result<TResult> Map<TResult>(Func<T, TResult> mapper)
        {


            return FlatMap(value => Result.Success(mapper(value)));
        }

        public T Unwrap(FailureResultHandler<T> fallbackFactory)
        {


            return _result.Unwrap(
                onSuccess: () => _value,
                onFailure: fallbackFactory);
        }

        public Result ToResult() => _result;
    }
}
