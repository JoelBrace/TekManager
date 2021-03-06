using System;

namespace TekFront.Code.Option.Result
{
    public static class ResultExtensions
    {
        public static Result ToResult(this bool isSuccess, Func<string> getErrorMessage) =>
            isSuccess ? Result.Success() : Result.Failure(getErrorMessage());

        public static Result ToResult(this bool isSuccess, string errorMessage) =>
            isSuccess.ToResult(() => errorMessage);

        public static Result<T> ToResult<T>(this bool isSuccess, Func<T> getSuccessValue, Func<string> getErrorMessage) =>
            isSuccess ? Result.Success(getSuccessValue()) : Result.Failure<T>(getErrorMessage());

        public static Result<T> ToResult<T>(this bool isSuccess, Func<T> getSuccessValue, string errorMessage) =>
            isSuccess.ToResult(getSuccessValue, () => errorMessage);

        public static void MatchSuccess(this Result result, Action onSuccess) =>
            result.Match(onSuccess, error => { });

        public static void MatchFailure(this Result result, FailureResultHandler onFailure) =>
            result.Match(() => { }, onFailure);

        public static void MatchSuccess<T>(this Result<T> result, Action<T> onSuccess) =>
            result.Match(onSuccess, error => { });

        public static void MatchFailure<T>(this Result<T> result, FailureResultHandler onFailure) =>
            result.Match(value => { }, onFailure);

        public static Result<TBase> Cast<T, TBase>(this Result<T> result) where T : TBase =>
            result.Map<TBase>(arg => arg);

        public static T Unwrap<T>(this Result<T> result, T failureValue) =>
            result.Unwrap(error => failureValue);


        public static string UnwrapError(this Result result) =>
            result.Unwrap(() => string.Empty, error => error);

        public static bool UnwrapToIsSuccess<T>(this Result<T> result) =>
            result.Map(arg => true).Unwrap(false);

        public static bool UnwrapToIsSuccess(this Result result) =>
            result.Unwrap(
                onSuccess: () => true,
                onFailure: error => false);
    }
}
