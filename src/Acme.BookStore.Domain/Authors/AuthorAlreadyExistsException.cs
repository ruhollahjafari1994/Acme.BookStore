using Volo.Abp;

namespace Acme.BookStore.Authors;

public partial class AuthorManager
{
    public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}

}
