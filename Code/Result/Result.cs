using System;

namespace TekFront.Code.Option.Result
{
    public abstract partial class Result
    {
        public abstract void Match(Action onSuccess, FailureResultHandler onFailure);
        public abstract Result Filter(Func<bool> predicate, Func<string> errorFactory);
        public abstract T Unwrap<T>(Func<T> onSuccess, FailureResultHandler<T> onFailure);

        public abstract Result And(Func<Result> otherResultFactory);
        public abstract Result Or(Func<Result> otherResultFactory);

        public static Result Success() => new SuccessResult();
        public static Result Failure(string error) => new FailureResult(error);

        public static Result<T> Success<T>(T value) => new Result<T>(Success(), value);
        public static Result<T> Failure<T>(string error) => new Result<T>(Failure(error), default(T));
    }

    public delegate void FailureResultHandler(string error);
    public delegate T FailureResultHandler<out T>(string error);
}
