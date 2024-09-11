using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Review.AddReview;

public sealed record AddReviewCommand(Guid BookingId, int Rating, string Comment) : ICommand;