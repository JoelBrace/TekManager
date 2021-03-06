using System;

namespace TekFront.Code.Option.Result
{
    public abstract partial class Result
    {
        private sealed class FailureResult : Result
        {
            private readonly string _error;

            public FailureResult(string error)
            {
                _error = error;
            }

            public override void Match(Action onSuccess, FailureResultHandler onFailure)
            {
                onFailure(_error);
            }

            public override Result Filter(Func<bool> predicate, Func<string> errorFactory)
            {
                return this;
            }

            public override T Unwrap<T>(Func<T> onSuccess, FailureResultHandler<T> onFailure)
            {
                return onFailure(_error);
            }

            public override Result And(Func<Result> otherResultFactory)
            {
                return this;
            }

            public override Result Or(Func<Result> otherResultFactory)
            {
                return otherResultFactory();
            }
        }
    }
}