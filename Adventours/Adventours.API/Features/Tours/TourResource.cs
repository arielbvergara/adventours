using DataAccess.Entities;

namespace Adventours.API.Features.Tours;

public record TourResource(int TourId, string Title, string Description, UserEntity User);