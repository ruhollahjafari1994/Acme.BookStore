using Acme.BookStore.Authors;
using AutoMapper;

namespace Acme.BookStore.Books;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorLookupDto>();
    }
}
