using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using TekFront.Code.Option.Result;
using TekManager.DataService;

namespace TekManager.Code.Connection
{
    public class DataServiceHelper
    {
        private readonly DataServiceSoapClient _client;

        public DataServiceHelper()
        {
            _client = new DataServiceSoapClient();
        }

        public Result<int> Login(LoginAttemptDto loginAttempt)
        {
            try
            {
                return Result.Success(_client.Login(loginAttempt));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, $"Failed to login. {e}");
                return Result.Failure<int>(e.ToString());
            }
        }

        public Result<List<string>> Register(RegisterAttemptDto model)
        {
            try
            {
                return Result.Success(_client.Register(model).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, $"Failed to register. {e}");
                return Result.Failure<List<string>>(e.ToString());
            }
        }

        public Result CreatePasswordResetRequest(string email)
        {
            try
            {
                _client.CreateResetEmailRequest(email);
                return Result.Success();
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error,
                    $"Failed to create password reset request. {e}");
                return Result.Failure(e.ToString());
            }
        }

        public Result<bool> CanResetPassword(string guid)
        {
            try
            {
                return Result.Success(_client.CanResetPassword(guid));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<bool>(e.ToString());
            }
        }

        public Result ResetPassword(PasswordResetDto dto)
        {
            try
            {
                _client.ResetPassword(dto);
                return Result.Success();
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, $"Failed to reset password. {e}");
                return Result.Failure(e.ToString());
            }
        }

        public Result<List<ProductSqlModel>> GetProducts(string commaIds)
        {
            try
            {
                return Result.Success(_client.GetProducts(commaIds).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<ProductSqlModel>>(e.ToString());
            }

        }

        public Result<List<ProductSqlModel>> GetProductsByPage(int pageNumber, string category)
        {
            try
            {
                return Result.Success(_client.GetProductsByPage(pageNumber, category).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<ProductSqlModel>>(e.ToString());
            }

        }

        public Result<List<ProductSqlModel>> GetProductsByPartial(string partialName, int count)
        {
            try
            {
                return Result.Success(_client.GetProductsByPartial(partialName, count).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<ProductSqlModel>>(e.ToString());
            }

        }
    }
}
