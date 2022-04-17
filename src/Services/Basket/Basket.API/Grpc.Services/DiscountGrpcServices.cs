using Discount.Grpc.Protos;

namespace Basket.API.Grpc.Services
{
    public class DiscountGrpcServices
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient discountProtoServiceClient;

        public DiscountGrpcServices(DiscountProtoService.DiscountProtoServiceClient discountProtoServiceClient)
        {
            this.discountProtoServiceClient = discountProtoServiceClient ?? throw new ArgumentNullException(nameof(discountProtoServiceClient));
        }
        public async Task<CouponModel> GetDiscount(string poductName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = poductName };
            return await discountProtoServiceClient.GetDiscountAsync(discountRequest);
        }
    }
}
