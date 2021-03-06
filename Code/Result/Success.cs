using System;

namespace TekFront.Code.Option.Result
{
    public abstract partial class Result
    {
        private sealed class SuccessResult : Result
        {
            public override void Match(Action onSuccess, FailureResultHandler onFailure)
            {
                onSuccess();
            }

            public override Result Filter(Func<bool> predicate, Func<string> errorFactory)
            {
                return predicate() ? this : Failure(errorFactory());
            }

            public override T Unwrap<T>(Func<T> onSuccess, FailureResultHandler<T> onFailure)
            {
                return onSuccess();
            }

            public override Result And(Func<Result> otherResultFactory)
            {
                return otherResultFactory();
            }

            public override Result Or(Func<Result> otherResultFactory)
            {
                return this;
            }
        }
    }
}
