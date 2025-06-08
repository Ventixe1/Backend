using Persistence.Repositories;

namespace Application.Services;
public class EventService(IEventRepository eventRepository) : IEventService
{ 
    private readonly IEventRepository _eventRepository = eventRepository;

    public async Task<EventResult> CreateEventAsync(CreateEventRequest request)
    {

    }
}
