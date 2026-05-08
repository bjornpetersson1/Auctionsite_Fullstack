using Auctionsite_Backend.Core.Interface;
using Auctionsite_Backend.Data.DTO;
using Auctionsite_Backend.Data.Interface;

namespace Auctionsite_Backend.Core.Service
{
    public class AuctionsService : IAuctionsService
    {
        private readonly IAuctionsRepo _aucyionsRepo;

        public AuctionsService(IAuctionsRepo aucyionsRepo)
        {
            _aucyionsRepo = aucyionsRepo;
        }

        public Task<CreateNewAuctionResponseDTO> CreateNewAuction()
        {
            throw new NotImplementedException();
        }

        public Task<DeleteAuctionResponseDTO> DeleteAuction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EditAuctionResponseDTO> EditAuction(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AuctionDTO> GetAuctionById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AuctionListDTO> GetAuctionsList()
        {
            throw new NotImplementedException();
        }
    }
}
