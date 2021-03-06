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

        public Result<int> SaveProduct(ProductSqlModel product)
        {
            try
            {
                return Result.Success(_client.SaveProduct(product));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<int>(e.ToString());
            }


            
        }

        public Result<int> DeleteProduct(int productId)
        {
            try
            {
                return Result.Success(_client.DeleteProduct(productId));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<int>(e.ToString());
            }
        }


        public Result<List<MemberSqlModel>> GetMembersByEmailOrId(string searchTerm, int count)
        {
            try
            {
                return Result.Success(_client.GetMembersByEmailOrId(searchTerm, count).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<MemberSqlModel>>(e.ToString());
            }
        }

        public Result<List<SellRequestSqlModel>> GetSellRequestsByMemberId(int memberId)
        {
            try
            {
                return Result.Success(_client.GetSellRequestsByMemberId(memberId).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<SellRequestSqlModel>>(e.ToString());
            }
        }

        public Result<List<SellRequestSqlModel>> GetAllSellRequests()
        {
            try
            {
                return Result.Success(_client.GetAllSellRequests().ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<SellRequestSqlModel>>(e.ToString());
            }
        }

        public Result<int> UpdateSellRequestStatusAndReason(UpdateSellRequestDto updateSellRequest)
        {
            try
            {
                return Result.Success(_client.UpdateSellRequestStatusAndReason(updateSellRequest));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<int>(e.ToString());
            }
        }

        public Result<List<SellRequestImageModel>> GetSellRequestImagesBySellRequestId(int sellRequestId)
        {
            try
            {
                return Result.Success(_client.GetSellRequestImagesBySellRequestId(sellRequestId).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<SellRequestImageModel>>(e.ToString());
            }
        }

        public Result<bool> SendSellRequestUpdateEmail(int sellRequestId)
        {
            try
            {
                return Result.Success(_client.SendSellRequestUpdateEmail(sellRequestId));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<bool>(e.ToString());
            }
        }

        public Result<int> UpdateMember(MemberSqlModel memberSqlModel)
        {
            try
            {
                return Result.Success(_client.UpdateMember(memberSqlModel));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<int>(e.ToString());
            }
        }

        public Result<List<LogSqlModel>> GetLogsByMessage(string messageTerm, int count)
        {
            try
            {
                return Result.Success(_client.GetLogsByMessage(messageTerm, count).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<LogSqlModel>>(e.ToString());
            }
        }

        public Result<List<BlogPostSqlModel>> GetBlogsByTitleOrContent(string messageTerm, int count)
        {
            try
            {
                return Result.Success(_client.GetBlogPostsByTitleOrContent(messageTerm, count).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<BlogPostSqlModel>>(e.ToString());
            }
        }

        public Result<int> SaveBlogPost(BlogPostSqlModel model)
        {
            try
            {
                return Result.Success(_client.SaveBlogPost(model));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<int>(e.ToString());
            }
        }

        public Result<int> DeleteBlogPost(int blogPostId)
        {
            try
            {
                return Result.Success(_client.DeleteBlogPost(blogPostId));
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<int>(e.ToString());
            }
        }

        public Result<List<PaymentSqlModel>> GetPaymentsByMemberIdSearch(string searchTerm, int count)
        {
            try
            {
                return Result.Success(_client.GetPaymentsByMemberIdSearch(searchTerm, count).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<PaymentSqlModel>>(e.ToString());
            }
        }

        public Result<List<PaymentBasketSqlModelWithProductName>> GetPaymentBasketByPaymentId(int paymentId)
        {
            try
            {
                return Result.Success(_client.GetPaymentBasketByPaymentId(paymentId).ToList());
            }
            catch (Exception e)
            {
                Logger.Log(EventLevel.Error, e.ToString());
                return Result.Failure<List<PaymentBasketSqlModelWithProductName>>(e.ToString());
            }
        }
    }
}
