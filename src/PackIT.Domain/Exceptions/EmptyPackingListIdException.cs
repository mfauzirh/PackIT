using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain;

public class EmptyPackingListIdException : PackItException
{
    public EmptyPackingListIdException() : base("Packing list ID cannot be empty.")
    {

    }
}
